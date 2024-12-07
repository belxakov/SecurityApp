using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security.LocalAdmin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SystemInactive();
            InactivityTimer();
        }

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
        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocalAdmin.Settings settings = new LocalAdmin.Settings();
            settings.Show();
            return;
        }

        private void showContractButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contracts contracts = new Contracts();
            contracts.Show();
            return;
        }
    }
}
