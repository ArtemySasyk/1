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
            panel_main = new Panel();
            button_export = new Button();
            button_invoices = new Button();
            button_customers = new Button();
            button_products = new Button();
            panel_main.SuspendLayout();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.Controls.Add(button_export);
            panel_main.Controls.Add(button_invoices);
            panel_main.Controls.Add(button_customers);
            panel_main.Controls.Add(button_products);
            panel_main.Location = new Point(14, 15);
            panel_main.Margin = new Padding(3, 4, 3, 4);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(383, 425);
            panel_main.TabIndex = 1;
            // 
            // button_export
            // 
            button_export.Location = new Point(62, 186);
            button_export.Margin = new Padding(3, 4, 3, 4);
            button_export.Name = "button_export";
            button_export.Size = new Size(114, 40);
            button_export.TabIndex = 4;
            button_export.Text = "Экспорт";
            button_export.UseVisualStyleBackColor = true;
            button_export.Click += button_export_Click;
            // 
            // button_invoices
            // 
            button_invoices.Location = new Point(62, 138);
            button_invoices.Margin = new Padding(3, 4, 3, 4);
            button_invoices.Name = "button_invoices";
            button_invoices.Size = new Size(114, 40);
            button_invoices.TabIndex = 2;
            button_invoices.Text = "Накладные";
            button_invoices.UseVisualStyleBackColor = true;
            button_invoices.Click += button_invoices_Click;
            // 
            // button_customers
            // 
            button_customers.Location = new Point(62, 90);
            button_customers.Margin = new Padding(3, 4, 3, 4);
            button_customers.Name = "button_customers";
            button_customers.Size = new Size(114, 40);
            button_customers.TabIndex = 1;
            button_customers.Text = "Поставщики";
            button_customers.UseVisualStyleBackColor = true;
            button_customers.Click += button_customers_Click;
            // 
            // button_products
            // 
            button_products.Location = new Point(62, 42);
            button_products.Margin = new Padding(3, 4, 3, 4);
            button_products.Name = "button_products";
            button_products.Size = new Size(114, 40);
            button_products.TabIndex = 0;
            button_products.Text = "Товары";
            button_products.UseVisualStyleBackColor = true;
            button_products.Click += button_products_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 469);
            Controls.Add(panel_main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            panel_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main;
        private Button button_invoices;
        private Button button_customers;
        private Button button_products;
        private Button button_export;
    }
}