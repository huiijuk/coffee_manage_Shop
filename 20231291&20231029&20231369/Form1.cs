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
using System.Diagnostics.Eventing.Reader;

namespace _20231291_20231029_20231369
{
    public partial class log_in: Form
    {
        public log_in()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = db_coffeeshop1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "" && txtpass.Text == "" && txtcomfirm.Text == "" && txtphn.Text == "") 
            {
                MessageBox.Show("username and password field are empty", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else if(txtpass.Text == txtcomfirm.Text)
            {
                conn.Open();
                Random random = new Random();
                int CustomerID = random.Next(10000, 99999);
                string register = "INSERT INTO tb_userdata VALUES('" + txtusername.Text + "','" + txtpass.Text + "') ";
                    
                string cus_Data = "INSERT INTO tb_customer VALUES('" + CustomerID + "' , '" + txtusername.Text + "' , '" + txtphn.Text + "')";
                cmd = new OleDbCommand(register, conn);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(cus_Data, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txtusername.Text = "";
                txtpass.Text = "";
                txtcomfirm.Text = "";
                txtphn.Text = "";
                MessageBox.Show("Your Account Has Been Successfully Created", "Registration Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Password Dose Not Match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Text = "";
                txtcomfirm.Text = "";
                txtpass.Focus();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                txtpass.PasswordChar = '\0';
                txtcomfirm.PasswordChar = '\0';

            }
            else
            {
                txtpass.PasswordChar = '*';
                txtcomfirm.PasswordChar = '*';
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpass.Text = "";
            txtcomfirm.Text = "";
            txtphn.Text = "";
            txtusername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }
    }
}
