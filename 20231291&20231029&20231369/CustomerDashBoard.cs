using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.OleDb;

namespace _20231291_20231029_20231369
{
    public partial class CustomerDashBoard: Form
    {
        public CustomerDashBoard()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = db_coffeeshop1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

               
                txtname.Text = row.Cells["ProductName"].Value.ToString();
                txttype.Text = row.Cells["Type"].Value.ToString();
                txtprice.Text = row.Cells["Price"].Value.ToString();
                txtstock.Focus();
               
            }
        }

        private void CustomerDashBoard_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tb_product", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "test");
            dataGridView1.AutoGenerateColumns = false;
            for (int x = 0; (x <= (ds.Tables[0].Rows.Count - 1)); x++)
            {
                dataGridView1.Rows.Add(
                    ds.Tables[0].Rows[x]["ProductID"],
                    ds.Tables[0].Rows[x]["ProductName"],
                    ds.Tables[0].Rows[x]["Type"],
                    ds.Tables[0].Rows[x]["Stock"],
                    ds.Tables[0].Rows[x]["Price"],
                    ds.Tables[0].Rows[x]["Status"],
                    ds.Tables[0].Rows[x]["Date"]
                    );
            }
        }

        decimal total = 0, quantity = 0, price = 0  ;

        private void button1_Click(object sender, EventArgs e)
        {
            //Exchange button
            decimal Total = 0, GetCashie = 0;
            if(txtcash.Text == "")
            {
                MessageBox.Show("Invaild Number", "Please Input" , MessageBoxButtons.OK);
            }
            else
            {
                Total = Convert.ToDecimal(txttotal.Text);
                GetCashie = Convert.ToDecimal(txtcash.Text);

                txtexchange.Text = (GetCashie - Total).ToString();
            }
            

        }

        private void btnpaid_Click(object sender, EventArgs e)
        {
            total = 0;
            txttotal.Text = "---";
            txtcash.Text = "";
            txtexchange.Text = "---";
            MessageBox.Show("Paid", "Successfully",  MessageBoxButtons.OK);
        }

        private void btnquantity_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToDecimal(txtstock.Text);
            price = Convert.ToDecimal(txtprice.Text);
            txttotal2.Text = (quantity * price).ToString() ;
            
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "---" && txtprice.Text == "---" && txtstock.Text == "" && txttype.Text == "---" && txttotal2.Text == "---")
            {
                MessageBox.Show("Field Is Empty", "Please Select Drink Or Food", MessageBoxButtons.OK);
            }
            else
            {
                conn.Open();
                total += Convert.ToDecimal(txttotal2.Text);
                txttotal.Text = total.ToString();
                string insert = "INSERT INTO tb_income VALUES('" + txtname.Text + "','" + txttotal.Text + "', Now() )";
                cmd = new OleDbCommand(insert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Add To Cart Successfully", "kit luy hz", MessageBoxButtons.OK);
               
                txtname.Text = "---";
                txttype.Text = "---";
                txtstock.Text = "";
                txtprice.Text = "---";
                txttotal2.Text = "---";
                txtcash.Focus();

            }

           
           
        }
    }
}
