namespace FactoryWinForm
{
    partial class ReportForm
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
            dataGridView_clients = new DataGridView();
            button_action = new Button();
            dateTimePicker_start = new DateTimePicker();
            label_start = new Label();
            label_end = new Label();
            dateTimePicker_end = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView_clients).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_clients
            // 
            dataGridView_clients.AllowUserToAddRows = false;
            dataGridView_clients.AllowUserToDeleteRows = false;
            dataGridView_clients.AllowUserToResizeRows = false;
            dataGridView_clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_clients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_clients.Dock = DockStyle.Left;
            dataGridView_clients.Location = new Point(0, 0);
            dataGridView_clients.Name = "dataGridView_clients";
            dataGridView_clients.ReadOnly = true;
            dataGridView_clients.RowHeadersWidth = 51;
            dataGridView_clients.RowTemplate.Height = 29;
            dataGridView_clients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_clients.Size = new Size(377, 450);
            dataGridView_clients.TabIndex = 0;
            // 
            // button_action
            // 
            button_action.Location = new Point(527, 250);
            button_action.Name = "button_action";
            button_action.Size = new Size(140, 29);
            button_action.TabIndex = 1;
            button_action.Text = "Сформировать";
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // dateTimePicker_start
            // 
            dateTimePicker_start.Format = DateTimePickerFormat.Short;
            dateTimePicker_start.Location = new Point(586, 114);
            dateTimePicker_start.Name = "dateTimePicker_start";
            dateTimePicker_start.Size = new Size(130, 27);
            dateTimePicker_start.TabIndex = 2;
            // 
            // label_start
            // 
            label_start.AutoSize = true;
            label_start.Location = new Point(478, 118);
            label_start.Name = "label_start";
            label_start.Size = new Size(61, 20);
            label_start.TabIndex = 3;
            label_start.Text = "Начало";
            // 
            // label_end
            // 
            label_end.AutoSize = true;
            label_end.Location = new Point(478, 185);
            label_end.Name = "label_end";
            label_end.Size = new Size(53, 20);
            label_end.TabIndex = 4;
            label_end.Text = "Конец";
            // 
            // dateTimePicker_end
            // 
            dateTimePicker_end.Format = DateTimePickerFormat.Short;
            dateTimePicker_end.Location = new Point(586, 181);
            dateTimePicker_end.Name = "dateTimePicker_end";
            dateTimePicker_end.Size = new Size(130, 27);
            dateTimePicker_end.TabIndex = 5;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker_end);
            Controls.Add(label_end);
            Controls.Add(label_start);
            Controls.Add(dateTimePicker_start);
            Controls.Add(button_action);
            Controls.Add(dataGridView_clients);
            Name = "ReportForm";
            Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_clients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_clients;
        private Button button_action;
        private DateTimePicker dateTimePicker_start;
        private Label label_start;
        private Label label_end;
        private DateTimePicker dateTimePicker_end;
    }
}