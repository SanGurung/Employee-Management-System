namespace ABC_Security_Company_InfoSys
{
    partial class monthlyPayslip
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.compnt_NI = new System.Windows.Forms.TextBox();
            this.compnt_Tax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.compnt_hours = new System.Windows.Forms.TextBox();
            this.compnt_Salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compnt_Grid = new System.Windows.Forms.DataGridView();
            this.compnt_show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.compnt_year = new System.Windows.Forms.ComboBox();
            this.compnt_month = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compnt_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "ABC Security Company Detail Monthly Report.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.compnt_NI);
            this.groupBox2.Controls.Add(this.compnt_Tax);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.compnt_hours);
            this.groupBox2.Controls.Add(this.compnt_Salary);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(221, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 95);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // compnt_NI
            // 
            this.compnt_NI.Location = new System.Drawing.Point(397, 53);
            this.compnt_NI.Name = "compnt_NI";
            this.compnt_NI.ReadOnly = true;
            this.compnt_NI.Size = new System.Drawing.Size(100, 20);
            this.compnt_NI.TabIndex = 7;
            // 
            // compnt_Tax
            // 
            this.compnt_Tax.Location = new System.Drawing.Point(397, 21);
            this.compnt_Tax.Name = "compnt_Tax";
            this.compnt_Tax.ReadOnly = true;
            this.compnt_Tax.Size = new System.Drawing.Size(100, 20);
            this.compnt_Tax.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Ni Deduction:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Tax:";
            // 
            // compnt_hours
            // 
            this.compnt_hours.Location = new System.Drawing.Point(149, 53);
            this.compnt_hours.Name = "compnt_hours";
            this.compnt_hours.ReadOnly = true;
            this.compnt_hours.Size = new System.Drawing.Size(117, 20);
            this.compnt_hours.TabIndex = 3;
            // 
            // compnt_Salary
            // 
            this.compnt_Salary.Location = new System.Drawing.Point(149, 21);
            this.compnt_Salary.Name = "compnt_Salary";
            this.compnt_Salary.ReadOnly = true;
            this.compnt_Salary.Size = new System.Drawing.Size(117, 20);
            this.compnt_Salary.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hours of Deployment(Total):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Guards Salary (Total):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.compnt_Grid);
            this.groupBox1.Location = new System.Drawing.Point(14, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 250);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monthly Report Details:";
            // 
            // compnt_Grid
            // 
            this.compnt_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compnt_Grid.Location = new System.Drawing.Point(6, 19);
            this.compnt_Grid.Name = "compnt_Grid";
            this.compnt_Grid.Size = new System.Drawing.Size(706, 211);
            this.compnt_Grid.TabIndex = 0;
            // 
            // compnt_show
            // 
            this.compnt_show.Location = new System.Drawing.Point(30, 156);
            this.compnt_show.Name = "compnt_show";
            this.compnt_show.Size = new System.Drawing.Size(98, 23);
            this.compnt_show.TabIndex = 42;
            this.compnt_show.Text = "&Show";
            this.compnt_show.UseVisualStyleBackColor = true;
            this.compnt_show.Click += new System.EventHandler(this.show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 41;
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
            this.compnt_year.Location = new System.Drawing.Point(154, 129);
            this.compnt_year.Name = "compnt_year";
            this.compnt_year.Size = new System.Drawing.Size(57, 21);
            this.compnt_year.TabIndex = 40;
            this.compnt_year.Text = "2009";
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
            this.compnt_month.Location = new System.Drawing.Point(106, 129);
            this.compnt_month.Name = "compnt_month";
            this.compnt_month.Size = new System.Drawing.Size(44, 21);
            this.compnt_month.TabIndex = 39;
            this.compnt_month.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ABC_Security_Company_InfoSys.Properties.Resources.payslipgroup;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 100);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // monthlyPayslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.compnt_show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compnt_year);
            this.Controls.Add(this.compnt_month);
            this.Name = "monthlyPayslip";
            this.Text = "monthlyPayslip";
            this.Load += new System.EventHandler(this.monthlyPayslip_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compnt_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox compnt_NI;
        private System.Windows.Forms.TextBox compnt_Tax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox compnt_hours;
        private System.Windows.Forms.TextBox compnt_Salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView compnt_Grid;
        private System.Windows.Forms.Button compnt_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox compnt_year;
        private System.Windows.Forms.ComboBox compnt_month;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}