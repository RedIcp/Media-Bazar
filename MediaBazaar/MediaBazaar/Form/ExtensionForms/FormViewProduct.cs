using AdminBackups;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormViewProduct : Form
    {
        Product product;
        Employee employee;
        public FormViewProduct(Employee e, Product p)
        {
            InitializeComponent();
            this.product = p;
            this.employee = e;

            this.Text = $"{product.ProductID}: {product.ProductName}";

            if (employee is ProductManager)
            {
                tbxSellingPrice.ReadOnly = true;
                cbxStatus.Visible = false;
                tbxStatus.ReadOnly = true;
                tbxType.Visible = false;

            } else if (employee is SalesManager)
            {
                tbxStatus.Visible = false;
                tbxProductName.ReadOnly = true;
                tbxBarcode.ReadOnly = true;
                tbxType.ReadOnly = true;
                cbxProductType.Visible = false;
                btnCreateOrderInfo.Visible = false;
            }

            LoadProductInfo();
            if (employee is ProductManager)
            {
                LoadSuppliersForProduct();
            }
        }
        private void LoadProductInfo()
        {
            tbxProductID.Text = product.ProductID.ToString();
            tbxProductName.Text = product.ProductName;
            tbxBarcode.Text = product.Barcode;
            tbxType.Text = product.ProductType;
            cbxProductType.Text = product.ProductType;
            tbxSellingPrice.Text = product.SellingPrice.ToString();
            tbxAmountInDepot.Text = product.AmountInDepot.ToString();
            tbxAmountInStore.Text = product.AmountInStore.ToString();

            if (product.IsDiscontinued)
            {
                tbxStatus.Text = "Discontinued";
                cbxStatus.Text = "Discontinued";
            } else
            {
                tbxStatus.Text = "Available";
                cbxStatus.Text = "Available";
            }
        }
        public void LoadSuppliersForProduct()
        {
            List<Supplier> suppliersWithOrderInfos = new List<Supplier>();
            List<Supplier> productSuppliers = ((ProductManager)employee).SupplierManagerPM.GetSuppliersForProduct(product);

            // check if supplier has order infos
            product.OrderInfos = ((ProductManager)employee).OrderInfoManagerPM.GetOrderInfosForProduct(product);

            foreach (Supplier s in productSuppliers)
            {
                foreach (OrderInfo oi in product.OrderInfos)
                {
                    if (oi.Supplier.ID == s.ID)
                    {
                        suppliersWithOrderInfos.Add(s);
                    }
                }
            }

            cbxSupplier.DataSource = suppliersWithOrderInfos;
        }
        private void GetOrderInfoForSupplier()
        {
            // get supplier from combobox
            if (cbxSupplier.SelectedIndex < 0)
            {
                return;
            }

            Object supplierObject = cbxSupplier.SelectedItem;
            if (!(supplierObject is Supplier))
            {
                return;
            }

            Supplier supplier = (Supplier)supplierObject;

            bool OrderInfound = false;

            // check order infos of product
            product.OrderInfos = ((ProductManager)employee).OrderInfoManagerPM.GetOrderInfosForProduct(product);
            foreach (OrderInfo oi in product.OrderInfos)
            {
                // get order info of selected supplier
                if (oi.Supplier.ID == supplier.ID)
                {
                    tbxMinAmount.Text = oi.MinAmount.ToString();
                    tbxMaxAmount.Text = oi.MaxAmount.ToString();
                    tbxMultiples.Text = oi.Multiples.ToString();
                    tbxPurchasePrice.Text = oi.PurchasePrice.ToString();
                    OrderInfound = true;
                }

                if (!OrderInfound)
                {
                    tbxMinAmount.Text = "";
                    tbxMaxAmount.Text = "";
                    tbxMultiples.Text = "";
                    tbxPurchasePrice.Text = "";
                }
            }
        }
        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOrderInfoForSupplier();
        }
        private bool UpdateProductPM()
        {
            if (string.IsNullOrEmpty(tbxProductName.Text))
            {
                MessageBox.Show("Product Name cannot be empty");
                return false;
            }
            product.ProductName = tbxProductName.Text;

            if (string.IsNullOrEmpty(tbxBarcode.Text))
            {
                MessageBox.Show("Barcode cannot be empty");
                return false;
            }
            product.Barcode = tbxBarcode.Text;

            if (string.IsNullOrEmpty(cbxProductType.Text))
            {
                MessageBox.Show("Product Type cannot be empty");
                return false;
            }
            product.ProductType = cbxProductType.Text;

            return ((ProductManager)employee).ProductManagerPM.UpdateProductPM(product);
        }
        private bool UpdateProductSM()
        {
            if (string.IsNullOrEmpty(tbxSellingPrice.Text))
            {
                MessageBox.Show("Selling Price cannot be empty");
                return false;
            }

            try
            {
                product.SellingPrice = Convert.ToDouble(tbxSellingPrice.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid selling Price");
                return false;
            }

            if (product.SellingPrice == 0)
            {
                MessageBox.Show("Please enter a selling price");
                return false;
            }

            if (cbxStatus.Text == "Available")
            {
                product.IsDiscontinued = false;
            } else if (cbxStatus.Text == "Discontinued")
            {
                product.IsDiscontinued = true;
            }

            return ((SalesManager)employee).ProductManagerSM.UpdateProductSM(product);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (employee is ProductManager)
            {
                if (!UpdateProductPM())
                {
                    return;
                }

                var formProductManager = Application.OpenForms.OfType<FormProductManager>().FirstOrDefault();
                formProductManager.ReadProducts();
                formProductManager.ReadProductsNoOrderInfo();

                DialogResult dr = MessageBox.Show("Do you want to view the order info", "Product Updated", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    return;
                } else if (dr == DialogResult.No)
                {
                    this.Close();
                }
            } else if (employee is SalesManager)
            {
                if (!UpdateProductSM())
                {
                    MessageBox.Show("Error");
                    return;
                }

                var formSalesManager = Application.OpenForms.OfType<FormSalesManager>().FirstOrDefault();
                if (formSalesManager.tbProductSearch.Text == "")
                {
                    formSalesManager.ReadProducts();
                    formSalesManager.ReadNewProducts();
                }
                else 
                {
                    formSalesManager.UserSearchbar();
                }

                DialogResult dr = MessageBox.Show("Do you want to view the order info", "Product Updated", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    return;
                }
                else if (dr == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnCreateOrderInfo_Click(object sender, EventArgs e)
        {
            FormOrderInfo formOrderInfo = new FormOrderInfo((ProductManager)employee, product);
            formOrderInfo.Show();
        }
    }
}
