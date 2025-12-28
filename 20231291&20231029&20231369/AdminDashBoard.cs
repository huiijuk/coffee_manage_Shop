using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _20231291_20231029_20231369
{
    public partial class AdminDashBoard: Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = db_coffeeshop1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT COUNT(customer_id) FROM tb_customer";
            string sum = "SELECT SUM(Money) FROM tb_income";
            OleDbCommand cmd2 = new OleDbCommand(sum, conn);
            cmd = new OleDbCommand(query, conn);
            int totalCustomers = Convert.ToInt32(cmd.ExecuteScalar());
            int totalcash = Convert.ToInt32(cmd2.ExecuteScalar());
            label4.Text = totalcash.ToString() + "$";
            label3.Text = totalCustomers.ToString();
            conn.Close();
        }

        private void btncustomerinfo_Click(object sender, EventArgs e)
        {
            new userinfo().Show();
            this.Hide();
        }

        private void btnmanagestock_Click(object sender, EventArgs e)
        {
            new Managestock().Show();
            this.Hide();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            new currentproduct().Show();
            this.Hide();
        }

        private void btnsale_Click(object sender, EventArgs e)
        {
            new Income_dashboard().Show();
            this.Hide();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT COUNT(customer_id) FROM tb_customer";
            string sum = "SELECT SUM(Money) FROM tb_income";
            OleDbCommand cmd2 = new OleDbCommand(sum, conn);
            cmd = new OleDbCommand(query, conn);
            int totalCustomers = Convert.ToInt32(cmd.ExecuteScalar());
            int totalcash = Convert.ToInt32(cmd2.ExecuteScalar());
            label4.Text = totalcash.ToString() + "$" ;
            label3.Text = totalCustomers.ToString();
            conn.Close();


        }
    }
}
