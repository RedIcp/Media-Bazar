
namespace AdminBackups
{
    partial class FormDepotManager
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPlanning = new System.Windows.Forms.TabPage();
            this.btnCheckForShifts = new System.Windows.Forms.Button();
            this.labNeedEmploye = new System.Windows.Forms.Label();
            this.cbUnregisteredShift = new System.Windows.Forms.ComboBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.btnClearWeek = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdNoPreference = new System.Windows.Forms.RadioButton();
            this.rbNotPreferred = new System.Windows.Forms.RadioButton();
            this.rbPreferred = new System.Windows.Forms.RadioButton();
            this.txtPlanningYear = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.btnAutoSchedule = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnDecreasePlanningWeek = new System.Windows.Forms.Button();
            this.btnIncreasePlanningWeek = new System.Windows.Forms.Button();
            this.lblPlanningWeek = new System.Windows.Forms.Label();
            this.dgPlanningSchedule = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveFromSchedule = new System.Windows.Forms.Button();
            this.lstEmpCanWork = new System.Windows.Forms.ListBox();
            this.lstEmpEnlisted = new System.Windows.Forms.ListBox();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.txtYear = new System.Windows.Forms.NumericUpDown();
            this.cbSchebuleByDepartment = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDecreaseWeek = new System.Windows.Forms.Button();
            this.btnIncreaseWeek = new System.Windows.Forms.Button();
            this.lblWeek = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgSchedule = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbScheduleDay = new System.Windows.Forms.TextBox();
            this.btnEditschedule = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbScheduleEvening = new System.Windows.Forms.TextBox();
            this.lbScheduleAfternoon = new System.Windows.Forms.TextBox();
            this.lbScheduleMorning = new System.Windows.Forms.TextBox();
            this.tabRestock = new System.Windows.Forms.TabPage();
            this.dgRestock = new System.Windows.Forms.DataGridView();
            this.rbHistory = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.txtRestockID = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderRestock = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteRestockRequest = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.cbOverviewDepartment = new System.Windows.Forms.ComboBox();
            this.dgOverviewRestock = new System.Windows.Forms.DataGridView();
            this.lstEmployeesWorkingToday = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgOverviewSchedule = new System.Windows.Forms.DataGridView();
            this.tabPlanning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanningYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanningSchedule)).BeginInit();
            this.tabSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabRestock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewRestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(995, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 34);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(162, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 29);
            this.textBox3.TabIndex = 18;
            // 
            // tabPlanning
            // 
            this.tabPlanning.Controls.Add(this.btnCheckForShifts);
            this.tabPlanning.Controls.Add(this.labNeedEmploye);
            this.tabPlanning.Controls.Add(this.cbUnregisteredShift);
            this.tabPlanning.Controls.Add(this.labSearch);
            this.tabPlanning.Controls.Add(this.btnClearWeek);
            this.tabPlanning.Controls.Add(this.txtSearch);
            this.tabPlanning.Controls.Add(this.rdNoPreference);
            this.tabPlanning.Controls.Add(this.rbNotPreferred);
            this.tabPlanning.Controls.Add(this.rbPreferred);
            this.tabPlanning.Controls.Add(this.txtPlanningYear);
            this.tabPlanning.Controls.Add(this.progressBar1);
            this.tabPlanning.Controls.Add(this.cbDepartments);
            this.tabPlanning.Controls.Add(this.btnAutoSchedule);
            this.tabPlanning.Controls.Add(this.label28);
            this.tabPlanning.Controls.Add(this.label30);
            this.tabPlanning.Controls.Add(this.btnDecreasePlanningWeek);
            this.tabPlanning.Controls.Add(this.btnIncreasePlanningWeek);
            this.tabPlanning.Controls.Add(this.lblPlanningWeek);
            this.tabPlanning.Controls.Add(this.dgPlanningSchedule);
            this.tabPlanning.Controls.Add(this.label4);
            this.tabPlanning.Controls.Add(this.label3);
            this.tabPlanning.Controls.Add(this.label2);
            this.tabPlanning.Controls.Add(this.btnRemoveFromSchedule);
            this.tabPlanning.Controls.Add(this.lstEmpCanWork);
            this.tabPlanning.Controls.Add(this.lstEmpEnlisted);
            this.tabPlanning.Location = new System.Drawing.Point(4, 30);
            this.tabPlanning.Name = "tabPlanning";
            this.tabPlanning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanning.Size = new System.Drawing.Size(1051, 530);
            this.tabPlanning.TabIndex = 11;
            this.tabPlanning.Text = "Planning";
            this.tabPlanning.UseVisualStyleBackColor = true;
            // 
            // btnCheckForShifts
            // 
            this.btnCheckForShifts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckForShifts.Location = new System.Drawing.Point(958, 18);
            this.btnCheckForShifts.Name = "btnCheckForShifts";
            this.btnCheckForShifts.Size = new System.Drawing.Size(79, 28);
            this.btnCheckForShifts.TabIndex = 94;
            this.btnCheckForShifts.Text = "Check";
            this.btnCheckForShifts.UseVisualStyleBackColor = true;
            this.btnCheckForShifts.Click += new System.EventHandler(this.btnCheckForShifts_Click);
            // 
            // labNeedEmploye
            // 
            this.labNeedEmploye.AutoSize = true;
            this.labNeedEmploye.Location = new System.Drawing.Point(588, 21);
            this.labNeedEmploye.Name = "labNeedEmploye";
            this.labNeedEmploye.Size = new System.Drawing.Size(137, 21);
            this.labNeedEmploye.TabIndex = 93;
            this.labNeedEmploye.Text = "Unregistered shift:";
            // 
            // cbUnregisteredShift
            // 
            this.cbUnregisteredShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnregisteredShift.FormattingEnabled = true;
            this.cbUnregisteredShift.Location = new System.Drawing.Point(731, 18);
            this.cbUnregisteredShift.Name = "cbUnregisteredShift";
            this.cbUnregisteredShift.Size = new System.Drawing.Size(219, 29);
            this.cbUnregisteredShift.TabIndex = 92;
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(588, 68);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(60, 21);
            this.labSearch.TabIndex = 91;
            this.labSearch.Text = "Search:";
            // 
            // btnClearWeek
            // 
            this.btnClearWeek.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearWeek.Location = new System.Drawing.Point(33, 496);
            this.btnClearWeek.Name = "btnClearWeek";
            this.btnClearWeek.Size = new System.Drawing.Size(112, 28);
            this.btnClearWeek.TabIndex = 90;
            this.btnClearWeek.Text = "Clear schedule";
            this.btnClearWeek.UseVisualStyleBackColor = true;
            this.btnClearWeek.Click += new System.EventHandler(this.btnClearWeek_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(654, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(370, 25);
            this.txtSearch.TabIndex = 89;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rdNoPreference
            // 
            this.rdNoPreference.AutoSize = true;
            this.rdNoPreference.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdNoPreference.Location = new System.Drawing.Point(927, 103);
            this.rdNoPreference.Name = "rdNoPreference";
            this.rdNoPreference.Size = new System.Drawing.Size(110, 21);
            this.rdNoPreference.TabIndex = 88;
            this.rdNoPreference.Text = "No Preference";
            this.rdNoPreference.UseVisualStyleBackColor = true;
            this.rdNoPreference.CheckedChanged += new System.EventHandler(this.rdNoPreference_CheckedChanged);
            // 
            // rbNotPreferred
            // 
            this.rbNotPreferred.AutoSize = true;
            this.rbNotPreferred.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNotPreferred.Location = new System.Drawing.Point(814, 103);
            this.rbNotPreferred.Name = "rbNotPreferred";
            this.rbNotPreferred.Size = new System.Drawing.Size(107, 21);
            this.rbNotPreferred.TabIndex = 87;
            this.rbNotPreferred.Text = "Not Preferred";
            this.rbNotPreferred.UseVisualStyleBackColor = true;
            this.rbNotPreferred.CheckedChanged += new System.EventHandler(this.rbNotPreferred_CheckedChanged);
            // 
            // rbPreferred
            // 
            this.rbPreferred.AutoSize = true;
            this.rbPreferred.Checked = true;
            this.rbPreferred.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPreferred.Location = new System.Drawing.Point(727, 103);
            this.rbPreferred.Name = "rbPreferred";
            this.rbPreferred.Size = new System.Drawing.Size(81, 21);
            this.rbPreferred.TabIndex = 86;
            this.rbPreferred.TabStop = true;
            this.rbPreferred.Text = "Preferred";
            this.rbPreferred.UseVisualStyleBackColor = true;
            this.rbPreferred.CheckedChanged += new System.EventHandler(this.rbPreferred_CheckedChanged);
            // 
            // txtPlanningYear
            // 
            this.txtPlanningYear.Location = new System.Drawing.Point(461, 34);
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
            this.txtPlanningYear.Size = new System.Drawing.Size(81, 29);
            this.txtPlanningYear.TabIndex = 83;
            this.txtPlanningYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.txtPlanningYear.ValueChanged += new System.EventHandler(this.txtPlanningYear_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(588, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(436, 23);
            this.progressBar1.TabIndex = 82;
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(33, 33);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(289, 29);
            this.cbDepartments.TabIndex = 81;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.cbDepartments_SelectedIndexChanged);
            // 
            // btnAutoSchedule
            // 
            this.btnAutoSchedule.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoSchedule.Location = new System.Drawing.Point(602, 459);
            this.btnAutoSchedule.Name = "btnAutoSchedule";
            this.btnAutoSchedule.Size = new System.Drawing.Size(403, 44);
            this.btnAutoSchedule.TabIndex = 80;
            this.btnAutoSchedule.Text = "Auto schedule";
            this.btnAutoSchedule.UseVisualStyleBackColor = true;
            this.btnAutoSchedule.Click += new System.EventHandler(this.btnAutoSchedule_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(461, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 21);
            this.label28.TabIndex = 79;
            this.label28.Text = "Year";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(373, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 21);
            this.label30.TabIndex = 78;
            this.label30.Text = "Week";
            // 
            // btnDecreasePlanningWeek
            // 
            this.btnDecreasePlanningWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecreasePlanningWeek.Location = new System.Drawing.Point(340, 33);
            this.btnDecreasePlanningWeek.Name = "btnDecreasePlanningWeek";
            this.btnDecreasePlanningWeek.Size = new System.Drawing.Size(27, 35);
            this.btnDecreasePlanningWeek.TabIndex = 76;
            this.btnDecreasePlanningWeek.Text = "<";
            this.btnDecreasePlanningWeek.UseVisualStyleBackColor = true;
            this.btnDecreasePlanningWeek.Click += new System.EventHandler(this.btnDecreasePlanningWeek_Click);
            // 
            // btnIncreasePlanningWeek
            // 
            this.btnIncreasePlanningWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncreasePlanningWeek.Location = new System.Drawing.Point(413, 33);
            this.btnIncreasePlanningWeek.Name = "btnIncreasePlanningWeek";
            this.btnIncreasePlanningWeek.Size = new System.Drawing.Size(27, 35);
            this.btnIncreasePlanningWeek.TabIndex = 75;
            this.btnIncreasePlanningWeek.Text = ">";
            this.btnIncreasePlanningWeek.UseVisualStyleBackColor = true;
            this.btnIncreasePlanningWeek.Click += new System.EventHandler(this.btnIncreasePlanningWeek_Click);
            // 
            // lblPlanningWeek
            // 
            this.lblPlanningWeek.AutoSize = true;
            this.lblPlanningWeek.Location = new System.Drawing.Point(373, 39);
            this.lblPlanningWeek.Name = "lblPlanningWeek";
            this.lblPlanningWeek.Size = new System.Drawing.Size(34, 21);
            this.lblPlanningWeek.TabIndex = 74;
            this.lblPlanningWeek.Text = "NN";
            // 
            // dgPlanningSchedule
            // 
            this.dgPlanningSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanningSchedule.Location = new System.Drawing.Point(33, 92);
            this.dgPlanningSchedule.Name = "dgPlanningSchedule";
            this.dgPlanningSchedule.RowHeadersWidth = 51;
            this.dgPlanningSchedule.RowTemplate.Height = 25;
            this.dgPlanningSchedule.Size = new System.Drawing.Size(525, 275);
            this.dgPlanningSchedule.TabIndex = 14;
            this.dgPlanningSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlanningSchedule_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employees Working:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employees Free:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Schedule:";
            // 
            // btnRemoveFromSchedule
            // 
            this.btnRemoveFromSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFromSchedule.Location = new System.Drawing.Point(453, 489);
            this.btnRemoveFromSchedule.Name = "btnRemoveFromSchedule";
            this.btnRemoveFromSchedule.Size = new System.Drawing.Size(105, 28);
            this.btnRemoveFromSchedule.TabIndex = 10;
            this.btnRemoveFromSchedule.Text = "Remove Employee";
            this.btnRemoveFromSchedule.UseVisualStyleBackColor = true;
            this.btnRemoveFromSchedule.Click += new System.EventHandler(this.btnRemoveFromSchedule_Click);
            // 
            // lstEmpCanWork
            // 
            this.lstEmpCanWork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmpCanWork.FormattingEnabled = true;
            this.lstEmpCanWork.ItemHeight = 17;
            this.lstEmpCanWork.Location = new System.Drawing.Point(588, 127);
            this.lstEmpCanWork.Name = "lstEmpCanWork";
            this.lstEmpCanWork.Size = new System.Drawing.Size(436, 276);
            this.lstEmpCanWork.TabIndex = 8;
            this.lstEmpCanWork.DoubleClick += new System.EventHandler(this.lstEmpCanWork_DoubleClick);
            // 
            // lstEmpEnlisted
            // 
            this.lstEmpEnlisted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmpEnlisted.FormattingEnabled = true;
            this.lstEmpEnlisted.ItemHeight = 17;
            this.lstEmpEnlisted.Location = new System.Drawing.Point(33, 395);
            this.lstEmpEnlisted.Name = "lstEmpEnlisted";
            this.lstEmpEnlisted.Size = new System.Drawing.Size(525, 89);
            this.lstEmpEnlisted.TabIndex = 7;
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.txtYear);
            this.tabSchedule.Controls.Add(this.cbSchebuleByDepartment);
            this.tabSchedule.Controls.Add(this.label18);
            this.tabSchedule.Controls.Add(this.label19);
            this.tabSchedule.Controls.Add(this.btnDecreaseWeek);
            this.tabSchedule.Controls.Add(this.btnIncreaseWeek);
            this.tabSchedule.Controls.Add(this.lblWeek);
            this.tabSchedule.Controls.Add(this.label6);
            this.tabSchedule.Controls.Add(this.dgSchedule);
            this.tabSchedule.Controls.Add(this.groupBox2);
            this.tabSchedule.Location = new System.Drawing.Point(4, 30);
            this.tabSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSchedule.Size = new System.Drawing.Size(1051, 530);
            this.tabSchedule.TabIndex = 0;
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(464, 42);
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
            this.txtYear.Size = new System.Drawing.Size(77, 29);
            this.txtYear.TabIndex = 85;
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
            this.cbSchebuleByDepartment.Location = new System.Drawing.Point(33, 41);
            this.cbSchebuleByDepartment.Name = "cbSchebuleByDepartment";
            this.cbSchebuleByDepartment.Size = new System.Drawing.Size(289, 29);
            this.cbSchebuleByDepartment.TabIndex = 84;
            this.cbSchebuleByDepartment.SelectedIndexChanged += new System.EventHandler(this.cbSchebuleByDepartment_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(464, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 21);
            this.label18.TabIndex = 73;
            this.label18.Text = "Year";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(368, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 21);
            this.label19.TabIndex = 72;
            this.label19.Text = "Week";
            // 
            // btnDecreaseWeek
            // 
            this.btnDecreaseWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecreaseWeek.Location = new System.Drawing.Point(343, 38);
            this.btnDecreaseWeek.Name = "btnDecreaseWeek";
            this.btnDecreaseWeek.Size = new System.Drawing.Size(27, 35);
            this.btnDecreaseWeek.TabIndex = 70;
            this.btnDecreaseWeek.Text = "<";
            this.btnDecreaseWeek.UseVisualStyleBackColor = true;
            this.btnDecreaseWeek.Click += new System.EventHandler(this.btnDecreaseWeek_Click);
            // 
            // btnIncreaseWeek
            // 
            this.btnIncreaseWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncreaseWeek.Location = new System.Drawing.Point(416, 38);
            this.btnIncreaseWeek.Name = "btnIncreaseWeek";
            this.btnIncreaseWeek.Size = new System.Drawing.Size(27, 35);
            this.btnIncreaseWeek.TabIndex = 69;
            this.btnIncreaseWeek.Text = ">";
            this.btnIncreaseWeek.UseVisualStyleBackColor = true;
            this.btnIncreaseWeek.Click += new System.EventHandler(this.btnIncreaseWeek_Click);
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(376, 44);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(34, 21);
            this.lblWeek.TabIndex = 68;
            this.lblWeek.Text = "NN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Schedule:";
            // 
            // dgSchedule
            // 
            this.dgSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchedule.Location = new System.Drawing.Point(42, 121);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.RowHeadersWidth = 51;
            this.dgSchedule.RowTemplate.Height = 25;
            this.dgSchedule.Size = new System.Drawing.Size(528, 325);
            this.dgSchedule.TabIndex = 5;
            this.dgSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSchedule_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbScheduleDay);
            this.groupBox2.Controls.Add(this.btnEditschedule);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbScheduleEvening);
            this.groupBox2.Controls.Add(this.lbScheduleAfternoon);
            this.groupBox2.Controls.Add(this.lbScheduleMorning);
            this.groupBox2.Location = new System.Drawing.Point(635, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 269);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule Management";
            // 
            // lbScheduleDay
            // 
            this.lbScheduleDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleDay.Location = new System.Drawing.Point(108, 48);
            this.lbScheduleDay.Name = "lbScheduleDay";
            this.lbScheduleDay.ReadOnly = true;
            this.lbScheduleDay.Size = new System.Drawing.Size(72, 23);
            this.lbScheduleDay.TabIndex = 95;
            // 
            // btnEditschedule
            // 
            this.btnEditschedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditschedule.Location = new System.Drawing.Point(63, 206);
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
            this.label24.Location = new System.Drawing.Point(39, 167);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 17);
            this.label24.TabIndex = 12;
            this.label24.Text = "Evening:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(26, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 17);
            this.label23.TabIndex = 11;
            this.label23.Text = "Afternoon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(36, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 17);
            this.label22.TabIndex = 10;
            this.label22.Text = "Morning:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(62, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Day:";
            // 
            // lbScheduleEvening
            // 
            this.lbScheduleEvening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleEvening.Location = new System.Drawing.Point(108, 164);
            this.lbScheduleEvening.Name = "lbScheduleEvening";
            this.lbScheduleEvening.Size = new System.Drawing.Size(73, 25);
            this.lbScheduleEvening.TabIndex = 6;
            // 
            // lbScheduleAfternoon
            // 
            this.lbScheduleAfternoon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleAfternoon.Location = new System.Drawing.Point(108, 126);
            this.lbScheduleAfternoon.Name = "lbScheduleAfternoon";
            this.lbScheduleAfternoon.Size = new System.Drawing.Size(73, 25);
            this.lbScheduleAfternoon.TabIndex = 5;
            // 
            // lbScheduleMorning
            // 
            this.lbScheduleMorning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleMorning.Location = new System.Drawing.Point(108, 87);
            this.lbScheduleMorning.Name = "lbScheduleMorning";
            this.lbScheduleMorning.Size = new System.Drawing.Size(73, 25);
            this.lbScheduleMorning.TabIndex = 4;
            // 
            // tabRestock
            // 
            this.tabRestock.Controls.Add(this.dgRestock);
            this.tabRestock.Controls.Add(this.rbHistory);
            this.tabRestock.Controls.Add(this.rbPending);
            this.tabRestock.Controls.Add(this.groupBox1);
            this.tabRestock.Controls.Add(this.label15);
            this.tabRestock.Location = new System.Drawing.Point(4, 30);
            this.tabRestock.Name = "tabRestock";
            this.tabRestock.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestock.Size = new System.Drawing.Size(1051, 530);
            this.tabRestock.TabIndex = 5;
            this.tabRestock.Text = "Restock";
            this.tabRestock.UseVisualStyleBackColor = true;
            // 
            // dgRestock
            // 
            this.dgRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRestock.Location = new System.Drawing.Point(18, 66);
            this.dgRestock.Name = "dgRestock";
            this.dgRestock.RowHeadersWidth = 51;
            this.dgRestock.RowTemplate.Height = 25;
            this.dgRestock.Size = new System.Drawing.Size(612, 441);
            this.dgRestock.TabIndex = 91;
            this.dgRestock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRestock_CellClick);
            // 
            // rbHistory
            // 
            this.rbHistory.AutoSize = true;
            this.rbHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbHistory.Location = new System.Drawing.Point(409, 39);
            this.rbHistory.Name = "rbHistory";
            this.rbHistory.Size = new System.Drawing.Size(120, 21);
            this.rbHistory.TabIndex = 90;
            this.rbHistory.Text = "Previous History";
            this.rbHistory.UseVisualStyleBackColor = true;
            this.rbHistory.CheckedChanged += new System.EventHandler(this.rbHistory_CheckedChanged);
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Checked = true;
            this.rbPending.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPending.Location = new System.Drawing.Point(319, 39);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(73, 21);
            this.rbPending.TabIndex = 89;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            this.rbPending.Click += new System.EventHandler(this.rbPending_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCurrentAmount);
            this.groupBox1.Controls.Add(this.txtRestockID);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOrderRestock);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDeleteRestockRequest);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(656, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 265);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restock Management";
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCurrentAmount.Location = new System.Drawing.Point(136, 103);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.ReadOnly = true;
            this.txtCurrentAmount.Size = new System.Drawing.Size(72, 23);
            this.txtCurrentAmount.TabIndex = 96;
            // 
            // txtRestockID
            // 
            this.txtRestockID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRestockID.Location = new System.Drawing.Point(136, 41);
            this.txtRestockID.Name = "txtRestockID";
            this.txtRestockID.ReadOnly = true;
            this.txtRestockID.Size = new System.Drawing.Size(72, 23);
            this.txtRestockID.TabIndex = 94;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBarcode.Location = new System.Drawing.Point(137, 74);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(72, 23);
            this.txtBarcode.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(60, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 69;
            this.label14.Text = "Restock ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "Barcode:";
            // 
            // btnOrderRestock
            // 
            this.btnOrderRestock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrderRestock.Location = new System.Drawing.Point(32, 147);
            this.btnOrderRestock.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOrderRestock.Name = "btnOrderRestock";
            this.btnOrderRestock.Size = new System.Drawing.Size(176, 30);
            this.btnOrderRestock.TabIndex = 70;
            this.btnOrderRestock.Text = "Order restock request";
            this.btnOrderRestock.UseVisualStyleBackColor = true;
            this.btnOrderRestock.Click += new System.EventHandler(this.btnOrderRestock_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(29, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Current Amount:";
            // 
            // btnDeleteRestockRequest
            // 
            this.btnDeleteRestockRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteRestockRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRestockRequest.Location = new System.Drawing.Point(32, 179);
            this.btnDeleteRestockRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDeleteRestockRequest.Name = "btnDeleteRestockRequest";
            this.btnDeleteRestockRequest.Size = new System.Drawing.Size(176, 30);
            this.btnDeleteRestockRequest.TabIndex = 84;
            this.btnDeleteRestockRequest.Text = "Delete restock request";
            this.btnDeleteRestockRequest.UseVisualStyleBackColor = true;
            this.btnDeleteRestockRequest.Click += new System.EventHandler(this.btnDeleteRestockRequest_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(18, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 21);
            this.label15.TabIndex = 57;
            this.label15.Text = "Restock Requests:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOverview);
            this.tabControl1.Controls.Add(this.tabRestock);
            this.tabControl1.Controls.Add(this.tabSchedule);
            this.tabControl1.Controls.Add(this.tabPlanning);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(33, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 564);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.cbOverviewDepartment);
            this.tabOverview.Controls.Add(this.dgOverviewRestock);
            this.tabOverview.Controls.Add(this.lstEmployeesWorkingToday);
            this.tabOverview.Controls.Add(this.label12);
            this.tabOverview.Controls.Add(this.label11);
            this.tabOverview.Controls.Add(this.label10);
            this.tabOverview.Controls.Add(this.dgOverviewSchedule);
            this.tabOverview.Location = new System.Drawing.Point(4, 30);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(1051, 530);
            this.tabOverview.TabIndex = 12;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // cbOverviewDepartment
            // 
            this.cbOverviewDepartment.FormattingEnabled = true;
            this.cbOverviewDepartment.Location = new System.Drawing.Point(729, 27);
            this.cbOverviewDepartment.Name = "cbOverviewDepartment";
            this.cbOverviewDepartment.Size = new System.Drawing.Size(240, 29);
            this.cbOverviewDepartment.TabIndex = 91;
            this.cbOverviewDepartment.SelectedIndexChanged += new System.EventHandler(this.cbOverviewDepartment_SelectedIndexChanged);
            // 
            // dgOverviewRestock
            // 
            this.dgOverviewRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOverviewRestock.Location = new System.Drawing.Point(21, 314);
            this.dgOverviewRestock.Name = "dgOverviewRestock";
            this.dgOverviewRestock.RowHeadersWidth = 51;
            this.dgOverviewRestock.RowTemplate.Height = 25;
            this.dgOverviewRestock.Size = new System.Drawing.Size(487, 190);
            this.dgOverviewRestock.TabIndex = 90;
            this.dgOverviewRestock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOverviewRestock_CellDoubleClick);
            // 
            // lstEmployeesWorkingToday
            // 
            this.lstEmployeesWorkingToday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmployeesWorkingToday.FormattingEnabled = true;
            this.lstEmployeesWorkingToday.ItemHeight = 17;
            this.lstEmployeesWorkingToday.Location = new System.Drawing.Point(528, 61);
            this.lstEmployeesWorkingToday.Name = "lstEmployeesWorkingToday";
            this.lstEmployeesWorkingToday.Size = new System.Drawing.Size(441, 429);
            this.lstEmployeesWorkingToday.TabIndex = 89;
            this.lstEmployeesWorkingToday.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstEmployeesWorkingToday_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(528, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 21);
            this.label12.TabIndex = 88;
            this.label12.Text = "Employees Working Today:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 21);
            this.label11.TabIndex = 86;
            this.label11.Text = "Pending Restock Requests:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Schedule:";
            // 
            // dgOverviewSchedule
            // 
            this.dgOverviewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOverviewSchedule.Location = new System.Drawing.Point(21, 27);
            this.dgOverviewSchedule.Name = "dgOverviewSchedule";
            this.dgOverviewSchedule.RowHeadersWidth = 51;
            this.dgOverviewSchedule.RowTemplate.Height = 25;
            this.dgOverviewSchedule.Size = new System.Drawing.Size(487, 251);
            this.dgOverviewSchedule.TabIndex = 13;
            this.dgOverviewSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOverviewSchedule_CellDoubleClick);
            // 
            // FormDepotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 601);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDepotManager";
            this.Text = "DepotManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDepotManager_FormClosing);
            this.tabPlanning.ResumeLayout(false);
            this.tabPlanning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanningYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanningSchedule)).EndInit();
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabRestock.ResumeLayout(false);
            this.tabRestock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewRestock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tabPlanning;
        private System.Windows.Forms.Button btnRemoveFromSchedule;
        private System.Windows.Forms.ListBox lstEmpCanWork;
        private System.Windows.Forms.ListBox lstEmpEnlisted;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.DataGridView dgSchedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditschedule;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lbScheduleEvening;
        private System.Windows.Forms.TextBox lbScheduleAfternoon;
        private System.Windows.Forms.TextBox lbScheduleMorning;
        private System.Windows.Forms.TabPage tabRestock;
        private System.Windows.Forms.Button btnDeleteRestockRequest;
        private System.Windows.Forms.Button btnOrderRestock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.ListBox lstEmployeesWorkingToday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgOverviewSchedule;
        private System.Windows.Forms.RadioButton rbHistory;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.DataGridView dgPlanningSchedule;
        private System.Windows.Forms.DataGridView dgRestock;
        private System.Windows.Forms.DataGridView dgOverviewRestock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDecreaseWeek;
        private System.Windows.Forms.Button btnIncreaseWeek;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnDecreasePlanningWeek;
        private System.Windows.Forms.Button btnIncreasePlanningWeek;
        private System.Windows.Forms.Label lblPlanningWeek;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Button btnAutoSchedule;
        private System.Windows.Forms.ComboBox cbSchebuleByDepartment;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown txtYear;
        private System.Windows.Forms.NumericUpDown txtPlanningYear;
        private System.Windows.Forms.ComboBox cbOverviewDepartment;
        private System.Windows.Forms.RadioButton rbNotPreferred;
        private System.Windows.Forms.RadioButton rbPreferred;
        private System.Windows.Forms.RadioButton rdNoPreference;
        private System.Windows.Forms.TextBox lbScheduleDay;
        private System.Windows.Forms.TextBox txtCurrentAmount;
        private System.Windows.Forms.TextBox txtRestockID;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClearWeek;
        private System.Windows.Forms.Label labNeedEmploye;
        private System.Windows.Forms.ComboBox cbUnregisteredShift;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Button btnCheckForShifts;
    }
}