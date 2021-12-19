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
    public partial class departments : Form
    {
        public departments()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");
        
        private void departments_Load(object sender, EventArgs e)
        {

        }

        private void list_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM departments";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void add_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO departments(departmentname,salary) VALUES (@p1,@p2)", connection);
                command.Parameters.AddWithValue("@p2", int.Parse(salary.Text));
                command.Parameters.AddWithValue("@p1", department.Text);
                command.ExecuteNonQuery();
            }
            catch(NpgsqlException ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
            }
            connection.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE departments SET departmentname=@p2,salary=@p3  WHERE departmentid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.Parameters.AddWithValue("@p3", int.Parse(salary.Text));
            command.Parameters.AddWithValue("@p2", department.Text);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM departments WHERE departmentid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
