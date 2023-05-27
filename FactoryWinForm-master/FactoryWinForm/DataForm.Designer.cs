namespace FactoryWinForm
{
    partial class DataForm
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
            this.components = new System.ComponentModel.Container();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_addFutura = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_addFuturaInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_editFutura = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_editFuturaInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_futura = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_futuraInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_secondTable = new System.Windows.Forms.Label();
            this.dataGridView_dataSecond = new System.Windows.Forms.DataGridView();
            this.panel_bottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dataSecond)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_update
            // 
            this.timer_update.Interval = 5000;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.AllowUserToAddRows = false;
            this.dataGridView_Data.AllowUserToDeleteRows = false;
            this.dataGridView_Data.AllowUserToResizeRows = false;
            this.dataGridView_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Data.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Data.Location = new System.Drawing.Point(0, 30);
            this.dataGridView_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Data.MultiSelect = false;
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.ReadOnly = true;
            this.dataGridView_Data.RowHeadersWidth = 51;
            this.dataGridView_Data.RowTemplate.Height = 25;
            this.dataGridView_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Data.Size = new System.Drawing.Size(914, 269);
            this.dataGridView_Data.TabIndex = 5;
            this.dataGridView_Data.SelectionChanged += new System.EventHandler(this.dataGridView_Data_SelectionChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(914, 30);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_addFutura,
            this.ToolStripMenuItem_addFuturaInfo});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "Добавить";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem_Add_Click);
            // 
            // ToolStripMenuItem_addFutura
            // 
            this.ToolStripMenuItem_addFutura.Name = "ToolStripMenuItem_addFutura";
            this.ToolStripMenuItem_addFutura.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_addFutura.Text = "Накладная";
            this.ToolStripMenuItem_addFutura.Visible = false;
            this.ToolStripMenuItem_addFutura.Click += new System.EventHandler(this.ToolStripMenuItem_addFutura_Click);
            // 
            // ToolStripMenuItem_addFuturaInfo
            // 
            this.ToolStripMenuItem_addFuturaInfo.Name = "ToolStripMenuItem_addFuturaInfo";
            this.ToolStripMenuItem_addFuturaInfo.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_addFuturaInfo.Text = "Отчёт";
            this.ToolStripMenuItem_addFuturaInfo.Visible = false;
            this.ToolStripMenuItem_addFuturaInfo.Click += new System.EventHandler(this.ToolStripMenuItem_addFuturaInfo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_editFutura,
            this.ToolStripMenuItem_editFuturaInfo});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem3.Text = "Изменить";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem_Edit_Click);
            // 
            // ToolStripMenuItem_editFutura
            // 
            this.ToolStripMenuItem_editFutura.Name = "ToolStripMenuItem_editFutura";
            this.ToolStripMenuItem_editFutura.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_editFutura.Text = "Накладная";
            this.ToolStripMenuItem_editFutura.Visible = false;
            this.ToolStripMenuItem_editFutura.Click += new System.EventHandler(this.ToolStripMenuItem_editFutura_Click);
            // 
            // ToolStripMenuItem_editFuturaInfo
            // 
            this.ToolStripMenuItem_editFuturaInfo.Name = "ToolStripMenuItem_editFuturaInfo";
            this.ToolStripMenuItem_editFuturaInfo.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_editFuturaInfo.Text = "Отчёт";
            this.ToolStripMenuItem_editFuturaInfo.Visible = false;
            this.ToolStripMenuItem_editFuturaInfo.Click += new System.EventHandler(this.ToolStripMenuItem_editFuturaInfo_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_futura,
            this.toolStripMenuItem_futuraInfo});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem4.Text = "Удалить";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // toolStripMenuItem_futura
            // 
            this.toolStripMenuItem_futura.Name = "toolStripMenuItem_futura";
            this.toolStripMenuItem_futura.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem_futura.Text = "Накладная";
            this.toolStripMenuItem_futura.Visible = false;
            this.toolStripMenuItem_futura.Click += new System.EventHandler(this.накладнаяToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_futuraInfo
            // 
            this.toolStripMenuItem_futuraInfo.Name = "toolStripMenuItem_futuraInfo";
            this.toolStripMenuItem_futuraInfo.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem_futuraInfo.Text = "Отчёт";
            this.toolStripMenuItem_futuraInfo.Visible = false;
            this.toolStripMenuItem_futuraInfo.Click += new System.EventHandler(this.отчётToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // label_secondTable
            // 
            this.label_secondTable.AutoSize = true;
            this.label_secondTable.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_secondTable.Location = new System.Drawing.Point(16, 13);
            this.label_secondTable.Name = "label_secondTable";
            this.label_secondTable.Size = new System.Drawing.Size(63, 19);
            this.label_secondTable.TabIndex = 3;
            this.label_secondTable.Text = "Отчёты";
            // 
            // dataGridView_dataSecond
            // 
            this.dataGridView_dataSecond.AllowUserToAddRows = false;
            this.dataGridView_dataSecond.AllowUserToDeleteRows = false;
            this.dataGridView_dataSecond.AllowUserToResizeRows = false;
            this.dataGridView_dataSecond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dataSecond.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_dataSecond.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_dataSecond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dataSecond.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_dataSecond.Location = new System.Drawing.Point(0, 36);
            this.dataGridView_dataSecond.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_dataSecond.MultiSelect = false;
            this.dataGridView_dataSecond.Name = "dataGridView_dataSecond";
            this.dataGridView_dataSecond.ReadOnly = true;
            this.dataGridView_dataSecond.RowHeadersWidth = 51;
            this.dataGridView_dataSecond.RowTemplate.Height = 25;
            this.dataGridView_dataSecond.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_dataSecond.Size = new System.Drawing.Size(914, 267);
            this.dataGridView_dataSecond.TabIndex = 2;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.label_secondTable);
            this.panel_bottom.Controls.Add(this.dataGridView_dataSecond);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 297);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(914, 303);
            this.panel_bottom.TabIndex = 7;
            this.panel_bottom.Visible = false;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.dataGridView_Data);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel_bottom);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataForm";
            this.Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dataSecond)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_update;
        private DataGridView dataGridView_Data;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem ToolStripMenuItem_addFutura;
        private ToolStripMenuItem ToolStripMenuItem_addFuturaInfo;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem ToolStripMenuItem_editFutura;
        private ToolStripMenuItem ToolStripMenuItem_editFuturaInfo;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem_futura;
        private ToolStripMenuItem toolStripMenuItem_futuraInfo;
        private System.Windows.Forms.Timer timer1;
        private Label label_secondTable;
        private DataGridView dataGridView_dataSecond;
        private Panel panel_bottom;
    }
}