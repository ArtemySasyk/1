namespace FactoryWinForm
{
    partial class AEFuturaInfoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.numericUpDown_totalSum = new System.Windows.Forms.NumericUpDown();
            this.label_totalSum = new System.Windows.Forms.Label();
            this.label_product = new System.Windows.Forms.Label();
            this.numericUpDown_nounce = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_action = new System.Windows.Forms.Button();
            this.label_nounce = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_totalSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nounce)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_product);
            this.panel1.Controls.Add(this.numericUpDown_totalSum);
            this.panel1.Controls.Add(this.label_totalSum);
            this.panel1.Controls.Add(this.label_product);
            this.panel1.Controls.Add(this.numericUpDown_nounce);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_action);
            this.panel1.Controls.Add(this.label_nounce);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 316);
            this.panel1.TabIndex = 2;
            // 
            // comboBox_product
            // 
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(146, 88);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(229, 28);
            this.comboBox_product.TabIndex = 0;
            // 
            // numericUpDown_totalSum
            // 
            this.numericUpDown_totalSum.Location = new System.Drawing.Point(224, 189);
            this.numericUpDown_totalSum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_totalSum.Name = "numericUpDown_totalSum";
            this.numericUpDown_totalSum.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_totalSum.TabIndex = 10;
            // 
            // label_totalSum
            // 
            this.label_totalSum.AutoSize = true;
            this.label_totalSum.Location = new System.Drawing.Point(37, 192);
            this.label_totalSum.Name = "label_totalSum";
            this.label_totalSum.Size = new System.Drawing.Size(48, 20);
            this.label_totalSum.TabIndex = 11;
            this.label_totalSum.Text = "Цена:";
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Location = new System.Drawing.Point(33, 92);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(54, 20);
            this.label_product.TabIndex = 4;
            this.label_product.Text = "Товар:";
            // 
            // numericUpDown_nounce
            // 
            this.numericUpDown_nounce.Location = new System.Drawing.Point(146, 139);
            this.numericUpDown_nounce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown_nounce.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_nounce.Name = "numericUpDown_nounce";
            this.numericUpDown_nounce.Size = new System.Drawing.Size(230, 27);
            this.numericUpDown_nounce.TabIndex = 2;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(262, 248);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(114, 40);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(37, 248);
            this.button_action.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(114, 40);
            this.button_action.TabIndex = 3;
            this.button_action.Text = "Добавить";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // label_nounce
            // 
            this.label_nounce.AutoSize = true;
            this.label_nounce.Location = new System.Drawing.Point(37, 139);
            this.label_nounce.Name = "label_nounce";
            this.label_nounce.Size = new System.Drawing.Size(93, 20);
            this.label_nounce.TabIndex = 0;
            this.label_nounce.Text = "Количество:";
            // 
            // AEFuturaInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 348);
            this.Controls.Add(this.panel1);
            this.Name = "AEFuturaInfoForm";
            this.Text = "AEFuturaInfoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_totalSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nounce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label_product;
        private NumericUpDown numericUpDown_nounce;
        private Button button_cancel;
        private Button button_action;
        private Label label_nounce;
        private NumericUpDown numericUpDown_totalSum;
        private Label label_totalSum;
        private ComboBox comboBox_product;
    }
}