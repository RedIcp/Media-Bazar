
namespace AdminBackups
{
    partial class FormRemoveEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemoveEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxReasonTermination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.tbxEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reason for termination:";
            // 
            // tbxReasonTermination
            // 
            this.tbxReasonTermination.Location = new System.Drawing.Point(29, 69);
            this.tbxReasonTermination.Multiline = true;
            this.tbxReasonTermination.Name = "tbxReasonTermination";
            this.tbxReasonTermination.Size = new System.Drawing.Size(404, 56);
            this.tbxReasonTermination.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contract end date:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(64, 9);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(256, 25);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "<Employee ID> <Employee>";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(358, 135);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveEmployee.TabIndex = 5;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxEndDate
            // 
            this.tbxEndDate.Location = new System.Drawing.Point(140, 135);
            this.tbxEndDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.tbxEndDate.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.tbxEndDate.Name = "tbxEndDate";
            this.tbxEndDate.Size = new System.Drawing.Size(200, 23);
            this.tbxEndDate.TabIndex = 7;
            this.tbxEndDate.Value = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            // 
            // FormRemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 185);
            this.Controls.Add(this.tbxEndDate);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxReasonTermination);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRemoveEmployee";
            this.ShowInTaskbar = false;
            this.Text = "FormRemoveEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxReasonTermination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.DateTimePicker tbxEndDate;
    }
}