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
            this.panel_address = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_totalSum = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label_address = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_action = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_address
            // 
            this.panel_address.Controls.Add(this.comboBox1);
            this.panel_address.Controls.Add(this.numericUpDown1);
            this.panel_address.Controls.Add(this.label_totalSum);
            this.panel_address.Controls.Add(this.dateTimePicker_date);
            this.panel_address.Controls.Add(this.label_address);
            this.panel_address.Controls.Add(this.button_cancel);
            this.panel_address.Controls.Add(this.button_action);
            this.panel_address.Controls.Add(this.label_name);
            this.panel_address.Location = new System.Drawing.Point(12, 13);
            this.panel_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_address.Name = "panel_address";
            this.panel_address.Size = new System.Drawing.Size(411, 416);
            this.panel_address.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(236, 175);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label_totalSum
            // 
            this.label_totalSum.AutoSize = true;
            this.label_totalSum.Location = new System.Drawing.Point(32, 182);
            this.label_totalSum.Name = "label_totalSum";
            this.label_totalSum.Size = new System.Drawing.Size(58, 20);
            this.label_totalSum.TabIndex = 9;
            this.label_totalSum.Text = "Сумма:";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(165, 112);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_date.TabIndex = 1;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(33, 117);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(44, 20);
            this.label_address.TabIndex = 3;
            this.label_address.Text = "Дата:";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(257, 301);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(114, 40);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(33, 301);
            this.button_action.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(114, 40);
            this.button_action.TabIndex = 6;
            this.button_action.Text = "Добавить";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(32, 54);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(89, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Поставщик:";
            // 
            // AEFuturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 448);
            this.Controls.Add(this.panel_address);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AEFuturaForm";
            this.Text = "AEFuturaForm";
            this.panel_address.ResumeLayout(false);
            this.panel_address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_address;
        private Label label_address;
        private Button button_cancel;
        private Button button_action;
        private Label label_name;
        private DateTimePicker dateTimePicker_date;
        private Label label_totalSum;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
    }
}