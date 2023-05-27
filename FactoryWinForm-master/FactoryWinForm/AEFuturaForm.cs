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
                numericUpDown1.ReadOnly = true;
                numericUpDown1.Increment = 0;
                this.Text = "Добавить запись";
                button_action.Text = "Добавить";
            }
            else
            {
                this.Text = "Изменить запись";
                button_action.Text = "Изменить";
                comboBox1.SelectedItem = attributes[0];
                string[] dateSt = attributes[1].Split('.');
                dateSt[2] = dateSt[2].Split(' ')[0];
                dateTimePicker_date.Value = new
                    DateTime(Convert.ToInt32(dateSt[2]), Convert.ToInt32(dateSt[1]), Convert.ToInt32(dateSt[0]));
                numericUpDown1.Value = Convert.ToInt32(attributes[2].Split(',')[0]);
                dateTimePicker_date.Enabled = false;
                comboBox1.Enabled = false;
                if (attributes[3] == "True")
                {
                    numericUpDown1.ReadOnly = true;
                    numericUpDown1.Increment = 0;
                }
            }
            this.Show();
            _id = id;
        }
        private void addNote(string name, string date,float sum)
        {
            _connection.Open();
            int idCustomer = searchCustomer(name);
            if (idCustomer == 0)
                MessageBox.Show("Поставщик не найден");
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"INSERT INTO futura (producer_id, date,sum_paid)" +
                    $" VALUES ('{idCustomer}', '{date}','{sum}')", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
        }
        private void editNote(string name, string date,float sum)
        {
            _connection.Open();
            int idCustomer = searchCustomer(name);
            if (idCustomer == 0)
                MessageBox.Show("Поставщик не найден");
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"UPDATE futura SET producer_id = '{idCustomer}', date = '{date}', sum_paid= '{sum}' WHERE id = {_id}", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
        }
        private void button_action_Click(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            DateTime dateTime = dateTimePicker_date.Value;
            string date = $"{dateTime.Year}-{dateTime.Month}-{dateTime.Day}";
            float sum = Convert.ToInt32(numericUpDown1.Value);
            if (name == "")
            {
                MessageBox.Show("Заполните поле поставщик");
                return;
            }
            if (_id == 0)
            {
                addNote(name, date,0);
            }
            else
            {
                if (dateTimePicker_date.Value < DateTime.Now.AddMonths(-5)) MessageBox.Show("Должник");
                editNote(name, date,sum);
            }
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
           // isDebtor();
            this.Close();
        }
        private int searchCustomer(string name)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new
                NpgsqlDataAdapter($"SELECT id FROM producer WHERE producer_name = '{name}';", _connection))
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
                NpgsqlDataAdapter($"SELECT producer_name FROM producer;", _connection))
            {
                dataAdapter.Fill(dataSet);
            }
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(dataSet.Tables[0].Rows[i].ItemArray[0].ToString());
            }
        }
        private void isDebtor()
        {
            _connection.Open();
            if (dateTimePicker_date.Value < DateTime.Now.AddMonths(-5))
            {
                using (NpgsqlCommand npgsqlCommand = new
                NpgsqlCommand($"UPDATE futura SET debtor= '{true}' WHERE id = {_id}", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
        }
    }
}
