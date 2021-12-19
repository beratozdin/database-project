using Npgsql;
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
    public partial class citiesdistricts : Form
    {
        public citiesdistricts()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void d_add_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO districts(districtname) VALUES (@p1)", connection);
            command.Parameters.AddWithValue("@p1", district.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void d_list_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM districts";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void addresses_Load(object sender, EventArgs e)
        {

        }

        private void d_update_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE districts SET districtname=@p2 WHERE districtid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.Parameters.AddWithValue("@p2", district.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void d_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM districts WHERE districtid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void c_list_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cities";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
        }

        private void c_add_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO cities(cityname) VALUES (@p1)", connection);
            command.Parameters.AddWithValue("@p1", city.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void c_update_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE cities SET cityname=@p2 WHERE cityid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView2.CurrentCell.Value);
            command.Parameters.AddWithValue("@p2", city.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void c_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM cities WHERE cityid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView2.CurrentCell.Value);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
