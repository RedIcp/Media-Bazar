
namespace acr122_demo {
    partial class Checks {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checks));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbCheck = new System.Windows.Forms.ListBox();
            this.labChekced = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCheck
            // 
            this.lbCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCheck.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheck.FormattingEnabled = true;
            this.lbCheck.ItemHeight = 22;
            this.lbCheck.Location = new System.Drawing.Point(24, 82);
            this.lbCheck.Margin = new System.Windows.Forms.Padding(4);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(756, 70);
            this.lbCheck.TabIndex = 0;
            // 
            // labChekced
            // 
            this.labChekced.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labChekced.AutoSize = true;
            this.labChekced.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labChekced.ForeColor = System.Drawing.Color.Black;
            this.labChekced.Location = new System.Drawing.Point(68, 9);
            this.labChekced.Name = "labChekced";
            this.labChekced.Size = new System.Drawing.Size(679, 42);
            this.labChekced.TabIndex = 2;
            this.labChekced.Text = "Please hold your card against the scaner";
            // 
            // Checks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 186);
            this.Controls.Add(this.labChekced);
            this.Controls.Add(this.lbCheck);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Checks";
            this.Text = "Card Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbCheck;
        private System.Windows.Forms.Label labChekced;
    }
}

