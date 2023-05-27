using Npgsql;
using System.Data;

namespace FactoryWinForm
{
    public partial class DataForm : Form
    {
        private string _stringConn = "Server=localhost; Port=5432; User Id=postgres; Password=postpass; Database=KutMag";
        private string _table;
        private string[] _namesTables;
        private DataSet _dataSet = new DataSet();
        private DataTable _dataTable = new DataTable();
        private NpgsqlConnection _connection = new NpgsqlConnection();

        public DataForm(string table, string[] namesTables)
        {
            _table = table;
            _namesTables = namesTables;
            InitializeComponent();
            initConnection();
            this.Show();
            timer_update.Enabled = true;
            dataGridView_Data.Dock = DockStyle.Fill;
            string formName = "Товары";
            if (table == "postavshiki")
                formName = "Поставщики";
            if (table == "futura")
            {
                formName = "Накладные";
                dataGridView_Data.Dock = DockStyle.Top;
                panel_bottom.Visible = true;
                ToolStripMenuItem_addFutura.Visible = true;
                ToolStripMenuItem_addFuturaInfo.Visible = true;
                ToolStripMenuItem_editFutura.Visible = true;
                ToolStripMenuItem_editFuturaInfo.Visible = true;
                toolStripMenuItem_futura.Visible = true;
                toolStripMenuItem_futuraInfo.Visible = true;

                ToolStripMenuItem_Add.Click -= ToolStripMenuItem_Add_Click;
                ToolStripMenuItem_Edit.Click -= ToolStripMenuItem_Edit_Click;
                ToolStripMenuItem_Delete.Click -= ToolStripMenuItem_Delete_Click;
            }
            this.Text = formName;
        }

        private void initConnection()
        {
            _connection = new NpgsqlConnection(_stringConn);
            NpgsqlConnection connection = new NpgsqlConnection(_stringConn);
            npgsqlAnswer(connection);
        }

        private void updateDateGridView()
        {
            NpgsqlConnection connection = new NpgsqlConnection(_stringConn);
            int sId = 0;
            if (dataGridView_Data.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView_Data.SelectedRows[0];
                sId = Convert.ToInt32(row.Cells[0].Value);
            }
            int sIdS = 0;
            if (dataGridView_dataSecond.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView_dataSecond.SelectedRows[0];
                sIdS = Convert.ToInt32(row.Cells[0].Value);
            }
            npgsqlAnswer(connection);

            dataGridView_Data.ClearSelection();
            foreach (DataGridViewRow row in dataGridView_Data.Rows)
            {
                if (row.Cells[0].Value.Equals(sId))
                {
                    row.Selected = true;
                }
            }
            foreach (DataGridViewRow row in dataGridView_dataSecond.Rows)
            {
                if (row.Cells[0].Value.Equals(sIdS))
                {
                    row.Selected = true;
                }
            }
        }

        private void npgsqlAnswer(NpgsqlConnection connection)
        {
            connection.Open();

            string sql = $"SELECT * FROM {_table};";

            if (_table == "futura")
            {
                sql = $"SELECT f.id, p.name, f.date, f.total_sum, f.oplata, f.paid FROM futura f " +
                    $"JOIN postavshiki p ON f.id_postav = p.id;";

            }

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }

            _dataTable = _dataSet.Tables[0];
            dataGridView_Data.DataSource = _dataTable;
            int n = _namesTables.Length;
            if (_table == "futura")
                n = 5;
            for (int i = 0; i < n; i++)
                dataGridView_Data.Columns[i + 1].HeaderText = _namesTables[i];

            connection.Close();
            if (_table == "futura")
                updateSecondTable(0);
        }
        private void updateSecondTable(int id)
        {
            DataSet ds = new DataSet();
            string sql = $"SELECT f.id, f.id_futura, p.product, f.quantity, f.price FROM futura_info f " +
                    $"JOIN products p ON f.id_product = p.id WHERE f.id_futura = {id};";
            _connection.Open();

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                ds.Reset();
                dataAdapter.Fill(ds);
            }

            dataGridView_dataSecond.DataSource = ds.Tables[0];
            int n =5;
            for (int i = 0; i < 4; i++)
                dataGridView_dataSecond.Columns[i + 1].HeaderText = _namesTables[i + n];

            _connection.Close();
        }

        private void deleteData(int id)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"DELETE FROM {_table} WHERE id = '{id}';", _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        private void deleteDataSecond(int id)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"DELETE FROM futura_info WHERE id = '{id}';", _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }

        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            if (_table == "products")
            {
                AEProductForm aeProductForm = new AEProductForm(_stringConn, 0, null);
            }
            if (_table == "postavshiki")
            {
                AECustomers aeCustomers = new AECustomers(_stringConn, 0, null);
            }
        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            DataGridViewRow row = dataGridView_Data.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);

            if (_table == "products")
            {
                string[] attributes =
                {
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(), 
                    row.Cells[3].Value.ToString(),
                };
                AEProductForm aeProductForm = new AEProductForm(_stringConn, sId, attributes);
                aeProductForm.Name = "Товары";
            }
            if (_table == "postavshiki")
            {
                string[] attributes =
                {
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                };
                AECustomers aeCustomers = new AECustomers(_stringConn, sId, attributes);
                aeCustomers.Name = "Поставщики";
            }
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Data.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            DataGridViewRow row = dataGridView_Data.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);

            deleteData(sId);
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            updateDateGridView();
        }

        private void ToolStripMenuItem_addFutura_Click(object sender, EventArgs e)
        {
            AEFuturaForm aeFuturaForm = new AEFuturaForm(_stringConn, 0, null);
        }

        private void ToolStripMenuItem_addFuturaInfo_Click(object sender, EventArgs e)
        {
            AEFuturaInfoForm aeFuturaInfoForm = new AEFuturaInfoForm(_stringConn, 0, null);

        }

        private void ToolStripMenuItem_editFutura_Click(object sender, EventArgs e)
        {
            if (dataGridView_Data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите накладную");
                return;
            }
            DataGridViewRow row = dataGridView_Data.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);
            string[] attributes =
            {
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                };
            AEFuturaForm aeFuturaForm = new AEFuturaForm(_stringConn, sId, attributes);
        }

        private void ToolStripMenuItem_editFuturaInfo_Click(object sender, EventArgs e)
        {
            if (dataGridView_dataSecond.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите отчёт");
                return;
            }
            DataGridViewRow row = dataGridView_dataSecond.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);
            string[] attributes =
                {
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                };
            AEFuturaInfoForm aeFuturaInfoForm = new AEFuturaInfoForm(_stringConn, sId, attributes);
        }

        private void dataGridView_Data_SelectionChanged(object sender, EventArgs e)
        {
            if (_table != "futura")
                return;
            if (dataGridView_Data.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = dataGridView_Data.SelectedRows[0];
            int selectedId = Convert.ToInt32(row.Cells[0].Value);
            updateSecondTable(selectedId);
        }

        private void toolStripMenuItem_futuraInfo_Click(object sender, EventArgs e)
        {
            if (dataGridView_dataSecond.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите накладную");
                return;
            }
            DataGridViewRow row = dataGridView_dataSecond.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);
            deleteDataSecond(sId);
        }

        private void toolStripMenuItem_futura_Click(object sender, EventArgs e)
        {
            if (dataGridView_Data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите накладную");
                return;
            }
            DataGridViewRow row = dataGridView_Data.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);
            deleteData(sId);
        }
    }
}
