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
            components = new System.ComponentModel.Container();
            dataGridView_Data = new DataGridView();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem_Menu = new ToolStripMenuItem();
            ToolStripMenuItem_Add = new ToolStripMenuItem();
            ToolStripMenuItem_addFutura = new ToolStripMenuItem();
            ToolStripMenuItem_addFuturaInfo = new ToolStripMenuItem();
            ToolStripMenuItem_Edit = new ToolStripMenuItem();
            ToolStripMenuItem_editFutura = new ToolStripMenuItem();
            ToolStripMenuItem_editFuturaInfo = new ToolStripMenuItem();
            ToolStripMenuItem_Delete = new ToolStripMenuItem();
            toolStripMenuItem_futura = new ToolStripMenuItem();
            toolStripMenuItem_futuraInfo = new ToolStripMenuItem();
            timer_update = new System.Windows.Forms.Timer(components);
            dataGridView_dataSecond = new DataGridView();
            label_secondTable = new Label();
            panel_bottom = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Data).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dataSecond).BeginInit();
            panel_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Data
            // 
            dataGridView_Data.AllowUserToAddRows = false;
            dataGridView_Data.AllowUserToDeleteRows = false;
            dataGridView_Data.AllowUserToResizeRows = false;
            dataGridView_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Data.BackgroundColor = Color.WhiteSmoke;
            dataGridView_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Data.Dock = DockStyle.Top;
            dataGridView_Data.Location = new Point(0, 30);
            dataGridView_Data.Margin = new Padding(3, 4, 3, 4);
            dataGridView_Data.MultiSelect = false;
            dataGridView_Data.Name = "dataGridView_Data";
            dataGridView_Data.ReadOnly = true;
            dataGridView_Data.RowHeadersWidth = 51;
            dataGridView_Data.RowTemplate.Height = 25;
            dataGridView_Data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Data.Size = new Size(914, 269);
            dataGridView_Data.TabIndex = 0;
            dataGridView_Data.SelectionChanged += dataGridView_Data_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_Menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Menu
            // 
            ToolStripMenuItem_Menu.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Add, ToolStripMenuItem_Edit, ToolStripMenuItem_Delete });
            ToolStripMenuItem_Menu.Name = "ToolStripMenuItem_Menu";
            ToolStripMenuItem_Menu.Size = new Size(65, 24);
            ToolStripMenuItem_Menu.Text = "Меню";
            // 
            // ToolStripMenuItem_Add
            // 
            ToolStripMenuItem_Add.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_addFutura, ToolStripMenuItem_addFuturaInfo });
            ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            ToolStripMenuItem_Add.Size = new Size(224, 26);
            ToolStripMenuItem_Add.Text = "Добавить";
            ToolStripMenuItem_Add.Click += ToolStripMenuItem_Add_Click;
            // 
            // ToolStripMenuItem_addFutura
            // 
            ToolStripMenuItem_addFutura.Name = "ToolStripMenuItem_addFutura";
            ToolStripMenuItem_addFutura.Size = new Size(167, 26);
            ToolStripMenuItem_addFutura.Text = "Накладная";
            ToolStripMenuItem_addFutura.Visible = false;
            ToolStripMenuItem_addFutura.Click += ToolStripMenuItem_addFutura_Click;
            // 
            // ToolStripMenuItem_addFuturaInfo
            // 
            ToolStripMenuItem_addFuturaInfo.Name = "ToolStripMenuItem_addFuturaInfo";
            ToolStripMenuItem_addFuturaInfo.Size = new Size(167, 26);
            ToolStripMenuItem_addFuturaInfo.Text = "Отчёт";
            ToolStripMenuItem_addFuturaInfo.Visible = false;
            ToolStripMenuItem_addFuturaInfo.Click += ToolStripMenuItem_addFuturaInfo_Click;
            // 
            // ToolStripMenuItem_Edit
            // 
            ToolStripMenuItem_Edit.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_editFutura, ToolStripMenuItem_editFuturaInfo });
            ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            ToolStripMenuItem_Edit.Size = new Size(224, 26);
            ToolStripMenuItem_Edit.Text = "Изменить";
            ToolStripMenuItem_Edit.Click += ToolStripMenuItem_Edit_Click;
            // 
            // ToolStripMenuItem_editFutura
            // 
            ToolStripMenuItem_editFutura.Name = "ToolStripMenuItem_editFutura";
            ToolStripMenuItem_editFutura.Size = new Size(167, 26);
            ToolStripMenuItem_editFutura.Text = "Накладная";
            ToolStripMenuItem_editFutura.Visible = false;
            ToolStripMenuItem_editFutura.Click += ToolStripMenuItem_editFutura_Click;
            // 
            // ToolStripMenuItem_editFuturaInfo
            // 
            ToolStripMenuItem_editFuturaInfo.Name = "ToolStripMenuItem_editFuturaInfo";
            ToolStripMenuItem_editFuturaInfo.Size = new Size(167, 26);
            ToolStripMenuItem_editFuturaInfo.Text = "Отчёт";
            ToolStripMenuItem_editFuturaInfo.Visible = false;
            ToolStripMenuItem_editFuturaInfo.Click += ToolStripMenuItem_editFuturaInfo_Click;
            // 
            // ToolStripMenuItem_Delete
            // 
            ToolStripMenuItem_Delete.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_futura, toolStripMenuItem_futuraInfo });
            ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            ToolStripMenuItem_Delete.Size = new Size(224, 26);
            ToolStripMenuItem_Delete.Text = "Удалить";
            ToolStripMenuItem_Delete.Click += ToolStripMenuItem_Delete_Click;
            // 
            // toolStripMenuItem_futura
            // 
            toolStripMenuItem_futura.Name = "toolStripMenuItem_futura";
            toolStripMenuItem_futura.Size = new Size(224, 26);
            toolStripMenuItem_futura.Text = "Накладная";
            toolStripMenuItem_futura.Visible = false;
            toolStripMenuItem_futura.Click += toolStripMenuItem_futura_Click;
            // 
            // toolStripMenuItem_futuraInfo
            // 
            toolStripMenuItem_futuraInfo.Name = "toolStripMenuItem_futuraInfo";
            toolStripMenuItem_futuraInfo.Size = new Size(224, 26);
            toolStripMenuItem_futuraInfo.Text = "Отчёт";
            toolStripMenuItem_futuraInfo.Visible = false;
            toolStripMenuItem_futuraInfo.Click += toolStripMenuItem_futuraInfo_Click;
            // 
            // timer_update
            // 
            timer_update.Interval = 2000;
            timer_update.Tick += timer_update_Tick;
            // 
            // dataGridView_dataSecond
            // 
            dataGridView_dataSecond.AllowUserToAddRows = false;
            dataGridView_dataSecond.AllowUserToDeleteRows = false;
            dataGridView_dataSecond.AllowUserToResizeRows = false;
            dataGridView_dataSecond.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_dataSecond.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_dataSecond.BackgroundColor = Color.WhiteSmoke;
            dataGridView_dataSecond.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_dataSecond.Dock = DockStyle.Bottom;
            dataGridView_dataSecond.Location = new Point(0, 36);
            dataGridView_dataSecond.Margin = new Padding(3, 4, 3, 4);
            dataGridView_dataSecond.MultiSelect = false;
            dataGridView_dataSecond.Name = "dataGridView_dataSecond";
            dataGridView_dataSecond.ReadOnly = true;
            dataGridView_dataSecond.RowHeadersWidth = 51;
            dataGridView_dataSecond.RowTemplate.Height = 25;
            dataGridView_dataSecond.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_dataSecond.Size = new Size(914, 267);
            dataGridView_dataSecond.TabIndex = 2;
            // 
            // label_secondTable
            // 
            label_secondTable.AutoSize = true;
            label_secondTable.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_secondTable.Location = new Point(16, 13);
            label_secondTable.Name = "label_secondTable";
            label_secondTable.Size = new Size(63, 19);
            label_secondTable.TabIndex = 3;
            label_secondTable.Text = "Отчёты";
            // 
            // panel_bottom
            // 
            panel_bottom.Controls.Add(label_secondTable);
            panel_bottom.Controls.Add(dataGridView_dataSecond);
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 297);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Size = new Size(914, 303);
            panel_bottom.TabIndex = 4;
            panel_bottom.Visible = false;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel_bottom);
            Controls.Add(dataGridView_Data);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Data).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dataSecond).EndInit();
            panel_bottom.ResumeLayout(false);
            panel_bottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Data;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem_Menu;
        private ToolStripMenuItem ToolStripMenuItem_Add;
        private ToolStripMenuItem ToolStripMenuItem_Edit;
        private ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.Timer timer_update;
        private DataGridView dataGridView_dataSecond;
        private Label label_secondTable;
        private Panel panel_bottom;
        private ToolStripMenuItem ToolStripMenuItem_addFutura;
        private ToolStripMenuItem ToolStripMenuItem_addFuturaInfo;
        private ToolStripMenuItem ToolStripMenuItem_editFutura;
        private ToolStripMenuItem ToolStripMenuItem_editFuturaInfo;
        private ToolStripMenuItem toolStripMenuItem_futura;
        private ToolStripMenuItem toolStripMenuItem_futuraInfo;
    }
}