using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses.IDepotEmployee;
using System;
using System.Data;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormDepotEmployee : Form
    {
        DepotEmployee de;
        Store s;
        IDepotEmployeeControl c;
        FormLogin login;

        public FormDepotEmployee(DepotEmployee e, Store s, FormLogin login)
        {
            InitializeComponent();

            this.login = login;
            de = e;
            this.s = s;
            c = de.Control;

            UpdatePendingRequests();
            UpdateOrders();
        }

        //Overview
        private void btnLogout_Click(object sender, EventArgs e)
        {
            login.Show();
            Close();
        }
        private void FormDepotEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        //Reshelf
        private void UpdatePendingRequests()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Barcode", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Status", typeof(string));

            foreach (Reshelf reshelf in c.GetReshelfRequest())
            {
                if (reshelf.Status == "Pending")
                {
                    table.Rows.Add(reshelf.ID, reshelf.Product.Barcode, reshelf.AmountRequested, reshelf.Status);
                }
            }

            dgReshelve.DataSource = table;
        }
        private void UpdateHistory()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Barcode", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Status", typeof(string));

            foreach (Reshelf reshelf in c.GetReshelfRequest())
            {
                if (reshelf.Status == "Fulfilled")
                {
                    table.Rows.Add(reshelf.ID, reshelf.Product.Barcode, reshelf.AmountRequested, reshelf.Status);
                }
            }

            dgReshelve.DataSource = table;
        }
        private void rbPending_Click(object sender, EventArgs e)
        {
            UpdatePendingRequests();

            txtAmountRequested.Text = "";
            txtBarcode.Text = "";
            txtReshelfID.Text = "";

            btnFufillReshelveRequest.Show();
            btnDeleteReshelveRequest.Show();
        }

        private void rbHistory_Click(object sender, EventArgs e)
        {
            UpdateHistory();

            txtAmountRequested.Text = "";
            txtBarcode.Text = "";
            txtReshelfID.Text = "";

            btnDeleteReshelveRequest.Hide();
            btnFufillReshelveRequest.Hide();
        }
        private void btnFufillReshelveRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtReshelfID.Text);
                Product p = c.GetProduct(txtBarcode.Text);
                int amount = Convert.ToInt32(txtAmountRequested.Text);

                if(c.CheckAmount(p, amount) == false)
                {
                    MessageBox.Show("Not enough amount of product in depot");
                }
                else
                {
                    if (c.CompleteReshelf(id, p))
                    {
                        UpdatePendingRequests();

                        txtAmountRequested.Text = "";
                        txtBarcode.Text = "";
                        txtReshelfID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                } 
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a reshelf request you want to fulfill");
            }
            UpdatePendingRequests();
        }
        private void btnDeleteReshelveRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtReshelfID.Text);

                if (c.DeleteReshelf(id))
                {
                    UpdatePendingRequests();

                    txtAmountRequested.Text = "";
                    txtBarcode.Text = "";
                    txtReshelfID.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a reshelf request you want to reject");
            }
        }
        private void dgReshelve_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgReshelve.Rows[e.RowIndex];

                txtReshelfID.Text = row.Cells["ID"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                txtAmountRequested.Text = row.Cells["Amount"].Value.ToString();
                txtDepot.Text = c.GetProduct(txtBarcode.Text).AmountInDepot.ToString();
            }
        }

        //Receive Product
        private void UpdateOrders()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Barcode", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Status", typeof(string));

            foreach (Restock restock in c.GetOrderedRestockRequests())
            {
                table.Rows.Add(restock.ID, restock.Product.Barcode, restock.AmountRequested, restock.Status);
            }

            dgOrder.DataSource = table;
        }
        private void dgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgOrder.Rows[e.RowIndex];
                txtRestockID.Text = row.Cells["ID"].Value.ToString();
                txtBarcodeRestock.Text = row.Cells["Barcode"].Value.ToString();
                txtAmountRestock.Text = row.Cells["Amount"].Value.ToString();
            }
        }
        private void btnReceiveProduct_Click(object sender, EventArgs e)
        {     
            try
            {
                int id = Convert.ToInt32(txtRestockID.Text);
                Product p = c.GetProduct(txtBarcodeRestock.Text);

                if (c.ReceiveRestock(id, p))
                {
                    UpdateOrders();

                    txtAmountRestock.Text = "";
                    txtBarcodeRestock.Text = "";
                    txtRestockID.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select restock request and input the amount supplied");
            }
            UpdateOrders();
        }
    }
}
