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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            InfoUser();
            UserInterfce();
        }

        string connectionString = data.connectionString;

        // ================ [ FUNC ] ================

        private void InfoUser()
        {
            labSurname.Text = $"Фамилия: {data.uSurname}";
            labName.Text = $"Имя: {data.uName}";
            labPatronymic.Text = $"Отчество: {data.uPatronymic}";
            labIndCard.Text = $"Служебное удостоверение: {data.uCard}";
            if(data.uRole == "1")
            {
                labStatus.Text = $"Статус: Cотрудник";
            }
            else if (data.uRole == "2")
            {
                labStatus.Text = $"Статус: Дежурный";
            }
            else if (data.uRole == "3")
            {
                labStatus.Text = $"Статус: Менеджер";
            }
            else if(data.uRole == "4")
            {
                labStatus.Text = $"Статус: Администратор";
            }
        }

        private void UserInterfce()
        {
            conclusionContract.Visible = false;
            contractList.Visible = false;
            signalList.Visible = false;
            memberList.Visible = false;
            clientList.Visible = false;
            if(data.uRole == "2")
            {
                // visible
                signalList.Visible = true;
                memberList.Visible = true;
                contractList.Visible = true;
                // location
                signalList.Location = new System.Drawing.Point(12, 14);
                contractList.Location = new System.Drawing.Point(12, 67);
                memberList.Location = new System.Drawing.Point(12, 120);
                closeApplication.Location = new System.Drawing.Point(12, 173);
            }
            else if(data.uRole == "3")
            {
                // visible
                conclusionContract.Visible = true;
                contractList.Visible = true;
                clientList.Visible = true;
                // location
                conclusionContract.Location = new System.Drawing.Point(12, 14);
                clientList.Location = new System.Drawing.Point(12, 120);
                closeApplication.Location = new System.Drawing.Point(12, 226);
            }
            else if(data.uRole == "4")
            {
                conclusionContract.Visible = true;
                contractList.Visible = true;
                signalList.Visible = true;
                memberList.Visible = true;
                clientList.Visible = true;
            }
        }

        // ================ [ BUTTONS ] ================
        private void conclusionContract_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewContract conclusionContract = new NewContract();
            conclusionContract.Show();
        }

        private void contractList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contracts contracts = new Contracts();
            contracts.Show();
        }

        private void signalList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Incidents incidents = new Incidents();
            incidents.Show();
        }

        private void memberList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Members members = new Members();
            members.Show();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void clientList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clients clients = new Clients();
            clients.Show();
        }

        private void listObject_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecurityObjects sObject = new SecurityObjects();
            sObject.Show();
        }

        private void importData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Import import = new Import();
            import.Show();
        }
    }
}
