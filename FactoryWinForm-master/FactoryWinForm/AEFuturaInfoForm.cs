using Npgsql;
using System.Data;

namespace FactoryWinForm
{
    public partial class AEFuturaInfoForm : Form
    {
        NpgsqlConnection _connection;
        private int _id;
        private int _sId;
        string[] _attr;
        public AEFuturaInfoForm(string conn, int id, string?[] attributes)
        {
            _connection = new NpgsqlConnection(conn);
            _id = id;
            _attr = attributes;
            InitializeComponent();

            comboBoxAdd();

            if (_attr == null)
            {
                this.Text = "Добавить запись";
                button_action.Text = "Добавить";
                numericUpDown_nounce.Value = 0;
                _sId = id;
            }
            else
            {
                this.Text = "Изменить запись";
                button_action.Text = "Изменить";
                _sId = Convert.ToInt32(attributes[1]);
                comboBox_product.SelectedItem = attributes[2];
                numericUpDown_nounce.Value = Convert.ToInt32(attributes[3]);
                if (attributes[4] != "")
                    numericUpDown_totalSum.Value = Convert.ToInt32(attributes[4].Substring(0, attributes[4].Length - 3));
            }
            this.Show();
        }
        private bool addNote(string product, int nounce, int sum)
        {
            _connection.Open();
            int idProduct = searchProduct(product);
            if (idProduct == 0)
            {
                MessageBox.Show("Товар не найден");
                return false;
            }
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"INSERT INTO futura_info (id_futura, id_product, quantity, price) " +
                    $"VALUES ('{_sId}', '{idProduct}', '{nounce}', '{sum}')", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
            return true;
        }
        private bool editNote(string product, int nounce, int sum)
        {
            _connection.Open();
            int idProduct = searchProduct(product);
            if (idProduct == 0)
            {
                MessageBox.Show("Товар не найден");
                return false;
            }
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"UPDATE futura_info SET id_futura = '{_sId}', id_product = '{idProduct}', " +
                    $"quantity = '{nounce}', price = '{sum}' WHERE id = '{_id}';", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
            return true;
        }
        private void button_action_Click(object sender, EventArgs e)
        {
            string product = comboBox_product.SelectedItem.ToString();
            int nounce = Convert.ToInt32(numericUpDown_nounce.Value);
            int sum = Convert.ToInt32(numericUpDown_totalSum.Value);
            if (product == "")
            {
                MessageBox.Show("Заполните поле товар");
                return;
            }
            if (_attr == null)
            {
                if (!addNote(product, nounce, sum))
                    return;
            }
            else
            {
                if (!editNote(product, nounce, sum))
                    return;
            }
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int searchProduct(string product)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new
                NpgsqlDataAdapter($"SELECT id FROM products WHERE name = '{product}';", _connection))
            {
                dataAdapter.Fill(dataSet);
            }
            if (dataSet.Tables[0].Rows.Count == 0)
                return 0;
            return Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
        }
        private void comboBoxAdd()
        {
            comboBox_product.Items.Clear();

            DataSet dataSet = new DataSet();
            DataSet dataSetS = new DataSet();

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter($"SELECT name FROM products;", _connection))
            {
                dataSetS.Clear();
                dataAdapter.Fill(dataSetS);
            }
            for (int i = 0; i < dataSetS.Tables[0].Rows.Count; i++)
            {
                comboBox_product.Items.Add(dataSetS.Tables[0].Rows[i].ItemArray[0].ToString());
            }
        }
    }
}