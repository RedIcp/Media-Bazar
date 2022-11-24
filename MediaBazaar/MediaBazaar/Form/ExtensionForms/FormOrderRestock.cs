using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses.IDepotManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormOrderRestock : Form
    {
        Restock r;
        IDepotManagerControl c;
        FormDepotManager depot;
        public FormOrderRestock(Restock restock, IDepotManagerControl control, FormDepotManager depot)
        {
            InitializeComponent();

            r = restock;
            c = control;
            this.depot = depot;

            txtRestockID.Text = restock.ID.ToString();
            UpdateOrderInfoList();
        }

        private void UpdateOrderInfoList()
        {
            lstOrderInfo.Items.Clear();
            foreach(OrderInfo orderInfo in r.Product.OrderInfos)
            {
                lstOrderInfo.Items.Add(orderInfo);
            }
        }
        private void btnOrderRestock_Click(object sender, EventArgs e)
        {
            Object orderinfoObject = lstOrderInfo.SelectedItem;
            if (!(orderinfoObject is OrderInfo))
            {
                MessageBox.Show("Select a order info!");
            }
            try
            {
                int amount = Convert.ToInt32(txtAmount.Text);
                OrderInfo orderInfo = (OrderInfo)orderinfoObject;

                if(c.IsValid(orderInfo, amount) == false)
                {
                    MessageBox.Show("Invalid Amount!");
                }
                else
                {
                    if (c.OrderRestock(r.ID, orderInfo, amount))
                    {
                        depot.UpdatePendingRequests();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void lstOrderInfo_Click(object sender, EventArgs e)
        {
            Object orderinfoObject = lstOrderInfo.SelectedItem;
            if (!(orderinfoObject is OrderInfo))
            {
                return;
            }
            else
            {
                OrderInfo orderInfo = (OrderInfo)orderinfoObject;

                txtOrderInfoID.Text = orderInfo.ID.ToString();
                txtSupplier.Text = orderInfo.Supplier.Name;
                txtMax.Text = orderInfo.MaxAmount.ToString();
                txtMin.Text = orderInfo.MinAmount.ToString();
                txtMultiples.Text = orderInfo.Multiples.ToString();
            }
        }
    }
}
