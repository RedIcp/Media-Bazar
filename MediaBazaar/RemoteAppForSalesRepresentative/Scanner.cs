using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses;
using ClassLibraryProject.ManagmentClasses.ISalesEmployee;
using System;
using System.Windows.Forms;

namespace RemoteAppForSalesRepresentative
{
    public partial class Scanner : Form
    {
        IDBReshelf dbReshelf;
        IReshelfSalesEmployee reshelf;

        ISalesEmployeeControl control;

        public Scanner()
        {
            InitializeComponent();

            dbReshelf = new DBReshelf();
            reshelf = new ReshelfManagment(dbReshelf);

            control = new SalesEmployeeControl(reshelf);

            timerUpdate.Start();
            timerRevival.Start();
        }

        private bool UpdateProduct()
        {
            try
            {
                Product p = control.GetProduct(txtBarcode.Text);

                if (p != null)
                {
                    lbName.Text = p.ProductName;
                    lbAmount.Text = Convert.ToString(p.AmountInStore);

                    return true;
                }
                else
                {
                    lbName.Text = "";
                    lbAmount.Text = "";
                    txtAmount.Text = "";

                    return false;
                }
            }
            catch (Exception)
            { 
                return false;
            }
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(txtAmount.Text);
                Product p = control.GetProduct(txtBarcode.Text);

                if (p != null)
                {
                    if (control.RequestReshelf(p, amount))
                    {
                        txtBarcode.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Already requested!");
                    }
                }
                else
                {
                    MessageBox.Show("Product with this barcode does not exist!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void timerRevival_Tick(object sender, EventArgs e)
        {
            if (UpdateProduct())
            {
                timerUpdate.Start();
            }
            else
            {
                timerUpdate.Stop();
            }
        }

        private void Scanner_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
        }
    }
}
