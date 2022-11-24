
namespace AdminBackups
{
    partial class FormOfficeManager
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
            this.Comapny = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxActiveEmployeeID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxEmployeeType = new System.Windows.Forms.ComboBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bntUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxSearchEmployee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.gbCompanyInfo = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labCompanyID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBTW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKVK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.gbDepartment = new System.Windows.Forms.GroupBox();
            this.labDepartmentID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.udResult = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.labDepartmentName = new System.Windows.Forms.Label();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHeadDepartments = new System.Windows.Forms.ComboBox();
            this.WorkHours = new System.Windows.Forms.TabPage();
            this.rbColor = new System.Windows.Forms.CheckBox();
            this.dgvAtendance = new System.Windows.Forms.DataGridView();
            this.btnMonthIncrease = new System.Windows.Forms.Button();
            this.btnIncreaseYear = new System.Windows.Forms.Button();
            this.btnMonthDecrease = new System.Windows.Forms.Button();
            this.btnDecreaseYear = new System.Windows.Forms.Button();
            this.labMonth = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.btnMakeExcelSheet = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Comapny.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCompanyInfo.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.gbDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udResult)).BeginInit();
            this.WorkHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendance)).BeginInit();
            this.SuspendLayout();
            // 
            // Comapny
            // 
            this.Comapny.Controls.Add(this.tabPage2);
            this.Comapny.Controls.Add(this.tabPage1);
            this.Comapny.Controls.Add(this.tabPage3);
            this.Comapny.Controls.Add(this.WorkHours);
            this.Comapny.Location = new System.Drawing.Point(11, 20);
            this.Comapny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Comapny.Name = "Comapny";
            this.Comapny.SelectedIndex = 0;
            this.Comapny.Size = new System.Drawing.Size(1131, 526);
            this.Comapny.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1123, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee overview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDepartment);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbxActiveEmployeeID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbxEmployeeType);
            this.groupBox1.Controls.Add(this.dgvEmployees);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1112, 491);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Employees";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(398, 27);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(154, 23);
            this.cbxDepartment.TabIndex = 21;
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Department:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(868, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Selected Employee:";
            // 
            // tbxActiveEmployeeID
            // 
            this.tbxActiveEmployeeID.Location = new System.Drawing.Point(868, 150);
            this.tbxActiveEmployeeID.Name = "tbxActiveEmployeeID";
            this.tbxActiveEmployeeID.ReadOnly = true;
            this.tbxActiveEmployeeID.Size = new System.Drawing.Size(225, 23);
            this.tbxActiveEmployeeID.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(17, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "Employees:";
            // 
            // cbxEmployeeType
            // 
            this.cbxEmployeeType.FormattingEnabled = true;
            this.cbxEmployeeType.Items.AddRange(new object[] {
            "All Employees",
            "CEO",
            "Admins",
            "Depot Managers",
            "Depot Employees",
            "Sales Managers",
            "Sales Representatives",
            "Product Managers",
            "Office Managers"});
            this.cbxEmployeeType.Location = new System.Drawing.Point(140, 27);
            this.cbxEmployeeType.Name = "cbxEmployeeType";
            this.cbxEmployeeType.Size = new System.Drawing.Size(163, 23);
            this.cbxEmployeeType.TabIndex = 16;
            this.cbxEmployeeType.Text = "All Employees";
            this.cbxEmployeeType.SelectedIndexChanged += new System.EventHandler(this.cbxEmployeeType_SelectedIndexChanged);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(16, 70);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowTemplate.Height = 25;
            this.dgvEmployees.Size = new System.Drawing.Size(835, 401);
            this.dgvEmployees.TabIndex = 15;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bntUpdateEmployee);
            this.groupBox4.Controls.Add(this.btnDeleteEmployee);
            this.groupBox4.Controls.Add(this.btnCreateEmployee);
            this.groupBox4.Location = new System.Drawing.Point(868, 197);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(241, 153);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manage Employees";
            // 
            // bntUpdateEmployee
            // 
            this.bntUpdateEmployee.Location = new System.Drawing.Point(6, 63);
            this.bntUpdateEmployee.Name = "bntUpdateEmployee";
            this.bntUpdateEmployee.Size = new System.Drawing.Size(219, 38);
            this.bntUpdateEmployee.TabIndex = 9;
            this.bntUpdateEmployee.Text = "Update Employee";
            this.bntUpdateEmployee.UseVisualStyleBackColor = true;
            this.bntUpdateEmployee.Click += new System.EventHandler(this.bntUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(6, 106);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(220, 38);
            this.btnDeleteEmployee.TabIndex = 7;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(6, 20);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(220, 38);
            this.btnCreateEmployee.TabIndex = 1;
            this.btnCreateEmployee.Text = "Add New Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.tbxSearchEmployee);
            this.groupBox5.Location = new System.Drawing.Point(868, 20);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(238, 80);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Search employee by name:";
            // 
            // tbxSearchEmployee
            // 
            this.tbxSearchEmployee.Location = new System.Drawing.Point(6, 42);
            this.tbxSearchEmployee.Name = "tbxSearchEmployee";
            this.tbxSearchEmployee.Size = new System.Drawing.Size(219, 23);
            this.tbxSearchEmployee.TabIndex = 11;
            this.tbxSearchEmployee.TextChanged += new System.EventHandler(this.tbxSearchEmployee_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "  ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditCompany);
            this.tabPage1.Controls.Add(this.gbCompanyInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1123, 498);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Company";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditCompany.Location = new System.Drawing.Point(709, 405);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(222, 58);
            this.btnEditCompany.TabIndex = 3;
            this.btnEditCompany.Text = "Save Changes";
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // gbCompanyInfo
            // 
            this.gbCompanyInfo.Controls.Add(this.tbID);
            this.gbCompanyInfo.Controls.Add(this.labCompanyID);
            this.gbCompanyInfo.Controls.Add(this.label8);
            this.gbCompanyInfo.Controls.Add(this.tbBTW);
            this.gbCompanyInfo.Controls.Add(this.label7);
            this.gbCompanyInfo.Controls.Add(this.tbKVK);
            this.gbCompanyInfo.Controls.Add(this.label6);
            this.gbCompanyInfo.Controls.Add(this.tbPhoneNumber);
            this.gbCompanyInfo.Controls.Add(this.label3);
            this.gbCompanyInfo.Controls.Add(this.tbEmail);
            this.gbCompanyInfo.Controls.Add(this.label2);
            this.gbCompanyInfo.Controls.Add(this.tbAdress);
            this.gbCompanyInfo.Controls.Add(this.label1);
            this.gbCompanyInfo.Controls.Add(this.tbCompanyName);
            this.gbCompanyInfo.Location = new System.Drawing.Point(23, 17);
            this.gbCompanyInfo.Name = "gbCompanyInfo";
            this.gbCompanyInfo.Size = new System.Drawing.Size(628, 475);
            this.gbCompanyInfo.TabIndex = 2;
            this.gbCompanyInfo.TabStop = false;
            this.gbCompanyInfo.Text = "Company info";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbID.Location = new System.Drawing.Point(204, 40);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(399, 33);
            this.tbID.TabIndex = 14;
            // 
            // labCompanyID
            // 
            this.labCompanyID.AutoSize = true;
            this.labCompanyID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labCompanyID.Location = new System.Drawing.Point(64, 40);
            this.labCompanyID.Name = "labCompanyID";
            this.labCompanyID.Size = new System.Drawing.Size(119, 25);
            this.labCompanyID.TabIndex = 13;
            this.labCompanyID.Text = "CompanyID: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(129, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "BTW:";
            // 
            // tbBTW
            // 
            this.tbBTW.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBTW.Location = new System.Drawing.Point(204, 418);
            this.tbBTW.Name = "tbBTW";
            this.tbBTW.Size = new System.Drawing.Size(399, 33);
            this.tbBTW.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(111, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Adress:";
            // 
            // tbKVK
            // 
            this.tbKVK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKVK.Location = new System.Drawing.Point(204, 356);
            this.tbKVK.Name = "tbKVK";
            this.tbKVK.Size = new System.Drawing.Size(399, 33);
            this.tbKVK.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "PhoneNumber:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPhoneNumber.Location = new System.Drawing.Point(204, 290);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(399, 33);
            this.tbPhoneNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "KVK:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(204, 229);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(399, 33);
            this.tbEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAdress.Location = new System.Drawing.Point(204, 165);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(399, 33);
            this.tbAdress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name:";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCompanyName.Location = new System.Drawing.Point(204, 102);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(399, 33);
            this.tbCompanyName.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvDepartments);
            this.tabPage3.Controls.Add(this.gbDepartment);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1123, 498);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Departments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDepartments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(37, 27);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 25;
            this.dgvDepartments.Size = new System.Drawing.Size(487, 444);
            this.dgvDepartments.TabIndex = 2;
            this.dgvDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartments_CellClick);
            // 
            // gbDepartment
            // 
            this.gbDepartment.Controls.Add(this.labDepartmentID);
            this.gbDepartment.Controls.Add(this.label12);
            this.gbDepartment.Controls.Add(this.udResult);
            this.gbDepartment.Controls.Add(this.btnDeleteDepartment);
            this.gbDepartment.Controls.Add(this.labDepartmentName);
            this.gbDepartment.Controls.Add(this.btnEditDepartment);
            this.gbDepartment.Controls.Add(this.btnAddDepartment);
            this.gbDepartment.Controls.Add(this.tbDepartmentName);
            this.gbDepartment.Controls.Add(this.label5);
            this.gbDepartment.Controls.Add(this.label4);
            this.gbDepartment.Controls.Add(this.cbHeadDepartments);
            this.gbDepartment.Location = new System.Drawing.Point(543, 27);
            this.gbDepartment.Name = "gbDepartment";
            this.gbDepartment.Size = new System.Drawing.Size(557, 444);
            this.gbDepartment.TabIndex = 1;
            this.gbDepartment.TabStop = false;
            // 
            // labDepartmentID
            // 
            this.labDepartmentID.AutoSize = true;
            this.labDepartmentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labDepartmentID.Location = new System.Drawing.Point(22, 29);
            this.labDepartmentID.Name = "labDepartmentID";
            this.labDepartmentID.Size = new System.Drawing.Size(111, 25);
            this.labDepartmentID.TabIndex = 10;
            this.labDepartmentID.Text = "I\'m invisible";
            this.labDepartmentID.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(336, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Result:";
            // 
            // udResult
            // 
            this.udResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.udResult.Location = new System.Drawing.Point(408, 29);
            this.udResult.Name = "udResult";
            this.udResult.ReadOnly = true;
            this.udResult.Size = new System.Drawing.Size(120, 33);
            this.udResult.TabIndex = 8;
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteDepartment.Location = new System.Drawing.Point(116, 366);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(361, 42);
            this.btnDeleteDepartment.TabIndex = 7;
            this.btnDeleteDepartment.Text = "Delete Department";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // labDepartmentName
            // 
            this.labDepartmentName.AutoSize = true;
            this.labDepartmentName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labDepartmentName.Location = new System.Drawing.Point(22, 58);
            this.labDepartmentName.Name = "labDepartmentName";
            this.labDepartmentName.Size = new System.Drawing.Size(111, 25);
            this.labDepartmentName.TabIndex = 6;
            this.labDepartmentName.Text = "I\'m invisible";
            this.labDepartmentName.Visible = false;
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditDepartment.Location = new System.Drawing.Point(116, 318);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(361, 42);
            this.btnEditDepartment.TabIndex = 5;
            this.btnEditDepartment.Text = "Edit Department";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDepartment.Location = new System.Drawing.Point(116, 270);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(361, 42);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDepartmentName.Location = new System.Drawing.Point(188, 130);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(340, 33);
            this.tbDepartmentName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(116, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "HeadDepartment:";
            // 
            // cbHeadDepartments
            // 
            this.cbHeadDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHeadDepartments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHeadDepartments.FormattingEnabled = true;
            this.cbHeadDepartments.Location = new System.Drawing.Point(188, 179);
            this.cbHeadDepartments.Name = "cbHeadDepartments";
            this.cbHeadDepartments.Size = new System.Drawing.Size(340, 33);
            this.cbHeadDepartments.TabIndex = 0;
            // 
            // WorkHours
            // 
            this.WorkHours.Controls.Add(this.rbColor);
            this.WorkHours.Controls.Add(this.dgvAtendance);
            this.WorkHours.Controls.Add(this.btnMonthIncrease);
            this.WorkHours.Controls.Add(this.btnIncreaseYear);
            this.WorkHours.Controls.Add(this.btnMonthDecrease);
            this.WorkHours.Controls.Add(this.btnDecreaseYear);
            this.WorkHours.Controls.Add(this.labMonth);
            this.WorkHours.Controls.Add(this.labYear);
            this.WorkHours.Controls.Add(this.btnMakeExcelSheet);
            this.WorkHours.Location = new System.Drawing.Point(4, 24);
            this.WorkHours.Name = "WorkHours";
            this.WorkHours.Padding = new System.Windows.Forms.Padding(3);
            this.WorkHours.Size = new System.Drawing.Size(1123, 498);
            this.WorkHours.TabIndex = 4;
            this.WorkHours.Text = "WorkHours";
            this.WorkHours.UseVisualStyleBackColor = true;
            // 
            // rbColor
            // 
            this.rbColor.AutoSize = true;
            this.rbColor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbColor.Location = new System.Drawing.Point(758, 34);
            this.rbColor.Name = "rbColor";
            this.rbColor.Size = new System.Drawing.Size(77, 29);
            this.rbColor.TabIndex = 9;
            this.rbColor.Text = "Color";
            this.rbColor.UseVisualStyleBackColor = true;
            // 
            // dgvAtendance
            // 
            this.dgvAtendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAtendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAtendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendance.Location = new System.Drawing.Point(10, 13);
            this.dgvAtendance.Name = "dgvAtendance";
            this.dgvAtendance.RowTemplate.Height = 25;
            this.dgvAtendance.Size = new System.Drawing.Size(693, 464);
            this.dgvAtendance.TabIndex = 8;
            // 
            // btnMonthIncrease
            // 
            this.btnMonthIncrease.BackColor = System.Drawing.Color.White;
            this.btnMonthIncrease.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMonthIncrease.Location = new System.Drawing.Point(1028, 103);
            this.btnMonthIncrease.Name = "btnMonthIncrease";
            this.btnMonthIncrease.Size = new System.Drawing.Size(40, 42);
            this.btnMonthIncrease.TabIndex = 7;
            this.btnMonthIncrease.Text = ">";
            this.btnMonthIncrease.UseVisualStyleBackColor = false;
            this.btnMonthIncrease.Click += new System.EventHandler(this.btnMonthIncrease_Click);
            // 
            // btnIncreaseYear
            // 
            this.btnIncreaseYear.BackColor = System.Drawing.Color.White;
            this.btnIncreaseYear.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncreaseYear.Location = new System.Drawing.Point(862, 103);
            this.btnIncreaseYear.Name = "btnIncreaseYear";
            this.btnIncreaseYear.Size = new System.Drawing.Size(40, 42);
            this.btnIncreaseYear.TabIndex = 6;
            this.btnIncreaseYear.Text = ">";
            this.btnIncreaseYear.UseVisualStyleBackColor = false;
            this.btnIncreaseYear.Click += new System.EventHandler(this.btnIncreaseYear_Click);
            // 
            // btnMonthDecrease
            // 
            this.btnMonthDecrease.BackColor = System.Drawing.Color.White;
            this.btnMonthDecrease.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMonthDecrease.Location = new System.Drawing.Point(947, 103);
            this.btnMonthDecrease.Name = "btnMonthDecrease";
            this.btnMonthDecrease.Size = new System.Drawing.Size(40, 42);
            this.btnMonthDecrease.TabIndex = 5;
            this.btnMonthDecrease.Text = "<";
            this.btnMonthDecrease.UseVisualStyleBackColor = false;
            this.btnMonthDecrease.Click += new System.EventHandler(this.btnMonthDecrease_Click);
            // 
            // btnDecreaseYear
            // 
            this.btnDecreaseYear.BackColor = System.Drawing.Color.White;
            this.btnDecreaseYear.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecreaseYear.Location = new System.Drawing.Point(758, 103);
            this.btnDecreaseYear.Name = "btnDecreaseYear";
            this.btnDecreaseYear.Size = new System.Drawing.Size(40, 42);
            this.btnDecreaseYear.TabIndex = 4;
            this.btnDecreaseYear.Text = "<";
            this.btnDecreaseYear.UseVisualStyleBackColor = false;
            this.btnDecreaseYear.Click += new System.EventHandler(this.btnDecreaseYear_Click);
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labMonth.Location = new System.Drawing.Point(993, 110);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(75, 30);
            this.labMonth.TabIndex = 3;
            this.labMonth.Text = "Month";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labYear.Location = new System.Drawing.Point(804, 110);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(52, 30);
            this.labYear.TabIndex = 2;
            this.labYear.Text = "Year";
            // 
            // btnMakeExcelSheet
            // 
            this.btnMakeExcelSheet.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMakeExcelSheet.Location = new System.Drawing.Point(739, 367);
            this.btnMakeExcelSheet.Name = "btnMakeExcelSheet";
            this.btnMakeExcelSheet.Size = new System.Drawing.Size(358, 110);
            this.btnMakeExcelSheet.TabIndex = 1;
            this.btnMakeExcelSheet.Text = "Make Excel sheet";
            this.btnMakeExcelSheet.UseVisualStyleBackColor = true;
            this.btnMakeExcelSheet.Click += new System.EventHandler(this.btnMakeExcelSheet_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1060, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 28);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(222, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(326, 33);
            this.textBox3.TabIndex = 6;
            // 
            // FormOfficeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 549);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.Comapny);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOfficeManager";
            this.Text = "FormOfficeManager";
            this.Comapny.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.gbCompanyInfo.ResumeLayout(false);
            this.gbCompanyInfo.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.gbDepartment.ResumeLayout(false);
            this.gbDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udResult)).EndInit();
            this.WorkHours.ResumeLayout(false);
            this.WorkHours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Comapny;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbCompanyInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.GroupBox gbDepartment;
        private System.Windows.Forms.ComboBox cbHeadDepartments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbKVK;
        private System.Windows.Forms.TextBox tbBTW;
        private System.Windows.Forms.Label labCompanyID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage WorkHours;
        private System.Windows.Forms.Button btnMakeExcelSheet;
        private System.Windows.Forms.Label labDepartmentName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Button btnDecreaseYear;
        private System.Windows.Forms.Label labMonth;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnIncreaseYear;
        private System.Windows.Forms.Button btnMonthDecrease;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button btnMonthIncrease;
        private System.Windows.Forms.DataGridView dgvAtendance;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxEmployeeType;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button bntUpdateEmployee;
        private System.Windows.Forms.TextBox tbxActiveEmployeeID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown udResult;
        private System.Windows.Forms.Label labDepartmentID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox rbColor;
        public System.Windows.Forms.TextBox tbxSearchEmployee;
    }
}