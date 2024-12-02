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
    public partial class NewContract : Form
    {
        public NewContract()
        {
            InitializeComponent();
            TypeObject();
            Client();
        }
        string connectionString = data.connectionString;
        private void TypeObject()
        {
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT name FROM type_object";
                    MySqlCommand listType = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader = listType.ExecuteReader();
                    while (reader.Read())
                    {
                        boxTypeObject.Items.Add($"{reader["name"]}");
                    }
                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Client()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT surname, name, patronymic FROM client";
                    MySqlCommand listClient = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader = listClient.ExecuteReader();
                    while (reader.Read())
                    {
                        boxClient.Items.Add($"{reader["surname"]} {reader["name"]} {reader["patronymic"]}");
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Conclusion()
        {
            string nameObject = boxNameObj.Text;
            string adress = boxAdress.Text;
            string client = boxClient.Text;
            string typeObject = boxTypeObject.Text;
            string status = boxStatus.Text;
            string typeSecurity = boxTypeSecurity.Text;
            using(MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO contract (client, name_object, adress, type_object, status, type_security) VALUES (@client, @nameObject, @adress, @typeObject, @status, @typeSecurity)";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@client", client);
                    cmd.Parameters.AddWithValue("@nameObject", nameObject);
                    cmd.Parameters.AddWithValue("@adress", adress);
                    cmd.Parameters.AddWithValue("@typeObject", typeObject);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@typeSecurity", typeSecurity);
                    try
                    {
                        connect.Open();
                        int result = cmd.ExecuteNonQuery();
                        if(result > 0)
                        {
                            MessageBox.Show("Договор успешно заключен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            boxNameObj.Text = null;
                            boxAdress.Text = null;
                            boxClient.Text = null;
                            boxTypeObject.Text = null;
                            boxStatus.Text = null;
                            boxTypeSecurity.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("Договор не был заключен!","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connect.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void conclusionContract_Click(object sender, EventArgs e)
        {
            Conclusion();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
