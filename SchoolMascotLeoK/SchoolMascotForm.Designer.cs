namespace SchoolMascotLeoK
{
    partial class frmMascot
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
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHillcrest = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCantubury = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGlebe = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSchoolMascot = new System.Windows.Forms.GroupBox();
            this.lblMascot = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.mnuSchools.SuspendLayout();
            this.grbSchoolMascot.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSchools
            // 
            this.mnuSchools.BackColor = System.Drawing.Color.LightBlue;
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(284, 24);
            this.mnuSchools.TabIndex = 0;
            this.mnuSchools.Text = "menuStrip1";
            this.mnuSchools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniHillcrest,
            this.mniCantubury,
            this.mniGlebe});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(152, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniHillcrest
            // 
            this.mniHillcrest.Name = "mniHillcrest";
            this.mniHillcrest.Size = new System.Drawing.Size(152, 22);
            this.mniHillcrest.Text = "Hillcrest";
            this.mniHillcrest.Click += new System.EventHandler(this.mniHillcrest_Click);
            // 
            // mniCantubury
            // 
            this.mniCantubury.Name = "mniCantubury";
            this.mniCantubury.Size = new System.Drawing.Size(152, 22);
            this.mniCantubury.Text = "Cantebury";
            this.mniCantubury.Click += new System.EventHandler(this.mniCantubury_Click);
            // 
            // mniGlebe
            // 
            this.mniGlebe.Name = "mniGlebe";
            this.mniGlebe.Size = new System.Drawing.Size(152, 22);
            this.mniGlebe.Text = "Glebe";
            this.mniGlebe.Click += new System.EventHandler(this.mniGlebe_Click);
            // 
            // grbSchoolMascot
            // 
            this.grbSchoolMascot.BackColor = System.Drawing.SystemColors.Control;
            this.grbSchoolMascot.Controls.Add(this.lblMascot);
            this.grbSchoolMascot.Controls.Add(this.lblSchool);
            this.grbSchoolMascot.Location = new System.Drawing.Point(22, 96);
            this.grbSchoolMascot.Name = "grbSchoolMascot";
            this.grbSchoolMascot.Size = new System.Drawing.Size(234, 126);
            this.grbSchoolMascot.TabIndex = 1;
            this.grbSchoolMascot.TabStop = false;
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.Location = new System.Drawing.Point(30, 77);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(96, 29);
            this.lblMascot.TabIndex = 2;
            this.lblMascot.Text = "Mascot";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(30, 16);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(94, 29);
            this.lblSchool.TabIndex = 0;
            this.lblSchool.Text = "School";
            // 
            // frmMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grbSchoolMascot);
            this.Controls.Add(this.mnuSchools);
            this.MainMenuStrip = this.mnuSchools;
            this.Name = "frmMascot";
            this.Text = "School Mascot by Leo Kay";
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.grbSchoolMascot.ResumeLayout(false);
            this.grbSchoolMascot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniHillcrest;
        private System.Windows.Forms.ToolStripMenuItem mniCantubury;
        private System.Windows.Forms.ToolStripMenuItem mniGlebe;
        private System.Windows.Forms.GroupBox grbSchoolMascot;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblMascot;
    }
}

