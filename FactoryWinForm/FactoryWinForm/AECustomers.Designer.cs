namespace FactoryWinForm
{
    partial class AECustomers
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
            textBox_phone = new TextBox();
            label_phone = new Label();
            textBox_address = new TextBox();
            label_address = new Label();
            button_cancel = new Button();
            button_action = new Button();
            textBox_name = new TextBox();
            label_name = new Label();
            panel_address.SuspendLayout();
            SuspendLayout();
            // 
            // panel_address
            // 
            panel_address.Controls.Add(textBox_phone);
            panel_address.Controls.Add(label_phone);
            panel_address.Controls.Add(textBox_address);
            panel_address.Controls.Add(label_address);
            panel_address.Controls.Add(button_cancel);
            panel_address.Controls.Add(button_action);
            panel_address.Controls.Add(textBox_name);
            panel_address.Controls.Add(label_name);
            panel_address.Location = new Point(11, 13);
            panel_address.Margin = new Padding(3, 4, 3, 4);
            panel_address.Name = "panel_address";
            panel_address.Size = new Size(411, 316);
            panel_address.TabIndex = 3;
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(146, 144);
            textBox_phone.Margin = new Padding(3, 4, 3, 4);
            textBox_phone.MaxLength = 10;
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(229, 27);
            textBox_phone.TabIndex = 2;
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Location = new Point(33, 148);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(72, 20);
            label_phone.TabIndex = 5;
            label_phone.Text = "Телефон:";
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(146, 92);
            textBox_address.Margin = new Padding(3, 4, 3, 4);
            textBox_address.MaxLength = 1024;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(229, 27);
            textBox_address.TabIndex = 1;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(33, 95);
            label_address.Name = "label_address";
            label_address.Size = new Size(54, 20);
            label_address.TabIndex = 3;
            label_address.Text = "Адрес:";
            label_address.Click += label_address_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(261, 213);
            button_cancel.Margin = new Padding(3, 4, 3, 4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(114, 40);
            button_cancel.TabIndex = 4;
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
            button_action.TabIndex = 3;
            button_action.Text = "Добавить";
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(145, 40);
            textBox_name.Margin = new Padding(3, 4, 3, 4);
            textBox_name.MaxLength = 200;
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(229, 27);
            textBox_name.TabIndex = 0;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(32, 44);
            label_name.Name = "label_name";
            label_name.Size = new Size(89, 20);
            label_name.TabIndex = 0;
            label_name.Text = "Поставщик:";
            // 
            // AECustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 348);
            Controls.Add(panel_address);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AECustomers";
            Text = "AECustomers";
            panel_address.ResumeLayout(false);
            panel_address.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_address;
        private Button button_cancel;
        private Button button_action;
        private TextBox textBox_name;
        private Label label_name;
        private TextBox textBox_phone;
        private Label label_phone;
        private TextBox textBox_address;
        private Label label_address;
    }
}