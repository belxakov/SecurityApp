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
    public partial class Contracts : Form
    {
        public Contracts()
        {
            InitializeComponent();
            InfoContracts();
            boxTypeObj.Items.Add("Все объекты");
            boxClient.Items.Add("Все клиенты");
            TypeObject();
            Client();
            labNameObj.Visible = false;
            labTypeObj.Visible = false;
            labSort.Visible = false;
            labClient.Visible = false;
            labTypeSec.Visible = false;
            boxNameObj.Visible = false;
            boxTypeObj.Visible = false;
            boxSort.Visible = false;
            boxClient.Visible = false;
            boxTypeSec.Visible = false;
            imageNoFilter.Visible = false;
            boxSort.Items.Add("Активен");
            boxSort.Items.Add("Неактивен");
            dataGridView1.Height = 356;
        }

        string connectionString = data.connectionString;

        private void InfoContracts()
        {
            try
            {
                MySqlConnection connect = new MySqlConnection(connectionString);
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract", connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void goMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }


        private void imageFilter_Click(object sender, EventArgs e)
        {
            dataGridView1.Height = 315;
            dataGridView1.Location = new System.Drawing.Point(15, 79);
            labNameObj.Visible = true;
            labTypeObj.Visible = true;
            labSort.Visible = true;
            labClient.Visible = true;
            labTypeSec.Visible = true;
            boxNameObj.Visible = true;
            boxTypeObj.Visible = true;
            boxSort.Visible = true;
            boxClient.Visible = true;
            boxTypeSec.Visible = true;
            imageNoFilter.Visible = true;
            imageFilter.Visible = false;
        }

        private void imageNoFilter_Click(object sender, EventArgs e)
        {
            dataGridView1.Height = 356;
            dataGridView1.Location = new System.Drawing.Point(16, 38);
            labNameObj.Visible = false;
            labTypeObj.Visible = false;
            labSort.Visible = false;
            labClient.Visible = false;
            labTypeSec.Visible = false;
            boxNameObj.Visible = false;
            boxTypeObj.Visible = false;
            boxSort.Visible = false;
            boxClient.Visible = false;
            boxTypeSec.Visible = false;
            imageNoFilter.Visible = false;
            imageFilter.Visible = true;
        }

        private void boxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortStatus = boxSort.SelectedItem.ToString() == "Активен" ? "ASC" : "DESC";
            SortDirection(sortStatus);
        }
        private void SortDirection(string sortStatus)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    MySqlCommand sort = new MySqlCommand($"SELECT client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract ORDER BY status {sortStatus}", connect);
                    sort.ExecuteNonQuery();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sort);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void TypeObject()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT name FROM type_object";
                    MySqlCommand listType = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader = listType.ExecuteReader();
                    while (reader.Read())
                    {
                        boxTypeObj.Items.Add($"{reader["name"]}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Client()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT surname, name, patronymic FROM client";
                    MySqlCommand listClient = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader = listClient.ExecuteReader();
                    while (reader.Read())
                    {
                        boxClient.Items.Add($"{reader["surname"]} {reader["name"]} {reader["patronymic"]}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boxTypeObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeObject = boxTypeObj.Text;
            FilterTypeObject(typeObject);
        }
        private void FilterTypeObject(string typeObject)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    MySqlCommand filterObject = new MySqlCommand($"SELECT client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE type_object LIKE @typeObject", connect);
                    filterObject.Parameters.AddWithValue("@typeObject", typeObject);
                    filterObject.ExecuteNonQuery();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(filterObject);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    if(typeObject == "Все объекты")
                    {
                        InfoContracts();
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FilterNameObject(string nameObject)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    MySqlCommand filterObject = new MySqlCommand($"SELECT client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE name_object LIKE @nameObject", connect);
                    filterObject.Parameters.AddWithValue("@nameObject", nameObject);
                    filterObject.ExecuteNonQuery();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(filterObject);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    if (nameObject == null)
                    {
                        InfoContracts();
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadData(string nameObject)
        {
            using(MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string query = "SELECT  client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE name_object LIKE @nameObject";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@nameObject", "%" + nameObject + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    connect.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FilterClient(string clientInfo)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    MySqlCommand filterObject = new MySqlCommand($"SELECT client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE client LIKE @clientInfo", connect);
                    filterObject.Parameters.AddWithValue("@clientInfo", clientInfo);
                    filterObject.ExecuteNonQuery();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(filterObject);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    if (clientInfo == "Все клиенты")
                    {
                        InfoContracts();
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clientInfo = boxClient.Text;
            FilterClient(clientInfo);
        }
        private void FilterTypeSecurity(string typeSecurity)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    MySqlCommand filterObject = new MySqlCommand($"SELECT client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE type_security LIKE @typeSecurity", connect);
                    filterObject.Parameters.AddWithValue("@typeObject", typeSecurity);
                    filterObject.ExecuteNonQuery();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(filterObject);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    if (typeSecurity == "Выбрать все")
                    {
                        InfoContracts();
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boxTypeSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeSecurity = boxTypeSec.Text;
            FilterTypeSecurity(typeSecurity);
        }

        private void boxNameObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameObject = boxNameObj.Text;
            FilterNameObject(nameObject);
        }

        private void boxNameObj_TextChanged(object sender, EventArgs e)
        {
            string nameObject = boxNameObj.Text;
            LoadData(nameObject);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditContract editContract = new EditContract();
            editContract.Show();
        }
    }
}
