namespace FactoryWinForm
{
    partial class AEFuturaForm
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
            panel_address = new Panel();
            comboBox_name = new ComboBox();
            dateTimePicker_date = new DateTimePicker();
            label_address = new Label();
            button_cancel = new Button();
            button_action = new Button();
            label_name = new Label();
            label_paid = new Label();
            numericUpDown1 = new NumericUpDown();
            panel_address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel_address
            // 
            panel_address.Controls.Add(numericUpDown1);
            panel_address.Controls.Add(label_paid);
            panel_address.Controls.Add(comboBox_name);
            panel_address.Controls.Add(dateTimePicker_date);
            panel_address.Controls.Add(label_address);
            panel_address.Controls.Add(button_cancel);
            panel_address.Controls.Add(button_action);
            panel_address.Controls.Add(label_name);
            panel_address.Location = new Point(11, 13);
            panel_address.Margin = new Padding(3, 4, 3, 4);
            panel_address.Name = "panel_address";
            panel_address.Size = new Size(411, 316);
            panel_address.TabIndex = 4;
            // 
            // comboBox_name
            // 
            comboBox_name.FormattingEnabled = true;
            comboBox_name.Location = new Point(125, 40);
            comboBox_name.Margin = new Padding(3, 4, 3, 4);
            comboBox_name.Name = "comboBox_name";
            comboBox_name.Size = new Size(250, 28);
            comboBox_name.TabIndex = 0;
            // 
            // dateTimePicker_date
            // 
            dateTimePicker_date.Location = new Point(125, 96);
            dateTimePicker_date.Name = "dateTimePicker_date";
            dateTimePicker_date.Size = new Size(250, 27);
            dateTimePicker_date.TabIndex = 1;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(32, 101);
            label_address.Name = "label_address";
            label_address.Size = new Size(44, 20);
            label_address.TabIndex = 3;
            label_address.Text = "Дата:";
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(261, 253);
            button_cancel.Margin = new Padding(3, 4, 3, 4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(114, 40);
            button_cancel.TabIndex = 7;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_action
            // 
            button_action.Location = new Point(32, 253);
            button_action.Margin = new Padding(3, 4, 3, 4);
            button_action.Name = "button_action";
            button_action.Size = new Size(114, 40);
            button_action.TabIndex = 6;
            button_action.Text = "Добавить";
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(32, 44);
            label_name.Name = "label_name";
            label_name.Size = new Size(89, 20);
            label_name.TabIndex = 0;
            label_name.Text = "Поставщик:";
            label_name.Click += label_name_Click;
            // 
            // label_paid
            // 
            label_paid.AutoSize = true;
            label_paid.Location = new Point(26, 148);
            label_paid.Name = "label_paid";
            label_paid.Size = new Size(79, 20);
            label_paid.TabIndex = 8;
            label_paid.Text = "Оплачено";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(125, 141);
            numericUpDown1.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 9;
            // 
            // AEFuturaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 348);
            Controls.Add(panel_address);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AEFuturaForm";
            Text = "AEFuturaForm";
            panel_address.ResumeLayout(false);
            panel_address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_address;
        private Label label_address;
        private Button button_cancel;
        private Button button_action;
        private TextBox textBox_name;
        private Label label_name;
        private DateTimePicker dateTimePicker_date;
        private ComboBox comboBox_name;
        private NumericUpDown numericUpDown1;
        private Label label_paid;
    }
}