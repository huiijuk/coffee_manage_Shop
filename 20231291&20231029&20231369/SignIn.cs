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
    public partial class SignIn: Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = db_coffeeshop1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string adminQuery = "SELECT * FROM tb_admin WHERE admin_name = ? AND password = ?";
                OleDbCommand cmdAdmin = new OleDbCommand(adminQuery, conn);
                cmdAdmin.Parameters.AddWithValue("@admin_name", txtusername.Text);
                cmdAdmin.Parameters.AddWithValue("@password", txtpass.Text);

                OleDbDataReader drAdmin = cmdAdmin.ExecuteReader();

                if (drAdmin.Read())
                {
                    new AdminDashBoard().Show();
                    this.Hide();
                    return;
                }

                drAdmin.Close();
                //user
                string userQuery = "SELECT * FROM tb_userdata WHERE username = ? AND password = ?";
                OleDbCommand cmdUser = new OleDbCommand(userQuery, conn);
                cmdUser.Parameters.AddWithValue("@username", txtusername.Text);
                cmdUser.Parameters.AddWithValue("@password", txtpass.Text);

                OleDbDataReader drUser = cmdUser.ExecuteReader();

                if (drUser.Read())
                {
                    new CustomerDashBoard().Show(); 
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password. Please try again.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtpass.Text = "";
                    txtusername.Text = "";
                    txtusername.Focus();
                }

                drUser.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpass.Text = "";
            txtusername.Text = "";
            txtusername.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = '\0';

            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new log_in().Show();
            this.Hide();
        }
    }
}
