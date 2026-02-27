namespace School_Managment_System
{
    partial class dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesChallanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.studentsRecordToolStripMenuItem,
            this.teachersRecordToolStripMenuItem,
            this.feesChallanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // studentsRecordToolStripMenuItem
            // 
            this.studentsRecordToolStripMenuItem.Name = "studentsRecordToolStripMenuItem";
            this.studentsRecordToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.studentsRecordToolStripMenuItem.Text = "Students Record";
            // 
            // teachersRecordToolStripMenuItem
            // 
            this.teachersRecordToolStripMenuItem.Name = "teachersRecordToolStripMenuItem";
            this.teachersRecordToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.teachersRecordToolStripMenuItem.Text = "Teachers Record";
            // 
            // feesChallanToolStripMenuItem
            // 
            this.feesChallanToolStripMenuItem.Name = "feesChallanToolStripMenuItem";
            this.feesChallanToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.feesChallanToolStripMenuItem.Text = "Fees Challan";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_Managment_System.Properties.Resources._101821810_906556983194966_7249303151995405296_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 580);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.Text = "Dashboard Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesChallanToolStripMenuItem;
    }
}