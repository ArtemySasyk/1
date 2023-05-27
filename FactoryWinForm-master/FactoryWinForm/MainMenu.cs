using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FactoryWinForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            string tableName = "products";
            string[] tableFields =
            {
                "Наименование",
            };
            DataForm productsDataForm = new DataForm(tableName, tableFields);
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            string tableName = "producer";
            string[] tableFields =
            {
                "Поставщик",
                "Адрес",
                "Телефон",
            };
            DataForm customersDataForm = new DataForm(tableName, tableFields);
        }

        private void button_invoices_Click(object sender, EventArgs e)
        {
            string tableName = "futura";
            string[] tableFields =
            {
                "Поставщик",
                "Дата заказа",
                "Выплаченная сумма", 
                "Сумма",
                "Должник",
                "Поставщик",
                "Товар",
                "Кол-во",
                "Цена",
            };
            DataForm futuraDataForm = new DataForm(tableName, tableFields);
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection(
                "Server=localhost; Port=5432; User Id=postgres; Password=2243350; Database=kosmatov342");
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            connection.Open();
            string sql = $"SELECT f.id, p.producer_name, f.date, f.sum_paid, f.total_sum, debtor FROM futura f" +
                $"          JOIN producer p ON f.producer_id = p.id;";

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, connection))
            {
                dataSet.Reset();
                dataAdapter.Fill(dataSet);
            }

            dataTable = dataSet.Tables[0];

            connection.Close();
            string[] columns = {
                "Номер накладной",
                "Имя поставщика",
                "Дата",
                "Выплаченная сумма",
                "Общая сумма",
                "Задолжность",
            };
            if (dataTable.Rows.Count < 1)
            {
                MessageBox.Show("Записей не найдено");
                return;
            }
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < columns.Length + 1; i++)
            {
                application.Cells[1, i] = columns[i -1];
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j <6; j++)
                {
                    application.Cells[i + 2, j + 1] = dataTable.Rows[i].ItemArray[j].ToString();
                }
            }
            application.Columns.AutoFit();
            application.Visible = true;
        }
    }
}
