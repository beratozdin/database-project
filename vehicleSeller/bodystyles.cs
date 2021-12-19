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
    public partial class bodystyles : Form
    {
        public bodystyles()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");

        private void list_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM bodystyles";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void add_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO bodystyles(bodyname) VALUES (@p1)", connection);
            command.Parameters.AddWithValue("@p1", bodyname.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE bodystyles SET bodyname=@p2 WHERE bodyid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.Parameters.AddWithValue("@p2", bodyname.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM bodystyles WHERE bodyid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
