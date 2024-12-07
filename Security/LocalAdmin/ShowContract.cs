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

namespace Security.LocalAdmin
{
    public partial class ShowContract : Form
    {
        public ShowContract(int id)
        {
            InitializeComponent();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Contracts contracts = new Contracts();
            this.Hide();
            contracts.Show();
        }

        private void ShowContract_Load(object sender, EventArgs e)
        {

        }
    }
}
