namespace _20231291_20231029_20231369
{
    partial class SignIn
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(127, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Create Account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(96, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Don\'t Have An Account";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.GhostWhite;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclear.Location = new System.Drawing.Point(110, 395);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(174, 54);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Purple;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Location = new System.Drawing.Point(110, 335);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(174, 54);
            this.btnlogin.TabIndex = 20;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(173, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 26);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(62, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 18;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(60, 258);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(287, 39);
            this.txtpass.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(58, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(60, 166);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(287, 39);
            this.txtusername.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(58, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(123, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Log In";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 658);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}