
namespace CardReader
{
    partial class EmployeeCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeCard));
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.labAddress = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.labPhoneNumber = new System.Windows.Forms.Label();
            this.tbBSN = new System.Windows.Forms.TextBox();
            this.labBSN = new System.Windows.Forms.Label();
            this.tbDateOfBirth = new System.Windows.Forms.TextBox();
            this.laDateOfBirth = new System.Windows.Forms.Label();
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.labEmployeeID = new System.Windows.Forms.Label();
            this.btnConnectCardAndEmployee = new System.Windows.Forms.Button();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.labCard = new System.Windows.Forms.Label();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.labEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployee = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.labSearch);
            this.gbEmployee.Controls.Add(this.tbSearch);
            this.gbEmployee.Controls.Add(this.tbAddress);
            this.gbEmployee.Controls.Add(this.labAddress);
            this.gbEmployee.Controls.Add(this.tbEmail);
            this.gbEmployee.Controls.Add(this.labEmail);
            this.gbEmployee.Controls.Add(this.tbPhoneNumber);
            this.gbEmployee.Controls.Add(this.labPhoneNumber);
            this.gbEmployee.Controls.Add(this.tbBSN);
            this.gbEmployee.Controls.Add(this.labBSN);
            this.gbEmployee.Controls.Add(this.tbDateOfBirth);
            this.gbEmployee.Controls.Add(this.laDateOfBirth);
            this.gbEmployee.Controls.Add(this.tbEmployeeID);
            this.gbEmployee.Controls.Add(this.labEmployeeID);
            this.gbEmployee.Controls.Add(this.btnConnectCardAndEmployee);
            this.gbEmployee.Controls.Add(this.tbCardNumber);
            this.gbEmployee.Controls.Add(this.labCard);
            this.gbEmployee.Controls.Add(this.tbEmployeeName);
            this.gbEmployee.Controls.Add(this.labEmployeeName);
            this.gbEmployee.Controls.Add(this.lbEmployee);
            this.gbEmployee.Location = new System.Drawing.Point(12, 12);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(896, 487);
            this.gbEmployee.TabIndex = 11;
            this.gbEmployee.TabStop = false;
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(20, 24);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(75, 24);
            this.labSearch.TabIndex = 23;
            this.labSearch.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(110, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(348, 29);
            this.tbSearch.TabIndex = 22;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(680, 306);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(196, 26);
            this.tbAddress.TabIndex = 21;
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddress.Location = new System.Drawing.Point(676, 279);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(72, 20);
            this.labAddress.TabIndex = 20;
            this.labAddress.Text = "Address:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(680, 247);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(196, 26);
            this.tbEmail.TabIndex = 19;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.Location = new System.Drawing.Point(676, 220);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(52, 20);
            this.labEmail.TabIndex = 18;
            this.labEmail.Text = "Email:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(680, 186);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.ReadOnly = true;
            this.tbPhoneNumber.Size = new System.Drawing.Size(196, 26);
            this.tbPhoneNumber.TabIndex = 17;
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.AutoSize = true;
            this.labPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhoneNumber.Location = new System.Drawing.Point(676, 159);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.labPhoneNumber.TabIndex = 16;
            this.labPhoneNumber.Text = "PhoneNumber:";
            // 
            // tbBSN
            // 
            this.tbBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBSN.Location = new System.Drawing.Point(493, 306);
            this.tbBSN.Name = "tbBSN";
            this.tbBSN.ReadOnly = true;
            this.tbBSN.Size = new System.Drawing.Size(171, 26);
            this.tbBSN.TabIndex = 15;
            // 
            // labBSN
            // 
            this.labBSN.AutoSize = true;
            this.labBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBSN.Location = new System.Drawing.Point(489, 279);
            this.labBSN.Name = "labBSN";
            this.labBSN.Size = new System.Drawing.Size(46, 20);
            this.labBSN.TabIndex = 14;
            this.labBSN.Text = "BSN:";
            // 
            // tbDateOfBirth
            // 
            this.tbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateOfBirth.Location = new System.Drawing.Point(493, 247);
            this.tbDateOfBirth.Name = "tbDateOfBirth";
            this.tbDateOfBirth.ReadOnly = true;
            this.tbDateOfBirth.Size = new System.Drawing.Size(171, 26);
            this.tbDateOfBirth.TabIndex = 13;
            // 
            // laDateOfBirth
            // 
            this.laDateOfBirth.AutoSize = true;
            this.laDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDateOfBirth.Location = new System.Drawing.Point(489, 220);
            this.laDateOfBirth.Name = "laDateOfBirth";
            this.laDateOfBirth.Size = new System.Drawing.Size(98, 20);
            this.laDateOfBirth.TabIndex = 12;
            this.laDateOfBirth.Text = "DateOfBirth:";
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeID.Location = new System.Drawing.Point(493, 186);
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.ReadOnly = true;
            this.tbEmployeeID.Size = new System.Drawing.Size(171, 26);
            this.tbEmployeeID.TabIndex = 11;
            // 
            // labEmployeeID
            // 
            this.labEmployeeID.AutoSize = true;
            this.labEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployeeID.Location = new System.Drawing.Point(489, 159);
            this.labEmployeeID.Name = "labEmployeeID";
            this.labEmployeeID.Size = new System.Drawing.Size(104, 20);
            this.labEmployeeID.TabIndex = 10;
            this.labEmployeeID.Text = "Employee ID:";
            // 
            // btnConnectCardAndEmployee
            // 
            this.btnConnectCardAndEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCardAndEmployee.Location = new System.Drawing.Point(508, 368);
            this.btnConnectCardAndEmployee.Name = "btnConnectCardAndEmployee";
            this.btnConnectCardAndEmployee.Size = new System.Drawing.Size(350, 74);
            this.btnConnectCardAndEmployee.TabIndex = 9;
            this.btnConnectCardAndEmployee.Text = "Update employee card number";
            this.btnConnectCardAndEmployee.UseVisualStyleBackColor = true;
            this.btnConnectCardAndEmployee.Click += new System.EventHandler(this.btnConnectCardAndEmployee_Click);
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCardNumber.Location = new System.Drawing.Point(486, 111);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.ReadOnly = true;
            this.tbCardNumber.Size = new System.Drawing.Size(390, 29);
            this.tbCardNumber.TabIndex = 8;
            // 
            // labCard
            // 
            this.labCard.AutoSize = true;
            this.labCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCard.Location = new System.Drawing.Point(482, 84);
            this.labCard.Name = "labCard";
            this.labCard.Size = new System.Drawing.Size(129, 24);
            this.labCard.TabIndex = 7;
            this.labCard.Text = "Card Number:";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeName.Location = new System.Drawing.Point(486, 51);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.ReadOnly = true;
            this.tbEmployeeName.Size = new System.Drawing.Size(390, 29);
            this.tbEmployeeName.TabIndex = 6;
            // 
            // labEmployeeName
            // 
            this.labEmployeeName.AutoSize = true;
            this.labEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployeeName.Location = new System.Drawing.Point(482, 24);
            this.labEmployeeName.Name = "labEmployeeName";
            this.labEmployeeName.Size = new System.Drawing.Size(66, 24);
            this.labEmployeeName.TabIndex = 5;
            this.labEmployeeName.Text = "Name:";
            // 
            // lbEmployee
            // 
            this.lbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.FormattingEnabled = true;
            this.lbEmployee.ItemHeight = 24;
            this.lbEmployee.Location = new System.Drawing.Point(24, 72);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(452, 364);
            this.lbEmployee.TabIndex = 1;
            this.lbEmployee.SelectedIndexChanged += new System.EventHandler(this.lbEmployee_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 512);
            this.Controls.Add(this.gbEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeCard";
            this.Text = "EmployeeCard";
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.Button btnConnectCardAndEmployee;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label labCard;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label labEmployeeName;
        private System.Windows.Forms.ListBox lbEmployee;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbBSN;
        private System.Windows.Forms.Label labBSN;
        private System.Windows.Forms.TextBox tbDateOfBirth;
        private System.Windows.Forms.Label laDateOfBirth;
        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.Label labEmployeeID;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label labPhoneNumber;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}