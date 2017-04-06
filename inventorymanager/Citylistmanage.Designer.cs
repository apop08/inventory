namespace inventorymanager
{
    partial class Citylistmanage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cityidbox = new System.Windows.Forms.TextBox();
            this.citynamebox = new System.Windows.Forms.TextBox();
            this.insertcitylist = new System.Windows.Forms.Button();
            this.updatecitylist = new System.Windows.Forms.Button();
            this.deletecitylist = new System.Windows.Forms.Button();
            this.datagridcitylist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcitylist)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(46, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(20, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(54, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "City Name";
            // 
            // cityidbox
            // 
            this.cityidbox.Location = new System.Drawing.Point(81, 26);
            this.cityidbox.Name = "cityidbox";
            this.cityidbox.Size = new System.Drawing.Size(100, 20);
            this.cityidbox.TabIndex = 2;
            // 
            // citynamebox
            // 
            this.citynamebox.Location = new System.Drawing.Point(81, 65);
            this.citynamebox.Name = "citynamebox";
            this.citynamebox.Size = new System.Drawing.Size(191, 20);
            this.citynamebox.TabIndex = 3;
            // 
            // insertcitylist
            // 
            this.insertcitylist.Location = new System.Drawing.Point(12, 111);
            this.insertcitylist.Name = "insertcitylist";
            this.insertcitylist.Size = new System.Drawing.Size(75, 23);
            this.insertcitylist.TabIndex = 4;
            this.insertcitylist.Text = "Insert";
            this.insertcitylist.UseVisualStyleBackColor = true;
            this.insertcitylist.Click += new System.EventHandler(this.insertcitylist_Click);
            // 
            // updatecitylist
            // 
            this.updatecitylist.Location = new System.Drawing.Point(106, 111);
            this.updatecitylist.Name = "updatecitylist";
            this.updatecitylist.Size = new System.Drawing.Size(75, 23);
            this.updatecitylist.TabIndex = 5;
            this.updatecitylist.Text = "Update";
            this.updatecitylist.UseVisualStyleBackColor = true;
            this.updatecitylist.Click += new System.EventHandler(this.updatecitylist_Click);
            // 
            // deletecitylist
            // 
            this.deletecitylist.Location = new System.Drawing.Point(197, 111);
            this.deletecitylist.Name = "deletecitylist";
            this.deletecitylist.Size = new System.Drawing.Size(75, 23);
            this.deletecitylist.TabIndex = 6;
            this.deletecitylist.Text = "Delete";
            this.deletecitylist.UseVisualStyleBackColor = true;
            this.deletecitylist.Click += new System.EventHandler(this.deletecitylist_Click);
            // 
            // datagridcitylist
            // 
            this.datagridcitylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcitylist.Location = new System.Drawing.Point(12, 152);
            this.datagridcitylist.Name = "datagridcitylist";
            this.datagridcitylist.Size = new System.Drawing.Size(260, 255);
            this.datagridcitylist.TabIndex = 7;
            this.datagridcitylist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcitylist_CellContentClick);
            // 
            // Citylistmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 419);
            this.Controls.Add(this.datagridcitylist);
            this.Controls.Add(this.deletecitylist);
            this.Controls.Add(this.updatecitylist);
            this.Controls.Add(this.insertcitylist);
            this.Controls.Add(this.citynamebox);
            this.Controls.Add(this.cityidbox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Citylistmanage";
            this.Text = "Citylistmanage";
            ((System.ComponentModel.ISupportInitialize)(this.datagridcitylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox cityidbox;
        private System.Windows.Forms.TextBox citynamebox;
        private System.Windows.Forms.Button insertcitylist;
        private System.Windows.Forms.Button updatecitylist;
        private System.Windows.Forms.Button deletecitylist;
        private System.Windows.Forms.DataGridView datagridcitylist;
    }
}