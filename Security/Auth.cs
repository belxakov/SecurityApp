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
            FormInit();
            TimerInit();
            GenerateCaptha();
            boxPassword.UseSystemPasswordChar = true;
        }

        string connectionString = data.connectionString;
        public int mask = 0;
        Random rand = new Random();
        string codeCaptha;
        public Timer timer;

        private void FormInit()
        {
            Width = 815;
            Height = 480;
            headerText.Location = new System.Drawing.Point(31, 9);
        }

        private void TimerInit()
        {
            timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            boxCaptha.Enabled = true;
            completeCaptha.Enabled = true;
            timer.Stop();
            completeCaptha.Text = "Подтвердить";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(boxLogin.Text == "admin1" && boxPassword.Text == "admin1")
            {
                this.Hide();
                LoadBackup backup = new LoadBackup();
                backup.Show();
            }
            else
            {
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
                        Width = 1150;
                        headerText.Location = new System.Drawing.Point(183, 5);
                    }
                    connect.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка: Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Width = 1150;
                    boxLogin.Enabled = false;
                    boxPassword.Enabled = false;
                    headerText.Location = new System.Drawing.Point(183, 5);
                }
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

        // [CAPTHA]
        public string GenerateCodeCaptha(int length)
        {
            // генерация кода
            const string symbols = "abcdefghijklmnopqrstuvwxyz0123456789";
            char[] code = new char[length];
            for (int i = 0; i < length; i++)
            {
                code[i] = symbols[rand.Next(symbols.Length)];
            }
            return new string(code);
        }
        private void GenerateCaptha()
        {
            picBoxCaptha.Visible = true;
            codeCaptha = GenerateCodeCaptha(4);
            Bitmap img = new Bitmap(270, 100);
            using (Graphics graph = Graphics.FromImage(img)) // отрисовка
            {
                graph.Clear(Color.White);
                for (int i = 0; i < 1000; i++) // Помехи
                {
                    int posX = rand.Next(0, img.Width);
                    int posY = rand.Next(0, img.Height);
                    graph.FillEllipse(Brushes.LightGray, posX, posY, 5, 5); // (цвет кисти, коорд X Y, ширина, высота)
                }
                for (int i = 0; i < codeCaptha.Length; i++)
                {
                    Font font = new Font("Arial", 24 + rand.Next(10, 50));
                    Brush brush = Brushes.Black;
                    float angle = rand.Next(-30, 30);
                    graph.TranslateTransform(i * 40 + 10, rand.Next(10, 50));
                    graph.RotateTransform(angle);
                    graph.DrawString(codeCaptha[i].ToString(), font, brush, 0, 0);
                    graph.ResetTransform();
                }
                picBoxCaptha.Image = img;
            }
        }

        private void completeCaptha_Click(object sender, EventArgs e)
        {
            if (boxCaptha.Text == codeCaptha)
            {
                Width = 815;
                Height = 480;
                boxLogin.Enabled = true;
                boxPassword.Enabled = true;
                boxCaptha.Text = null;
                headerText.Location = new System.Drawing.Point(31, 9);
                GenerateCaptha();
            }
            else
            {
                boxCaptha.Enabled = false;
                completeCaptha.Enabled = false;
                timer.Start();
                GenerateCaptha();
                completeCaptha.Text = "Ввод заблокирован";
                MessageBox.Show("Некорректный ввод капчи! Ввод заблокирован на 10 секунд");
            }
        }
    }
}
