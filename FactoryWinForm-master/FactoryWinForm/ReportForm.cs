using Microsoft.Office.Interop.Excel;
using Npgsql;
using System.Data;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace FactoryWinForm
{
    public partial class ReportForm : Form
    {
        private NpgsqlConnection _connection = new NpgsqlConnection();
        private DataSet _dataSet = new DataSet();
        private DataTable _dataTable = new DataTable();
        private string[] _columnsRU;
        public ReportForm()
        {
            _columnsRU = new string[] {
                "Поставщик",
            };
            InitializeComponent();
            this.Show();
            initConnection();
            this.Text = "Формирование отчёта";
            updateDataGridView();
        }

        private void initConnection()
        {
            _connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=2243350; Database=kosmatov342");
        }
        private void updateDataGridView()
        {
            _connection.Open();
            string sql = $"SELECT id, producer_name FROM producer;";

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }

            _dataTable = _dataSet.Tables[0];
            dataGridView_clients.DataSource = _dataTable;
            for (int i = 0; i < _columnsRU.Length; i++)
                dataGridView_clients.Columns[i + 1].HeaderText = _columnsRU[i];

            _connection.Close();
        }

        private void exportToExcel(DataTable table)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            application.Columns.AutoFit();
            application.Visible = true;
        }

        private DataTable answerDB()
        {
            DataTable table = new DataTable();

            return table;
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            string[] dts = dateTimePicker_start.Text.Split('.');
            string dateStart = $"{dts[2]}-{dts[1]}-{dts[0]}";
            string[] dte = dateTimePicker_end.Text.Split('.');
            string dateEnd = $"{dte[2]}-{dte[1]}-{dte[0]}";
            string selectedNames = "";
            int n = dataGridView_clients.SelectedRows.Count;
            if (n == 0)
                return;
            selectedNames += $"p.producer_name = '{dataGridView_clients.SelectedRows[0].Cells[1].Value}'";
            for (int i = 1; i < n; i++)
            {
                selectedNames += $" OR p.producer_name = '{dataGridView_clients.SelectedRows[i].Cells[1].Value}'";
            }
            string sql = $"SELECT f.id, fi.id, p.producer_name, sum(f.total_sum) as max, sum(f.total_sum - f.sum_paid) as min FROM futura_info fi " +
                $"JOIN futura f ON fi.id_futura = f.id JOIN producer p ON p.id = f.producer_id WHERE { selectedNames} " +
                $"AND f.date >= '{dateStart}' AND f.date <= '{dateEnd}' GROUP BY fi.id,f.id,p.producer_name; ";

            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; " +
                "Password=2243350; Database=kosmatov342");
            connection.Open();
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                ds.Reset();
                dataAdapter.Fill(ds);
            }
            table = ds.Tables[0];
            string[] columns = {
                "Номер отчёта",
                "Имя поставщика",
                "Оборот",
                "Не выплаченно"
            };
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Записей не найдено");
                return;
            }
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < columns.Length + 1; i++)
            {
                application.Cells[1, i] = columns[i - 1];
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    application.Cells[i + 2, j + 1] = table.Rows[i].ItemArray[j+1].ToString();
                }
            }
            application.Columns.AutoFit();
            application.Visible = true;
        }
    }
}