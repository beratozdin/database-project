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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=sellerDB; user ID=postgres; password=1234");
      


        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addresses addr = new addresses();
            this.Hide();
            addr.ShowDialog();
            this.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            purchasings prc = new purchasings();
            this.Hide();
            prc.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bodystyles bd = new bodystyles();
            this.Hide();
            bd.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brands bd = new brands();
            this.Hide();
            bd.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            citiesdistricts ct = new citiesdistricts();
            this.Hide();
            ct.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customers cust = new customers();
            this.Hide();
            cust.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            departments dpt = new departments();
            this.Hide();
            dpt.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            employees emp = new employees();
            this.Hide();
            emp.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            engines eng = new engines();
            this.Hide();
            eng.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            models mdl = new models();
            this.Hide();
            mdl.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            stocks stc = new stocks();
            this.Hide();
            stc.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            vehicles vh = new vehicles();
            this.Hide();
            vh.ShowDialog();
            this.Show();
        }
    }
}
