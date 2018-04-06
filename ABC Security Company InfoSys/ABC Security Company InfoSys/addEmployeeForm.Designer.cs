namespace ABC_Security_Company_InfoSys
{
    partial class addEmployeeForm
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
            this.compnt__gender = new System.Windows.Forms.ComboBox();
            this.compnt__dob = new System.Windows.Forms.DateTimePicker();
            this.compnt_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compnt_hourlyrate = new System.Windows.Forms.TextBox();
            this.compnt__address = new System.Windows.Forms.TextBox();
            this.compnt__name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.compnt_postcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.compnt_phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.compnt__eid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // compnt__gender
            // 
            this.compnt__gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compnt__gender.FormattingEnabled = true;
            this.compnt__gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.compnt__gender.Location = new System.Drawing.Point(121, 193);
            this.compnt__gender.Name = "compnt__gender";
            this.compnt__gender.Size = new System.Drawing.Size(79, 21);
            this.compnt__gender.TabIndex = 2;
            // 
            // compnt__dob
            // 
            this.compnt__dob.Location = new System.Drawing.Point(121, 230);
            this.compnt__dob.Name = "compnt__dob";
            this.compnt__dob.Size = new System.Drawing.Size(191, 20);
            this.compnt__dob.TabIndex = 3;
            // 
            // compnt_Save
            // 
            this.compnt_Save.Location = new System.Drawing.Point(121, 426);
            this.compnt_Save.Name = "compnt_Save";
            this.compnt_Save.Size = new System.Drawing.Size(102, 43);
            this.compnt_Save.TabIndex = 8;
            this.compnt_Save.Text = "&Save";
            this.compnt_Save.UseVisualStyleBackColor = true;
            this.compnt_Save.Click += new System.EventHandler(this.compnt_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "HourlyRate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dob:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // compnt_hourlyrate
            // 
            this.compnt_hourlyrate.Location = new System.Drawing.Point(121, 387);
            this.compnt_hourlyrate.Name = "compnt_hourlyrate";
            this.compnt_hourlyrate.Size = new System.Drawing.Size(196, 20);
            this.compnt_hourlyrate.TabIndex = 7;
            this.compnt_hourlyrate.TextChanged += new System.EventHandler(this.compnt_hourlyrate_TextChanged);
            this.compnt_hourlyrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compnt_hourlyrate_KeyPress);
            // 
            // compnt__address
            // 
            this.compnt__address.Location = new System.Drawing.Point(121, 266);
            this.compnt__address.Multiline = true;
            this.compnt__address.Name = "compnt__address";
            this.compnt__address.Size = new System.Drawing.Size(191, 33);
            this.compnt__address.TabIndex = 4;
            this.compnt__address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compnt__address_KeyPress);
            // 
            // compnt__name
            // 
            this.compnt__name.Location = new System.Drawing.Point(121, 157);
            this.compnt__name.Name = "compnt__name";
            this.compnt__name.Size = new System.Drawing.Size(191, 20);
            this.compnt__name.TabIndex = 1;
            this.compnt__name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compnt__name_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABC_Security_Company_InfoSys.Properties.Resources.Addguard;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // compnt_postcode
            // 
            this.compnt_postcode.Location = new System.Drawing.Point(121, 315);
            this.compnt_postcode.Name = "compnt_postcode";
            this.compnt_postcode.Size = new System.Drawing.Size(191, 20);
            this.compnt_postcode.TabIndex = 5;
            this.compnt_postcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compnt_postcode_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Post Code:";
            // 
            // compnt_phone
            // 
            this.compnt_phone.Location = new System.Drawing.Point(121, 351);
            this.compnt_phone.Name = "compnt_phone";
            this.compnt_phone.Size = new System.Drawing.Size(191, 20);
            this.compnt_phone.TabIndex = 6;
            this.compnt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compnt_phone_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Phone no. :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Employee ID:";
            // 
            // compnt__eid
            // 
            this.compnt__eid.Location = new System.Drawing.Point(121, 131);
            this.compnt__eid.Name = "compnt__eid";
            this.compnt__eid.Size = new System.Drawing.Size(191, 20);
            this.compnt__eid.TabIndex = 0;
            // 
            // addEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 494);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.compnt__eid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.compnt_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.compnt_postcode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.compnt__gender);
            this.Controls.Add(this.compnt__dob);
            this.Controls.Add(this.compnt_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compnt_hourlyrate);
            this.Controls.Add(this.compnt__address);
            this.Controls.Add(this.compnt__name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addEmployeeForm";
            this.Text = "Add Employee ::";
            this.Load += new System.EventHandler(this.addEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox compnt__gender;
        private System.Windows.Forms.DateTimePicker compnt__dob;
        private System.Windows.Forms.Button compnt_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox compnt_hourlyrate;
        private System.Windows.Forms.TextBox compnt__address;
        private System.Windows.Forms.TextBox compnt__name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox compnt_postcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox compnt_phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox compnt__eid;
    }
}