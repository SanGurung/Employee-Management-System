namespace ABC_Security_Company_InfoSys
{
    partial class paySlipForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.compnt_guardName = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empdetaild = new ABC_Security_Company_InfoSys.empdetaild();
            this.label7 = new System.Windows.Forms.Label();
            this.compnt_totalHWorkd = new System.Windows.Forms.TextBox();
            this.compnt_Tax = new System.Windows.Forms.TextBox();
            this.compnt_NI = new System.Windows.Forms.TextBox();
            this.compnt_Earned = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compnt_Grid = new System.Windows.Forms.DataGridView();
            this.attendanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daydeployDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthdeployDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeardeployDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEarnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niDeductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDeductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_Security_dbDataSet = new ABC_Security_Company_InfoSys.ABC_Security_dbDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compnt_year = new System.Windows.Forms.ComboBox();
            this.compnt_month = new System.Windows.Forms.ComboBox();
            this.compnt_ID = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.compnt_show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new ABC_Security_Company_InfoSys.empdetaildTableAdapters.EmployeeTableAdapter();
            this.attendanceTableAdapter = new ABC_Security_Company_InfoSys.ABC_Security_dbDataSetTableAdapters.AttendanceTableAdapter();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.relB0B6D8CD81424208BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityGuardTableAdapter = new ABC_Security_Company_InfoSys.empdetaildTableAdapters.SecurityGuardTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetaild)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compnt_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Security_dbDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relB0B6D8CD81424208BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.compnt_guardName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.compnt_totalHWorkd);
            this.groupBox2.Controls.Add(this.compnt_Tax);
            this.groupBox2.Controls.Add(this.compnt_NI);
            this.groupBox2.Controls.Add(this.compnt_Earned);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 117);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly Summary";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // compnt_guardName
            // 
            this.compnt_guardName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.compnt_guardName.Location = new System.Drawing.Point(131, 23);
            this.compnt_guardName.Name = "compnt_guardName";
            this.compnt_guardName.ReadOnly = true;
            this.compnt_guardName.Size = new System.Drawing.Size(178, 20);
            this.compnt_guardName.TabIndex = 54;
            this.compnt_guardName.TextChanged += new System.EventHandler(this.field_name_TextChanged);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Guard Name:";
            // 
            // compnt_totalHWorkd
            // 
            this.compnt_totalHWorkd.Location = new System.Drawing.Point(131, 80);
            this.compnt_totalHWorkd.Name = "compnt_totalHWorkd";
            this.compnt_totalHWorkd.ReadOnly = true;
            this.compnt_totalHWorkd.Size = new System.Drawing.Size(100, 20);
            this.compnt_totalHWorkd.TabIndex = 7;
            // 
            // compnt_Tax
            // 
            this.compnt_Tax.Location = new System.Drawing.Point(392, 80);
            this.compnt_Tax.Name = "compnt_Tax";
            this.compnt_Tax.ReadOnly = true;
            this.compnt_Tax.Size = new System.Drawing.Size(100, 20);
            this.compnt_Tax.TabIndex = 6;
            // 
            // compnt_NI
            // 
            this.compnt_NI.Location = new System.Drawing.Point(392, 51);
            this.compnt_NI.Name = "compnt_NI";
            this.compnt_NI.ReadOnly = true;
            this.compnt_NI.Size = new System.Drawing.Size(100, 20);
            this.compnt_NI.TabIndex = 5;
            this.compnt_NI.TextChanged += new System.EventHandler(this.TNI_TextChanged);
            // 
            // compnt_Earned
            // 
            this.compnt_Earned.Location = new System.Drawing.Point(131, 52);
            this.compnt_Earned.Name = "compnt_Earned";
            this.compnt_Earned.ReadOnly = true;
            this.compnt_Earned.Size = new System.Drawing.Size(100, 20);
            this.compnt_Earned.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Hours Worked:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Tax Deduction:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total NI Deduction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grand Total Earned: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.compnt_Grid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 232);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detailed Report :";
            // 
            // compnt_Grid
            // 
            this.compnt_Grid.AutoGenerateColumns = false;
            this.compnt_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compnt_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.daydeployDataGridViewTextBoxColumn,
            this.monthdeployDataGridViewTextBoxColumn,
            this.yeardeployDataGridViewTextBoxColumn,
            this.workingHoursDataGridViewTextBoxColumn,
            this.totalEarnedDataGridViewTextBoxColumn,
            this.niDeductionDataGridViewTextBoxColumn,
            this.taxDeductionDataGridViewTextBoxColumn});
            this.compnt_Grid.DataSource = this.attendanceBindingSource;
            this.compnt_Grid.Location = new System.Drawing.Point(21, 23);
            this.compnt_Grid.Name = "compnt_Grid";
            this.compnt_Grid.ReadOnly = true;
            this.compnt_Grid.Size = new System.Drawing.Size(599, 199);
            this.compnt_Grid.TabIndex = 0;
            // 
            // attendanceIDDataGridViewTextBoxColumn
            // 
            this.attendanceIDDataGridViewTextBoxColumn.DataPropertyName = "AttendanceID";
            this.attendanceIDDataGridViewTextBoxColumn.HeaderText = "AttendanceID";
            this.attendanceIDDataGridViewTextBoxColumn.Name = "attendanceIDDataGridViewTextBoxColumn";
            this.attendanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendanceIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // daydeployDataGridViewTextBoxColumn
            // 
            this.daydeployDataGridViewTextBoxColumn.DataPropertyName = "Day_deploy";
            this.daydeployDataGridViewTextBoxColumn.HeaderText = "Day";
            this.daydeployDataGridViewTextBoxColumn.Name = "daydeployDataGridViewTextBoxColumn";
            this.daydeployDataGridViewTextBoxColumn.ReadOnly = true;
            this.daydeployDataGridViewTextBoxColumn.Width = 40;
            // 
            // monthdeployDataGridViewTextBoxColumn
            // 
            this.monthdeployDataGridViewTextBoxColumn.DataPropertyName = "Month_deploy";
            this.monthdeployDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthdeployDataGridViewTextBoxColumn.Name = "monthdeployDataGridViewTextBoxColumn";
            this.monthdeployDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthdeployDataGridViewTextBoxColumn.Width = 40;
            // 
            // yeardeployDataGridViewTextBoxColumn
            // 
            this.yeardeployDataGridViewTextBoxColumn.DataPropertyName = "Year_deploy";
            this.yeardeployDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yeardeployDataGridViewTextBoxColumn.Name = "yeardeployDataGridViewTextBoxColumn";
            this.yeardeployDataGridViewTextBoxColumn.ReadOnly = true;
            this.yeardeployDataGridViewTextBoxColumn.Width = 40;
            // 
            // workingHoursDataGridViewTextBoxColumn
            // 
            this.workingHoursDataGridViewTextBoxColumn.DataPropertyName = "WorkingHours";
            this.workingHoursDataGridViewTextBoxColumn.HeaderText = "Working Hours";
            this.workingHoursDataGridViewTextBoxColumn.Name = "workingHoursDataGridViewTextBoxColumn";
            this.workingHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.workingHoursDataGridViewTextBoxColumn.Width = 50;
            // 
            // totalEarnedDataGridViewTextBoxColumn
            // 
            this.totalEarnedDataGridViewTextBoxColumn.DataPropertyName = "TotalEarned";
            this.totalEarnedDataGridViewTextBoxColumn.HeaderText = "Total Earned";
            this.totalEarnedDataGridViewTextBoxColumn.Name = "totalEarnedDataGridViewTextBoxColumn";
            this.totalEarnedDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalEarnedDataGridViewTextBoxColumn.Width = 70;
            // 
            // niDeductionDataGridViewTextBoxColumn
            // 
            this.niDeductionDataGridViewTextBoxColumn.DataPropertyName = "NiDeduction";
            this.niDeductionDataGridViewTextBoxColumn.HeaderText = "Ni Deduction";
            this.niDeductionDataGridViewTextBoxColumn.Name = "niDeductionDataGridViewTextBoxColumn";
            this.niDeductionDataGridViewTextBoxColumn.ReadOnly = true;
            this.niDeductionDataGridViewTextBoxColumn.Width = 70;
            // 
            // taxDeductionDataGridViewTextBoxColumn
            // 
            this.taxDeductionDataGridViewTextBoxColumn.DataPropertyName = "TaxDeduction";
            this.taxDeductionDataGridViewTextBoxColumn.HeaderText = "Tax Deduction";
            this.taxDeductionDataGridViewTextBoxColumn.Name = "taxDeductionDataGridViewTextBoxColumn";
            this.taxDeductionDataGridViewTextBoxColumn.ReadOnly = true;
            this.taxDeductionDataGridViewTextBoxColumn.Width = 70;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.aBC_Security_dbDataSet;
            // 
            // aBC_Security_dbDataSet
            // 
            this.aBC_Security_dbDataSet.DataSetName = "ABC_Security_dbDataSet";
            this.aBC_Security_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.compnt_year);
            this.groupBox3.Controls.Add(this.compnt_month);
            this.groupBox3.Controls.Add(this.compnt_ID);
            this.groupBox3.Controls.Add(this.compnt_show);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(0, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 44);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Date: (mm/yy)";
            // 
            // compnt_year
            // 
            this.compnt_year.FormattingEnabled = true;
            this.compnt_year.Items.AddRange(new object[] {
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
            this.compnt_year.Location = new System.Drawing.Point(401, 12);
            this.compnt_year.Name = "compnt_year";
            this.compnt_year.Size = new System.Drawing.Size(57, 21);
            this.compnt_year.TabIndex = 52;
            this.compnt_year.Text = "2009";
            this.compnt_year.SelectedIndexChanged += new System.EventHandler(this.compnt_year_SelectedIndexChanged);
            // 
            // compnt_month
            // 
            this.compnt_month.FormattingEnabled = true;
            this.compnt_month.Items.AddRange(new object[] {
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
            this.compnt_month.Location = new System.Drawing.Point(353, 12);
            this.compnt_month.Name = "compnt_month";
            this.compnt_month.Size = new System.Drawing.Size(44, 21);
            this.compnt_month.TabIndex = 51;
            this.compnt_month.Text = "1";
            this.compnt_month.SelectedIndexChanged += new System.EventHandler(this.field_month_SelectedIndexChanged);
            // 
            // compnt_ID
            // 
            this.compnt_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.compnt_ID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "EmployeeID", true));
            this.compnt_ID.DataSource = this.employeeBindingSource2;
            this.compnt_ID.DisplayMember = "EmployeeID";
            this.compnt_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compnt_ID.FormattingEnabled = true;
            this.compnt_ID.Location = new System.Drawing.Point(105, 12);
            this.compnt_ID.Name = "compnt_ID";
            this.compnt_ID.Size = new System.Drawing.Size(129, 21);
            this.compnt_ID.TabIndex = 50;
            this.compnt_ID.ValueMember = "EmployeeID";
            this.compnt_ID.SelectedIndexChanged += new System.EventHandler(this.compnt_guardName_SelectedIndexChanged);
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.empdetaild;
            // 
            // compnt_show
            // 
            this.compnt_show.Location = new System.Drawing.Point(522, 12);
            this.compnt_show.Name = "compnt_show";
            this.compnt_show.Size = new System.Drawing.Size(98, 23);
            this.compnt_show.TabIndex = 49;
            this.compnt_show.Text = "&Calculate && Show";
            this.compnt_show.UseVisualStyleBackColor = true;
            this.compnt_show.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Guard ID:";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.empdetaild;
            // 
            // relB0B6D8CD81424208BindingSource
            // 
            this.relB0B6D8CD81424208BindingSource.DataMember = "Rel_B0B6D8CD_8142_4208";
            this.relB0B6D8CD81424208BindingSource.DataSource = this.employeeBindingSource1;
            // 
            // securityGuardTableAdapter
            // 
            this.securityGuardTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ABC_Security_Company_InfoSys.Properties.Resources.payslipindi;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 104);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // paySlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "paySlipForm";
            this.Text = "Payslip Form ::";
            this.Load += new System.EventHandler(this.paySlipForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetaild)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compnt_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Security_dbDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relB0B6D8CD81424208BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox compnt_totalHWorkd;
        private System.Windows.Forms.TextBox compnt_Tax;
        private System.Windows.Forms.TextBox compnt_NI;
        private System.Windows.Forms.TextBox compnt_Earned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView compnt_Grid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox compnt_ID;
        private System.Windows.Forms.Button compnt_show;
        private System.Windows.Forms.Label label1;
        private empdetaild empdetaild;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ABC_Security_Company_InfoSys.empdetaildTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox compnt_guardName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox compnt_year;
        private System.Windows.Forms.ComboBox compnt_month;
        private ABC_Security_dbDataSet aBC_Security_dbDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private ABC_Security_Company_InfoSys.ABC_Security_dbDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daydeployDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthdeployDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeardeployDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEarnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niDeductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDeductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.BindingSource relB0B6D8CD81424208BindingSource;
        private ABC_Security_Company_InfoSys.empdetaildTableAdapters.SecurityGuardTableAdapter securityGuardTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}