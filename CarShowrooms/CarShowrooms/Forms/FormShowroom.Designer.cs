namespace CarShowrooms
{
    partial class FormShowroom
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowroom));
            this.AppEx = new System.Windows.Forms.Button();
            this.TbNameSwrms = new System.Windows.Forms.TextBox();
            this.BtShwrm = new System.Windows.Forms.Button();
            this.LbShwrm = new System.Windows.Forms.ListBox();
            this.LablShwrm = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.buttonTotalShwrm = new System.Windows.Forms.Button();
            this.labelTatolShwrm = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.numericUpDownRaiting = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumberPlaceOfCars = new System.Windows.Forms.NumericUpDown();
            this.btnEditShwrm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveShwrm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRaiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberPlaceOfCars)).BeginInit();
            this.SuspendLayout();
            // 
            // AppEx
            // 
            this.AppEx.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AppEx.Location = new System.Drawing.Point(540, 5);
            this.AppEx.Name = "AppEx";
            this.AppEx.Size = new System.Drawing.Size(41, 26);
            this.AppEx.TabIndex = 4;
            this.AppEx.Text = "Exit";
            this.AppEx.UseVisualStyleBackColor = true;
            this.AppEx.Click += new System.EventHandler(this.AppEx_Click);
            // 
            // TbNameSwrms
            // 
            this.TbNameSwrms.AccessibleDescription = "";
            this.TbNameSwrms.AccessibleName = "";
            this.TbNameSwrms.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TbNameSwrms.Location = new System.Drawing.Point(237, 23);
            this.TbNameSwrms.Name = "TbNameSwrms";
            this.TbNameSwrms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TbNameSwrms.Size = new System.Drawing.Size(116, 20);
            this.TbNameSwrms.TabIndex = 5;
            this.TbNameSwrms.Tag = "";
            // 
            // BtShwrm
            // 
            this.BtShwrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtShwrm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtShwrm.Location = new System.Drawing.Point(233, 127);
            this.BtShwrm.Name = "BtShwrm";
            this.BtShwrm.Size = new System.Drawing.Size(95, 43);
            this.BtShwrm.TabIndex = 8;
            this.BtShwrm.Text = "Add Showrooms";
            this.BtShwrm.UseVisualStyleBackColor = true;
            this.BtShwrm.Click += new System.EventHandler(this.BtShwrm_Click);
            // 
            // LbShwrm
            // 
            this.LbShwrm.FormattingEnabled = true;
            this.LbShwrm.Location = new System.Drawing.Point(12, 21);
            this.LbShwrm.Name = "LbShwrm";
            this.LbShwrm.Size = new System.Drawing.Size(215, 147);
            this.LbShwrm.TabIndex = 9;
            // 
            // LablShwrm
            // 
            this.LablShwrm.AutoSize = true;
            this.LablShwrm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LablShwrm.Location = new System.Drawing.Point(71, 5);
            this.LablShwrm.Name = "LablShwrm";
            this.LablShwrm.Size = new System.Drawing.Size(81, 13);
            this.LablShwrm.TabIndex = 20;
            this.LablShwrm.Text = "List Showrooms";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTotal.Location = new System.Drawing.Point(12, 411);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(0, 25);
            this.LblTotal.TabIndex = 34;
            // 
            // buttonTotalShwrm
            // 
            this.buttonTotalShwrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTotalShwrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTotalShwrm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTotalShwrm.Location = new System.Drawing.Point(12, 174);
            this.buttonTotalShwrm.Name = "buttonTotalShwrm";
            this.buttonTotalShwrm.Size = new System.Drawing.Size(105, 23);
            this.buttonTotalShwrm.TabIndex = 37;
            this.buttonTotalShwrm.Text = "Total Showroom\rs\n";
            this.buttonTotalShwrm.UseVisualStyleBackColor = true;
            this.buttonTotalShwrm.Click += new System.EventHandler(this.buttonTotalShwrm_Click);
            // 
            // labelTatolShwrm
            // 
            this.labelTatolShwrm.AutoSize = true;
            this.labelTatolShwrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTatolShwrm.Location = new System.Drawing.Point(123, 177);
            this.labelTatolShwrm.Name = "labelTatolShwrm";
            this.labelTatolShwrm.Size = new System.Drawing.Size(18, 20);
            this.labelTatolShwrm.TabIndex = 38;
            this.labelTatolShwrm.Text = "0";
            this.labelTatolShwrm.Click += new System.EventHandler(this.labelTatolShwrm_Click);
            // 
            // tbAdress
            // 
            this.tbAdress.AccessibleDescription = "";
            this.tbAdress.AccessibleName = "";
            this.tbAdress.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbAdress.Location = new System.Drawing.Point(237, 49);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAdress.Size = new System.Drawing.Size(116, 20);
            this.tbAdress.TabIndex = 39;
            this.tbAdress.Tag = "";
            // 
            // numericUpDownRaiting
            // 
            this.numericUpDownRaiting.Location = new System.Drawing.Point(237, 76);
            this.numericUpDownRaiting.Name = "numericUpDownRaiting";
            this.numericUpDownRaiting.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRaiting.TabIndex = 40;
            // 
            // numericUpDownNumberPlaceOfCars
            // 
            this.numericUpDownNumberPlaceOfCars.Location = new System.Drawing.Point(237, 101);
            this.numericUpDownNumberPlaceOfCars.Name = "numericUpDownNumberPlaceOfCars";
            this.numericUpDownNumberPlaceOfCars.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumberPlaceOfCars.TabIndex = 41;
            // 
            // btnEditShwrm
            // 
            this.btnEditShwrm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEditShwrm.Location = new System.Drawing.Point(334, 127);
            this.btnEditShwrm.Name = "btnEditShwrm";
            this.btnEditShwrm.Size = new System.Drawing.Size(90, 43);
            this.btnEditShwrm.TabIndex = 43;
            this.btnEditShwrm.Text = "Edit Showrooms";
            this.btnEditShwrm.UseVisualStyleBackColor = true;
            this.btnEditShwrm.Click += new System.EventHandler(this.btnEditShwrm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(370, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Name showroom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(370, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Showroom adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(370, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Showroom raiting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(369, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = " Number Place Of Cars";
            // 
            // btnRemoveShwrm
            // 
            this.btnRemoveShwrm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRemoveShwrm.Location = new System.Drawing.Point(430, 127);
            this.btnRemoveShwrm.Name = "btnRemoveShwrm";
            this.btnRemoveShwrm.Size = new System.Drawing.Size(101, 43);
            this.btnRemoveShwrm.TabIndex = 54;
            this.btnRemoveShwrm.Text = "Remove Showroom\r\n";
            this.btnRemoveShwrm.UseVisualStyleBackColor = true;
            this.btnRemoveShwrm.Click += new System.EventHandler(this.btnRemoveShwrm_Click);
            // 
            // FormShowroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(588, 214);
            this.Controls.Add(this.btnRemoveShwrm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditShwrm);
            this.Controls.Add(this.numericUpDownNumberPlaceOfCars);
            this.Controls.Add(this.numericUpDownRaiting);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.labelTatolShwrm);
            this.Controls.Add(this.buttonTotalShwrm);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LablShwrm);
            this.Controls.Add(this.LbShwrm);
            this.Controls.Add(this.BtShwrm);
            this.Controls.Add(this.TbNameSwrms);
            this.Controls.Add(this.AppEx);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShowroom";
            this.Text = "Base";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRaiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberPlaceOfCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AppEx;
        private System.Windows.Forms.TextBox TbNameSwrms;
        private System.Windows.Forms.Button BtShwrm;
        private System.Windows.Forms.ListBox LbShwrm;
        private System.Windows.Forms.Label LablShwrm;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button buttonTotalShwrm;
        private System.Windows.Forms.Label labelTatolShwrm;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.NumericUpDown numericUpDownRaiting;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberPlaceOfCars;
        private System.Windows.Forms.Button btnEditShwrm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveShwrm;
    }
}

