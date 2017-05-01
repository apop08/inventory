namespace inventorymanager
{
    partial class saleform
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
            this.ItemName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Storename = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.itemquantity = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ItemCost = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.workername = new System.Windows.Forms.TextBox();
            this.workerid = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.WorkerNumb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(77, 12);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(426, 20);
            this.ItemName.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(59, 13);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Item Name:";
            // 
            // Storename
            // 
            this.Storename.Location = new System.Drawing.Point(77, 38);
            this.Storename.Name = "Storename";
            this.Storename.Size = new System.Drawing.Size(426, 20);
            this.Storename.TabIndex = 10;
            this.Storename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(12, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(59, 13);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Store Name:";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // itemquantity
            // 
            this.itemquantity.Location = new System.Drawing.Point(77, 64);
            this.itemquantity.Name = "itemquantity";
            this.itemquantity.Size = new System.Drawing.Size(426, 20);
            this.itemquantity.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(12, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(59, 13);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Quantity:";
            // 
            // ItemCost
            // 
            this.ItemCost.Location = new System.Drawing.Point(77, 90);
            this.ItemCost.Name = "ItemCost";
            this.ItemCost.Size = new System.Drawing.Size(426, 20);
            this.ItemCost.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(12, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(59, 13);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Cost:";
            // 
            // workername
            // 
            this.workername.Location = new System.Drawing.Point(77, 122);
            this.workername.Name = "workername";
            this.workername.Size = new System.Drawing.Size(426, 20);
            this.workername.TabIndex = 16;
            // 
            // workerid
            // 
            this.workerid.BackColor = System.Drawing.SystemColors.Control;
            this.workerid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerid.Location = new System.Drawing.Point(-1, 122);
            this.workerid.Name = "workerid";
            this.workerid.ReadOnly = true;
            this.workerid.Size = new System.Drawing.Size(72, 13);
            this.workerid.TabIndex = 15;
            this.workerid.Text = "Worker Name";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(10, 192);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 17;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(224, 192);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyButton.TabIndex = 18;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(417, 192);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // WorkerNumb
            // 
            this.WorkerNumb.Location = new System.Drawing.Point(90, 148);
            this.WorkerNumb.Name = "WorkerNumb";
            this.WorkerNumb.Size = new System.Drawing.Size(413, 20);
            this.WorkerNumb.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(-1, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(86, 13);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Sale Number:";
            // 
            // saleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 230);
            this.Controls.Add(this.WorkerNumb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.workername);
            this.Controls.Add(this.workerid);
            this.Controls.Add(this.ItemCost);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.itemquantity);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Storename);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.textBox2);
            this.Name = "saleform";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.inventoryform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Storename;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox itemquantity;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox ItemCost;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox workername;
        private System.Windows.Forms.TextBox workerid;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox WorkerNumb;
        private System.Windows.Forms.TextBox textBox1;
    }
}