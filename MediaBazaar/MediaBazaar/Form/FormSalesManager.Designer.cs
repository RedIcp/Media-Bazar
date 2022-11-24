
namespace AdminBackups
{
    partial class FormSalesManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.cbOverviewDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvNewProducts = new System.Windows.Forms.DataGridView();
            this.lstEmployeesWorkingToday = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgOverviewSchedule = new System.Windows.Forms.DataGridView();
            this.txtProductID = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxSelectedProduct = new System.Windows.Forms.TextBox();
            this.bntUpdateProduct = new System.Windows.Forms.Button();
            this.labProductSearch = new System.Windows.Forms.Label();
            this.tbProductSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.txtYear = new System.Windows.Forms.NumericUpDown();
            this.cbSchebuleByDepartment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDecreaseWeek = new System.Windows.Forms.Button();
            this.btnIncreaseWeek = new System.Windows.Forms.Button();
            this.lblWeek = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSchedule = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMonth = new System.Windows.Forms.Label();
            this.lbScheduleDay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditschedule = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScheduleEvening = new System.Windows.Forms.TextBox();
            this.lbScheduleAfternoon = new System.Windows.Forms.TextBox();
            this.lbScheduleMorning = new System.Windows.Forms.TextBox();
            this.tabPlanning = new System.Windows.Forms.TabPage();
            this.btnCheckForShifts = new System.Windows.Forms.Button();
            this.labSearch = new System.Windows.Forms.Label();
            this.labNeedEmploye = new System.Windows.Forms.Label();
            this.cbUnregisteredShift = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClearScheduleForTheWeek = new System.Windows.Forms.Button();
            this.rdNoPreference = new System.Windows.Forms.RadioButton();
            this.rbNotPreferred = new System.Windows.Forms.RadioButton();
            this.rbPreferred = new System.Windows.Forms.RadioButton();
            this.txtPlanningYear = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAutoSchedule = new System.Windows.Forms.Button();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDecreasePlanningWeek = new System.Windows.Forms.Button();
            this.btnIncreasePlanningWeek = new System.Windows.Forms.Button();
            this.lblPlanningWeek = new System.Windows.Forms.Label();
            this.dgPlanningSchedule = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveFromSchedule = new System.Windows.Forms.Button();
            this.lstEmpCanWork = new System.Windows.Forms.ListBox();
            this.lstEmpEnlisted = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewSchedule)).BeginInit();
            this.txtProductID.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPlanning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanningYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanningSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOverview);
            this.tabControl1.Controls.Add(this.txtProductID);
            this.tabControl1.Controls.Add(this.tabSchedule);
            this.tabControl1.Controls.Add(this.tabPlanning);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.cbOverviewDepartment);
            this.tabOverview.Controls.Add(this.label4);
            this.tabOverview.Controls.Add(this.label13);
            this.tabOverview.Controls.Add(this.dgvNewProducts);
            this.tabOverview.Controls.Add(this.lstEmployeesWorkingToday);
            this.tabOverview.Controls.Add(this.label12);
            this.tabOverview.Controls.Add(this.label14);
            this.tabOverview.Controls.Add(this.dgOverviewSchedule);
            this.tabOverview.Location = new System.Drawing.Point(4, 30);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(1031, 529);
            this.tabOverview.TabIndex = 12;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // cbOverviewDepartment
            // 
            this.cbOverviewDepartment.FormattingEnabled = true;
            this.cbOverviewDepartment.Location = new System.Drawing.Point(732, 13);
            this.cbOverviewDepartment.Name = "cbOverviewDepartment";
            this.cbOverviewDepartment.Size = new System.Drawing.Size(240, 29);
            this.cbOverviewDepartment.TabIndex = 102;
            this.cbOverviewDepartment.SelectedIndexChanged += new System.EventHandler(this.cbOverviewDepartment_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 21);
            this.label4.TabIndex = 101;
            this.label4.Text = "Employees Working Today:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(22, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 21);
            this.label13.TabIndex = 100;
            this.label13.Text = "New Products:";
            // 
            // dgvNewProducts
            // 
            this.dgvNewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewProducts.Location = new System.Drawing.Point(21, 326);
            this.dgvNewProducts.Name = "dgvNewProducts";
            this.dgvNewProducts.RowHeadersWidth = 51;
            this.dgvNewProducts.RowTemplate.Height = 25;
            this.dgvNewProducts.Size = new System.Drawing.Size(488, 190);
            this.dgvNewProducts.TabIndex = 99;
            this.dgvNewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewProducts_CellContentClick);
            this.dgvNewProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellDoubleClick);
            // 
            // lstEmployeesWorkingToday
            // 
            this.lstEmployeesWorkingToday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmployeesWorkingToday.FormattingEnabled = true;
            this.lstEmployeesWorkingToday.ItemHeight = 17;
            this.lstEmployeesWorkingToday.Location = new System.Drawing.Point(530, 72);
            this.lstEmployeesWorkingToday.Name = "lstEmployeesWorkingToday";
            this.lstEmployeesWorkingToday.Size = new System.Drawing.Size(402, 429);
            this.lstEmployeesWorkingToday.TabIndex = 97;
            this.lstEmployeesWorkingToday.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstEmployeesWorkingToday_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(530, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 21);
            this.label12.TabIndex = 96;
            this.label12.Text = "Employees Working Today:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 21);
            this.label14.TabIndex = 94;
            this.label14.Text = "Schedule:";
            // 
            // dgOverviewSchedule
            // 
            this.dgOverviewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOverviewSchedule.Location = new System.Drawing.Point(22, 37);
            this.dgOverviewSchedule.Name = "dgOverviewSchedule";
            this.dgOverviewSchedule.RowHeadersWidth = 51;
            this.dgOverviewSchedule.RowTemplate.Height = 25;
            this.dgOverviewSchedule.Size = new System.Drawing.Size(487, 251);
            this.dgOverviewSchedule.TabIndex = 93;
            this.dgOverviewSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOverviewSchedule_CellDoubleClick);
            // 
            // txtProductID
            // 
            this.txtProductID.Controls.Add(this.groupBox4);
            this.txtProductID.Controls.Add(this.labProductSearch);
            this.txtProductID.Controls.Add(this.tbProductSearch);
            this.txtProductID.Controls.Add(this.dgvProducts);
            this.txtProductID.Controls.Add(this.label3);
            this.txtProductID.Location = new System.Drawing.Point(4, 30);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Size = new System.Drawing.Size(1031, 529);
            this.txtProductID.TabIndex = 3;
            this.txtProductID.Text = "Products ";
            this.txtProductID.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbxSelectedProduct);
            this.groupBox4.Controls.Add(this.bntUpdateProduct);
            this.groupBox4.Location = new System.Drawing.Point(765, 78);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(208, 114);
            this.groupBox4.TabIndex = 106;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manage Products";
            // 
            // tbxSelectedProduct
            // 
            this.tbxSelectedProduct.Location = new System.Drawing.Point(7, 37);
            this.tbxSelectedProduct.Name = "tbxSelectedProduct";
            this.tbxSelectedProduct.PlaceholderText = "Selected Product";
            this.tbxSelectedProduct.ReadOnly = true;
            this.tbxSelectedProduct.Size = new System.Drawing.Size(195, 29);
            this.tbxSelectedProduct.TabIndex = 107;
            // 
            // bntUpdateProduct
            // 
            this.bntUpdateProduct.Location = new System.Drawing.Point(6, 72);
            this.bntUpdateProduct.Name = "bntUpdateProduct";
            this.bntUpdateProduct.Size = new System.Drawing.Size(197, 31);
            this.bntUpdateProduct.TabIndex = 9;
            this.bntUpdateProduct.Text = "Update Product";
            this.bntUpdateProduct.UseVisualStyleBackColor = true;
            this.bntUpdateProduct.Click += new System.EventHandler(this.bntUpdateProduct_Click);
            // 
            // labProductSearch
            // 
            this.labProductSearch.AutoSize = true;
            this.labProductSearch.Location = new System.Drawing.Point(388, 26);
            this.labProductSearch.Name = "labProductSearch";
            this.labProductSearch.Size = new System.Drawing.Size(118, 21);
            this.labProductSearch.TabIndex = 105;
            this.labProductSearch.Text = "Search Product:";
            // 
            // tbProductSearch
            // 
            this.tbProductSearch.Location = new System.Drawing.Point(512, 23);
            this.tbProductSearch.Name = "tbProductSearch";
            this.tbProductSearch.PlaceholderText = "Product Name or Barcode";
            this.tbProductSearch.Size = new System.Drawing.Size(247, 29);
            this.tbProductSearch.TabIndex = 104;
            this.tbProductSearch.TextChanged += new System.EventHandler(this.tbProductSearch_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(16, 62);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(743, 392);
            this.dgvProducts.TabIndex = 103;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 102;
            this.label3.Text = "Product List:";
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.txtYear);
            this.tabSchedule.Controls.Add(this.cbSchebuleByDepartment);
            this.tabSchedule.Controls.Add(this.label11);
            this.tabSchedule.Controls.Add(this.label6);
            this.tabSchedule.Controls.Add(this.btnDecreaseWeek);
            this.tabSchedule.Controls.Add(this.btnIncreaseWeek);
            this.tabSchedule.Controls.Add(this.lblWeek);
            this.tabSchedule.Controls.Add(this.label2);
            this.tabSchedule.Controls.Add(this.dgSchedule);
            this.tabSchedule.Controls.Add(this.groupBox2);
            this.tabSchedule.Location = new System.Drawing.Point(4, 30);
            this.tabSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSchedule.Size = new System.Drawing.Size(1031, 529);
            this.tabSchedule.TabIndex = 4;
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(453, 44);
            this.txtYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.txtYear.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(97, 29);
            this.txtYear.TabIndex = 84;
            this.txtYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.txtYear.ValueChanged += new System.EventHandler(this.txtYear_ValueChanged);
            // 
            // cbSchebuleByDepartment
            // 
            this.cbSchebuleByDepartment.FormattingEnabled = true;
            this.cbSchebuleByDepartment.Location = new System.Drawing.Point(22, 43);
            this.cbSchebuleByDepartment.Name = "cbSchebuleByDepartment";
            this.cbSchebuleByDepartment.Size = new System.Drawing.Size(289, 29);
            this.cbSchebuleByDepartment.TabIndex = 83;
            this.cbSchebuleByDepartment.SelectedIndexChanged += new System.EventHandler(this.cbSchebuleByDepartment_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 21);
            this.label11.TabIndex = 67;
            this.label11.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 66;
            this.label6.Text = "Week";
            // 
            // btnDecreaseWeek
            // 
            this.btnDecreaseWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecreaseWeek.Location = new System.Drawing.Point(332, 40);
            this.btnDecreaseWeek.Name = "btnDecreaseWeek";
            this.btnDecreaseWeek.Size = new System.Drawing.Size(27, 35);
            this.btnDecreaseWeek.TabIndex = 64;
            this.btnDecreaseWeek.Text = "<";
            this.btnDecreaseWeek.UseVisualStyleBackColor = true;
            this.btnDecreaseWeek.Click += new System.EventHandler(this.btnDecreaseWeek_Click);
            // 
            // btnIncreaseWeek
            // 
            this.btnIncreaseWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncreaseWeek.Location = new System.Drawing.Point(405, 40);
            this.btnIncreaseWeek.Name = "btnIncreaseWeek";
            this.btnIncreaseWeek.Size = new System.Drawing.Size(27, 35);
            this.btnIncreaseWeek.TabIndex = 63;
            this.btnIncreaseWeek.Text = ">";
            this.btnIncreaseWeek.UseVisualStyleBackColor = true;
            this.btnIncreaseWeek.Click += new System.EventHandler(this.btnIncreaseWeek_Click);
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(365, 46);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(34, 21);
            this.lblWeek.TabIndex = 62;
            this.lblWeek.Text = "NN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Schedule:";
            // 
            // dgSchedule
            // 
            this.dgSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchedule.Location = new System.Drawing.Point(22, 112);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.RowHeadersWidth = 51;
            this.dgSchedule.RowTemplate.Height = 25;
            this.dgSchedule.Size = new System.Drawing.Size(528, 325);
            this.dgSchedule.TabIndex = 60;
            this.dgSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSchedule_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMonth);
            this.groupBox2.Controls.Add(this.lbScheduleDay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnEditschedule);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbScheduleEvening);
            this.groupBox2.Controls.Add(this.lbScheduleAfternoon);
            this.groupBox2.Controls.Add(this.lbScheduleMorning);
            this.groupBox2.Location = new System.Drawing.Point(662, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 297);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule Management";
            // 
            // txtMonth
            // 
            this.txtMonth.AutoSize = true;
            this.txtMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonth.Location = new System.Drawing.Point(108, 93);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(46, 17);
            this.txtMonth.TabIndex = 18;
            this.txtMonth.Text = "Month";
            // 
            // lbScheduleDay
            // 
            this.lbScheduleDay.AutoSize = true;
            this.lbScheduleDay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleDay.Location = new System.Drawing.Point(108, 49);
            this.lbScheduleDay.Name = "lbScheduleDay";
            this.lbScheduleDay.Size = new System.Drawing.Size(30, 17);
            this.lbScheduleDay.TabIndex = 17;
            this.lbScheduleDay.Text = "Day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(46, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Month:";
            // 
            // btnEditschedule
            // 
            this.btnEditschedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditschedule.Location = new System.Drawing.Point(63, 253);
            this.btnEditschedule.Name = "btnEditschedule";
            this.btnEditschedule.Size = new System.Drawing.Size(118, 26);
            this.btnEditschedule.TabIndex = 14;
            this.btnEditschedule.Text = "Update schedule";
            this.btnEditschedule.UseVisualStyleBackColor = true;
            this.btnEditschedule.Click += new System.EventHandler(this.btnEditschedule_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(39, 214);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 17);
            this.label24.TabIndex = 12;
            this.label24.Text = "Evening:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(26, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 17);
            this.label23.TabIndex = 11;
            this.label23.Text = "Afternoon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(36, 137);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 17);
            this.label22.TabIndex = 10;
            this.label22.Text = "Morning:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Day:";
            // 
            // lbScheduleEvening
            // 
            this.lbScheduleEvening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleEvening.Location = new System.Drawing.Point(108, 211);
            this.lbScheduleEvening.Name = "lbScheduleEvening";
            this.lbScheduleEvening.Size = new System.Drawing.Size(73, 25);
            this.lbScheduleEvening.TabIndex = 6;
            // 
            // lbScheduleAfternoon
            // 
            this.lbScheduleAfternoon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleAfternoon.Location = new System.Drawing.Point(108, 173);
            this.lbScheduleAfternoon.Name = "lbScheduleAfternoon";
            this.lbScheduleAfternoon.Size = new System.Drawing.Size(73, 25);
            this.lbScheduleAfternoon.TabIndex = 5;
            // 
            // lbScheduleMorning
            // 
            this.lbScheduleMorning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleMorning.Location = new System.Drawing.Point(108, 134);
            this.lbScheduleMorning.Name = "lbScheduleMorning";
            this.lbScheduleMorning.Size = new System.Drawing.Size(73, 25);
            this.lbScheduleMorning.TabIndex = 4;
            // 
            // tabPlanning
            // 
            this.tabPlanning.Controls.Add(this.btnCheckForShifts);
            this.tabPlanning.Controls.Add(this.labSearch);
            this.tabPlanning.Controls.Add(this.labNeedEmploye);
            this.tabPlanning.Controls.Add(this.cbUnregisteredShift);
            this.tabPlanning.Controls.Add(this.txtSearch);
            this.tabPlanning.Controls.Add(this.btnClearScheduleForTheWeek);
            this.tabPlanning.Controls.Add(this.rdNoPreference);
            this.tabPlanning.Controls.Add(this.rbNotPreferred);
            this.tabPlanning.Controls.Add(this.rbPreferred);
            this.tabPlanning.Controls.Add(this.txtPlanningYear);
            this.tabPlanning.Controls.Add(this.progressBar1);
            this.tabPlanning.Controls.Add(this.btnAutoSchedule);
            this.tabPlanning.Controls.Add(this.cbDepartments);
            this.tabPlanning.Controls.Add(this.label15);
            this.tabPlanning.Controls.Add(this.label16);
            this.tabPlanning.Controls.Add(this.btnDecreasePlanningWeek);
            this.tabPlanning.Controls.Add(this.btnIncreasePlanningWeek);
            this.tabPlanning.Controls.Add(this.lblPlanningWeek);
            this.tabPlanning.Controls.Add(this.dgPlanningSchedule);
            this.tabPlanning.Controls.Add(this.label8);
            this.tabPlanning.Controls.Add(this.label9);
            this.tabPlanning.Controls.Add(this.label10);
            this.tabPlanning.Controls.Add(this.btnRemoveFromSchedule);
            this.tabPlanning.Controls.Add(this.lstEmpCanWork);
            this.tabPlanning.Controls.Add(this.lstEmpEnlisted);
            this.tabPlanning.Location = new System.Drawing.Point(4, 30);
            this.tabPlanning.Name = "tabPlanning";
            this.tabPlanning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanning.Size = new System.Drawing.Size(1031, 529);
            this.tabPlanning.TabIndex = 11;
            this.tabPlanning.Text = "Planning";
            this.tabPlanning.UseVisualStyleBackColor = true;
            // 
            // btnCheckForShifts
            // 
            this.btnCheckForShifts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckForShifts.Location = new System.Drawing.Point(919, 22);
            this.btnCheckForShifts.Name = "btnCheckForShifts";
            this.btnCheckForShifts.Size = new System.Drawing.Size(79, 25);
            this.btnCheckForShifts.TabIndex = 97;
            this.btnCheckForShifts.Text = "Check";
            this.btnCheckForShifts.UseVisualStyleBackColor = true;
            this.btnCheckForShifts.Click += new System.EventHandler(this.btnCheckForShifts_Click);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(574, 61);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(60, 21);
            this.labSearch.TabIndex = 96;
            this.labSearch.Text = "Search:";
            // 
            // labNeedEmploye
            // 
            this.labNeedEmploye.AutoSize = true;
            this.labNeedEmploye.Location = new System.Drawing.Point(575, 23);
            this.labNeedEmploye.Name = "labNeedEmploye";
            this.labNeedEmploye.Size = new System.Drawing.Size(137, 21);
            this.labNeedEmploye.TabIndex = 95;
            this.labNeedEmploye.Text = "Unregistered shift:";
            // 
            // cbUnregisteredShift
            // 
            this.cbUnregisteredShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnregisteredShift.FormattingEnabled = true;
            this.cbUnregisteredShift.Location = new System.Drawing.Point(718, 20);
            this.cbUnregisteredShift.Name = "cbUnregisteredShift";
            this.cbUnregisteredShift.Size = new System.Drawing.Size(195, 29);
            this.cbUnregisteredShift.TabIndex = 94;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(640, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(358, 25);
            this.txtSearch.TabIndex = 92;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClearScheduleForTheWeek
            // 
            this.btnClearScheduleForTheWeek.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearScheduleForTheWeek.Location = new System.Drawing.Point(20, 491);
            this.btnClearScheduleForTheWeek.Name = "btnClearScheduleForTheWeek";
            this.btnClearScheduleForTheWeek.Size = new System.Drawing.Size(138, 28);
            this.btnClearScheduleForTheWeek.TabIndex = 91;
            this.btnClearScheduleForTheWeek.Text = "Clear entire schedule";
            this.btnClearScheduleForTheWeek.UseVisualStyleBackColor = true;
            this.btnClearScheduleForTheWeek.Click += new System.EventHandler(this.btnClearScheduleForTheWeek_Click);
            // 
            // rdNoPreference
            // 
            this.rdNoPreference.AutoSize = true;
            this.rdNoPreference.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdNoPreference.Location = new System.Drawing.Point(903, 94);
            this.rdNoPreference.Name = "rdNoPreference";
            this.rdNoPreference.Size = new System.Drawing.Size(110, 21);
            this.rdNoPreference.TabIndex = 90;
            this.rdNoPreference.Text = "No Preference";
            this.rdNoPreference.UseVisualStyleBackColor = true;
            this.rdNoPreference.CheckedChanged += new System.EventHandler(this.rdNoPreference_CheckedChanged);
            // 
            // rbNotPreferred
            // 
            this.rbNotPreferred.AutoSize = true;
            this.rbNotPreferred.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNotPreferred.Location = new System.Drawing.Point(790, 94);
            this.rbNotPreferred.Name = "rbNotPreferred";
            this.rbNotPreferred.Size = new System.Drawing.Size(107, 21);
            this.rbNotPreferred.TabIndex = 89;
            this.rbNotPreferred.Text = "Not Preferred";
            this.rbNotPreferred.UseVisualStyleBackColor = true;
            this.rbNotPreferred.CheckedChanged += new System.EventHandler(this.rbNotPreferred_CheckedChanged);
            // 
            // rbPreferred
            // 
            this.rbPreferred.AutoSize = true;
            this.rbPreferred.Checked = true;
            this.rbPreferred.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPreferred.Location = new System.Drawing.Point(703, 94);
            this.rbPreferred.Name = "rbPreferred";
            this.rbPreferred.Size = new System.Drawing.Size(81, 21);
            this.rbPreferred.TabIndex = 88;
            this.rbPreferred.TabStop = true;
            this.rbPreferred.Text = "Preferred";
            this.rbPreferred.UseVisualStyleBackColor = true;
            this.rbPreferred.CheckedChanged += new System.EventHandler(this.rbPreferred_CheckedChanged);
            // 
            // txtPlanningYear
            // 
            this.txtPlanningYear.Location = new System.Drawing.Point(440, 37);
            this.txtPlanningYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.txtPlanningYear.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.txtPlanningYear.Name = "txtPlanningYear";
            this.txtPlanningYear.Size = new System.Drawing.Size(93, 29);
            this.txtPlanningYear.TabIndex = 85;
            this.txtPlanningYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.txtPlanningYear.ValueChanged += new System.EventHandler(this.txtPlanningYear_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(574, 419);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(411, 23);
            this.progressBar1.TabIndex = 84;
            // 
            // btnAutoSchedule
            // 
            this.btnAutoSchedule.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoSchedule.Location = new System.Drawing.Point(574, 448);
            this.btnAutoSchedule.Name = "btnAutoSchedule";
            this.btnAutoSchedule.Size = new System.Drawing.Size(411, 61);
            this.btnAutoSchedule.TabIndex = 83;
            this.btnAutoSchedule.Text = "Auto schedule";
            this.btnAutoSchedule.UseVisualStyleBackColor = true;
            this.btnAutoSchedule.Click += new System.EventHandler(this.btnAutoSchedule_Click);
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(20, 36);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(289, 29);
            this.cbDepartments.TabIndex = 82;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.cbDepartments_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(456, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 21);
            this.label15.TabIndex = 73;
            this.label15.Text = "Year";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(360, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 21);
            this.label16.TabIndex = 72;
            this.label16.Text = "Week";
            // 
            // btnDecreasePlanningWeek
            // 
            this.btnDecreasePlanningWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecreasePlanningWeek.Location = new System.Drawing.Point(327, 33);
            this.btnDecreasePlanningWeek.Name = "btnDecreasePlanningWeek";
            this.btnDecreasePlanningWeek.Size = new System.Drawing.Size(27, 35);
            this.btnDecreasePlanningWeek.TabIndex = 70;
            this.btnDecreasePlanningWeek.Text = "<";
            this.btnDecreasePlanningWeek.UseVisualStyleBackColor = true;
            this.btnDecreasePlanningWeek.Click += new System.EventHandler(this.btnDecreasePlanningWeek_Click);
            // 
            // btnIncreasePlanningWeek
            // 
            this.btnIncreasePlanningWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncreasePlanningWeek.Location = new System.Drawing.Point(400, 33);
            this.btnIncreasePlanningWeek.Name = "btnIncreasePlanningWeek";
            this.btnIncreasePlanningWeek.Size = new System.Drawing.Size(27, 35);
            this.btnIncreasePlanningWeek.TabIndex = 69;
            this.btnIncreasePlanningWeek.Text = ">";
            this.btnIncreasePlanningWeek.UseVisualStyleBackColor = true;
            this.btnIncreasePlanningWeek.Click += new System.EventHandler(this.btnIncreasePlanningWeek_Click);
            // 
            // lblPlanningWeek
            // 
            this.lblPlanningWeek.AutoSize = true;
            this.lblPlanningWeek.Location = new System.Drawing.Point(360, 39);
            this.lblPlanningWeek.Name = "lblPlanningWeek";
            this.lblPlanningWeek.Size = new System.Drawing.Size(34, 21);
            this.lblPlanningWeek.TabIndex = 68;
            this.lblPlanningWeek.Text = "NN";
            // 
            // dgPlanningSchedule
            // 
            this.dgPlanningSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanningSchedule.Location = new System.Drawing.Point(20, 94);
            this.dgPlanningSchedule.Name = "dgPlanningSchedule";
            this.dgPlanningSchedule.RowHeadersWidth = 51;
            this.dgPlanningSchedule.RowTemplate.Height = 25;
            this.dgPlanningSchedule.Size = new System.Drawing.Size(525, 275);
            this.dgPlanningSchedule.TabIndex = 21;
            this.dgPlanningSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlanningSchedule_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Employees Working:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Employees Free:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Schedule:";
            // 
            // btnRemoveFromSchedule
            // 
            this.btnRemoveFromSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFromSchedule.Location = new System.Drawing.Point(440, 492);
            this.btnRemoveFromSchedule.Name = "btnRemoveFromSchedule";
            this.btnRemoveFromSchedule.Size = new System.Drawing.Size(105, 28);
            this.btnRemoveFromSchedule.TabIndex = 17;
            this.btnRemoveFromSchedule.Text = "Remove Employee";
            this.btnRemoveFromSchedule.UseVisualStyleBackColor = true;
            this.btnRemoveFromSchedule.Click += new System.EventHandler(this.btnRemoveFromSchedule_Click);
            // 
            // lstEmpCanWork
            // 
            this.lstEmpCanWork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmpCanWork.FormattingEnabled = true;
            this.lstEmpCanWork.ItemHeight = 17;
            this.lstEmpCanWork.Location = new System.Drawing.Point(574, 123);
            this.lstEmpCanWork.Name = "lstEmpCanWork";
            this.lstEmpCanWork.Size = new System.Drawing.Size(411, 276);
            this.lstEmpCanWork.TabIndex = 16;
            this.lstEmpCanWork.DoubleClick += new System.EventHandler(this.lstEmpCanWork_DoubleClick);
            // 
            // lstEmpEnlisted
            // 
            this.lstEmpEnlisted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmpEnlisted.FormattingEnabled = true;
            this.lstEmpEnlisted.ItemHeight = 17;
            this.lstEmpEnlisted.Location = new System.Drawing.Point(20, 396);
            this.lstEmpEnlisted.Name = "lstEmpEnlisted";
            this.lstEmpEnlisted.Size = new System.Drawing.Size(525, 89);
            this.lstEmpEnlisted.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(919, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 34);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormSalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 600);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSalesManager";
            this.Text = "FormSalesManager";
            this.tabControl1.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewSchedule)).EndInit();
            this.txtProductID.ResumeLayout(false);
            this.txtProductID.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPlanning.ResumeLayout(false);
            this.tabPlanning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanningYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanningSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage txtProductID;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabPlanning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtMonth;
        private System.Windows.Forms.Label lbScheduleDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditschedule;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbScheduleEvening;
        private System.Windows.Forms.TextBox lbScheduleAfternoon;
        private System.Windows.Forms.TextBox lbScheduleMorning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgSchedule;
        private System.Windows.Forms.DataGridView dgPlanningSchedule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoveFromSchedule;
        private System.Windows.Forms.ListBox lstEmpCanWork;
        private System.Windows.Forms.ListBox lstEmpEnlisted;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.ListBox lstEmployeesWorkingToday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgOverviewSchedule;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvNewProducts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDecreaseWeek;
        private System.Windows.Forms.Button btnIncreaseWeek;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDecreasePlanningWeek;
        private System.Windows.Forms.Button btnIncreasePlanningWeek;
        private System.Windows.Forms.Label lblPlanningWeek;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Button btnAutoSchedule;
        private System.Windows.Forms.ComboBox cbSchebuleByDepartment;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labProductSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSelectedProduct;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bntUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.NumericUpDown txtYear;
        private System.Windows.Forms.NumericUpDown txtPlanningYear;
        public System.Windows.Forms.TextBox tbProductSearch;
        private System.Windows.Forms.RadioButton rbNotPreferred;
        private System.Windows.Forms.RadioButton rbPreferred;
        private System.Windows.Forms.RadioButton rdNoPreference;
        private System.Windows.Forms.Button btnClearScheduleForTheWeek;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labNeedEmploye;
        private System.Windows.Forms.ComboBox cbUnregisteredShift;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Button btnCheckForShifts;
        private System.Windows.Forms.ComboBox cbOverviewDepartment;
        private System.Windows.Forms.Label label4;
    }
}