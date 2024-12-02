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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
            GetDate();
            CheckRole();
            boxRole.Items.Add("Сотрудник");
            boxRole.Items.Add("Дежурный");
            boxRole.Items.Add("Менеджер");
            boxRole.Items.Add("Администратор");
            boxRole.SelectedIndex = 0;
        }

        private Random rand = new Random();
        string connectionString = data.connectionString;

        private void GetDate()
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT surname AS 'Фамилия', name AS 'Имя', patronymic AS 'Отчество', post AS 'Должность', identification_card AS 'Удостоверение', login AS 'Логин', password AS 'Пароль', role AS 'Роль' FROM user", connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();
        }

        private void CheckRole()
        {
            if(data.uRole == "2")
            {
                dataGridView1.Height = 382;
                // label
                labTittle.Visible = false;
                labSurname.Visible = false;
                labName.Visible = false;
                labPatronymic.Visible = false;
                labPost.Visible = false;
                labIndCard.Visible = false;
                labRole.Visible = false;
                labLogin.Visible = false;
                labPassword.Visible = false;
                // boxes
                boxSurname.Visible = false;
                boxName.Visible = false;
                boxPatronymic.Visible = false;
                boxPost.Visible = false;
                boxIndCard.Visible = false;
                boxRole.Visible = false;
                boxLogin.Visible = false;
                boxPassword.Visible = false;
                newMember.Visible = false;
                generateLogin.Visible = false;
                generatePassword.Visible = false;
            }
        }

        private bool CheckLoginAndPassword(string login, string indCard)
        {
            bool userExist = false;
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                string query = $"SELECT COUNT(*) FROM user WHERE login = @login OR identification_card = @indCard";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@indCard", indCard);
                try
                {
                    connect.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    userExist = count > 0;
                    connect.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return userExist;
        }

        public string GenerateLogin(int length)
        {
            const string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghigklmnopqrstuvwxyz0123456789";
            char[] login = new char[length];
            for (int i = 0; i < length; i++)
            {
                login[i] = symbols[rand.Next(symbols.Length)];
            }
            return new string(login);
        }
        public string GeneratePassword(int length)
        {
            const string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghigklmnopqrstuvwxyz0123456789";
            char[] pwd = new char[length];
            for (int i = 0; i < length; i++)
            {
                pwd[i] = symbols[rand.Next(symbols.Length)];
            }
            return new string(pwd);
        }


        private void goMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void generateLogin_Click(object sender, EventArgs e)
        {
            boxLogin.Text = "loginU" + GenerateLogin(6);
        }

        private void generatePassword_Click(object sender, EventArgs e)
        {
            boxPassword.Text = GeneratePassword(8);
        }

        private void newMember_Click(object sender, EventArgs e)
        {
            string surname = boxSurname.Text;
            string name = boxName.Text;
            string patronymic = boxPatronymic.Text;
            string post = boxPost.Text;
            string indCard = boxIndCard.Text;
            string login = boxLogin.Text;
            string password = boxPassword.Text;
            int role = boxRole.SelectedIndex + 1;
            using (MySqlConnection connect = new MySqlConnection())
            {
                connect.ConnectionString = data.connectionString;
                try
                {
                    string query = "INSERT INTO user (surname, name, patronymic, post, identification_card, login, password, role) VALUES (@surname, @name, @patronymic, @post, @indCard, @login, @password, @role)";
                    MySqlCommand insertUser = new MySqlCommand(query, connect);
                    insertUser.Parameters.AddWithValue("@surname", surname);
                    insertUser.Parameters.AddWithValue("@name", name);
                    insertUser.Parameters.AddWithValue("@patronymic", patronymic);
                    insertUser.Parameters.AddWithValue("@post", post);
                    insertUser.Parameters.AddWithValue("@indCard", indCard);
                    insertUser.Parameters.AddWithValue("@login", login);
                    insertUser.Parameters.AddWithValue("@password", password);
                    insertUser.Parameters.AddWithValue("@role", role);
                    try
                    {
                        if (string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(post) || indCard == "" ||
                            string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                        {
                            MessageBox.Show("Ошибка: заполните все обязательные поля!\n(Фамилия, Имя, Должность, Серия и номер удостоверения, Логин, Пароль)", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            boxSurname.Text = null;
                            boxName.Text = null;
                            boxPatronymic.Text = null;
                            boxPost.Text = null;
                            boxIndCard.Text = null;
                            boxLogin.Text = null;
                            boxPassword.Text = null;
                            boxRole.SelectedIndex = 0;
                        }
                        else
                        {
                            connect.Open();
                            if (CheckLoginAndPassword(login, indCard))
                            {
                                MessageBox.Show("Ошибка! Пользователь с таким логином или удостверением уже существует!");
                            }
                            else
                            {
                                int result = insertUser.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Пользователь успешно добавлен!", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    boxSurname.Text = null;
                                    boxName.Text = null;
                                    boxPatronymic.Text = null;
                                    boxPost.Text = null;
                                    boxIndCard.Text = null;
                                    boxLogin.Text = null;
                                    boxPassword.Text = null;
                                    boxRole.SelectedIndex = 0;
                                    GetDate();
                                }
                                else
                                {
                                    MessageBox.Show("Пользователь не был добавлен!", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            connect.Close();
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

        private void boxPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void boxIndCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void boxRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
