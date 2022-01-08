namespace HospitalmanagementSystem
{
    partial class Administration
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
            this.wordManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStatusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inpatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLabel = new System.Windows.Forms.Label();
            this.AmPm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GetIdLebel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getLoginTimeLebel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordManagementToolStripMenuItem,
            this.patientManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wordManagementToolStripMenuItem
            // 
            this.wordManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bedToolStripMenuItem});
            this.wordManagementToolStripMenuItem.Name = "wordManagementToolStripMenuItem";
            this.wordManagementToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.wordManagementToolStripMenuItem.Text = " Management";
            // 
            // bedToolStripMenuItem
            // 
            this.bedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkStatusToolStripMenuItem1});
            this.bedToolStripMenuItem.Name = "bedToolStripMenuItem";
            this.bedToolStripMenuItem.Size = new System.Drawing.Size(144, 34);
            this.bedToolStripMenuItem.Text = "Bed";
            // 
            // checkStatusToolStripMenuItem1
            // 
            this.checkStatusToolStripMenuItem1.Name = "checkStatusToolStripMenuItem1";
            this.checkStatusToolStripMenuItem1.Size = new System.Drawing.Size(214, 34);
            this.checkStatusToolStripMenuItem1.Text = "Check Status";
            this.checkStatusToolStripMenuItem1.Click += new System.EventHandler(this.checkStatusToolStripMenuItem1_Click);
            // 
            // patientManagementToolStripMenuItem
            // 
            this.patientManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inpatientToolStripMenuItem});
            this.patientManagementToolStripMenuItem.Name = "patientManagementToolStripMenuItem";
            this.patientManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 29);
            this.patientManagementToolStripMenuItem.Text = "Patient Registration";
            // 
            // inpatientToolStripMenuItem
            // 
            this.inpatientToolStripMenuItem.Name = "inpatientToolStripMenuItem";
            this.inpatientToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.inpatientToolStripMenuItem.Text = "Patient Summary";
            this.inpatientToolStripMenuItem.Click += new System.EventHandler(this.inpatientToolStripMenuItem_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.DarkCyan;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(248, 345);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(143, 37);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "00:00:00";
            // 
            // AmPm
            // 
            this.AmPm.AutoSize = true;
            this.AmPm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AmPm.Enabled = false;
            this.AmPm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmPm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AmPm.Location = new System.Drawing.Point(398, 351);
            this.AmPm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmPm.Name = "AmPm";
            this.AmPm.Size = new System.Drawing.Size(0, 29);
            this.AmPm.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID :";
            // 
            // GetIdLebel
            // 
            this.GetIdLebel.AutoSize = true;
            this.GetIdLebel.Location = new System.Drawing.Point(80, 62);
            this.GetIdLebel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GetIdLebel.Name = "GetIdLebel";
            this.GetIdLebel.Size = new System.Drawing.Size(0, 20);
            this.GetIdLebel.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Login Time:";
            // 
            // getLoginTimeLebel
            // 
            this.getLoginTimeLebel.AutoSize = true;
            this.getLoginTimeLebel.Location = new System.Drawing.Point(126, 102);
            this.getLoginTimeLebel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.getLoginTimeLebel.Name = "getLoginTimeLebel";
            this.getLoginTimeLebel.Size = new System.Drawing.Size(0, 20);
            this.getLoginTimeLebel.TabIndex = 26;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.big_background_big_resize;
            this.ClientSize = new System.Drawing.Size(1200, 729);
            this.Controls.Add(this.GetIdLebel);
            this.Controls.Add(this.getLoginTimeLebel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmPm);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wordManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStatusToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inpatientToolStripMenuItem;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label AmPm;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label GetIdLebel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label getLoginTimeLebel;
    }
}