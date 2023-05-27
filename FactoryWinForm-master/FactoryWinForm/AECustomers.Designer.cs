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
            this.panel_address = new System.Windows.Forms.Panel();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_action = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_address
            // 
            this.panel_address.Controls.Add(this.textBox_phone);
            this.panel_address.Controls.Add(this.label_phone);
            this.panel_address.Controls.Add(this.textBox_address);
            this.panel_address.Controls.Add(this.label_address);
            this.panel_address.Controls.Add(this.button_cancel);
            this.panel_address.Controls.Add(this.button_action);
            this.panel_address.Controls.Add(this.textBox_name);
            this.panel_address.Controls.Add(this.label_name);
            this.panel_address.Location = new System.Drawing.Point(11, 13);
            this.panel_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_address.Name = "panel_address";
            this.panel_address.Size = new System.Drawing.Size(411, 316);
            this.panel_address.TabIndex = 3;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(146, 144);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_phone.MaxLength = 10;
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(229, 27);
            this.textBox_phone.TabIndex = 2;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(33, 148);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(72, 20);
            this.label_phone.TabIndex = 5;
            this.label_phone.Text = "Телефон:";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(146, 92);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_address.MaxLength = 1024;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(229, 27);
            this.textBox_address.TabIndex = 1;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(33, 96);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(61, 20);
            this.label_address.TabIndex = 3;
            this.label_address.Text = "Адресс:";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(261, 213);
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
            this.button_action.Location = new System.Drawing.Point(35, 213);
            this.button_action.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(114, 40);
            this.button_action.TabIndex = 3;
            this.button_action.Text = "Добавить";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(145, 40);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_name.MaxLength = 200;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(229, 27);
            this.textBox_name.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(32, 44);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(78, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Заказщик:";
            // 
            // AECustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 348);
            this.Controls.Add(this.panel_address);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AECustomers";
            this.Text = "AECustomers";
            this.panel_address.ResumeLayout(false);
            this.panel_address.PerformLayout();
            this.ResumeLayout(false);

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