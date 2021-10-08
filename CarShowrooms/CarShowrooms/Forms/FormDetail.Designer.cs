namespace CarShowrooms.Forms
{
    partial class FormDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetail));
            this.LbDetails = new System.Windows.Forms.ListBox();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.TbDeteilType = new System.Windows.Forms.TextBox();
            this.TbDetailNumber = new System.Windows.Forms.TextBox();
            this.numericUpDownDetailMass = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDetailModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnExitDetails = new System.Windows.Forms.Button();
            this.btnEditDetail = new System.Windows.Forms.Button();
            this.btnRenoveDetail = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotalDetails = new System.Windows.Forms.Label();
            this.btnTotalDetails = new System.Windows.Forms.Button();
            this.lbCars2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailMass)).BeginInit();
            this.SuspendLayout();
            // 
            // LbDetails
            // 
            this.LbDetails.FormattingEnabled = true;
            this.LbDetails.Location = new System.Drawing.Point(24, 27);
            this.LbDetails.Name = "LbDetails";
            this.LbDetails.Size = new System.Drawing.Size(285, 134);
            this.LbDetails.TabIndex = 0;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(324, 133);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddDetail.TabIndex = 1;
            this.btnAddDetail.Text = "Add detail";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // TbDeteilType
            // 
            this.TbDeteilType.Location = new System.Drawing.Point(333, 25);
            this.TbDeteilType.Name = "TbDeteilType";
            this.TbDeteilType.Size = new System.Drawing.Size(100, 20);
            this.TbDeteilType.TabIndex = 2;
            // 
            // TbDetailNumber
            // 
            this.TbDetailNumber.Location = new System.Drawing.Point(333, 51);
            this.TbDetailNumber.Name = "TbDetailNumber";
            this.TbDetailNumber.Size = new System.Drawing.Size(100, 20);
            this.TbDetailNumber.TabIndex = 3;
            // 
            // numericUpDownDetailMass
            // 
            this.numericUpDownDetailMass.Location = new System.Drawing.Point(333, 77);
            this.numericUpDownDetailMass.Name = "numericUpDownDetailMass";
            this.numericUpDownDetailMass.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDetailMass.TabIndex = 4;
            // 
            // comboBoxDetailModel
            // 
            this.comboBoxDetailModel.FormattingEnabled = true;
            this.comboBoxDetailModel.Location = new System.Drawing.Point(332, 103);
            this.comboBoxDetailModel.Name = "comboBoxDetailModel";
            this.comboBoxDetailModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDetailModel.TabIndex = 5;
            this.comboBoxDetailModel.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(474, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Detail type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(474, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Detail number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(474, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "To model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(474, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mass (kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(113, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "List details";
            // 
            // BtnExitDetails
            // 
            this.BtnExitDetails.Location = new System.Drawing.Point(874, -1);
            this.BtnExitDetails.Name = "BtnExitDetails";
            this.BtnExitDetails.Size = new System.Drawing.Size(35, 23);
            this.BtnExitDetails.TabIndex = 19;
            this.BtnExitDetails.Text = "Exit";
            this.BtnExitDetails.UseVisualStyleBackColor = true;
            this.BtnExitDetails.Click += new System.EventHandler(this.BtnExitDetails_Click);
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Location = new System.Drawing.Point(405, 133);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(75, 23);
            this.btnEditDetail.TabIndex = 20;
            this.btnEditDetail.Text = "Edit Detail";
            this.btnEditDetail.UseVisualStyleBackColor = true;
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // btnRenoveDetail
            // 
            this.btnRenoveDetail.Location = new System.Drawing.Point(487, 133);
            this.btnRenoveDetail.Name = "btnRenoveDetail";
            this.btnRenoveDetail.Size = new System.Drawing.Size(83, 23);
            this.btnRenoveDetail.TabIndex = 21;
            this.btnRenoveDetail.Text = "Remove detail";
            this.btnRenoveDetail.UseVisualStyleBackColor = true;
            this.btnRenoveDetail.Click += new System.EventHandler(this.btnRenoveDetail_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(691, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "List cars";
            // 
            // labelTotalDetails
            // 
            this.labelTotalDetails.AutoSize = true;
            this.labelTotalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalDetails.Location = new System.Drawing.Point(128, 170);
            this.labelTotalDetails.Name = "labelTotalDetails";
            this.labelTotalDetails.Size = new System.Drawing.Size(16, 17);
            this.labelTotalDetails.TabIndex = 24;
            this.labelTotalDetails.Text = "0";
            // 
            // btnTotalDetails
            // 
            this.btnTotalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTotalDetails.Location = new System.Drawing.Point(24, 167);
            this.btnTotalDetails.Name = "btnTotalDetails";
            this.btnTotalDetails.Size = new System.Drawing.Size(98, 23);
            this.btnTotalDetails.TabIndex = 25;
            this.btnTotalDetails.Text = "Total Details";
            this.btnTotalDetails.UseVisualStyleBackColor = true;
            this.btnTotalDetails.Click += new System.EventHandler(this.btnTotalDetails_Click);
            // 
            // lbCars2
            // 
            this.lbCars2.FormattingEnabled = true;
            this.lbCars2.Location = new System.Drawing.Point(592, 28);
            this.lbCars2.Name = "lbCars2";
            this.lbCars2.Size = new System.Drawing.Size(285, 134);
            this.lbCars2.TabIndex = 27;
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(911, 236);
            this.Controls.Add(this.lbCars2);
            this.Controls.Add(this.btnTotalDetails);
            this.Controls.Add(this.labelTotalDetails);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRenoveDetail);
            this.Controls.Add(this.btnEditDetail);
            this.Controls.Add(this.BtnExitDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDetailModel);
            this.Controls.Add(this.numericUpDownDetailMass);
            this.Controls.Add(this.TbDetailNumber);
            this.Controls.Add(this.TbDeteilType);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.LbDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDetail";
            this.Text = "Detail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDetail_FormClosed);
            this.Load += new System.EventHandler(this.FormDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbDetails;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.TextBox TbDeteilType;
        private System.Windows.Forms.TextBox TbDetailNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownDetailMass;
        private System.Windows.Forms.ComboBox comboBoxDetailModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnExitDetails;
        private System.Windows.Forms.Button btnEditDetail;
        private System.Windows.Forms.Button btnRenoveDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotalDetails;
        private System.Windows.Forms.Button btnTotalDetails;
        private System.Windows.Forms.ListBox lbCars2;
    }
}