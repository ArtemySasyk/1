using Npgsql;
using System.Data;

namespace FactoryWinForm
{
    public partial class AEFuturaForm : Form
    {
        private NpgsqlConnection _connection;
        private int _id;
        public AEFuturaForm(string con, int id, string?[] attributes)
        {
            _connection = new NpgsqlConnection(con);
            InitializeComponent();
            comboBoxAdd();

            if (id < 1)
            {
                this.Text = "Добавить запись";
                button_action.Text = "Добавить";
                
            }
            else
            {
                this.Text = "Изменить запись";
                button_action.Text = "Изменить";
                comboBox_name.SelectedItem = attributes[0];
                string[] dateSt = attributes[1].Split('.');
                dateSt[2] = dateSt[2].Split(' ')[0];
                dateTimePicker_date.Value = new
                    DateTime(Convert.ToInt32(dateSt[2]), Convert.ToInt32(dateSt[1]), Convert.ToInt32(dateSt[0]));
                if (attributes[2] != "")
                    numericUpDown1.Value = Convert.ToInt32(attributes[2].Substring(0, attributes[2].Length - 3));
                if (attributes[3] == "True")
                {
                    label_paid.Visible = false;
                    numericUpDown1.Visible = false;
                }
            }
            this.Show();
            _id = id;
        }
        private void addNote(string name, string date, int paid)
        {
            _connection.Open();
            int idCustomer = searchCustomer(name);
            if (idCustomer == 0)
                MessageBox.Show("Поставщик не найден");
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"INSERT INTO futura (id_postav, date, paid)" +
                    $" VALUES ('{idCustomer}', '{date}','{paid}')", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
        }
        private void editNote(string name, string date, int paid)
        {
            _connection.Open();
            int idCustomer = searchCustomer(name);
            if (idCustomer == 0)
                MessageBox.Show("Поставщик не найден");
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"UPDATE futura SET id_postav = '{idCustomer}', date = '{date}', paid = '{paid}' WHERE id = {_id}", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
        }
        private void button_action_Click(object sender, EventArgs e)
        {
            string name = comboBox_name.SelectedItem.ToString();
            DateTime dateTime = dateTimePicker_date.Value;
            string date = $"{dateTime.Year}-{dateTime.Month}-{dateTime.Day}";
            int paid = Convert.ToInt32(numericUpDown1.Value);
            if (name == "")
            {
                MessageBox.Show("Заполните поле Поставщик");
                return;
            }

            if (_id == 0)
            {
                addNote(name, date, paid);
            }
            else
            {
                editNote(name, date,paid);
            }
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int searchCustomer(string name)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new
                NpgsqlDataAdapter($"SELECT id FROM postavshiki WHERE name = '{name}';", _connection))
            {
                dataAdapter.Fill(dataSet);
            }
            if (dataSet.Tables[0].Rows.Count == 0)
                return 0;
            return Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
        }
        private void comboBoxAdd()
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new
                NpgsqlDataAdapter($"SELECT name FROM postavshiki;", _connection))
            {
                dataAdapter.Fill(dataSet);
            }
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBox_name.Items.Add(dataSet.Tables[0].Rows[i].ItemArray[0].ToString());
            }
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }
    }
}
