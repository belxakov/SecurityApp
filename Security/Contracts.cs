﻿using System;
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
            SystemInactive();
            InactivityTimer();
            InitContextMenu();
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
        public int minSearch = 0;
        public int maxSerach = 20;
        public int countRow;
        private Timer inactivityTimer;

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
            this.Hide();
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

        private void InitContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem showContract = new ToolStripMenuItem("Посмотреть");
            showContract.Click += ShowContract_Click;
            contextMenu.Items.Add(showContract);
            dataGridView1.ContextMenuStrip = contextMenu;
        }

        private void ShowContract_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int selectIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[selectIndex];
                int id = Convert.ToInt32(selectRow.Cells["id"].Value);
                LocalAdmin.ShowContract showContract = new LocalAdmin.ShowContract(id);
                this.Hide();
                showContract.Show();
                return;
            }
        }

        private void InfoContracts()
        {
            try
            {
                MySqlConnection connect = new MySqlConnection(connectionString);
                connect.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT id, client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract LIMIT {minSearch}, {maxSerach}", connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                this.dataGridView1.Columns["id"].Visible = false;
                countRow = dataGridView1.RowCount;
                countContracts.Text = $"Количество строк: {countRow}";

                foreach (DataRow row in table.Rows)
                {
                    string client = row["Клиент"].ToString();
                    string nameObject = row["Наименование объекта"].ToString();
                    if(client.Length > 3)
                    {
                        client = client.Substring(0, 8) + new string('*', client.Length - 6);
                    }
                    if(nameObject.Length > 6)
                    {
                        nameObject = nameObject.Substring(0, 6) + new string('*', nameObject.Length - 6);
                    }
                    else if(nameObject.Length < 6)
                    {
                        nameObject = nameObject.Substring(0, 3) + new string('*', nameObject.Length - 3);
                    }
                    row["Клиент"] = client;
                    row["Наименование объекта"] = nameObject;
                }

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
            LocalAdmin.Menu menu = new LocalAdmin.Menu();
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
                    MySqlCommand sort = new MySqlCommand($"SELECT client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract ORDER BY status {sortStatus} LIMIT {minSearch}, {maxSerach}", connect);
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
                    MySqlCommand filterObject = new MySqlCommand($"SELECT id, client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE type_object LIKE @typeObject LIMIT {minSearch}, {maxSerach}", connect);
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
                    this.dataGridView1.Columns["id"].Visible = false;
                    countRow = dataGridView1.RowCount;
                    countContracts.Text = $"Количество строк: {countRow}";
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
                    MySqlCommand filterObject = new MySqlCommand($"SELECT id, client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE name_object LIKE @nameObject LIMIT {minSearch}, {maxSerach}", connect);
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
                    this.dataGridView1.Columns["id"].Visible = false;
                    countRow = dataGridView1.RowCount;
                    countContracts.Text = $"Количество строк: {countRow}";
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
                    string query = $"SELECT id, client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE name_object LIKE @nameObject LIMIT {minSearch}, {maxSerach}";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@nameObject", "%" + nameObject + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    this.dataGridView1.Columns["id"].Visible = false;
                    countRow = dataGridView1.RowCount;
                    countContracts.Text = $"Количество строк: {countRow}";
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
                    MySqlCommand filterObject = new MySqlCommand($"SELECT id, client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE client LIKE @clientInfo LIMIT {minSearch}, {maxSerach}", connect);
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
                    this.dataGridView1.Columns["id"].Visible = false;
                    countRow = dataGridView1.RowCount;
                    countContracts.Text = $"Количество строк: {countRow}";
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
                    MySqlCommand filterObject = new MySqlCommand($"SELECT client AS 'Клиент', name_object AS 'Наименование объекта', adress AS 'Адрес', type_object AS 'Тип объекта', status AS 'Статус', type_security AS 'Тип охраны' FROM contract WHERE type_security LIKE @typeSecurity LIMIT {minSearch}, {maxSerach}", connect);
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
                    this.dataGridView1.Columns["id"].Visible = false;
                    countRow = dataGridView1.RowCount;
                    countContracts.Text = $"Количество строк: {countRow}";
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

        // navigation

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (maxSerach <= countRow)
            {
                minSearch += 20;
                if(minSearch == 20)
                {
                    countPage.Text = "2";
                }
                else if(minSearch == 40)
                {
                    countPage.Text = "3";
                }
                else if (minSearch == 60)
                {
                    countPage.Text = "4";
                }
                InfoContracts();
            }
            else
            {
                minSearch = 0;
                maxSerach = 20;
                InfoContracts();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (minSearch != 0)
            {
                minSearch -= 20;
                if(minSearch == 0)
                {
                    countPage.Text = "1";
                }
               else if (minSearch == 20)
                {
                    countPage.Text = "2";
                }
                else if (minSearch == 40)
                {
                    countPage.Text = "3";
                }
                else if (minSearch == 60)
                {
                    countPage.Text = "4";
                }
                InfoContracts();
            }
            else
            {
                minSearch = countRow + 1;
                maxSerach = 20;
                InfoContracts();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Статус") // Проверяем имя колонки
                {
                    var CellValue = dataGridView1.Rows[e.RowIndex].Cells["Статус"].Value;
                    if (CellValue != null)
                    {
                        string status = CellValue.ToString();
                        switch (status)
                        {
                            case "Активен":
                                e.CellStyle.BackColor = Color.LightGreen;
                                break;
                            case "активный":
                                e.CellStyle.BackColor = Color.LightGreen;
                                break;
                            case "ожидает подписи":
                                e.CellStyle.BackColor = Color.Bisque;
                                break;
                            case "Неактивен":
                                e.CellStyle.BackColor = Color.Orange;
                                break;
                            case "Завершен":
                                e.CellStyle.BackColor = Color.OrangeRed;
                                break;
                            case "закрыт":
                                e.CellStyle.BackColor = Color.OrangeRed;
                                break;
                            default:
                                e.CellStyle.BackColor = Color.White; // Если статус не распознан
                                break;
                        }
                    }
                }
            }
        }

        private void Contracts_Load(object sender, EventArgs e)
        {

        }

        private void page1_Click(object sender, EventArgs e)
        {
            minSearch = 0;
            maxSerach = 20;
            InfoContracts();
            countPage.Text = "1";
        }

        private void page2_Click(object sender, EventArgs e)
        {
            minSearch += 20;
            if(minSearch == 40)
            {
                InfoContracts();
                countPage.Text = "2";
            }
        }

        private void page3_Click(object sender, EventArgs e)
        {
            minSearch += 40;
            if (minSearch == 60)
            {
                InfoContracts();
                countPage.Text = "3";
            }
        }

        private void page4_Click(object sender, EventArgs e)
        {
            minSearch += 60;
            if (minSearch == 80)
            {
                InfoContracts();
                countPage.Text = "4";
            }
        }
    }
}
