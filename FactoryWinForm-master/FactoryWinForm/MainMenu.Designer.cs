namespace FactoryWinForm
{
    partial class MainMenu
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.button_invoices = new System.Windows.Forms.Button();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_products = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.button1);
            this.panel_main.Controls.Add(this.button_export);
            this.panel_main.Controls.Add(this.button_invoices);
            this.panel_main.Controls.Add(this.button_customers);
            this.panel_main.Controls.Add(this.button_products);
            this.panel_main.Location = new System.Drawing.Point(14, 15);
            this.panel_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(240, 280);
            this.panel_main.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Экспорт накладных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(62, 163);
            this.button_export.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(114, 40);
            this.button_export.TabIndex = 4;
            this.button_export.Text = "Экспорт";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_invoices
            // 
            this.button_invoices.Location = new System.Drawing.Point(62, 115);
            this.button_invoices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_invoices.Name = "button_invoices";
            this.button_invoices.Size = new System.Drawing.Size(114, 40);
            this.button_invoices.TabIndex = 2;
            this.button_invoices.Text = "Накладные";
            this.button_invoices.UseVisualStyleBackColor = true;
            this.button_invoices.Click += new System.EventHandler(this.button_invoices_Click);
            // 
            // button_customers
            // 
            this.button_customers.Location = new System.Drawing.Point(62, 67);
            this.button_customers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(114, 40);
            this.button_customers.TabIndex = 1;
            this.button_customers.Text = "Поставщики";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.button_customers_Click);
            // 
            // button_products
            // 
            this.button_products.Location = new System.Drawing.Point(62, 19);
            this.button_products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(114, 40);
            this.button_products.TabIndex = 0;
            this.button_products.Text = "Товары";
            this.button_products.UseVisualStyleBackColor = true;
            this.button_products.Click += new System.EventHandler(this.button_products_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 308);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_main;
        private Button button_invoices;
        private Button button_customers;
        private Button button_products;
        private Button button_export;
        private Button button1;
    }
}