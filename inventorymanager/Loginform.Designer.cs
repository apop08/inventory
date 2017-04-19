namespace inventorymanager
{
    partial class Loginform
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
            this.CreateLogin = new System.Windows.Forms.Button();
            this.LoginLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.Userhash = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PassHashOne = new System.Windows.Forms.TextBox();
            this.Passhash = new System.Windows.Forms.TextBox();
            this.PassHashTwo = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.UserHashTwo = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // CreateLogin
            // 
            this.CreateLogin.Location = new System.Drawing.Point(103, 57);
            this.CreateLogin.Name = "CreateLogin";
            this.CreateLogin.Size = new System.Drawing.Size(75, 23);
            this.CreateLogin.TabIndex = 1;
            this.CreateLogin.Text = "Create";
            this.CreateLogin.UseVisualStyleBackColor = true;
            this.CreateLogin.Click += new System.EventHandler(this.CreateLogin_Click);
            // 
            // LoginLogin
            // 
            this.LoginLogin.Location = new System.Drawing.Point(449, 57);
            this.LoginLogin.Name = "LoginLogin";
            this.LoginLogin.Size = new System.Drawing.Size(75, 23);
            this.LoginLogin.TabIndex = 2;
            this.LoginLogin.Text = "Login";
            this.LoginLogin.UseVisualStyleBackColor = true;
            this.LoginLogin.Click += new System.EventHandler(this.LoginLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(38, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Username:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(38, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Password:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(103, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(482, 20);
            this.Username.TabIndex = 5;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.Location = new System.Drawing.Point(103, 31);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(482, 20);
            this.PasswordLogin.TabIndex = 6;
            this.PasswordLogin.TextChanged += new System.EventHandler(this.PasswordLogin_TextChanged);
            // 
            // Userhash
            // 
            this.Userhash.Location = new System.Drawing.Point(103, 91);
            this.Userhash.Name = "Userhash";
            this.Userhash.ReadOnly = true;
            this.Userhash.Size = new System.Drawing.Size(482, 20);
            this.Userhash.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(38, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "User Hash:";
            // 
            // PassHashOne
            // 
            this.PassHashOne.Location = new System.Drawing.Point(103, 117);
            this.PassHashOne.Name = "PassHashOne";
            this.PassHashOne.ReadOnly = true;
            this.PassHashOne.Size = new System.Drawing.Size(482, 20);
            this.PassHashOne.TabIndex = 10;
            // 
            // Passhash
            // 
            this.Passhash.BackColor = System.Drawing.SystemColors.Control;
            this.Passhash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passhash.Location = new System.Drawing.Point(38, 117);
            this.Passhash.Name = "Passhash";
            this.Passhash.ReadOnly = true;
            this.Passhash.Size = new System.Drawing.Size(100, 13);
            this.Passhash.TabIndex = 9;
            this.Passhash.Text = "Pass Hash:";
            // 
            // PassHashTwo
            // 
            this.PassHashTwo.Location = new System.Drawing.Point(103, 196);
            this.PassHashTwo.Name = "PassHashTwo";
            this.PassHashTwo.ReadOnly = true;
            this.PassHashTwo.Size = new System.Drawing.Size(482, 20);
            this.PassHashTwo.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(38, 196);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Pass Hash:";
            // 
            // UserHashTwo
            // 
            this.UserHashTwo.Location = new System.Drawing.Point(103, 170);
            this.UserHashTwo.Name = "UserHashTwo";
            this.UserHashTwo.ReadOnly = true;
            this.UserHashTwo.Size = new System.Drawing.Size(482, 20);
            this.UserHashTwo.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(38, 177);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 13);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "User Hash:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(264, 72);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 13);
            this.textBox9.TabIndex = 15;
            this.textBox9.Text = "After SHA256";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(264, 151);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 13);
            this.textBox10.TabIndex = 16;
            this.textBox10.Text = "After RSA";
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 454);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.PassHashTwo);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.UserHashTwo);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.PassHashOne);
            this.Controls.Add(this.Passhash);
            this.Controls.Add(this.Userhash);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoginLogin);
            this.Controls.Add(this.CreateLogin);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Loginform";
            this.Text = "Loginform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CreateLogin;
        private System.Windows.Forms.Button LoginLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.TextBox Userhash;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox PassHashOne;
        private System.Windows.Forms.TextBox Passhash;
        private System.Windows.Forms.TextBox PassHashTwo;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox UserHashTwo;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
    }
}