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
            GetDate(id);
        }
        string connectionString = data.connectionString;
        private void GetDate(int id)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection(connectionString);
                connect.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT client , name_object , adress , type_object , status , type_security  FROM contract WHERE id = {id}", connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                boxClient.Text = rdr["client"].ToString();
                boxObject.Text = rdr["name_object"].ToString();
                boxAdress.Text = rdr["adress"].ToString();
                boxTypeObject.Text = rdr["type_object"].ToString();
                boxStatus.Text = rdr["status"].ToString();
                boxTypeSecurity.Text = rdr["type_security"].ToString();

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
