
namespace AdminBackups
{
    partial class MakeBackups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeBackups));
            this.niMakingBackups = new System.Windows.Forms.NotifyIcon(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnFolder = new System.Windows.Forms.Button();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.btnStartMakingBackups = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labAmount = new System.Windows.Forms.Label();
            this.rbMinutes = new System.Windows.Forms.RadioButton();
            this.rbHours = new System.Windows.Forms.RadioButton();
            this.rbDays = new System.Windows.Forms.RadioButton();
            this.labTimeTillBackup = new System.Windows.Forms.Label();
            this.labFolder = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // niMakingBackups
            // 
            this.niMakingBackups.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niMakingBackups.Icon = ((System.Drawing.Icon)(resources.GetObject("niMakingBackups.Icon")));
            this.niMakingBackups.Text = "Just making backups Dont mind me";
            this.niMakingBackups.Visible = true;
            this.niMakingBackups.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niMakingBackups_MouseClick);
            this.niMakingBackups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(590, 30);
            this.progressBar1.TabIndex = 10;
            // 
            // btnFolder
            // 
            this.btnFolder.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFolder.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnFolder.Location = new System.Drawing.Point(38, 181);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(191, 33);
            this.btnFolder.TabIndex = 8;
            this.btnFolder.Text = "Select folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // tbFolder
            // 
            this.tbFolder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFolder.Location = new System.Drawing.Point(38, 140);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.ReadOnly = true;
            this.tbFolder.Size = new System.Drawing.Size(590, 35);
            this.tbFolder.TabIndex = 7;
            // 
            // btnStartMakingBackups
            // 
            this.btnStartMakingBackups.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartMakingBackups.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnStartMakingBackups.Location = new System.Drawing.Point(97, 319);
            this.btnStartMakingBackups.Name = "btnStartMakingBackups";
            this.btnStartMakingBackups.Size = new System.Drawing.Size(429, 62);
            this.btnStartMakingBackups.TabIndex = 0;
            this.btnStartMakingBackups.Text = "Start";
            this.btnStartMakingBackups.UseVisualStyleBackColor = true;
            this.btnStartMakingBackups.Click += new System.EventHandler(this.btnStartMakingBackups_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAmount.Location = new System.Drawing.Point(407, 245);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(84, 25);
            this.labAmount.TabIndex = 11;
            this.labAmount.Text = "Minutes:";
            // 
            // rbMinutes
            // 
            this.rbMinutes.AutoSize = true;
            this.rbMinutes.Checked = true;
            this.rbMinutes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMinutes.Location = new System.Drawing.Point(51, 243);
            this.rbMinutes.Name = "rbMinutes";
            this.rbMinutes.Size = new System.Drawing.Size(98, 29);
            this.rbMinutes.TabIndex = 12;
            this.rbMinutes.TabStop = true;
            this.rbMinutes.Text = "Minutes";
            this.rbMinutes.UseVisualStyleBackColor = true;
            this.rbMinutes.CheckedChanged += new System.EventHandler(this.rbMinutes_CheckedChanged);
            // 
            // rbHours
            // 
            this.rbHours.AutoSize = true;
            this.rbHours.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbHours.Location = new System.Drawing.Point(176, 243);
            this.rbHours.Name = "rbHours";
            this.rbHours.Size = new System.Drawing.Size(80, 29);
            this.rbHours.TabIndex = 13;
            this.rbHours.Text = "Hours";
            this.rbHours.UseVisualStyleBackColor = true;
            this.rbHours.CheckedChanged += new System.EventHandler(this.rbHours_CheckedChanged);
            // 
            // rbDays
            // 
            this.rbDays.AutoSize = true;
            this.rbDays.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDays.Location = new System.Drawing.Point(282, 243);
            this.rbDays.Name = "rbDays";
            this.rbDays.Size = new System.Drawing.Size(70, 29);
            this.rbDays.TabIndex = 14;
            this.rbDays.Text = "Days";
            this.rbDays.UseVisualStyleBackColor = true;
            this.rbDays.CheckedChanged += new System.EventHandler(this.rbDays_CheckedChanged);
            // 
            // labTimeTillBackup
            // 
            this.labTimeTillBackup.AutoSize = true;
            this.labTimeTillBackup.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labTimeTillBackup.Location = new System.Drawing.Point(38, 27);
            this.labTimeTillBackup.Name = "labTimeTillBackup";
            this.labTimeTillBackup.Size = new System.Drawing.Size(268, 22);
            this.labTimeTillBackup.TabIndex = 15;
            this.labTimeTillBackup.Text = "Time left untill backup is made:\r\n";
            // 
            // labFolder
            // 
            this.labFolder.AutoSize = true;
            this.labFolder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labFolder.Location = new System.Drawing.Point(38, 115);
            this.labFolder.Name = "labFolder";
            this.labFolder.Size = new System.Drawing.Size(140, 22);
            this.labFolder.TabIndex = 16;
            this.labFolder.Text = "Folder location:";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmount.Location = new System.Drawing.Point(497, 243);
            this.tbAmount.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.tbAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(120, 33);
            this.tbAmount.TabIndex = 17;
            this.tbAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MakeBackups
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(653, 415);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.labFolder);
            this.Controls.Add(this.labTimeTillBackup);
            this.Controls.Add(this.rbDays);
            this.Controls.Add(this.rbHours);
            this.Controls.Add(this.rbMinutes);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStartMakingBackups);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.tbFolder);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeBackups";
            this.Text = "MakeBackups";
            this.Resize += new System.EventHandler(this.MakeBackups_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niMakingBackups;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btnStartMakingBackups;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.RadioButton rbHours;
        private System.Windows.Forms.RadioButton rbDays;
        private System.Windows.Forms.Label labTimeTillBackup;
        private System.Windows.Forms.Label labFolder;
        private System.Windows.Forms.NumericUpDown tbAmount;
        internal System.Windows.Forms.RadioButton rbMinutes;
    }
}