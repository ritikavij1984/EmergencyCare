namespace HospitalmanagementSystem
{
    partial class patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resisterButton = new System.Windows.Forms.Button();
            this.F5 = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.SelectBedButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DischargeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.admitdate = new System.Windows.Forms.TextBox();
            this.pmobile = new System.Windows.Forms.TextBox();
            this.pcity = new System.Windows.Forms.TextBox();
            this.page = new System.Windows.Forms.TextBox();
            this.pgender = new System.Windows.Forms.ComboBox();
            this.pname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dischargeDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DoctorId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbednumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4,
            this.Column10,
            this.Column7,
            this.Column6,
            this.Column15,
            this.Column3,
            this.Column17,
             this.Column1,
            this.Column18});
            this.dataGridView1.Location = new System.Drawing.Point(553, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 323);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column2
            // 
            this.Column2.FillWeight = 120F;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Age";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Admit Date";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Bed Number";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Bed Status";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Presenting issue";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Last Comment";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column17
            // 
            this.Column17.FillWeight = 120F;
            this.Column17.HeaderText = "Last Updated";
            this.Column17.MinimumWidth = 8;
            this.Column17.Name = "Column17";
            this.Column17.Width = 140;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Nurse";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;

            // 
            // Column1
            // 
            this.Column18.FillWeight = 150F;
            this.Column18.HeaderText = "PID";
            this.Column18.MinimumWidth = 8;
            this.Column18.Name = "Column18";
            this.Column18.Width = 150;
            // 
            // resisterButton
            // 
            this.resisterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resisterButton.BackgroundImage")));
            this.resisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resisterButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resisterButton.Image = global::HospitalmanagementSystem.Properties.Resources.add1;
            this.resisterButton.Location = new System.Drawing.Point(711, 561);
            this.resisterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resisterButton.Name = "resisterButton";
            this.resisterButton.Size = new System.Drawing.Size(165, 51);
            this.resisterButton.TabIndex = 11;
            this.resisterButton.Text = "Register";
            this.resisterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resisterButton.UseVisualStyleBackColor = true;
            this.resisterButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // F5
            // 
            this.F5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("F5.BackgroundImage")));
            this.F5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.F5.Image = global::HospitalmanagementSystem.Properties.Resources.Actions_view_refresh_icon;
            this.F5.Location = new System.Drawing.Point(884, 562);
            this.F5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.F5.Name = "F5";
            this.F5.Size = new System.Drawing.Size(165, 51);
            this.F5.TabIndex = 16;
            this.F5.Text = "Refresh";
            this.F5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.F5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.F5.UseVisualStyleBackColor = true;
            this.F5.Click += new System.EventHandler(this.F5_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.Image = global::HospitalmanagementSystem.Properties.Resources.Hospital_blue_icon;
            this.homeButton.Location = new System.Drawing.Point(553, 562);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(150, 49);
            this.homeButton.TabIndex = 29;
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.WindowText;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MintCream;
            this.label16.Image = global::HospitalmanagementSystem.Properties.Resources.images79UVSEYU;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label16.Location = new System.Drawing.Point(654, 5);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(457, 64);
            this.label16.TabIndex = 30;
            this.label16.Text = "Patient Summary";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // SelectBedButton
            // 
            this.SelectBedButton.BackColor = System.Drawing.Color.Navy;
            this.SelectBedButton.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.images79UVSEYU;
            this.SelectBedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBedButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBedButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectBedButton.Location = new System.Drawing.Point(601, 104);
            this.SelectBedButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectBedButton.Name = "SelectBedButton";
            this.SelectBedButton.Size = new System.Drawing.Size(318, 60);
            this.SelectBedButton.TabIndex = 28;
            this.SelectBedButton.Text = "Bed Status";
            this.SelectBedButton.UseVisualStyleBackColor = false;
            this.SelectBedButton.Click += new System.EventHandler(this.SelectBedButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.images79UVSEYU;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(951, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 60);
            this.button1.TabIndex = 35;
            this.button1.Text = "Patient Admitted Today";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DischargeButton
            // 
            this.DischargeButton.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.stock_vector_medical_background_abstract_digestive_system_91081253;
            this.DischargeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DischargeButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DischargeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DischargeButton.Location = new System.Drawing.Point(1067, 560);
            this.DischargeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DischargeButton.Name = "DischargeButton";
            this.DischargeButton.Size = new System.Drawing.Size(159, 51);
            this.DischargeButton.TabIndex = 36;
            this.DischargeButton.Text = "Discharge";
            this.DischargeButton.UseVisualStyleBackColor = true;
            this.DischargeButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 477);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mobile No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 425);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "City :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gender :";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 648);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Admit Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(486, 643);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(25, 35);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // admitdate
            // 
            this.admitdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admitdate.Location = new System.Drawing.Point(204, 643);
            this.admitdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admitdate.Name = "admitdate";
            this.admitdate.Size = new System.Drawing.Size(283, 35);
            this.admitdate.TabIndex = 10;
            // 
            // pmobile
            // 
            this.pmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmobile.Location = new System.Drawing.Point(204, 472);
            this.pmobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pmobile.Name = "pmobile";
            this.pmobile.Size = new System.Drawing.Size(307, 35);
            this.pmobile.TabIndex = 7;
            // 
            // pcity
            // 
            this.pcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcity.Location = new System.Drawing.Point(204, 420);
            this.pcity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcity.Name = "pcity";
            this.pcity.Size = new System.Drawing.Size(307, 35);
            this.pcity.TabIndex = 6;
            // 
            // page
            // 
            this.page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page.Location = new System.Drawing.Point(204, 302);
            this.page.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(307, 35);
            this.page.TabIndex = 4;
            // 
            // pgender
            // 
            this.pgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgender.FormattingEnabled = true;
            this.pgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Common"});
            this.pgender.Location = new System.Drawing.Point(204, 245);
            this.pgender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgender.Name = "pgender";
            this.pgender.Size = new System.Drawing.Size(307, 37);
            this.pgender.TabIndex = 3;
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(204, 188);
            this.pname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(307, 35);
            this.pname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // pid
            // 
            this.pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.Location = new System.Drawing.Point(204, 131);
            this.pid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Size = new System.Drawing.Size(307, 35);
            this.pid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // dischargeDate
            // 
            this.dischargeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischargeDate.Location = new System.Drawing.Point(207, 606);
            this.dischargeDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dischargeDate.Name = "dischargeDate";
            this.dischargeDate.Size = new System.Drawing.Size(259, 35);
            this.dischargeDate.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(6, 611);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "Discharge Date :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(465, 606);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(25, 35);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // DoctorId
            // 
            this.DoctorId.AutoSize = true;
            this.DoctorId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DoctorId.Location = new System.Drawing.Point(9, 663);
            this.DoctorId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoctorId.Name = "DoctorId";
            this.DoctorId.Size = new System.Drawing.Size(0, 25);
            this.DoctorId.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.images79UVSEYU;
            this.groupBox2.Controls.Add(this.pbednumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DoctorId);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.dischargeDate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(18, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(510, 692);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient information";
            // 
            // pbednumber
            // 
            this.pbednumber.AllowDrop = true;
            this.pbednumber.Location = new System.Drawing.Point(188, 258);
            this.pbednumber.Name = "pbednumber";
            this.pbednumber.Size = new System.Drawing.Size(302, 30);
            this.pbednumber.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(28, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bed Number:";
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.images79UVSEYU;
            this.ClientSize = new System.Drawing.Size(1922, 938);
            this.Controls.Add(this.DischargeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectBedButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.F5);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.pmobile);
            this.Controls.Add(this.admitdate);
            this.Controls.Add(this.pcity);
            this.Controls.Add(this.page);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pgender);
            this.Controls.Add(this.resisterButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "patient";
            this.Load += new System.EventHandler(this.patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button F5;
        private System.Windows.Forms.Button homeButton;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button resisterButton;
        private System.Windows.Forms.Button SelectBedButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button DischargeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox admitdate;
        private System.Windows.Forms.TextBox pmobile;
        private System.Windows.Forms.TextBox pcity;
        private System.Windows.Forms.TextBox page;
        private System.Windows.Forms.ComboBox pgender;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dischargeDate;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label DoctorId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.TextBox pbednumber;
        private System.Windows.Forms.Label label6;
    }
}