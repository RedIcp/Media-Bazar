
namespace AdminBackups
{
    partial class FormDepotEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstAnnouncement = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReshelves = new System.Windows.Forms.TabPage();
            this.dgReshelve = new System.Windows.Forms.DataGridView();
            this.rbHistory = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmountRequested = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtReshelfID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFufillReshelveRequest = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteReshelveRequest = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tabReceivingGood = new System.Windows.Forms.TabPage();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAmountRestock = new System.Windows.Forms.TextBox();
            this.txtBarcodeRestock = new System.Windows.Forms.TextBox();
            this.txtRestockID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReceiveProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDepot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabReshelves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReshelve)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabReceivingGood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(802, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 33);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstAnnouncement
            // 
            this.lstAnnouncement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstAnnouncement.FormattingEnabled = true;
            this.lstAnnouncement.ItemHeight = 17;
            this.lstAnnouncement.Location = new System.Drawing.Point(21, 47);
            this.lstAnnouncement.Name = "lstAnnouncement";
            this.lstAnnouncement.Size = new System.Drawing.Size(764, 208);
            this.lstAnnouncement.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReshelves);
            this.tabControl1.Controls.Add(this.tabReceivingGood);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 522);
            this.tabControl1.TabIndex = 3;
            // 
            // tabReshelves
            // 
            this.tabReshelves.Controls.Add(this.dgReshelve);
            this.tabReshelves.Controls.Add(this.rbHistory);
            this.tabReshelves.Controls.Add(this.rbPending);
            this.tabReshelves.Controls.Add(this.groupBox1);
            this.tabReshelves.Controls.Add(this.label15);
            this.tabReshelves.Location = new System.Drawing.Point(4, 30);
            this.tabReshelves.Name = "tabReshelves";
            this.tabReshelves.Padding = new System.Windows.Forms.Padding(3);
            this.tabReshelves.Size = new System.Drawing.Size(894, 488);
            this.tabReshelves.TabIndex = 0;
            this.tabReshelves.Text = "Reshelf";
            this.tabReshelves.UseVisualStyleBackColor = true;
            // 
            // dgReshelve
            // 
            this.dgReshelve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReshelve.Location = new System.Drawing.Point(17, 51);
            this.dgReshelve.Name = "dgReshelve";
            this.dgReshelve.RowHeadersWidth = 51;
            this.dgReshelve.RowTemplate.Height = 25;
            this.dgReshelve.Size = new System.Drawing.Size(603, 406);
            this.dgReshelve.TabIndex = 96;
            this.dgReshelve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReshelve_CellClick_1);
            // 
            // rbHistory
            // 
            this.rbHistory.AutoSize = true;
            this.rbHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbHistory.Location = new System.Drawing.Point(408, 24);
            this.rbHistory.Name = "rbHistory";
            this.rbHistory.Size = new System.Drawing.Size(120, 21);
            this.rbHistory.TabIndex = 95;
            this.rbHistory.Text = "Previous History";
            this.rbHistory.UseVisualStyleBackColor = true;
            this.rbHistory.Click += new System.EventHandler(this.rbHistory_Click);
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Checked = true;
            this.rbPending.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPending.Location = new System.Drawing.Point(318, 24);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(73, 21);
            this.rbPending.TabIndex = 94;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            this.rbPending.Click += new System.EventHandler(this.rbPending_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmountRequested);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.txtReshelfID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFufillReshelveRequest);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDeleteReshelveRequest);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(648, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 279);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restock Management";
            // 
            // txtAmountRequested
            // 
            this.txtAmountRequested.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmountRequested.Location = new System.Drawing.Point(132, 109);
            this.txtAmountRequested.Name = "txtAmountRequested";
            this.txtAmountRequested.ReadOnly = true;
            this.txtAmountRequested.Size = new System.Drawing.Size(78, 23);
            this.txtAmountRequested.TabIndex = 97;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBarcode.Location = new System.Drawing.Point(110, 73);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(100, 23);
            this.txtBarcode.TabIndex = 97;
            // 
            // txtReshelfID
            // 
            this.txtReshelfID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReshelfID.Location = new System.Drawing.Point(110, 34);
            this.txtReshelfID.Name = "txtReshelfID";
            this.txtReshelfID.ReadOnly = true;
            this.txtReshelfID.Size = new System.Drawing.Size(100, 23);
            this.txtReshelfID.TabIndex = 97;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(36, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 69;
            this.label14.Text = "Reshelf ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "Barcode:";
            // 
            // btnFufillReshelveRequest
            // 
            this.btnFufillReshelveRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFufillReshelveRequest.Location = new System.Drawing.Point(21, 203);
            this.btnFufillReshelveRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFufillReshelveRequest.Name = "btnFufillReshelveRequest";
            this.btnFufillReshelveRequest.Size = new System.Drawing.Size(189, 30);
            this.btnFufillReshelveRequest.TabIndex = 70;
            this.btnFufillReshelveRequest.Text = "Fufill reshelve request";
            this.btnFufillReshelveRequest.UseVisualStyleBackColor = true;
            this.btnFufillReshelveRequest.Click += new System.EventHandler(this.btnFufillReshelveRequest_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(5, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Amount Requested:";
            // 
            // btnDeleteReshelveRequest
            // 
            this.btnDeleteReshelveRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteReshelveRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteReshelveRequest.Location = new System.Drawing.Point(21, 235);
            this.btnDeleteReshelveRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDeleteReshelveRequest.Name = "btnDeleteReshelveRequest";
            this.btnDeleteReshelveRequest.Size = new System.Drawing.Size(189, 30);
            this.btnDeleteReshelveRequest.TabIndex = 84;
            this.btnDeleteReshelveRequest.Text = "Delete reshelve request";
            this.btnDeleteReshelveRequest.UseVisualStyleBackColor = true;
            this.btnDeleteReshelveRequest.Click += new System.EventHandler(this.btnDeleteReshelveRequest_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(17, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 21);
            this.label15.TabIndex = 92;
            this.label15.Text = "Reshelf Requests:";
            // 
            // tabReceivingGood
            // 
            this.tabReceivingGood.Controls.Add(this.dgOrder);
            this.tabReceivingGood.Controls.Add(this.groupBox2);
            this.tabReceivingGood.Controls.Add(this.label10);
            this.tabReceivingGood.Location = new System.Drawing.Point(4, 30);
            this.tabReceivingGood.Name = "tabReceivingGood";
            this.tabReceivingGood.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceivingGood.Size = new System.Drawing.Size(894, 488);
            this.tabReceivingGood.TabIndex = 1;
            this.tabReceivingGood.Text = "ReceivingGoods";
            this.tabReceivingGood.UseVisualStyleBackColor = true;
            // 
            // dgOrder
            // 
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.Location = new System.Drawing.Point(20, 57);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.RowHeadersWidth = 51;
            this.dgOrder.RowTemplate.Height = 25;
            this.dgOrder.Size = new System.Drawing.Size(620, 398);
            this.dgOrder.TabIndex = 96;
            this.dgOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrder_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAmountRestock);
            this.groupBox2.Controls.Add(this.txtBarcodeRestock);
            this.groupBox2.Controls.Add(this.txtRestockID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnReceiveProduct);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(662, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 176);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Management";
            // 
            // txtAmountRestock
            // 
            this.txtAmountRestock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmountRestock.Location = new System.Drawing.Point(101, 91);
            this.txtAmountRestock.Name = "txtAmountRestock";
            this.txtAmountRestock.ReadOnly = true;
            this.txtAmountRestock.Size = new System.Drawing.Size(89, 23);
            this.txtAmountRestock.TabIndex = 97;
            // 
            // txtBarcodeRestock
            // 
            this.txtBarcodeRestock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBarcodeRestock.Location = new System.Drawing.Point(101, 62);
            this.txtBarcodeRestock.Name = "txtBarcodeRestock";
            this.txtBarcodeRestock.ReadOnly = true;
            this.txtBarcodeRestock.Size = new System.Drawing.Size(89, 23);
            this.txtBarcodeRestock.TabIndex = 97;
            // 
            // txtRestockID
            // 
            this.txtRestockID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRestockID.Location = new System.Drawing.Point(101, 34);
            this.txtRestockID.Name = "txtRestockID";
            this.txtRestockID.ReadOnly = true;
            this.txtRestockID.Size = new System.Drawing.Size(89, 23);
            this.txtRestockID.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "Restock ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 87;
            this.label6.Text = "Barcode:";
            // 
            // btnReceiveProduct
            // 
            this.btnReceiveProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReceiveProduct.Location = new System.Drawing.Point(13, 132);
            this.btnReceiveProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReceiveProduct.Name = "btnReceiveProduct";
            this.btnReceiveProduct.Size = new System.Drawing.Size(185, 30);
            this.btnReceiveProduct.TabIndex = 70;
            this.btnReceiveProduct.Text = "Receive Product";
            this.btnReceiveProduct.UseVisualStyleBackColor = true;
            this.btnReceiveProduct.Click += new System.EventHandler(this.btnReceiveProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(40, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(20, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 21);
            this.label10.TabIndex = 92;
            this.label10.Text = "Restock Ordered:";
            // 
            // txtDepot
            // 
            this.txtDepot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDepot.Location = new System.Drawing.Point(132, 145);
            this.txtDepot.Name = "txtDepot";
            this.txtDepot.ReadOnly = true;
            this.txtDepot.Size = new System.Drawing.Size(78, 23);
            this.txtDepot.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "Amount In Depot:";
            // 
            // FormDepotEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 588);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDepotEmployee";
            this.Text = "FormDepotEmployee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDepotEmployee_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabReshelves.ResumeLayout(false);
            this.tabReshelves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReshelve)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabReceivingGood.ResumeLayout(false);
            this.tabReceivingGood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox lstAnnouncement;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReshelves;
        private System.Windows.Forms.DataGridView dgReshelve;
        private System.Windows.Forms.RadioButton rbHistory;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFufillReshelveRequest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteReshelveRequest;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabReceivingGood;
        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReceiveProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAmountRequested;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtReshelfID;
        private System.Windows.Forms.TextBox txtAmountRestock;
        private System.Windows.Forms.TextBox txtBarcodeRestock;
        private System.Windows.Forms.TextBox txtRestockID;
        private System.Windows.Forms.TextBox txtDepot;
        private System.Windows.Forms.Label label2;
    }
}