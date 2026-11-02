namespace Fedorova
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows Forms

        private void InitializeComponent()
        {
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.userControl11 = new Fedorova.UserControl1();
            this.userControl12 = new Fedorova.UserControl1();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.numericMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxPrice)).BeginInit();
            this.SuspendLayout();
            //
            // buttonLeft
            //
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonLeft.Location = new System.Drawing.Point(12, 200);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(65, 300);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            //
            // buttonRight
            //
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonRight.Location = new System.Drawing.Point(928, 200);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(65, 300);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            //
            // userControl11
            //
            this.userControl11.Location = new System.Drawing.Point(95, 50);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(405, 490);
            this.userControl11.TabIndex = 2;
            //
            // userControl12
            //
            this.userControl12.Location = new System.Drawing.Point(510, 50);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(405, 490);
            this.userControl12.TabIndex = 3;
            //
            // labelBrand
            //
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(95, 16);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(43, 13);
            this.labelBrand.TabIndex = 4;
            this.labelBrand.Text = "Марка:";
            //
            // comboBoxBrand
            //
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(145, 12);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(160, 21);
            this.comboBoxBrand.TabIndex = 5;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            //
            // labelMaxPrice
            //
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(325, 16);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(51, 13);
            this.labelMaxPrice.TabIndex = 6;
            this.labelMaxPrice.Text = "Цена до:";
            //
            // numericMaxPrice
            //
            this.numericMaxPrice.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numericMaxPrice.Location = new System.Drawing.Point(382, 13);
            this.numericMaxPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numericMaxPrice.Name = "numericMaxPrice";
            this.numericMaxPrice.Size = new System.Drawing.Size(110, 20);
            this.numericMaxPrice.TabIndex = 7;
            this.numericMaxPrice.ThousandsSeparator = true;
            this.numericMaxPrice.ValueChanged += new System.EventHandler(this.numericMaxPrice_ValueChanged);
            //
            // buttonReset
            //
            this.buttonReset.Location = new System.Drawing.Point(510, 11);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(110, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Сбросить фильтр";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            //
            // labelCount
            //
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(640, 16);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 13);
            this.labelCount.TabIndex = 9;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 555);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.numericMaxPrice);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мотоциклы - Fedorova";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.NumericUpDown numericMaxPrice;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelCount;
    }
}
