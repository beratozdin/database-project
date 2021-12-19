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
    public partial class addresses : Form
    {
        public addresses()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");


        private void addresses_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query1 = "SELECT * FROM cities";
            string query2 = "SELECT * FROM districts";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query1, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            comboBox1.DisplayMember = "cityname";
            comboBox1.ValueMember = "cityid";
            comboBox1.DataSource = dataTable;
            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(query2, connection);
            DataTable dataTable1 = new DataTable();
            dataAdapter1.Fill(dataTable1);
            comboBox2.DisplayMember = "districtname";
            comboBox2.ValueMember = "districtid";
            comboBox2.DataSource = dataTable1;
            connection.Close();
        }

        private void a_list_Click(object sender, EventArgs e)
        {
            string query = "SELECT addresses.addressid,cities.cityname,districts.districtname FROM ((addresses INNER JOIN cities ON addresses.city = cities.cityid) INNER JOIN districts ON addresses.district=districts.districtid )";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO addresses(city,district) VALUES (@p1,@p2)", connection);
            command.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            command.Parameters.AddWithValue("@p2",comboBox2.SelectedValue);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void a_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM addresses WHERE addressid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void a_update_Click(object sender, EventArgs e)
        {

            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE addresses SET city=@p2,district=@p3 WHERE addressid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.Parameters.AddWithValue("@p2", comboBox1.SelectedValue);
            command.Parameters.AddWithValue("@p3", comboBox2.SelectedValue);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main yeniSayfa = new main();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }
    }
}
