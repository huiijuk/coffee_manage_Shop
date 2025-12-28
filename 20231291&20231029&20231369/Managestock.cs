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
    public partial class Managestock: Form
    {
        public Managestock()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = db_coffeeshop1.mdb");
        OleDbCommand cmd = new OleDbCommand();
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Managestock_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tb_stock ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "test");
            dataGridView1.AutoGenerateColumns = false;
            for (int x = 0; (x <= (ds.Tables[0].Rows.Count -1)); x++)
            {
                dataGridView1.Rows.Add(
                    ds.Tables[0].Rows[x]["ProductID"],
                    ds.Tables[0].Rows[x]["ProductName"],
                    ds.Tables[0].Rows[x]["Stock"],
                    ds.Tables[0].Rows[x]["Price"],
                    ds.Tables[0].Rows[x]["Status"],
                    ds.Tables[0].Rows[x]["Date"]
                    );
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           if(txtID.Text == "" && txtname.Text == "" && txtprice.Text == "" && txtstatus.Text=="" && txtstock.Text == "")
            {
                MessageBox.Show("Field Is Empty ", "Please Refill the Field",  MessageBoxButtons.OK);
            }
            else
            {
                conn.Open();
                string add = "INSERT INTO tb_stock VALUES('" + txtID.Text + "','" + txtname.Text + "','" + txtstock.Text + "','" + txtprice.Text + "','" + txtstatus.Text + "', Now())";
                cmd = new OleDbCommand(add, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txtID.Text = "";
                txtname.Text = "";
                txtprice.Text = "";
                txtstatus.Text = "";
                txtstock.Text = "";
                MessageBox.Show("Add New Item SuccessFully", "Upload Successfullly", MessageBoxButtons.OK);
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tb_stock ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "test");
            dataGridView1.AutoGenerateColumns = false;
            for (int x = 0; (x <= (ds.Tables[0].Rows.Count - 1)); x++)
            {
                dataGridView1.Rows.Add(
                    ds.Tables[0].Rows[x]["ProductID"],
                    ds.Tables[0].Rows[x]["ProductName"],
                    ds.Tables[0].Rows[x]["Stock"],
                    ds.Tables[0].Rows[x]["Price"],
                    ds.Tables[0].Rows[x]["Status"],
                    ds.Tables[0].Rows[x]["Date"]
                    );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["ProductID"].Value.ToString();
                txtname.Text = row.Cells["ProductName"].Value.ToString();
                txtstock.Text = row.Cells["Stock"].Value.ToString();
                txtprice.Text = row.Cells["Price"].Value.ToString();
                txtstatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            string update =
                "UPDATE tb_stock " +
                "SET ProductName = '" + txtname.Text + "', " +
                "Stock = '" + txtstock.Text + "', " +
                "Price = '" + txtprice.Text + "', " +
                "Status = '" + txtstatus.Text + "', " +
                "[Date] = Now() " +
                "WHERE ProductID = '" + txtID.Text + "'"; 

            cmd = new OleDbCommand(update, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            txtID.Text = "";
            txtname.Text = "";
            txtprice.Text = "";
            txtstatus.Text = "";
            txtstock.Text = "";

            MessageBox.Show("Has Been Updated Successfully!", "Success", MessageBoxButtons.OK);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Delete = "DELETE FROM tb_stock WHERE ProductID = '" + txtID.Text + "'";
            cmd = new OleDbCommand(Delete, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            txtID.Text = "";
            txtname.Text = "";
            txtprice.Text = "";
            txtstatus.Text = "";
            txtstock.Text = "";

            MessageBox.Show("Item Has Been Delete", "Successfully", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminDashBoard().Show();
            this.Hide();
        }
    }
}
