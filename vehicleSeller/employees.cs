﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicleSeller
{
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void list_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM employees";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void add_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO employees(employeename,employeesurname,department) VALUES (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", ename.Text);
            command.Parameters.AddWithValue("@p2", esurname.Text);
            command.Parameters.AddWithValue("@p3", comboBox1.SelectedValue);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void update_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE employees SET employeename=@p2,employeesurname=@p3,department=@p4 WHERE employeeid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.Parameters.AddWithValue("@p2", ename.Text);
            command.Parameters.AddWithValue("@p3", esurname.Text);
            command.Parameters.AddWithValue("@p4", comboBox1.SelectedValue);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM employees WHERE employeeid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void employees_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM departments";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            comboBox1.DisplayMember = "departmentname";
            comboBox1.ValueMember = "departmentid";
            comboBox1.DataSource = dataTable;
            connection.Close();
        }
    }
}
