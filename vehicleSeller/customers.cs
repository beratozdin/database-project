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
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customers";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void customers_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT addresses.addressid,cities.cityname,districts.districtname FROM ((addresses INNER JOIN cities ON addresses.city = cities.cityid) INNER JOIN districts ON addresses.district=districts.districtid )";        
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void list_c_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM companies";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void list_p_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM people";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand commandT = new NpgsqlCommand("SELECt * FROM customers WHERE customerid=@p1", connection);
            commandT.Parameters.AddWithValue("@p1",dataGridView1.CurrentCell.Value);
            var reader=commandT.ExecuteReader();
            reader.Read();
            string cType=reader[3].ToString();
            connection.Close();
            if (cType =="person")
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("UPDATE person SET phone=@p2,address=@p3,personname=@p4,personsurname=@p5 WHERE customerid=@p1", connection);
                command.Parameters.AddWithValue("@p1",dataGridView1.CurrentCell.Value);
                command.Parameters.AddWithValue("@p2", phone.Text);
                command.Parameters.AddWithValue("@p3", dataGridView2.CurrentCell.Value);
                command.Parameters.AddWithValue("@p4", pname.Text);
                command.Parameters.AddWithValue("@p5", psurname.Text);
                command.ExecuteNonQuery();
                connection.Close();

            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("UPDATE companies SET phone=@p2,address=@p3,companyname=@p4 WHERE customerid=@p1", connection);
                command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
                command.Parameters.AddWithValue("@p2", phone.Text);
                command.Parameters.AddWithValue("@p4", cname.Text);
                command.Parameters.AddWithValue("@p3", dataGridView2.CurrentCell.Value);
                
                command.ExecuteNonQuery();
                connection.Close();

            }



       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO companies(phone,address,companyname) VALUES (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", phone.Text);
            command.Parameters.AddWithValue("@p2", dataGridView2.CurrentCell.Value);
            command.Parameters.AddWithValue("@p3", cname.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO people(phone,address,personname,personsurname) VALUES (@p1,@p2,@p3,@p4)", connection);
            command.Parameters.AddWithValue("@p1", phone.Text);
            command.Parameters.AddWithValue("@p2", dataGridView2.CurrentCell.Value);
            command.Parameters.AddWithValue("@p3", pname.Text);
            command.Parameters.AddWithValue("@p4", psurname.Text);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM customers WHERE customerid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customers WHERE phone like '%" + search.Text + "%' "+"OR "+ "customertype like '%" + search.Text + "%'";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
