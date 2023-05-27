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
            panel1 = new Panel();
            comboBox_futura = new ComboBox();
            numericUpDown_totalSum = new NumericUpDown();
            label_totalSum = new Label();
            label_product = new Label();
            numericUpDown_nounce = new NumericUpDown();
            button_cancel = new Button();
            button_action = new Button();
            label_nounce = new Label();
            label_futura = new Label();
            comboBox_product = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_totalSum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nounce).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox_product);
            panel1.Controls.Add(comboBox_futura);
            panel1.Controls.Add(numericUpDown_totalSum);
            panel1.Controls.Add(label_totalSum);
            panel1.Controls.Add(label_product);
            panel1.Controls.Add(numericUpDown_nounce);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(button_action);
            panel1.Controls.Add(label_nounce);
            panel1.Controls.Add(label_futura);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 237);
            panel1.TabIndex = 2;
            // 
            // comboBox_futura
            // 
            comboBox_futura.FormattingEnabled = true;
            comboBox_futura.Location = new Point(128, 33);
            comboBox_futura.Margin = new Padding(3, 2, 3, 2);
            comboBox_futura.Name = "comboBox_futura";
            comboBox_futura.Size = new Size(201, 23);
            comboBox_futura.TabIndex = 0;
            // 
            // numericUpDown_totalSum
            // 
            numericUpDown_totalSum.Location = new Point(196, 142);
            numericUpDown_totalSum.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_totalSum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDown_totalSum.Name = "numericUpDown_totalSum";
            numericUpDown_totalSum.Size = new Size(131, 23);
            numericUpDown_totalSum.TabIndex = 10;
            // 
            // label_totalSum
            // 
            label_totalSum.AutoSize = true;
            label_totalSum.Location = new Point(32, 144);
            label_totalSum.Name = "label_totalSum";
            label_totalSum.Size = new Size(38, 15);
            label_totalSum.TabIndex = 11;
            label_totalSum.Text = "Цена:";
            // 
            // label_product
            // 
            label_product.AutoSize = true;
            label_product.Location = new Point(29, 69);
            label_product.Name = "label_product";
            label_product.Size = new Size(42, 15);
            label_product.TabIndex = 4;
            label_product.Text = "Товар:";
            // 
            // numericUpDown_nounce
            // 
            numericUpDown_nounce.Location = new Point(128, 104);
            numericUpDown_nounce.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown_nounce.Name = "numericUpDown_nounce";
            numericUpDown_nounce.Size = new Size(201, 23);
            numericUpDown_nounce.TabIndex = 2;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(229, 186);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 30);
            button_cancel.TabIndex = 4;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_action
            // 
            button_action.Location = new Point(32, 186);
            button_action.Name = "button_action";
            button_action.Size = new Size(100, 30);
            button_action.TabIndex = 3;
            button_action.Text = "Добавить";
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // label_nounce
            // 
            label_nounce.AutoSize = true;
            label_nounce.Location = new Point(32, 104);
            label_nounce.Name = "label_nounce";
            label_nounce.Size = new Size(75, 15);
            label_nounce.TabIndex = 0;
            label_nounce.Text = "Количество:";
            // 
            // label_futura
            // 
            label_futura.AutoSize = true;
            label_futura.Location = new Point(28, 33);
            label_futura.Name = "label_futura";
            label_futura.Size = new Size(85, 15);
            label_futura.TabIndex = 0;
            label_futura.Text = "№ накладной:";
            // 
            // comboBox_product
            // 
            comboBox_product.FormattingEnabled = true;
            comboBox_product.Location = new Point(128, 66);
            comboBox_product.Margin = new Padding(3, 2, 3, 2);
            comboBox_product.Name = "comboBox_product";
            comboBox_product.Size = new Size(201, 23);
            comboBox_product.TabIndex = 0;
            // 
            // AEFuturaInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AEFuturaInfoForm";
            Text = "AEFuturaInfoForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_totalSum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nounce).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_product;
        private NumericUpDown numericUpDown_nounce;
        private Button button_cancel;
        private Button button_action;
        private Label label_nounce;
        private Label label_futura;
        private NumericUpDown numericUpDown_totalSum;
        private Label label_totalSum;
        private ComboBox comboBox_futura;
        private ComboBox comboBox_product;
    }
}