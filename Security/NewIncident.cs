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
    public partial class NewIncident : Form
    {
        public NewIncident()
        {
            InitializeComponent();
            InfoObject();
            SystemInactive();
            InactivityTimer();
        }

        string connectionString = data.connectionString;
        public Timer inactivityTimer;

        private void SystemInactive()
        {
            this.MouseMove += ResetInactivityTimer;
            this.KeyPress += ResetInactivityTimer;
        }

        private void InactivityTimer()
        {
            inactivityTimer = new Timer();
            inactivityTimer.Interval = data.inactivityTime;
            inactivityTimer.Tick += InactivityTimer_Tick;
            inactivityTimer.Start();
            return;
        }

        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            inactivityTimer.Stop();
            this.Close();
            Auth auth = new Auth();
            auth.Show();
            return;
        }

        private void ResetInactivityTimer(object sender, EventArgs e)
        {
            inactivityTimer.Start();
            inactivityTimer.Stop();
            return;
        }

        private void InfoObject()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT name_object FROM contract";
                    MySqlCommand listType = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader = listType.ExecuteReader();
                    while (reader.Read())
                    {
                        boxObject.Items.Add($"{reader["name_object"]}");
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

        private void regIncident_Click(object sender, EventArgs e)
        {
            string nObject = boxObject.Text;
            string status = boxStatus.Text;
            string desc = boxDesc.Text;
            DateTime currentDate = DateTime.Now;

            using(MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO incident (description, status, date_incident, object) VALUES (@desc, @status, @currentDate, @nObject)";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@currentDate", currentDate);
                    cmd.Parameters.AddWithValue("@nObject", nObject);
                    try
                    {
                        connect.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Вызов зарегистрирован!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Вызов не был зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        boxObject.Text = "";
                        boxStatus.Text = "";
                        boxDesc.Text = "";
                        connect.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Incidents incidents = new Incidents();
            incidents.Show();
        }
    }
}
