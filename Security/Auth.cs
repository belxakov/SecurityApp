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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            boxPassword.UseSystemPasswordChar = true;
        }

        string connectionString = data.connectionString;
        public int mask = 0;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(data.login == "admin1" && data.password == "admin1")
            {
                this.Hide();
                Import import = new Import();
                import.Show();
            }
            try
            {
                string login = boxLogin.Text.ToString();
                string password = boxPassword.Text.ToString();
                string role = string.Empty;

                MySqlConnection connect = new MySqlConnection(connectionString);
                connect.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM user WHERE login = '{login}'", connect);
                MySqlDataAdapter dAdapter = new MySqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                string uid = dTable.Rows[0].ItemArray.GetValue(0).ToString();
                string userSurname = dTable.Rows[0].ItemArray.GetValue(1).ToString();
                string userName = dTable.Rows[0].ItemArray.GetValue(2).ToString();
                string userPatronymic = dTable.Rows[0].ItemArray.GetValue(3).ToString();
                string userCard = dTable.Rows[0].ItemArray.GetValue(5).ToString();
                string userRole = dTable.Rows[0].ItemArray.GetValue(8).ToString();

                data.uSurname = userSurname;
                data.uName = userName;
                data.uPatronymic = userPatronymic;
                data.uCard = userCard;
                data.uRole = userRole;


                if (password == dTable.Rows[0].ItemArray.GetValue(7).ToString())
                {
                    if (userRole == "1")
                    {
                        MessageBox.Show($"Вы успешно авторизовались!\nСотрудник: {userName} {userSurname}", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenu menu = new MainMenu();
                        menu.Show();
                    }
                    else if (userRole == "2")
                    {
                        MessageBox.Show($"Вы успешно авторизовались!\nДежурный: {userName} {userSurname}", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenu menu = new MainMenu();
                        menu.Show();
                    }
                    else if (userRole == "3")
                    {
                        MessageBox.Show($"Вы успешно авторизовались!\nМенеджер: {userName} {userSurname}", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenu menu = new MainMenu();
                        menu.Show();
                    }
                    else if (userRole == "4")
                    {
                        MessageBox.Show($"Вы успешно авторизовались!\nАдминистратор: {userName} {userSurname}", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenu menu = new MainMenu();
                        menu.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка: Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connect.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка: Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boxMaskPassword_CheckedChanged(object sender, EventArgs e)
        {
            mask++;
            if(mask % 2 == 1)
            {
                boxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                boxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
