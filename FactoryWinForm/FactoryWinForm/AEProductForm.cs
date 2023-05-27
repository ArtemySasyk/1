using Npgsql;

namespace FactoryWinForm
{
    public partial class AEProductForm : Form
    {
        private NpgsqlConnection _connection;
        private int _id;
        public AEProductForm(string con, int id, string?[] attributes)
        {
            _connection = new NpgsqlConnection(con);
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
                textBox_info.Text = attributes[1];
                numericUpDown_nounce.Value = Convert.ToInt32(attributes[2]);
            }
            this.Show();
        }
        private void addNote(string name, string info, int nounce)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"INSERT INTO products (product, info_pr, nounce) VALUES ('{name}', '{info}',{nounce});", _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        private void editNote(string name,string info, int nounce)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"UPDATE products SET product = '{name}',info_pr = '{info}', nounce = '{nounce}' " +
                $"WHERE id = {_id};", _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        private void button_action_Click(object sender, EventArgs e)
        {
            if (_id > 0 && textBox_name.Text != "" && numericUpDown_nounce.Value != 0)
            {
                string name = textBox_name.Text;
                string info = textBox_info.Text;
                int nounce = Convert.ToInt32(numericUpDown_nounce.Value);
                editNote(name,info, nounce);
            }
            else
            {
                string name = textBox_name.Text;
                string info = textBox_info.Text;
                int nounce = Convert.ToInt32(numericUpDown_nounce.Value);
                addNote(name,info, nounce);
            }
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
