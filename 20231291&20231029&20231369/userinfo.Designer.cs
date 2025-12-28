namespace _20231291_20231029_20231369
{
    partial class userinfo
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
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.customer_name,
            this.customer_phonenumber});
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // customer_id
            // 
            this.customer_id.HeaderText = "customer_id";
            this.customer_id.MinimumWidth = 6;
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Width = 125;
            // 
            // customer_name
            // 
            this.customer_name.HeaderText = "customer_name";
            this.customer_name.MinimumWidth = 6;
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 125;
            // 
            // customer_phonenumber
            // 
            this.customer_phonenumber.HeaderText = "customer_phonenumber";
            this.customer_phonenumber.MinimumWidth = 6;
            this.customer_phonenumber.Name = "customer_phonenumber";
            this.customer_phonenumber.ReadOnly = true;
            this.customer_phonenumber.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Information";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(449, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "userinfo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.userinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_phonenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}