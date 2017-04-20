namespace inventorymanager
{
    partial class inventoryform
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Storename = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.itemquantity = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ItemCost = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ItemPrice = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // ItemPrice
            // 
            this.ItemPrice.Location = new System.Drawing.Point(77, 122);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(426, 20);
            this.ItemPrice.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(12, 122);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(59, 13);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "Price";
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
            // inventoryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 230);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.ItemCost);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.itemquantity);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Storename);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.textBox2);
            this.Name = "inventoryform";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.inventoryform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Storename;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox itemquantity;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox ItemCost;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox ItemPrice;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button deleteButton;
    }
}