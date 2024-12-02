using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        private void saveData_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void getFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog getFile = new OpenFileDialog();
            getFile.InitialDirectory = "c:\\";
            getFile.Filter = "CSV files (*.csv)|*.csv";
            getFile.FilterIndex = 1;
            getFile.RestoreDirectory = true;
            if(getFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = getFile.FileName;
            }
        }
    }
}
