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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            int inactiveTime;
            if (int.TryParse(boxSettingsInactive.Text, out inactiveTime))
            {
                data.inactivityTime = inactiveTime;
                MessageBox.Show("Данные изменены!");
                this.Hide();
                LocalAdmin.Menu menu = new LocalAdmin.Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Введите корректное целое число.");
            }
        }
    }
}
