using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security
{
    public partial class SecurityObjects : Form
    {
        public SecurityObjects()
        {
            InitializeComponent();
            GetDate();
        }

        string connectionString = data.connectionString;

        private void GetDate()
        {
            using(MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', type_security AS 'Тип охраны' FROM contract";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
    }
}
