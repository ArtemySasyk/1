namespace FactoryWinForm
{
    partial class AEProductForm
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
            numericUpDown_nounce = new NumericUpDown();
            button_cancel = new Button();
            button_action = new Button();
            label_nounce = new Label();
            textBox_name = new TextBox();
            label_name = new Label();
            label1 = new Label();
            textBox_info = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nounce).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown_nounce);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(button_action);
            panel1.Controls.Add(label_nounce);
            panel1.Controls.Add(textBox_info);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_name);
            panel1.Controls.Add(label_name);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 316);
            panel1.TabIndex = 2;
            // 
            // numericUpDown_nounce
            // 
            numericUpDown_nounce.Location = new Point(145, 120);
            numericUpDown_nounce.Margin = new Padding(3, 4, 3, 4);
            numericUpDown_nounce.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown_nounce.Name = "numericUpDown_nounce";
            numericUpDown_nounce.Size = new Size(230, 27);
            numericUpDown_nounce.TabIndex = 1;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(261, 213);
            button_cancel.Margin = new Padding(3, 4, 3, 4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(114, 40);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_action
            // 
            button_action.Location = new Point(35, 213);
            button_action.Margin = new Padding(3, 4, 3, 4);
            button_action.Name = "button_action";
            button_action.Size = new Size(114, 40);
            button_action.TabIndex = 2;
            button_action.Text = "Добавить";
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // label_nounce
            // 
            label_nounce.AutoSize = true;
            label_nounce.Location = new Point(35, 120);
            label_nounce.Name = "label_nounce";
            label_nounce.Size = new Size(90, 20);
            label_nounce.TabIndex = 0;
            label_nounce.Text = "Количество";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(145, 40);
            textBox_name.Margin = new Padding(3, 4, 3, 4);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(229, 27);
            textBox_name.TabIndex = 0;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(30, 43);
            label_name.Name = "label_name";
            label_name.Size = new Size(119, 20);
            label_name.TabIndex = 0;
            label_name.Text = "Наименование:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 82);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Доп инфо:";
            // 
            // textBox_info
            // 
            textBox_info.Location = new Point(145, 75);
            textBox_info.Margin = new Padding(3, 4, 3, 4);
            textBox_info.Name = "textBox_info";
            textBox_info.Size = new Size(229, 27);
            textBox_info.TabIndex = 0;
            // 
            // AEProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 348);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AEProductForm";
            Text = "AEProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nounce).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown numericUpDown_nounce;
        private Button button_cancel;
        private Button button_action;
        private Label label_nounce;
        private TextBox textBox_name;
        private Label label_name;
        private TextBox textBox_info;
        private Label label1;
    }
}