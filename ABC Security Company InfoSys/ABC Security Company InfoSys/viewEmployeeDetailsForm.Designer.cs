namespace ABC_Security_Company_InfoSys
{
    partial class viewEmployeeDetailsForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.compt_dataGrid = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empdetaildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empdetaild = new ABC_Security_Company_InfoSys.empdetaild();
            this.label1 = new System.Windows.Forms.Label();
            this.compnt__empBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.compnt__gender = new System.Windows.Forms.ComboBox();
            this.compnt__dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compnt__name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.compnt__phoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.compnt__hourlyrate = new System.Windows.Forms.TextBox();
            this.compnt__address = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeTableAdapter = new ABC_Security_Company_InfoSys.empdetaildTableAdapters.EmployeeTableAdapter();
            this.relB0B6D8CD81424208BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityGuardTableAdapter = new ABC_Security_Company_InfoSys.empdetaildTableAdapters.SecurityGuardTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compt_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetaildBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetaild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relB0B6D8CD81424208BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Location = new System.Drawing.Point(50, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(910, 311);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.compt_dataGrid);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.compnt__empBox);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(0, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1010, 507);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // compt_dataGrid
            // 
            this.compt_dataGrid.AllowUserToOrderColumns = true;
            this.compt_dataGrid.AutoGenerateColumns = false;
            this.compt_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compt_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.dojDataGridViewTextBoxColumn});
            this.compt_dataGrid.DataSource = this.employeeBindingSource;
            this.compt_dataGrid.Location = new System.Drawing.Point(9, 186);
            this.compt_dataGrid.Name = "compt_dataGrid";
            this.compt_dataGrid.Size = new System.Drawing.Size(802, 281);
            this.compt_dataGrid.TabIndex = 9;
            this.compt_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.compt_dataGrid_CellContentClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 70;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Width = 80;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // dojDataGridViewTextBoxColumn
            // 
            this.dojDataGridViewTextBoxColumn.DataPropertyName = "doj";
            this.dojDataGridViewTextBoxColumn.HeaderText = "doj";
            this.dojDataGridViewTextBoxColumn.Name = "dojDataGridViewTextBoxColumn";
            this.dojDataGridViewTextBoxColumn.Width = 70;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.empdetaildBindingSource;
            // 
            // empdetaildBindingSource
            // 
            this.empdetaildBindingSource.DataSource = this.empdetaild;
            this.empdetaildBindingSource.Position = 0;
            // 
            // empdetaild
            // 
            this.empdetaild.DataSetName = "empdetaild";
            this.empdetaild.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Name:";
            // 
            // compnt__empBox
            // 
            this.compnt__empBox.DataSource = this.employeeBindingSource1;
            this.compnt__empBox.DisplayMember = "Name";
            this.compnt__empBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compnt__empBox.FormattingEnabled = true;
            this.compnt__empBox.Location = new System.Drawing.Point(113, 25);
            this.compnt__empBox.Name = "compnt__empBox";
            this.compnt__empBox.Size = new System.Drawing.Size(233, 21);
            this.compnt__empBox.TabIndex = 7;
            this.compnt__empBox.ValueMember = "Name";
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.empdetaildBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(24, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.compnt__gender);
            this.panel2.Controls.Add(this.compnt__dob);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.compnt__name);
            this.panel2.Location = new System.Drawing.Point(17, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 92);
            this.panel2.TabIndex = 21;
            // 
            // compnt__gender
            // 
            this.compnt__gender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Gender", true));
            this.compnt__gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compnt__gender.FormattingEnabled = true;
            this.compnt__gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.compnt__gender.Location = new System.Drawing.Point(80, 36);
            this.compnt__gender.Name = "compnt__gender";
            this.compnt__gender.Size = new System.Drawing.Size(158, 21);
            this.compnt__gender.TabIndex = 19;
            // 
            // compnt__dob
            // 
            this.compnt__dob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "dob", true));
            this.compnt__dob.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource1, "dob", true));
            this.compnt__dob.Location = new System.Drawing.Point(80, 63);
            this.compnt__dob.Name = "compnt__dob";
            this.compnt__dob.Size = new System.Drawing.Size(191, 20);
            this.compnt__dob.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dob:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name:";
            // 
            // compnt__name
            // 
            this.compnt__name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Name", true));
            this.compnt__name.Location = new System.Drawing.Point(80, 10);
            this.compnt__name.Name = "compnt__name";
            this.compnt__name.ReadOnly = true;
            this.compnt__name.Size = new System.Drawing.Size(196, 20);
            this.compnt__name.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.compnt__phoneNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.compnt__hourlyrate);
            this.panel1.Controls.Add(this.compnt__address);
            this.panel1.Location = new System.Drawing.Point(309, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 92);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Phone no. :";
            // 
            // compnt__phoneNumber
            // 
            this.compnt__phoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "PhoneNumber", true));
            this.compnt__phoneNumber.Location = new System.Drawing.Point(77, 62);
            this.compnt__phoneNumber.Name = "compnt__phoneNumber";
            this.compnt__phoneNumber.ReadOnly = true;
            this.compnt__phoneNumber.Size = new System.Drawing.Size(191, 20);
            this.compnt__phoneNumber.TabIndex = 24;
            this.compnt__phoneNumber.TextChanged += new System.EventHandler(this.compnt__phoneNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "HourlyRate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Address:";
            // 
            // compnt__hourlyrate
            // 
            this.compnt__hourlyrate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "PostCode", true));
            this.compnt__hourlyrate.Location = new System.Drawing.Point(77, 36);
            this.compnt__hourlyrate.Name = "compnt__hourlyrate";
            this.compnt__hourlyrate.ReadOnly = true;
            this.compnt__hourlyrate.Size = new System.Drawing.Size(191, 20);
            this.compnt__hourlyrate.TabIndex = 21;
            // 
            // compnt__address
            // 
            this.compnt__address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Address", true));
            this.compnt__address.Location = new System.Drawing.Point(78, 10);
            this.compnt__address.Name = "compnt__address";
            this.compnt__address.ReadOnly = true;
            this.compnt__address.Size = new System.Drawing.Size(191, 20);
            this.compnt__address.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ABC_Security_Company_InfoSys.Properties.Resources.viewdetails;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 121);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
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
            // viewEmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "viewEmployeeDetailsForm";
            this.Text = "View Employee Details ::";
            this.Load += new System.EventHandler(this.viewEmployeeDetails_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compt_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetaildBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetaild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relB0B6D8CD81424208BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox compnt__empBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox compnt__gender;
        private System.Windows.Forms.DateTimePicker compnt__dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox compnt__name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox compnt__phoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox compnt__hourlyrate;
        private System.Windows.Forms.TextBox compnt__address;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView compt_dataGrid;
        private System.Windows.Forms.BindingSource empdetaildBindingSource;
        private empdetaild empdetaild;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ABC_Security_Company_InfoSys.empdetaildTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dojDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource relB0B6D8CD81424208BindingSource;
        private ABC_Security_Company_InfoSys.empdetaildTableAdapters.SecurityGuardTableAdapter securityGuardTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
    }
}