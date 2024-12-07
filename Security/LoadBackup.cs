using System;
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
    public partial class LoadBackup : Form
    {
        public LoadBackup()
        {
            InitializeComponent();
            SystemInactive();
            InactivityTimer();
        }

        string connectionString = @"host=localhost;user=root;password=root;";
        private Timer inactiveTimer;

        private void SystemInactive()
        {
            this.MouseMove += ResetInactivityTimer;
            this.KeyPress += ResetInactivityTimer;
        }
        private void InactivityTimer()
        {
            inactiveTimer = new Timer();
            inactiveTimer.Interval = data.inactivityTime;
            inactiveTimer.Tick += InactiveTimer_Tick;
            inactiveTimer.Start();
            return;
        }

        private void InactiveTimer_Tick(object sender, EventArgs e)
        {
            inactiveTimer.Stop();
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
            return;
        }

        private void ResetInactivityTimer(object sender, EventArgs e)
        {
            inactiveTimer.Start();
            inactiveTimer.Stop();
        }

        private void RecoveryDatabase(string filePath)
        {
            string script = File.ReadAllText(filePath);
            InsertData(script);
        }
        private long InsertData(string query)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return cmd.LastInsertedId;
            }
        }

        private void backupData_Click(object sender, EventArgs e)
        {
            // Выбор файла
            OpenFileDialog getFile = new OpenFileDialog();
            getFile.InitialDirectory = "c:\\";
            getFile.Filter = "SQL files (*.sql)|*.sql";
            getFile.FilterIndex = 1;
            getFile.RestoreDirectory = true;
            if (getFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = getFile.FileName;
                RecoveryDatabase(filePath);
                MessageBox.Show("Данные успешно восстановлены!");
                this.Hide();
                Import import = new Import();
                import.Show();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocalAdmin.Menu menu = new LocalAdmin.Menu();
            menu.Show();
        }
    }
}
