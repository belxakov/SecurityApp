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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            GetDate();
        }

        string connectionString = data.connectionString;

        private void GetDate()
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT id, surname AS 'Фамилия', name AS 'Имя', patronymic AS 'Отчество', organization AS 'Организация', phoneNumber AS 'Номер телефона', passport AS 'Паспортные данные' FROM client", connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();
        }

        private void goMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private bool CheckPassportAndNumberPhone(string passport, string phoneNumber)
        {
            bool userExist = false;
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                string query = $"SELECT COUNT(*) FROM client WHERE passport = @passport OR phoneNumber = @phoneNumber";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@passport", passport);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                try
                {
                    connect.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    userExist = count > 0;
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return userExist;
        }

        private void newClient_Click(object sender, EventArgs e)
        {
            string surname = boxSurname.Text;
            string name = boxName.Text;
            string patronymic = boxPatronymic.Text;
            string organization = boxOrg.Text;
            string phoneNumber = boxNumberPh.Text;
            string passport = boxPassport.Text;
            using(MySqlConnection connect = new MySqlConnection())
            {
                connect.ConnectionString = data.connectionString;
                try
                {
                    string query = "INSERT INTO client (surname, name, patronymic, organization, phoneNumber, passport) VALUES (@surname, @name, @patronymic, @organization, @phoneNumber, @passport)";
                    MySqlCommand insertClient = new MySqlCommand(query, connect);
                    insertClient.Parameters.AddWithValue("@surname", surname);
                    insertClient.Parameters.AddWithValue("@name", name);
                    insertClient.Parameters.AddWithValue("@patronymic", patronymic);
                    insertClient.Parameters.AddWithValue("@organization", organization);
                    insertClient.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    insertClient.Parameters.AddWithValue("@passport", passport);
                    try
                    {
                        if (string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(name) || phoneNumber == null || passport == null)
                        {
                            MessageBox.Show("Ошибка: заполните все обязательные поля!\n(Фамилия, Имя, Номер телефона, Серия и номер паспорта)", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            boxSurname.Text = null;
                            boxName.Text = null;
                            boxPatronymic.Text = null;
                            boxOrg.Text = null;
                            boxNumberPh.Text = null;
                            boxPassport.Text = null;
                        }
                        else
                        {
                            if(!CheckPassportAndNumberPhone(passport, phoneNumber))
                            {
                                connect.Open();
                                int result = insertClient.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Пользователь успешно добавлен!", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    boxSurname.Text = null;
                                    boxName.Text = null;
                                    boxPatronymic.Text = null;
                                    boxOrg.Text = null;
                                    boxNumberPh.Text = null;
                                    boxPassport.Text = null;
                                    GetDate();
                                }
                                else
                                {
                                    MessageBox.Show("Пользователь не был добавлен!", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                connect.Close();
                            }
                            else
                            {
                                MessageBox.Show("Пользователь с такими паспортными данными или номером телефона уже существует!", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void boxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void boxPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void boxPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                string surname = boxSurname.Text;
                string name = boxName.Text;
                string patronymic = boxPatronymic.Text;
                string org = boxOrg.Text;
                string phoneNumber = boxNumberPh.Text;
                string passport = boxPassport.Text;

                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                using(MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open();
                        string query = "UPDATE client SET surname = @surname, name = @name, patronymic = @patronymic," +
                           " organization = @organization, phoneNumber = @phoneNumber, passport = @passport WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@patronymic", patronymic);
                        cmd.Parameters.AddWithValue("@organization", org);
                        cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@passport", passport);
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if(rowsAffected > 0)
                        {
                            MessageBox.Show("Запись успешно изменена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetDate();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка обновления записи!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connect.Close();
                        surname = null;
                        name = null;
                        patronymic = null;
                        org = null;
                        phoneNumber = null;
                        passport = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите запись!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
