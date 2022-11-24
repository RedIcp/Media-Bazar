using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using MediaBazaar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormOrderInfo : Form
    {
        ProductManager productManager;
        Product product;
        public FormOrderInfo(ProductManager pm, Product p)
        {
            InitializeComponent();

            this.productManager = pm;
            this.product = p;

            LoadProductInfo();
            LoadSuppliers();
        }
        private void LoadProductInfo()
        {
            if (product != null)
            {
                this.Text = product.ProductName;

                lblProductName.Text = product.ProductName;
                tbxBarcode.Text = product.Barcode;
            }
        }
       
        /* Supplier Start */
        private void LoadSuppliers()
        {
            List<Supplier> suppliers = productManager.SupplierManagerPM.ReadSuppliers();

            lbxSupplier.Items.Clear();

            foreach (Supplier s in suppliers)
            {
                if (s.ProductType == product.ProductType)
                {
                    lbxSupplier.Items.Add(s);
                }
            }
        }
       
        /* Search Bar Supplier */
        private void tbxSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            string search = tbxSearchSupplier.Text;

            if (!string.IsNullOrEmpty(search))
            {
                List<Supplier> suppliers = productManager.SupplierManagerPM.SearchSuppliers(search);
                lbxSupplier.Items.Clear();

                foreach (Supplier s in suppliers)
                {
                    if (s.ProductType == product.ProductType)
                    {
                        lbxSupplier.Items.Add(s);
                    }
                }
            }
            else
            {
                LoadSuppliers();
            }
        }
       
        /* Select Supplier */
        private Supplier SelectSupplier()
        {
            if (lbxSupplier.SelectedIndex < 0)
            {
                return null;
            }

            Object supplierObject = lbxSupplier.SelectedItem;
            if (!(supplierObject is Supplier))
            {
                return null;
            }

            Supplier supplier = (Supplier)supplierObject;

            tbxSupplier.Text = supplier.ToString();


            // check if supplier already has order info

            bool orderInfound = false;

            product.OrderInfos = productManager.OrderInfoManagerPM.GetOrderInfosForProduct(product);

            foreach (OrderInfo oi in product.OrderInfos)
            {
                if (oi.Supplier.ID == supplier.ID)
                {
                    tbxMinAmount.Text = oi.MinAmount.ToString();
                    tbxMaxAmount.Text = oi.MaxAmount.ToString();
                    tbxMultiples.Text = oi.Multiples.ToString();
                    tbxPurchasePrice.Text = oi.PurchasePrice.ToString();

                    orderInfound = true;
                }

                if (!orderInfound)
                {
                    tbxMinAmount.Value = 1;
                    tbxMaxAmount.Value = 1;
                    tbxMultiples.Value = 1;
                    tbxPurchasePrice.Text = "1";
                }
            }

            return supplier;
        }
        private void lbxSupplier_DoubleClick(object sender, EventArgs e)
        {
            SelectSupplier();
        }
        private void lbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectSupplier();
        }
      
        /* Supplier End */
        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            if (CreateOrderInfo())
            {
                var formProductManager = Application.OpenForms.OfType<FormProductManager>().FirstOrDefault();
                formProductManager.ReadProducts();
                formProductManager.ReadProductsNoOrderInfo();

                var formViewProduct = Application.OpenForms.OfType<FormViewProduct>().FirstOrDefault();
                if (formViewProduct != null)
                {
                    formViewProduct.LoadSuppliersForProduct();
                }
            }
        }
        private bool CreateOrderInfo()
        {
            int minAmount = 0;
            int maxAmount = 0;
            int multiples = 0;
            double purchasePrice = 0;

            try
            {
                minAmount = Convert.ToInt32(tbxMinAmount.Value);
                maxAmount = Convert.ToInt32(tbxMaxAmount.Value);
                multiples = Convert.ToInt32(tbxMultiples.Value);
            }
            catch
            {
                MessageBox.Show("Please enter a number");
                return false;
            }

            if (string.IsNullOrEmpty(tbxPurchasePrice.Text))
            {
                MessageBox.Show("Please enter a purchase price");
                return false;
            }

            try
            {
                purchasePrice = Convert.ToDouble(tbxPurchasePrice.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a purchase price");
                return false;
            }

            Supplier supplier = SelectSupplier();

            if (supplier == null)
            {
                MessageBox.Show("Please select a supplier first");
                return false;
            }

            OrderInfo newOrderInfo = new OrderInfo(supplier, product, minAmount, maxAmount, multiples, purchasePrice);

            if (productManager.OrderInfoManagerPM.CreateOrderInfo(newOrderInfo))
            {
                DialogResult dr = MessageBox.Show("Do you want to add another order info?", "Order Info added", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    SelectSupplier();

                    return true;
                }
                else if (dr == DialogResult.No)
                {
                     SelectSupplier();

                    this.Close();
                    return true;
                }
            }

            return false;
        }
        private void UpdateOrderInfo()
        {
            try
            {
                // check if supplier has order info
                product.OrderInfos = productManager.OrderInfoManagerPM.GetOrderInfosForProduct(product);

                int MinAmount = Convert.ToInt32(tbxMinAmount.Value);
                int MaxAmount = Convert.ToInt32(tbxMaxAmount.Value);
                int Multiples = Convert.ToInt32(tbxMultiples.Value);

                if (string.IsNullOrEmpty(tbxPurchasePrice.Text))
                {
                    MessageBox.Show("Purchase price cannot be empty");
                    return;
                }

                 double PurchasePrice = Convert.ToDouble(tbxPurchasePrice.Text);

                Supplier supplier = SelectSupplier();

                foreach (OrderInfo oi in product.OrderInfos)
                {
                    if (oi.Supplier.ID == supplier.ID)
                    {
                        if (oi != null)
                        {
                            oi.MinAmount = MinAmount;
                            oi.MaxAmount = MaxAmount;
                            oi.Multiples = Multiples;
                            oi.PurchasePrice = PurchasePrice;

                            if (productManager.OrderInfoManagerPM.UpdateOrderInfo(oi))
                            {
                                SelectSupplier();
                                MessageBox.Show("Order info has been updated");
                            }
                            else 
                            {
                                MessageBox.Show("Update failed");
                            }
                        }
                    }
                }
            }
            catch { }
        }
        private void DeleteOrderInfo()
        {
            Supplier supplier = SelectSupplier();

            // check if supplier has order info
            product.OrderInfos = productManager.OrderInfoManagerPM.GetOrderInfosForProduct(product);

            foreach (OrderInfo oi in product.OrderInfos)
            {
                if (oi.Supplier.ID == supplier.ID)
                {
                    if (oi != null)
                    {
                        if (productManager.OrderInfoManagerPM.DeleteOrderInfo(oi))
                        {
                            MessageBox.Show("Order Info deleted");

                            tbxMinAmount.Value = 1;
                            tbxMaxAmount.Value = 1;
                            tbxMultiples.Value = 1;
                            tbxPurchasePrice.Text = "0";
                        }
                    }
                }
            }
        }
        private void btnUpdateOrderInfo_Click(object sender, EventArgs e)
        {
            UpdateOrderInfo();
        }
        private void btnDeleteOrderInfo_Click(object sender, EventArgs e)
        {
            DeleteOrderInfo();
        }
    }
}
