using Npgsql;
using System.Data;

namespace FactoryWinForm
{
    public partial class AEFuturaInfoForm : Form
    {
        NpgsqlConnection _connection;
        private int _id;
        public AEFuturaInfoForm(string conn, int id, string?[] attributes)
        {
            _connection = new NpgsqlConnection(conn);
            _id = id;

            InitializeComponent();

            comboBoxAdd();

            if (id == 0)
            {
                this.Text = "Добавить запись";
                button_action.Text = "Добавить";
                numericUpDown_nounce.Value = 0;
            }
            else
            {
                this.Text = "Изменить запись";
                button_action.Text = "Изменить";
                comboBox_futura.SelectedItem = attributes[0];
                comboBox_product.SelectedItem = attributes[1];
                numericUpDown_nounce.Value = Convert.ToInt32(attributes[2]);
                if (attributes[3] != "")
                    numericUpDown_totalSum.Value = Convert.ToInt32(attributes[3].Substring(0, attributes[3].Length - 3));
            }
            this.Show();
        }
        private bool addNote(string futura, string product, int nounce, int sum)
        {
            _connection.Open();
            int idFutura = searchFutura(futura);
            int idProduct = searchProduct(product, nounce);
            if (idFutura == 0)
            {
                MessageBox.Show("Накладная не найдена");
                return false;
            }
            if (idProduct == 0)
            {
                MessageBox.Show("Товар не найден");
                return false;
            }
            if (idProduct == -1)
            {
                _connection.Close();
                MessageBox.Show("Товар не соответствует количеству");
                return false;
            }
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"INSERT INTO futura_info (id_futura, id_product, quantity, price) " +
                    $"VALUES ('{idFutura}', '{idProduct}', '{nounce}', '{sum}')", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }

            }
            _connection.Close();
            return true;
        }
        private bool editNote(string futura, string product, int nounce, int sum)
        {
            _connection.Open();
            int idFutura = searchFutura(futura);
            int idProduct = searchProduct(product, nounce);
            if (idFutura == 0)
            {
                MessageBox.Show("Накладная не найдена");
                return false;
            }
            if (idProduct == 0)
            {
                MessageBox.Show("Товар не найден");
                return false;
            }
            if (idProduct == -1)
            {
                MessageBox.Show("Товар не соответствует количеству");
                return false;
            }
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"UPDATE futura_info SET id_futura = '{idFutura}', id_product = '{idProduct}', " +
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
            string futura = comboBox_futura.SelectedItem.ToString();
            string product = comboBox_product.SelectedItem.ToString();
            int nounce = Convert.ToInt32(numericUpDown_nounce.Value);
            int sum = Convert.ToInt32(numericUpDown_totalSum.Value);
            if (futura == "")
            {
                MessageBox.Show("Заполните поле накладная");
                return;
            }
            if (product == "")
            {
                MessageBox.Show("Заполните поле товар");
                return;
            }
            if (_id == 0)
            {
                if (!addNote(futura, product, nounce, sum))
                    return;
            }
            else
            {
                if (!editNote(futura, product, nounce, sum))
                    return;
            }
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int searchFutura(string id)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new
                NpgsqlDataAdapter($"SELECT id FROM futura WHERE id = '{id}';", _connection))
            {
                dataAdapter.Fill(dataSet);
            }
            if (dataSet.Tables[0].Rows.Count == 0)
                return 0;
            return Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
        }
        private int searchProduct(string product, int nounce)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new
                NpgsqlDataAdapter($"SELECT id, nounce FROM products WHERE product = '{product}';", _connection))
            {
                dataAdapter.Fill(dataSet);
            }
            if (Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]) < nounce) {
                MessageBox.Show("Не хватает кол-ва продукта"); 
                return -1;
            }
                if (dataSet.Tables[0].Rows.Count == 0)
            {
                return 0;
            }
            return Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
        }
        private void comboBoxAdd()
        {
            comboBox_futura.Items.Clear();
            comboBox_product.Items.Clear();

            DataSet dataSet = new DataSet();
            DataSet dataSetS = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter($"SELECT id FROM futura;", _connection))
            {
                dataSet.Clear();
                dataAdapter.Fill(dataSet);
            }
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBox_futura.Items.Add(dataSet.Tables[0].Rows[i].ItemArray[0].ToString());
            }

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter($"SELECT product FROM products;", _connection))
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