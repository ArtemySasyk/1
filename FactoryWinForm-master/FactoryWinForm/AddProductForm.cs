using Npgsql;
using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryWinForm
{
    public partial class AddProductForm : Form
    {
        private NpgsqlConnection _connection;
        private string _table;
        public AddProductForm(NpgsqlConnection connection, string table)
        {
            _connection = connection;
            _table = table;
            InitializeComponent();
        }
        private void addNote(string name, int nounce)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"INSERT INTO products (name, nounce) VALUES ('{name}', {nounce})"))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "" && Convert.ToInt32(numericUpDown_nounce.Value) > 0)
            {
                addNote(textBox_name.Text, Convert.ToInt32(numericUpDown_nounce.Text));
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
