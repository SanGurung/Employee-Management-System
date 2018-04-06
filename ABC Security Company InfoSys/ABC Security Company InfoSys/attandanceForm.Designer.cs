namespace ABC_Security_Company_InfoSys
{
    partial class attendanceForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Compnt_calculate = new System.Windows.Forms.Button();
            this.Compnt_tax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Compnt_NI = new System.Windows.Forms.TextBox();
            this.Compnt_employeeName = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empdetaild = new ABC_Security_Company_InfoSys.empdetaild();
            this.Compnt_saveCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Compnt_workingHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Compnt_year = new System.Windows.Forms.ComboBox();
            this.Compnt_day = new System.Windows.Forms.ComboBox();
            this.Compnt_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Compnt_taxPercentage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Compnt_niPercentage = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter = new ABC_Security_Company_InfoSys.empdetaildTableAdapters.EmployeeTableAdapter();
            this.compnt_employeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.compnt_hourlyRate = new System.Windows.Forms.ComboBox();
            this.relB0B6D8CD81424208BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityGuardTableAdapter = new ABC_Security_Company_InfoSys.empdetaildTableAdapters.SecurityGuardTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetaild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relB0B6D8CD81424208BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Compnt_calculate);
            this.groupBox1.Controls.Add(this.Compnt_tax);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Compnt_NI);
            this.groupBox1.Location = new System.Drawing.Point(243, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 81);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // Compnt_calculate
            // 
            this.Compnt_calculate.Location = new System.Drawing.Point(225, 19);
            this.Compnt_calculate.Name = "Compnt_calculate";
            this.Compnt_calculate.Size = new System.Drawing.Size(83, 43);
            this.Compnt_calculate.TabIndex = 58;
            this.Compnt_calculate.Text = "Calculate";
            this.Compnt_calculate.UseVisualStyleBackColor = true;
            this.Compnt_calculate.Click += new System.EventHandler(this.Compnt_calculate_Click);
            // 
            // Compnt_tax
            // 
            this.Compnt_tax.Location = new System.Drawing.Point(108, 49);
            this.Compnt_tax.Name = "Compnt_tax";
            this.Compnt_tax.Size = new System.Drawing.Size(103, 20);
            this.Compnt_tax.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tax Deduction:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "NI Deduction:";
            // 
            // Compnt_NI
            // 
            this.Compnt_NI.Location = new System.Drawing.Point(108, 16);
            this.Compnt_NI.Name = "Compnt_NI";
            this.Compnt_NI.Size = new System.Drawing.Size(103, 20);
            this.Compnt_NI.TabIndex = 54;
            // 
            // Compnt_employeeName
            // 
            this.Compnt_employeeName.DataSource = this.employeeBindingSource;
            this.Compnt_employeeName.DisplayMember = "Name";
            this.Compnt_employeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Compnt_employeeName.FormattingEnabled = true;
            this.Compnt_employeeName.Location = new System.Drawing.Point(130, 124);
            this.Compnt_employeeName.Name = "Compnt_employeeName";
            this.Compnt_employeeName.Size = new System.Drawing.Size(233, 21);
            this.Compnt_employeeName.TabIndex = 48;
            this.Compnt_employeeName.ValueMember = "Name";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.empdetaild;
            // 
            // empdetaild
            // 
            this.empdetaild.DataSetName = "empdetaild";
            this.empdetaild.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Compnt_saveCalculate
            // 
            this.Compnt_saveCalculate.Location = new System.Drawing.Point(130, 322);
            this.Compnt_saveCalculate.Name = "Compnt_saveCalculate";
            this.Compnt_saveCalculate.Size = new System.Drawing.Size(102, 43);
            this.Compnt_saveCalculate.TabIndex = 44;
            this.Compnt_saveCalculate.Text = "Calculate && &Save";
            this.Compnt_saveCalculate.UseVisualStyleBackColor = true;
            this.Compnt_saveCalculate.Click += new System.EventHandler(this.Compnt_saveCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Working Hours:";
            // 
            // Compnt_workingHours
            // 
            this.Compnt_workingHours.Location = new System.Drawing.Point(129, 203);
            this.Compnt_workingHours.Name = "Compnt_workingHours";
            this.Compnt_workingHours.Size = new System.Drawing.Size(154, 20);
            this.Compnt_workingHours.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date: (dd/mm/yy)";
            // 
            // Compnt_year
            // 
            this.Compnt_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Compnt_year.FormattingEnabled = true;
            this.Compnt_year.Items.AddRange(new object[] {
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.Compnt_year.Location = new System.Drawing.Point(230, 163);
            this.Compnt_year.Name = "Compnt_year";
            this.Compnt_year.Size = new System.Drawing.Size(57, 21);
            this.Compnt_year.TabIndex = 40;
            // 
            // Compnt_day
            // 
            this.Compnt_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Compnt_day.FormattingEnabled = true;
            this.Compnt_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Compnt_day.Location = new System.Drawing.Point(130, 163);
            this.Compnt_day.Name = "Compnt_day";
            this.Compnt_day.Size = new System.Drawing.Size(47, 21);
            this.Compnt_day.TabIndex = 38;
            // 
            // Compnt_month
            // 
            this.Compnt_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Compnt_month.FormattingEnabled = true;
            this.Compnt_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Compnt_month.Location = new System.Drawing.Point(182, 163);
            this.Compnt_month.Name = "Compnt_month";
            this.Compnt_month.Size = new System.Drawing.Size(44, 21);
            this.Compnt_month.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Employee Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABC_Security_Company_InfoSys.Properties.Resources.attendance;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 103);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Compnt_taxPercentage
            // 
            this.Compnt_taxPercentage.Location = new System.Drawing.Point(129, 275);
            this.Compnt_taxPercentage.Name = "Compnt_taxPercentage";
            this.Compnt_taxPercentage.Size = new System.Drawing.Size(99, 20);
            this.Compnt_taxPercentage.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Tax Percentage%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "NI Percentage%";
            // 
            // Compnt_niPercentage
            // 
            this.Compnt_niPercentage.Location = new System.Drawing.Point(129, 244);
            this.Compnt_niPercentage.Name = "Compnt_niPercentage";
            this.Compnt_niPercentage.Size = new System.Drawing.Size(99, 20);
            this.Compnt_niPercentage.TabIndex = 56;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // compnt_employeeID
            // 
            this.compnt_employeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeID", true));
            this.compnt_employeeID.Location = new System.Drawing.Point(468, 122);
            this.compnt_employeeID.Name = "compnt_employeeID";
            this.compnt_employeeID.ReadOnly = true;
            this.compnt_employeeID.Size = new System.Drawing.Size(69, 20);
            this.compnt_employeeID.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Employee ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Hourly Rate:";
            // 
            // compnt_hourlyRate
            // 
            this.compnt_hourlyRate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "EmployeeID", true));
            this.compnt_hourlyRate.DataSource = this.relB0B6D8CD81424208BindingSource;
            this.compnt_hourlyRate.DisplayMember = "HourlyRate";
            this.compnt_hourlyRate.FormattingEnabled = true;
            this.compnt_hourlyRate.Location = new System.Drawing.Point(468, 158);
            this.compnt_hourlyRate.Name = "compnt_hourlyRate";
            this.compnt_hourlyRate.Size = new System.Drawing.Size(72, 21);
            this.compnt_hourlyRate.TabIndex = 64;
            this.compnt_hourlyRate.ValueMember = "EmployeeID";
            // 
            // relB0B6D8CD81424208BindingSource
            // 
            this.relB0B6D8CD81424208BindingSource.DataMember = "Rel_B0B6D8CD_8142_4208";
            this.relB0B6D8CD81424208BindingSource.DataSource = this.employeeBindingSource;
            // 
            // securityGuardTableAdapter
            // 
            this.securityGuardTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 370);
            this.Controls.Add(this.compnt_hourlyRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.compnt_employeeID);
            this.Controls.Add(this.Compnt_taxPercentage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Compnt_niPercentage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Compnt_employeeName);
            this.Controls.Add(this.Compnt_saveCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Compnt_workingHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Compnt_year);
            this.Controls.Add(this.Compnt_day);
            this.Controls.Add(this.Compnt_month);
            this.Controls.Add(this.label1);
            this.Name = "attendanceForm";
            this.Text = "Attandance Form ::";
            this.Load += new System.EventHandler(this.attandanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetaild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relB0B6D8CD81424208BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Compnt_employeeName;
        private System.Windows.Forms.Button Compnt_saveCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Compnt_workingHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Compnt_year;
        private System.Windows.Forms.ComboBox Compnt_day;
        private System.Windows.Forms.ComboBox Compnt_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Compnt_tax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Compnt_NI;
        private System.Windows.Forms.TextBox Compnt_taxPercentage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Compnt_niPercentage;
        private System.Windows.Forms.Button Compnt_calculate;
        private empdetaild empdetaild;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ABC_Security_Company_InfoSys.empdetaildTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox compnt_employeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox compnt_hourlyRate;
        private System.Windows.Forms.BindingSource relB0B6D8CD81424208BindingSource;
        private ABC_Security_Company_InfoSys.empdetaildTableAdapters.SecurityGuardTableAdapter securityGuardTableAdapter;
    }
}