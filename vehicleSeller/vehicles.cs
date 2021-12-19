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
    public partial class vehicles : Form
    {
        public vehicles()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");

      private void add_Click(object sender, EventArgs e)
      {
            var stockcode=0;
            int stockNumber = int.Parse(stock.Text);
            for (int i = 0; i < stockNumber; i++)
            {
                connection.Open();
                NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM passengers WHERE brand=@p1 AND model=@p2 AND color=@p3 AND enginetype=@p4 AND bodystyle=@p5 AND luggagecapacity=@p6", connection);
                command1.Parameters.AddWithValue("@p1", c_brand.SelectedValue);
                command1.Parameters.AddWithValue("@p2", c_model.SelectedValue);
                command1.Parameters.AddWithValue("@p3", color.Text);
                command1.Parameters.AddWithValue("@p4", c_engine.SelectedValue);
                command1.Parameters.AddWithValue("@p5", c_body.SelectedValue);
                command1.Parameters.AddWithValue("@p6", int.Parse(luggage.Text));
                var reader = command1.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    stockcode = int.Parse(reader[6].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command2 = new NpgsqlCommand("SELECT * FROM stocks WHERE stockid=@p1", connection);
                    command2.Parameters.AddWithValue("@p1", stockcode);
                    var reader1 = command2.ExecuteReader();
                    reader1.Read();
                    var currentstock = int.Parse(reader1[1].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command3 = new NpgsqlCommand("UPDATE stocks SET stock=@p2 WHERE stockid=@p1", connection);
                    command3.Parameters.AddWithValue("@p1", stockcode);
                    command3.Parameters.AddWithValue("@p2", currentstock + 1);
                    command3.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO passengers(brand,model,color,enginetype,bodystyle,stockCode,status,luggagecapacity,vehicletype)" +
                     " VALUES (@p1,@p2,@p3,@p4,@p5,@p6,default,@p8,default)", connection);
                    command.Parameters.AddWithValue("@p1", c_brand.SelectedValue);
                    command.Parameters.AddWithValue("@p2", c_model.SelectedValue);
                    command.Parameters.AddWithValue("@p3", color.Text);
                    command.Parameters.AddWithValue("@p4", c_engine.SelectedValue);
                    command.Parameters.AddWithValue("@p5", c_body.SelectedValue);
                    command.Parameters.AddWithValue("@p6", stockcode);
                    command.Parameters.AddWithValue("@p8", int.Parse(luggage.Text));
                    
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command3 = new NpgsqlCommand("INSERT INTO stocks(stock) VALUES (@p1)", connection);
                    command3.Parameters.AddWithValue("@p1", 1);
                    command3.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command4 = new NpgsqlCommand("SELECT stockid FROM stocks ORDER BY stockid DESC", connection);
                    var reader3 = command4.ExecuteReader();
                    reader3.Read();
                    stockcode=int.Parse(reader3[0].ToString()); 
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO passengers(brand,model,color,enginetype,bodystyle,stockCode,status,luggagecapacity,vehicletype)" +
                     " VALUES (@p1,@p2,@p3,@p4,@p5,@p6,default,@p8,default)", connection);
                    command.Parameters.AddWithValue("@p1", c_brand.SelectedValue);
                    command.Parameters.AddWithValue("@p2", c_model.SelectedValue);
                    command.Parameters.AddWithValue("@p3", color.Text);
                    command.Parameters.AddWithValue("@p4", c_engine.SelectedValue);
                    command.Parameters.AddWithValue("@p5", c_body.SelectedValue);
                    command.Parameters.AddWithValue("@p6", stockcode);
                    command.Parameters.AddWithValue("@p8", int.Parse(luggage.Text));
                    
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }

        private void list_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vehicles";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
    
        }
    
        private void color_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passengervehicles_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM brands";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            c_brand.DisplayMember = "brandname";
            c_brand.ValueMember = "brandid";
            c_brand.DataSource = dataTable;

            string query1 = "SELECT * FROM models";
            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(query1, connection);
            DataTable dataTable1 = new DataTable();
            dataAdapter1.Fill(dataTable1);
            c_model.DisplayMember = "modelname";
            c_model.ValueMember = "modelid";
            c_model.DataSource = dataTable1;

            string query2 = "SELECT * FROM engines";
            NpgsqlDataAdapter dataAdapter2 = new NpgsqlDataAdapter(query2, connection);
            DataTable dataTable2 = new DataTable();
            dataAdapter2.Fill(dataTable2);
            c_engine.DisplayMember = "enginename";
            c_engine.ValueMember = "engineid";
            c_engine.DataSource = dataTable2;

            string query3 = "SELECT * FROM bodystyles";
            NpgsqlDataAdapter dataAdapter3 = new NpgsqlDataAdapter(query3, connection);
            DataTable dataTable3 = new DataTable();
            dataAdapter3.Fill(dataTable3);
            c_body.DisplayMember = "bodyname";
            c_body.ValueMember = "bodyid";
            c_body.DataSource = dataTable3;


            connection.Close();
        }

        private void luggage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Commercial vehicle adding
        {

            var stockcode = 0;
            int stockNumber = int.Parse(stock.Text);
            for (int i = 0; i < stockNumber; i++)
            {
                connection.Open();
                NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM commercials WHERE brand=@p1 AND model=@p2 AND color=@p3 AND enginetype=@p4 AND bodystyle=@p5 AND tonnage=@p6", connection);
                command1.Parameters.AddWithValue("@p1", c_brand.SelectedValue);
                command1.Parameters.AddWithValue("@p2", c_model.SelectedValue);
                command1.Parameters.AddWithValue("@p3", color.Text);
                command1.Parameters.AddWithValue("@p4", c_engine.SelectedValue);
                command1.Parameters.AddWithValue("@p5", c_body.SelectedValue);
                command1.Parameters.AddWithValue("@p6", int.Parse(tonnage.Text));
                var reader = command1.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    stockcode = int.Parse(reader[6].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command2 = new NpgsqlCommand("SELECT * FROM stocks WHERE stockid=@p1", connection);
                    command2.Parameters.AddWithValue("@p1", stockcode);
                    var reader1 = command2.ExecuteReader();
                    reader1.Read();
                    var currentstock = int.Parse(reader1[1].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command3 = new NpgsqlCommand("UPDATE stocks SET stock=@p2 WHERE stockid=@p1", connection);
                    command3.Parameters.AddWithValue("@p1", stockcode);
                    command3.Parameters.AddWithValue("@p2", currentstock + 1);
                    command3.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO commercials(brand,model,color,enginetype,bodystyle,stockCode,status,tonnage,vehicletype)" +
                     " VALUES (@p1,@p2,@p3,@p4,@p5,@p6,default,@p8,default)", connection);
                    command.Parameters.AddWithValue("@p1", c_brand.SelectedValue);
                    command.Parameters.AddWithValue("@p2", c_model.SelectedValue);
                    command.Parameters.AddWithValue("@p3", color.Text);
                    command.Parameters.AddWithValue("@p4", c_engine.SelectedValue);
                    command.Parameters.AddWithValue("@p5", c_body.SelectedValue);
                    command.Parameters.AddWithValue("@p6", stockcode);
                    command.Parameters.AddWithValue("@p8", int.Parse(tonnage.Text));
                  
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command3 = new NpgsqlCommand("INSERT INTO stocks(stock) VALUES (@p1)", connection);
                    command3.Parameters.AddWithValue("@p1", 1);
                    command3.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command4 = new NpgsqlCommand("SELECT stockid FROM stocks ORDER BY stockid DESC", connection);
                    var reader3 = command4.ExecuteReader();
                    reader3.Read();
                    stockcode = int.Parse(reader3[0].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO commercials(brand,model,color,enginetype,bodystyle,stockCode,status,tonnage,vehicletype)" +
                     " VALUES (@p1,@p2,@p3,@p4,@p5,@p6,default,@p8,default)", connection);
                    command.Parameters.AddWithValue("@p1", c_brand.SelectedValue);
                    command.Parameters.AddWithValue("@p2", c_model.SelectedValue);
                    command.Parameters.AddWithValue("@p3", color.Text);
                    command.Parameters.AddWithValue("@p4", c_engine.SelectedValue);
                    command.Parameters.AddWithValue("@p5", c_body.SelectedValue);
                    command.Parameters.AddWithValue("@p6", stockcode);
                    command.Parameters.AddWithValue("@p8", int.Parse(tonnage.Text));        
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM passengers";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM commercials";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void update_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand commandT = new NpgsqlCommand("SELECt * FROM vehicles WHERE vehicleid=@p1", connection);
            commandT.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            var reader1 = commandT.ExecuteReader();
            reader1.Read();           
            string cType = reader1[8].ToString();
            int stockcode = int.Parse(reader1[6].ToString());
            connection.Close();
            if (cType == "passenger")
            {
                connection.Open();
                NpgsqlCommand commandC = new NpgsqlCommand("SELECT * FROM passengers WHERE vehicleid=@p1", connection);
                commandC.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
                var reader = commandC.ExecuteReader();
                reader.Read();
                //Read old data of passenger 
                int old_brand = int.Parse(reader[1].ToString());
                int old_model = int.Parse(reader[2].ToString());
                string old_color = reader[3].ToString();
                int engine = int.Parse(reader[4].ToString());
                int body = int.Parse(reader[5].ToString());
                int old_luggage = int.Parse(reader[8].ToString());               
                connection.Close();
                connection.Open();
                NpgsqlCommand command2 = new NpgsqlCommand("SELECT * FROM stocks WHERE stockid=@p1", connection);
                command2.Parameters.AddWithValue("@p1", stockcode);
                var reader2 = command2.ExecuteReader();
                reader2.Read();
                var oldstock= int.Parse(reader2[1].ToString());
                connection.Close();
                connection.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT decrease_stock_after_delete(@p1,@p2)", connection);
                com.Parameters.AddWithValue("@p1", stockcode);
                com.Parameters.AddWithValue("@p2", oldstock);
                com.ExecuteNonQuery();
                connection.Close();
                //Check new vehicle is present in table
                connection.Open();
                var newstockcode = 0;
                NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM passengers WHERE brand=@p1 AND model=@p2 AND color=@p3 AND enginetype=@p4 AND bodystyle=@p5 AND luggagecapacity=@p6", connection);
                command1.Parameters.AddWithValue("@p1", c_brand.SelectedValue);
                command1.Parameters.AddWithValue("@p2", c_model.SelectedValue);
                command1.Parameters.AddWithValue("@p3", color.Text);
                command1.Parameters.AddWithValue("@p4", c_engine.SelectedValue);
                command1.Parameters.AddWithValue("@p5", c_body.SelectedValue);
                command1.Parameters.AddWithValue("@p6", int.Parse(luggage.Text));
                var reader3 = command1.ExecuteReader();
                reader3.Read();
                if (reader3.HasRows)
                {
                    newstockcode = int.Parse(reader3[6].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command5 = new NpgsqlCommand("SELECT * FROM stocks WHERE stockid=@p1", connection);
                    command5.Parameters.AddWithValue("@p1", newstockcode);
                    var reader5 = command5.ExecuteReader();
                    reader5.Read();
                    var currentstock = int.Parse(reader5[1].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command3 = new NpgsqlCommand("SELECT increase_stock_one(@p1,@p2)", connection);
                    command3.Parameters.AddWithValue("@p1", newstockcode);
                    command3.Parameters.AddWithValue("@p2", currentstock);
                    command3.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT update_vehicle(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
                    command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
                    command.Parameters.AddWithValue("@p2", c_brand.SelectedValue);
                    command.Parameters.AddWithValue("@p3", c_model.SelectedValue);
                    command.Parameters.AddWithValue("@p4", color.Text);
                    command.Parameters.AddWithValue("@p5", c_engine.SelectedValue);
                    command.Parameters.AddWithValue("@p6", c_body.SelectedValue);
                    command.Parameters.AddWithValue("@p7", int.Parse(luggage.Text));
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command4 = new NpgsqlCommand("SELECT change_stockcode(@p1,@p2)", connection);
                    command4.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
                    command4.Parameters.AddWithValue("@p2", newstockcode);        
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command3 = new NpgsqlCommand("SELECT create_first_stock()", connection);
                    command3.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command4 = new NpgsqlCommand("SELECT stockid FROM stocks ORDER BY stockid DESC", connection);
                    var reader4 = command4.ExecuteReader();
                    reader4.Read();
                    newstockcode = int.Parse(reader4[0].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT update_vehicle(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
                    command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
                    command.Parameters.AddWithValue("@p2", c_brand.SelectedValue);
                    command.Parameters.AddWithValue("@p3", c_model.SelectedValue);
                    command.Parameters.AddWithValue("@p4", color.Text);
                    command.Parameters.AddWithValue("@p5", c_engine.SelectedValue);
                    command.Parameters.AddWithValue("@p6", c_body.SelectedValue);
                    command.Parameters.AddWithValue("@p7", int.Parse(luggage.Text));
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command6 = new NpgsqlCommand("SELECT change_stockcode(@p1,@p2)", connection);
                    command6.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
                    command6.Parameters.AddWithValue("@p2", newstockcode);
                    command6.ExecuteNonQuery();
                    connection.Close();

                }
            }
            else
            {
                connection.Open();
                NpgsqlCommand commandC = new NpgsqlCommand("SELECT * FROM commercials WHERE vehicleid=@p1", connection);
                commandC.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
                var reader = commandC.ExecuteReader();
                reader.Read();
                //Read old data of passenger 
                int old_brand = int.Parse(reader[1].ToString());
                int old_model = int.Parse(reader[2].ToString());
                string old_color = reader[3].ToString();
                int engine = int.Parse(reader[4].ToString());
                int body = int.Parse(reader[5].ToString());
                int old_tonnage = int.Parse(reader[8].ToString());
                connection.Close();
                connection.Open();
                NpgsqlCommand command2 = new NpgsqlCommand("SELECT * FROM stocks WHERE stockid=@p1", connection);
                command2.Parameters.AddWithValue("@p1", stockcode);
                var reader2 = command2.ExecuteReader();
                reader2.Read();
                var oldstock = int.Parse(reader2[1].ToString());
                connection.Close();
                connection.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT decrease_stock_after_delete(@p1,@p2)", connection);
                com.Parameters.AddWithValue("@p1", stockcode);
                com.Parameters.AddWithValue("@p2", oldstock);
                com.ExecuteNonQuery();
                connection.Close();
                //Check new vehicle is present in table
                connection.Open();
                var newstockcode = 0;
                NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM commercials WHERE brand=@p1 AND model=@p2 AND color=@p3 AND enginetype=@p4 AND bodystyle=@p5 AND tonnage=@p6", connection);
                command1.Parameters.AddWithValue("@p1", c_brand.SelectedValue);
                command1.Parameters.AddWithValue("@p2", c_model.SelectedValue);
                command1.Parameters.AddWithValue("@p3", color.Text);
                command1.Parameters.AddWithValue("@p4", c_engine.SelectedValue);
                command1.Parameters.AddWithValue("@p5", c_body.SelectedValue);
                command1.Parameters.AddWithValue("@p6", int.Parse(tonnage.Text));
                var reader3 = command1.ExecuteReader();
                reader3.Read();
                if (reader3.HasRows)
                {
                    newstockcode = int.Parse(reader3[6].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command5 = new NpgsqlCommand("SELECT * FROM stocks WHERE stockid=@p1", connection);
                    command5.Parameters.AddWithValue("@p1", newstockcode);
                    var reader5 = command5.ExecuteReader();
                    reader5.Read();
                    var currentstock = int.Parse(reader5[1].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command3 = new NpgsqlCommand("SELECT increase_stock_one(@p1,@p2)", connection);
                    command3.Parameters.AddWithValue("@p1", newstockcode);
                    command3.Parameters.AddWithValue("@p2", currentstock);
                    command3.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE commercials SET brand=@p2,model=@p3,color=@p4,enginetype=@p5,bodystyle=@p6,tonnage=@p7,stockcode=@p8 WHERE vehicleid=@p1", connection);
                    command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
                    command.Parameters.AddWithValue("@p2", c_brand.SelectedValue);
                    command.Parameters.AddWithValue("@p3", c_model.SelectedValue);
                    command.Parameters.AddWithValue("@p4", color.Text);
                    command.Parameters.AddWithValue("@p5", c_engine.SelectedValue);
                    command.Parameters.AddWithValue("@p6", c_body.SelectedValue);
                    command.Parameters.AddWithValue("@p7", int.Parse(tonnage.Text));
                    command.Parameters.AddWithValue("@p8", newstockcode);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command3 = new NpgsqlCommand("SELECT create_first_stock()", connection);
                    command3.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command4 = new NpgsqlCommand("SELECT stockid FROM stocks ORDER BY stockid DESC", connection);
                    var reader4 = command4.ExecuteReader();
                    reader4.Read();
                    newstockcode = int.Parse(reader4[0].ToString());
                    connection.Close();
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE commercials SET brand=@p2,model=@p3,color=@p4,enginetype=@p5,bodystyle=@p6,tonnage=@p7,stockcode=@p8 WHERE vehicleid=@p1", connection);
                    command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
                    command.Parameters.AddWithValue("@p2", c_brand.SelectedValue);
                    command.Parameters.AddWithValue("@p3", c_model.SelectedValue);
                    command.Parameters.AddWithValue("@p4", color.Text);
                    command.Parameters.AddWithValue("@p5", c_engine.SelectedValue);
                    command.Parameters.AddWithValue("@p6", c_body.SelectedValue);
                    command.Parameters.AddWithValue("@p7", int.Parse(tonnage.Text));
                    command.Parameters.AddWithValue("@p8", newstockcode);
                    command.ExecuteNonQuery();
                    connection.Close();             

                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
          
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM vehicles WHERE vehicleid=@p1", connection);
            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            var reader=command.ExecuteReader();
            reader.Read();
            int a=int.Parse(reader[6].ToString());
            connection.Close();
            connection.Open();
            NpgsqlCommand commandt = new NpgsqlCommand("SELECT * FROM stocks WHERE stockid=@p1", connection);
            commandt.Parameters.AddWithValue("@p1",a);
            var reader1 = commandt.ExecuteReader();
            reader1.Read();
            int b = int.Parse(reader1[1].ToString());
            connection.Close();
            connection.Open();
            NpgsqlCommand com = new NpgsqlCommand("SELECT decrease_stock_after_delete(@p1,@p2)", connection);
            com.Parameters.AddWithValue("@p1", a);
            com.Parameters.AddWithValue("@p2", b);
            com.ExecuteNonQuery();
            connection.Close();
            connection.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("DELETE FROM vehicles WHERE vehicleid=@p1", connection);
            command2.Parameters.AddWithValue("@p1", dataGridView1.CurrentCell.Value);
            command2.ExecuteNonQuery();
            connection.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM vehicles WHERE color like '%"+search.Text+"%' "+"OR "+"status like '%"+search.Text+"%' "+"OR "+"vehicletype like '%" + search.Text + "%'";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }
    }
}
