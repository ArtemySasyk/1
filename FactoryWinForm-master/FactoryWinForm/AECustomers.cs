using Npgsql;

namespace FactoryWinForm
{
    public partial class AECustomers : Form
    {
        private NpgsqlConnection _connection;
        private int _id;
        public AECustomers(NpgsqlConnection connection, int id, string?[] attributes)
        {
            InitializeComponent();
            if (id < 1)
            {
                this.Text = "Добавить запись";
                button_action.Text = "Добавить";
            }
            else
            {
                this.Text = "Изменить запись";
                button_action.Text = "Изменить";
                textBox_name.Text = attributes[0];
                textBox_address.Text = attributes[1];
                textBox_phone.Text = attributes[2];
            }
            this.Show();
            _connection = connection;
            _id = id;
        }
        private void addNote(string name, string adress, string phone)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"INSERT INTO producer (producer_name, producer_address, producer_phone) VALUES ('{name}', '{adress}', '{phone}')", _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        private void editNote(string name, string adress, string phone)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"UPDATE producer SET producer_name = '{name}', producer_address = '{adress}', producer_phone = '{phone}'" +
                $"WHERE id = {_id}", _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        private void button_action_Click(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                string name = textBox_name.Text;
                string address = textBox_address.Text;
                string phone = textBox_phone.Text;
                editNote(name, address, phone);
            }
            else
            {
                string name = textBox_name.Text;
                string address = textBox_address.Text;
                string phone = textBox_phone.Text;
                addNote(name, address, phone);
            }
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
