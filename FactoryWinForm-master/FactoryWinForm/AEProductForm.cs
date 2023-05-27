using Npgsql;

namespace FactoryWinForm
{
    public partial class AEProductForm : Form
    {
        private NpgsqlConnection _connection;
        private int _id;
        public AEProductForm(NpgsqlConnection connection, int id, string?[] attributes)
        {
            _connection = connection;
            _id = id;
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
            }
            this.Show();
        }
        private void addNote(string name)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"INSERT INTO products (name) VALUES ('{name}');", _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        private void editNote(string name)
        {
            _connection.Open();

            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"UPDATE products SET name = '{name}'  " +
                $"WHERE id = {_id};", _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
                
            }
            _connection.Close();
        }
        private void button_action_Click(object sender, EventArgs e)
        {
            if (_id > 0 && textBox_name.Text != "" )
            {
                string name = textBox_name.Text;
                editNote(name);
            }
            else
            {
                string name = textBox_name.Text;
                addNote(name);
            }
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
