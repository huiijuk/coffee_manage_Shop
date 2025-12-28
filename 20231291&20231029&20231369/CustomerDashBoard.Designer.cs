namespace _20231291_20231029_20231369
{
    partial class CustomerDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.Label();
            this.txtexchange = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnpaid = new System.Windows.Forms.Button();
            this.btnquantity = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotal2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Type,
            this.Stock,
            this.Price,
            this.Status,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(992, 204);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 180;
            // 
            // btncart
            // 
            this.btncart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncart.Location = new System.Drawing.Point(606, 292);
            this.btncart.Name = "btncart";
            this.btncart.Size = new System.Drawing.Size(78, 63);
            this.btncart.TabIndex = 19;
            this.btncart.Text = "🧺";
            this.btncart.UseVisualStyleBackColor = false;
            this.btncart.Click += new System.EventHandler(this.btncart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Product :";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(207, 233);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(27, 20);
            this.txtname.TabIndex = 22;
            this.txtname.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Price Each :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Quantity :";
            // 
            // txtprice
            // 
            this.txtprice.AutoSize = true;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(519, 277);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(27, 20);
            this.txtprice.TabIndex = 28;
            this.txtprice.Text = "---";
            // 
            // txttype
            // 
            this.txttype.AutoSize = true;
            this.txttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.Location = new System.Drawing.Point(209, 277);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(27, 20);
            this.txttype.TabIndex = 26;
            this.txttype.Text = "---";
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(480, 226);
            this.txtstock.Multiline = true;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(120, 36);
            this.txtstock.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Total Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(770, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cash :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(768, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Exchange :";
            // 
            // txtcash
            // 
            this.txtcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.Location = new System.Drawing.Point(857, 295);
            this.txtcash.Multiline = true;
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(108, 30);
            this.txtcash.TabIndex = 33;
            // 
            // txttotal
            // 
            this.txttotal.AutoSize = true;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(898, 267);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(27, 20);
            this.txttotal.TabIndex = 34;
            this.txttotal.Text = "---";
            // 
            // txtexchange
            // 
            this.txtexchange.AutoSize = true;
            this.txtexchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexchange.Location = new System.Drawing.Point(898, 335);
            this.txtexchange.Name = "txtexchange";
            this.txtexchange.Size = new System.Drawing.Size(27, 20);
            this.txtexchange.TabIndex = 35;
            this.txtexchange.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(764, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "Cashier";
            // 
            // btnpaid
            // 
            this.btnpaid.BackColor = System.Drawing.Color.Lime;
            this.btnpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaid.ForeColor = System.Drawing.Color.White;
            this.btnpaid.Location = new System.Drawing.Point(769, 381);
            this.btnpaid.Name = "btnpaid";
            this.btnpaid.Size = new System.Drawing.Size(91, 36);
            this.btnpaid.TabIndex = 37;
            this.btnpaid.Text = "Paid";
            this.btnpaid.UseVisualStyleBackColor = false;
            this.btnpaid.Click += new System.EventHandler(this.btnpaid_Click);
            // 
            // btnquantity
            // 
            this.btnquantity.BackColor = System.Drawing.Color.Lime;
            this.btnquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquantity.ForeColor = System.Drawing.Color.White;
            this.btnquantity.Location = new System.Drawing.Point(606, 226);
            this.btnquantity.Name = "btnquantity";
            this.btnquantity.Size = new System.Drawing.Size(78, 36);
            this.btnquantity.TabIndex = 38;
            this.btnquantity.Text = "add";
            this.btnquantity.UseVisualStyleBackColor = false;
            this.btnquantity.Click += new System.EventHandler(this.btnquantity_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(770, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Total :";
            // 
            // txttotal2
            // 
            this.txttotal2.AutoSize = true;
            this.txttotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal2.Location = new System.Drawing.Point(519, 323);
            this.txttotal2.Name = "txttotal2";
            this.txttotal2.Size = new System.Drawing.Size(27, 20);
            this.txttotal2.TabIndex = 40;
            this.txttotal2.Text = "---";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(971, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 33);
            this.button1.TabIndex = 41;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttotal2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnquantity);
            this.Controls.Add(this.btnpaid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtexchange);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtcash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncart);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerDashBoard";
            this.Text = "CustomerDashBoard";
            this.Load += new System.EventHandler(this.CustomerDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btncart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtprice;
        private System.Windows.Forms.Label txttype;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.Label txttotal;
        private System.Windows.Forms.Label txtexchange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnpaid;
        private System.Windows.Forms.Button btnquantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txttotal2;
        private System.Windows.Forms.Button button1;
    }
}