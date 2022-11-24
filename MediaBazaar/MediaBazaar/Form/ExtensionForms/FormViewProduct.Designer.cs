
namespace MediaBazaar
{
    partial class FormViewProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.tbxSellingPrice = new System.Windows.Forms.TextBox();
            this.tbxAmountInDepot = new System.Windows.Forms.TextBox();
            this.tbxAmountInStore = new System.Windows.Forms.TextBox();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateOrderInfo = new System.Windows.Forms.Button();
            this.tbxMultiples = new System.Windows.Forms.TextBox();
            this.tbxMaxAmount = new System.Windows.Forms.TextBox();
            this.tbxMinAmount = new System.Windows.Forms.TextBox();
            this.tbxPurchasePrice = new System.Windows.Forms.TextBox();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProduct);
            this.groupBox1.Controls.Add(this.tbxType);
            this.groupBox1.Controls.Add(this.tbxStatus);
            this.groupBox1.Controls.Add(this.cbxStatus);
            this.groupBox1.Controls.Add(this.tbxSellingPrice);
            this.groupBox1.Controls.Add(this.tbxAmountInDepot);
            this.groupBox1.Controls.Add(this.tbxAmountInStore);
            this.groupBox1.Controls.Add(this.tbxBarcode);
            this.groupBox1.Controls.Add(this.cbxProductType);
            this.groupBox1.Controls.Add(this.tbxProductName);
            this.groupBox1.Controls.Add(this.tbxProductID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info:";
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(430, 153);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(104, 23);
            this.btnProduct.TabIndex = 18;
            this.btnProduct.Text = "Update Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(118, 124);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(146, 23);
            this.tbxType.TabIndex = 17;
            // 
            // tbxStatus
            // 
            this.tbxStatus.Location = new System.Drawing.Point(388, 124);
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.Size = new System.Drawing.Size(146, 23);
            this.tbxStatus.TabIndex = 16;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Available",
            "Discontinued"});
            this.cbxStatus.Location = new System.Drawing.Point(388, 124);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(146, 23);
            this.cbxStatus.TabIndex = 15;
            // 
            // tbxSellingPrice
            // 
            this.tbxSellingPrice.Location = new System.Drawing.Point(388, 90);
            this.tbxSellingPrice.Name = "tbxSellingPrice";
            this.tbxSellingPrice.Size = new System.Drawing.Size(146, 23);
            this.tbxSellingPrice.TabIndex = 14;
            // 
            // tbxAmountInDepot
            // 
            this.tbxAmountInDepot.Location = new System.Drawing.Point(388, 61);
            this.tbxAmountInDepot.Name = "tbxAmountInDepot";
            this.tbxAmountInDepot.ReadOnly = true;
            this.tbxAmountInDepot.Size = new System.Drawing.Size(146, 23);
            this.tbxAmountInDepot.TabIndex = 13;
            // 
            // tbxAmountInStore
            // 
            this.tbxAmountInStore.Location = new System.Drawing.Point(388, 28);
            this.tbxAmountInStore.Name = "tbxAmountInStore";
            this.tbxAmountInStore.ReadOnly = true;
            this.tbxAmountInStore.Size = new System.Drawing.Size(146, 23);
            this.tbxAmountInStore.TabIndex = 12;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(118, 90);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.ReadOnly = true;
            this.tbxBarcode.Size = new System.Drawing.Size(146, 23);
            this.tbxBarcode.TabIndex = 11;
            // 
            // cbxProductType
            // 
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Items.AddRange(new object[] {
            "KITCHEN_HOME",
            "PHOTO_VIDEO_NAVIGATION",
            "SMART_HOME_APPLIANCES",
            "GAMING_MUSIC_COMPUTERS"});
            this.cbxProductType.Location = new System.Drawing.Point(118, 124);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(146, 23);
            this.cbxProductType.TabIndex = 10;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(118, 58);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(146, 23);
            this.tbxProductName.TabIndex = 9;
            // 
            // tbxProductID
            // 
            this.tbxProductID.Location = new System.Drawing.Point(118, 28);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.ReadOnly = true;
            this.tbxProductID.Size = new System.Drawing.Size(146, 23);
            this.tbxProductID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Amount in Store:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount in Depot:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selling Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateOrderInfo);
            this.groupBox2.Controls.Add(this.tbxMultiples);
            this.groupBox2.Controls.Add(this.tbxMaxAmount);
            this.groupBox2.Controls.Add(this.tbxMinAmount);
            this.groupBox2.Controls.Add(this.tbxPurchasePrice);
            this.groupBox2.Controls.Add(this.cbxSupplier);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(13, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Info:";
            // 
            // btnCreateOrderInfo
            // 
            this.btnCreateOrderInfo.Location = new System.Drawing.Point(388, 95);
            this.btnCreateOrderInfo.Name = "btnCreateOrderInfo";
            this.btnCreateOrderInfo.Size = new System.Drawing.Size(146, 23);
            this.btnCreateOrderInfo.TabIndex = 13;
            this.btnCreateOrderInfo.Text = "Add New Order Info";
            this.btnCreateOrderInfo.UseVisualStyleBackColor = true;
            this.btnCreateOrderInfo.Click += new System.EventHandler(this.btnCreateOrderInfo_Click);
            // 
            // tbxMultiples
            // 
            this.tbxMultiples.Location = new System.Drawing.Point(388, 62);
            this.tbxMultiples.Name = "tbxMultiples";
            this.tbxMultiples.ReadOnly = true;
            this.tbxMultiples.Size = new System.Drawing.Size(146, 23);
            this.tbxMultiples.TabIndex = 12;
            // 
            // tbxMaxAmount
            // 
            this.tbxMaxAmount.Location = new System.Drawing.Point(131, 92);
            this.tbxMaxAmount.Name = "tbxMaxAmount";
            this.tbxMaxAmount.ReadOnly = true;
            this.tbxMaxAmount.Size = new System.Drawing.Size(133, 23);
            this.tbxMaxAmount.TabIndex = 11;
            // 
            // tbxMinAmount
            // 
            this.tbxMinAmount.Location = new System.Drawing.Point(131, 63);
            this.tbxMinAmount.Name = "tbxMinAmount";
            this.tbxMinAmount.ReadOnly = true;
            this.tbxMinAmount.Size = new System.Drawing.Size(133, 23);
            this.tbxMinAmount.TabIndex = 10;
            // 
            // tbxPurchasePrice
            // 
            this.tbxPurchasePrice.Location = new System.Drawing.Point(388, 29);
            this.tbxPurchasePrice.Name = "tbxPurchasePrice";
            this.tbxPurchasePrice.ReadOnly = true;
            this.tbxPurchasePrice.Size = new System.Drawing.Size(146, 23);
            this.tbxPurchasePrice.TabIndex = 9;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(118, 29);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(146, 23);
            this.cbxSupplier.TabIndex = 5;
            this.cbxSupplier.SelectedIndexChanged += new System.EventHandler(this.cbxSupplier_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Purchase Price:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Order Multiples:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Max Order Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Min Order Amount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Supplier:";
            // 
            // FormViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormViewProduct";
            this.Text = "ViewProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.TextBox tbxSellingPrice;
        private System.Windows.Forms.TextBox tbxAmountInDepot;
        private System.Windows.Forms.TextBox tbxAmountInStore;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.ComboBox cbxProductType;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.TextBox tbxPurchasePrice;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMultiples;
        private System.Windows.Forms.TextBox tbxMaxAmount;
        private System.Windows.Forms.TextBox tbxMinAmount;
        private System.Windows.Forms.Button btnCreateOrderInfo;
    }
}