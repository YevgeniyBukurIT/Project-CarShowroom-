namespace CarShowrooms.Forms
{
    partial class FormSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeller));
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbSellers = new System.Windows.Forms.ListBox();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.btnSeller = new System.Windows.Forms.Button();
            this.labelGetSalaryMounth = new System.Windows.Forms.Label();
            this.labelGetSalaryYear = new System.Windows.Forms.Label();
            this.labelTotalSellers = new System.Windows.Forms.Label();
            this.btnTotalSellers = new System.Windows.Forms.Button();
            this.btnGetSallary = new System.Windows.Forms.Button();
            this.btnDeleteSeller = new System.Windows.Forms.Button();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExitSeller = new System.Windows.Forms.Button();
            this.btnEditSeller = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownnumberOfCarsSold = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.lbShowrooms2 = new System.Windows.Forms.ListBox();
            this.btnAddSellerTo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnumberOfCarsSold)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(311, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 20);
            this.tbName.TabIndex = 0;
            // 
            // lbSellers
            // 
            this.lbSellers.FormattingEnabled = true;
            this.lbSellers.Location = new System.Drawing.Point(24, 30);
            this.lbSellers.Name = "lbSellers";
            this.lbSellers.Size = new System.Drawing.Size(281, 160);
            this.lbSellers.TabIndex = 1;
            // 
            // tbSurName
            // 
            this.tbSurName.Location = new System.Drawing.Point(311, 56);
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(120, 20);
            this.tbSurName.TabIndex = 2;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(311, 83);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 3;
            this.comboBoxSex.Text = "Sex";
            // 
            // btnSeller
            // 
            this.btnSeller.Location = new System.Drawing.Point(312, 164);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(75, 23);
            this.btnSeller.TabIndex = 6;
            this.btnSeller.Text = "Add seller";
            this.btnSeller.UseVisualStyleBackColor = true;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // labelGetSalaryMounth
            // 
            this.labelGetSalaryMounth.AutoSize = true;
            this.labelGetSalaryMounth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGetSalaryMounth.Location = new System.Drawing.Point(147, 304);
            this.labelGetSalaryMounth.Name = "labelGetSalaryMounth";
            this.labelGetSalaryMounth.Size = new System.Drawing.Size(16, 17);
            this.labelGetSalaryMounth.TabIndex = 8;
            this.labelGetSalaryMounth.Text = "0";
            // 
            // labelGetSalaryYear
            // 
            this.labelGetSalaryYear.AutoSize = true;
            this.labelGetSalaryYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGetSalaryYear.Location = new System.Drawing.Point(147, 329);
            this.labelGetSalaryYear.Name = "labelGetSalaryYear";
            this.labelGetSalaryYear.Size = new System.Drawing.Size(16, 17);
            this.labelGetSalaryYear.TabIndex = 9;
            this.labelGetSalaryYear.Text = "0";
            // 
            // labelTotalSellers
            // 
            this.labelTotalSellers.AutoSize = true;
            this.labelTotalSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSellers.Location = new System.Drawing.Point(136, 199);
            this.labelTotalSellers.Name = "labelTotalSellers";
            this.labelTotalSellers.Size = new System.Drawing.Size(16, 17);
            this.labelTotalSellers.TabIndex = 10;
            this.labelTotalSellers.Text = "0";
            // 
            // btnTotalSellers
            // 
            this.btnTotalSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTotalSellers.Location = new System.Drawing.Point(24, 196);
            this.btnTotalSellers.Name = "btnTotalSellers";
            this.btnTotalSellers.Size = new System.Drawing.Size(102, 23);
            this.btnTotalSellers.TabIndex = 11;
            this.btnTotalSellers.Text = "TotalSellers";
            this.btnTotalSellers.UseVisualStyleBackColor = true;
            this.btnTotalSellers.Click += new System.EventHandler(this.btnTotalSellers_Click);
            // 
            // btnGetSallary
            // 
            this.btnGetSallary.Location = new System.Drawing.Point(216, 266);
            this.btnGetSallary.Name = "btnGetSallary";
            this.btnGetSallary.Size = new System.Drawing.Size(75, 23);
            this.btnGetSallary.TabIndex = 12;
            this.btnGetSallary.Text = "GetSalary";
            this.btnGetSallary.UseVisualStyleBackColor = true;
            this.btnGetSallary.Click += new System.EventHandler(this.btnGetSallary_Click);
            // 
            // btnDeleteSeller
            // 
            this.btnDeleteSeller.Location = new System.Drawing.Point(474, 164);
            this.btnDeleteSeller.Name = "btnDeleteSeller";
            this.btnDeleteSeller.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSeller.TabIndex = 13;
            this.btnDeleteSeller.Text = "Delete seller";
            this.btnDeleteSeller.UseVisualStyleBackColor = true;
            this.btnDeleteSeller.Click += new System.EventHandler(this.btnDeleteSeller_Click);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(312, 111);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAge.TabIndex = 14;
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(312, 137);
            this.maskedTextBoxPhoneNumber.Mask = "+(380) 00-000-00-00";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(438, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(438, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(438, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(438, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(438, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(122, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Get salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(88, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Month";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(88, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(117, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "List sellers";
            // 
            // btnExitSeller
            // 
            this.btnExitSeller.Location = new System.Drawing.Point(844, 6);
            this.btnExitSeller.Name = "btnExitSeller";
            this.btnExitSeller.Size = new System.Drawing.Size(31, 23);
            this.btnExitSeller.TabIndex = 26;
            this.btnExitSeller.Text = "Exit";
            this.btnExitSeller.UseVisualStyleBackColor = true;
            this.btnExitSeller.Click += new System.EventHandler(this.btnExitSeller_Click);
            // 
            // btnEditSeller
            // 
            this.btnEditSeller.Location = new System.Drawing.Point(393, 164);
            this.btnEditSeller.Name = "btnEditSeller";
            this.btnEditSeller.Size = new System.Drawing.Size(75, 23);
            this.btnEditSeller.TabIndex = 27;
            this.btnEditSeller.Text = "Edit seller";
            this.btnEditSeller.UseVisualStyleBackColor = true;
            this.btnEditSeller.Click += new System.EventHandler(this.btnEditSeller_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(676, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "List showrooms";
            // 
            // numericUpDownnumberOfCarsSold
            // 
            this.numericUpDownnumberOfCarsSold.Location = new System.Drawing.Point(85, 269);
            this.numericUpDownnumberOfCarsSold.Name = "numericUpDownnumberOfCarsSold";
            this.numericUpDownnumberOfCarsSold.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownnumberOfCarsSold.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Cars sold";
            // 
            // lbShowrooms2
            // 
            this.lbShowrooms2.FormattingEnabled = true;
            this.lbShowrooms2.Location = new System.Drawing.Point(582, 32);
            this.lbShowrooms2.Name = "lbShowrooms2";
            this.lbShowrooms2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbShowrooms2.Size = new System.Drawing.Size(281, 160);
            this.lbShowrooms2.TabIndex = 35;
            this.lbShowrooms2.SelectedIndexChanged += new System.EventHandler(this.lbShowrooms2_SelectedIndexChanged);
            // 
            // btnAddSellerTo
            // 
            this.btnAddSellerTo.Location = new System.Drawing.Point(311, 193);
            this.btnAddSellerTo.Name = "btnAddSellerTo";
            this.btnAddSellerTo.Size = new System.Drawing.Size(75, 23);
            this.btnAddSellerTo.TabIndex = 36;
            this.btnAddSellerTo.Text = "Add also";
            this.btnAddSellerTo.UseVisualStyleBackColor = true;
            this.btnAddSellerTo.Click += new System.EventHandler(this.btnAddSellerTo_Click);
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 385);
            this.Controls.Add(this.btnAddSellerTo);
            this.Controls.Add(this.lbShowrooms2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDownnumberOfCarsSold);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEditSeller);
            this.Controls.Add(this.btnExitSeller);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.btnDeleteSeller);
            this.Controls.Add(this.btnGetSallary);
            this.Controls.Add(this.btnTotalSellers);
            this.Controls.Add(this.labelTotalSellers);
            this.Controls.Add(this.labelGetSalaryYear);
            this.Controls.Add(this.labelGetSalaryMounth);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.tbSurName);
            this.Controls.Add(this.lbSellers);
            this.Controls.Add(this.tbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSeller";
            this.Text = "Seller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSeller_FormClosed);
            this.Load += new System.EventHandler(this.FormSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnumberOfCarsSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lbSellers;
        private System.Windows.Forms.TextBox tbSurName;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Label labelGetSalaryMounth;
        private System.Windows.Forms.Label labelGetSalaryYear;
        private System.Windows.Forms.Label labelTotalSellers;
        private System.Windows.Forms.Button btnTotalSellers;
        private System.Windows.Forms.Button btnGetSallary;
        private System.Windows.Forms.Button btnDeleteSeller;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExitSeller;
        private System.Windows.Forms.Button btnEditSeller;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownnumberOfCarsSold;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbShowrooms2;
        private System.Windows.Forms.Button btnAddSellerTo;
    }
}