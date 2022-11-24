using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses;
using ClassLibraryProject.ManagmentClasses.IDepotEmployee;
using System;
using System.Windows.Forms;

namespace RemoteAppForDepotEmployee
{
    public partial class BarcodeScannerDepot : Form
    {
        IDBRestock dbRestock;
        IRestockDepotEmployee restock;

        IDBReshelf dbReshelf;
        IReshelfDepotEmployee reshelf;

        IDepotEmployeeControl control;

        public BarcodeScannerDepot()
        {
            InitializeComponent();

            dbRestock = new DBRestock();
            restock = new RestockManagment(dbRestock);

            dbReshelf = new DBReshelf();
            reshelf = new ReshelfManagment(dbReshelf);

            control = new DepotEmployeeControl(reshelf, restock);

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
                    lbAmount.Text = Convert.ToString(p.AmountInDepot);

                    return true;
                }
                else
                {
                    lbName.Text = "";
                    lbAmount.Text = "";

                    return false;
                }
            }
            catch 
            { 
                return false;
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

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Product p = control.GetProduct(txtBarcode.Text);
            if (p != null)
            {
                if (control.RequestRestock(p))
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

        private void BarcodeScannerDepot_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
        }
    }
}
