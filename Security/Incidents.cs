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
    public partial class Incidents : Form
    {
        public Incidents()
        {
            InitializeComponent();
            GetDate();
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
        private void GetDate()
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT description AS 'Описание', status AS 'Статус', date_incident AS 'Дата происшествия', object AS 'Объект' FROM incident", connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();
        }

        private void regIncident_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewIncident registerInc = new NewIncident();
            registerInc.Show();
        }

        private void goMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
    }
}
