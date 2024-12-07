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
