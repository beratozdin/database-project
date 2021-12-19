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
    public partial class purchasings : Form
    {
        public purchasings()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void purchasings_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vehicles";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];

            string query1 = "SELECT * FROM customers";
            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(query1, connection);
            DataSet dataSet1 = new DataSet();
            dataAdapter1.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM purchasings";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView3.DataSource = dataSet.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM vehicles WHERE vehicleid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView2.CurrentCell.Value);
            var reader = command.ExecuteReader();
            reader.Read();
            int stockcode = int.Parse(reader[6].ToString());
            connection.Close();
            connection.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("SELECT * FROM stocks WHERE stockid=@p1", connection);
            command2.Parameters.AddWithValue("@p1", stockcode);
            var reader2 = command2.ExecuteReader();
            reader2.Read();
            int stock = int.Parse(reader2[1].ToString());
            connection.Close();
            connection.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("SELECT decrease_stock_after_delete(@p1,@p2)", connection);
            command3.Parameters.AddWithValue("@p1", stockcode);
            command3.Parameters.AddWithValue("@p2", stock);
            command3.ExecuteNonQuery();
            connection.Close();
            connection.Open();
            NpgsqlCommand command5 = new NpgsqlCommand("INSERT INTO purchasings(vehicleid,customerid) VALUES (@p1,@p2)", connection);
            command5.Parameters.AddWithValue("@p1", dataGridView2.CurrentCell.Value);
            command5.Parameters.AddWithValue("@p2", dataGridView1.CurrentCell.Value);
            command5.ExecuteNonQuery();
            connection.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            button4_Click(sender,e);
            button1_Click(sender, e);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE purchasings SET vehicleid=@p2,customerid=@p3 WHERE purchasingid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView3.CurrentCell.Value);
            command.Parameters.AddWithValue("@p2", dataGridView2.CurrentCell.Value);
            command.Parameters.AddWithValue("@p3", dataGridView1.CurrentCell.Value);
            command.ExecuteNonQuery();
            connection.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM purchasings WHERE purchasingid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView3.CurrentCell.Value);
            var reader=command.ExecuteReader();
            reader.Read();
            int vid = int.Parse(reader[1].ToString());
            connection.Close();
            connection.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM vehicles WHERE vehicleid=@p1", connection);
            command1.Parameters.AddWithValue("@p1", vid);
            var reader1 = command1.ExecuteReader();
            reader1.Read();
            int stockcode = int.Parse(reader1[6].ToString());
            connection.Close();
            connection.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("SELECT * FROM stocks WHERE stockid=@p1", connection);
            command2.Parameters.AddWithValue("@p1", stockcode);
            var reader2 = command2.ExecuteReader();
            reader2.Read();
            int stock = int.Parse(reader2[1].ToString());
            connection.Close();
            connection.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("UPDATE stocks SET stock=@p2 WHERE stockid=@p1", connection);
            command3.Parameters.AddWithValue("@p1", stockcode);
            command3.Parameters.AddWithValue("@p2",stock+1);
            command3.ExecuteNonQuery();
            connection.Close();
            connection.Open();
            NpgsqlCommand command5 = new NpgsqlCommand("DELETE FROM purchasings WHERE purchasingid=@p1", connection);
            command5.Parameters.AddWithValue("@p1", dataGridView3.CurrentCell.Value);
            command5.ExecuteNonQuery();
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vehicles";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];

            string query1 = "SELECT * FROM customers";
            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(query1, connection);
            DataSet dataSet1 = new DataSet();
            dataAdapter1.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];




        }
    }
}
