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
    public partial class FormNewProduct : Form
    {
        ProductManager productManager;
        public FormNewProduct(ProductManager pm)
        {
            InitializeComponent();

            this.productManager = pm;
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            if (CreateProduct())
            {
                var formProductManager = Application.OpenForms.OfType<FormProductManager>().FirstOrDefault();
                formProductManager.ReadProducts();
                formProductManager.ReadProductsNoOrderInfo();
            }
        }
        private bool CreateProduct()
        {
            // get input
            string productName = tbxProductName.Text;
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a product name");
                return false;
            }

            foreach(Product p in productManager.ProductManagerPM.SearchProductsPM(productName))
            {
                if (p.ProductName == productName)
                {
                    MessageBox.Show("Product name has to be unique");
                    return false;
                }
            }

            string barcode = tbxBarcode.Text;
            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Please enter a barcode");
                return false;
            }

            string type = cbxProductType.Text;
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please enter a product type");
                return false;
            }

            // make product object
            Product product = new Product(productName, type, barcode);

            if (productManager.ProductManagerPM.CreateProduct(product))
            {
                DialogResult dr = MessageBox.Show("Do you want to add another product?", "Product Added", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    tbxProductName.Clear();
                    tbxBarcode.Clear();
                    return true;
                } 
                else if (dr == DialogResult.No)
                {
                    this.Close();
                    return true;
                }
            } 
            else
            {
                MessageBox.Show("Barcode has to be unique.");

                return false;
            }
            return false;
        }
    }
}
