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
    public partial class Income_dashboard: Form
    {
        public Income_dashboard()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = db_coffeeshop1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        decimal total = 0;

        private void Income_dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tb_income", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "test");
            dataGridView1.AutoGenerateColumns = false;
            for (int x = 0; (x <= (ds.Tables[0].Rows.Count -1)); x++)
            {
                dataGridView1.Rows.Add(
                     ds.Tables[0].Rows[x]["product_name"],
                     ds.Tables[0].Rows[x]["money"],
                     ds.Tables[0].Rows[x]["Date"]
                    );
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["money"].Value);
                label2.Text = total + "$";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tb_income", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "test");
            dataGridView1.AutoGenerateColumns = false;
            for (int x = 0; (x <= (ds.Tables[0].Rows.Count - 1)); x++)
            {
                dataGridView1.Rows.Add(
                     ds.Tables[0].Rows[x]["product_name"],
                     ds.Tables[0].Rows[x]["money"],
                     ds.Tables[0].Rows[x]["Date"]
                    );
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                total += Convert.ToDecimal(row.Cells["money"].Value);
                label2.Text = total+"$";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminDashBoard().Show();
            this.Hide();
        }
    }
}
