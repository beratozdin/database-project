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
    public partial class stocks : Form
    {
        public stocks()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");

        private void stocks_Load(object sender, EventArgs e)
        {

        }

        private void list_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM stocks";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void add_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO stocks(stock) VALUES (@p1)", connection);
            command.Parameters.AddWithValue("@p1", int.Parse(stock.Text));
            command.ExecuteNonQuery();
            connection.Close();

        }
        private void update_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE stocks SET stock=@p2 WHERE stockid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.Parameters.AddWithValue("@p2", int.Parse(stock.Text));
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void delete_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM stocks WHERE stockid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
