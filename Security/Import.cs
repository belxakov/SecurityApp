﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Security
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
            GetTables();
            SystemInactive();
            InactivityTimer();
        }

        string connectionString = data.connectionString;
        private Timer inactivityTimer;

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
            this.Hide();
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

        private void saveData_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocalAdmin.Menu menu = new LocalAdmin.Menu();
            menu.Show();
        }

        private void GetTables()
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SHOW TABLES", con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        boxTable.Items.Add(reader[0]);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void importData_Click(object sender, EventArgs e)
        {
            // Выбор файла
            OpenFileDialog getFile = new OpenFileDialog();
            getFile.InitialDirectory = "c:\\";
            getFile.Filter = "CSV files (*.csv)|*.csv";
            getFile.FilterIndex = 1;
            getFile.RestoreDirectory = true;
            if (getFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = getFile.FileName;
                ImportData(filePath, boxTable.SelectedItem.ToString());
            }
        }
        // Функция импорта
        private void ImportData(string filePath, string tablename)
        {
            using(MySqlConnection connect = new MySqlConnection(connectionString))
            {
                int count = 0;
                connect.Open();
                bool firstString = true;
                Encoding encoding = Encoding.GetEncoding(1251);
                using(StreamReader reader = new StreamReader(filePath, encoding))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        if(firstString) 
                        {
                            firstString = false;
                        }
                        else
                        {
                            var values = line.Split(';');
                            string query = string.Empty;
                            switch (tablename)
                            {
                                case "client":
                                    query = $"INSERT INTO `{tablename}` (id, surname, name, patronymic, organization, phoneNumber, passport) VALUES ({values[0]}, '{values[1]}', '{values[2]}', '{values[3]}', '{values[4]}', '{values[5]}', '{values[6]}')";
                                    break;
                                case "contract":
                                    query = $"INSERT INTO `{tablename}` (id, client, name_object, adress, type_object, status, type_security) VALUES ({values[0]}, '{values[1]}', '{values[2]}', '{values[3]}', '{values[4]}', '{values[5]}', '{values[6]}')";
                                    break;
                                case "incident":
                                    query = $"INSERT INTO `{tablename}` (id, description, status, date_incident, object) VALUES ({values[0]}, '{values[1]}', '{values[2]}', '{values[3]}', '{values[4]}')";
                                    break;
                                case "user":
                                    query = $"INSERT INTO `{tablename}` (id, surname, name, patronymic, post, identification_card, login, password, role) VALUES ({values[0]}, '{values[1]}', '{values[2]}', '{values[3]}', '{values[4]}', '{values[5]}', '{values[6]}', '{values[7]}', '{values[8]}')";
                                    break;
                            }
                            try
                            {
                                using(MySqlCommand cmd = new MySqlCommand(query, connect))
                                {
                                    cmd.ExecuteNonQuery();
                                    count++;
                                }
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show($"Error: {ex.Message}");
                            }
                        }
                    }
                    MessageBox.Show($"Данные успешно импортированы! Добавлено записей: {count}");
                }
                connect.Close();
            }
        }
    }
}
