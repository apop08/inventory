namespace inventorymanager
{
    partial class storelistmanage
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.citynamebox = new System.Windows.Forms.TextBox();
            this.insertcitylist = new System.Windows.Forms.Button();
            this.updatecitylist = new System.Windows.Forms.Button();
            this.deletecitylist = new System.Windows.Forms.Button();
            this.datagridstore = new System.Windows.Forms.DataGridView();
            this.storename = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.storetypename = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.storeinsert = new System.Windows.Forms.Panel();
            this.Storenumber = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.InsertStore = new System.Windows.Forms.Button();
            this.UpdateStoreName = new System.Windows.Forms.Button();
            this.UpdatePhone = new System.Windows.Forms.Button();
            this.deleteStore = new System.Windows.Forms.Button();
            this.datasetinventory = new System.Windows.Forms.DataGridView();
            this.dataGriditems = new System.Windows.Forms.DataGridView();
            this.dataGridstorelist = new System.Windows.Forms.DataGridView();
            this.datagridsale = new System.Windows.Forms.DataGridView();
            this.datasetpurchase = new System.Windows.Forms.DataGridView();
            this.datasetworker = new System.Windows.Forms.DataGridView();
            this.datasettype = new System.Windows.Forms.DataGridView();
            this.datasetcitylist = new System.Windows.Forms.DataGridView();
            this.datasetemployee = new System.Windows.Forms.DataGridView();
            this.Inventory = new System.Windows.Forms.Button();
            this.purchase = new System.Windows.Forms.Button();
            this.Sale = new System.Windows.Forms.Button();
            this.Workeradd = new System.Windows.Forms.Button();
            this.searchParams = new System.Windows.Forms.TextBox();
            this.dataGridSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridstore)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.storeinsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetinventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriditems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstorelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridsale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetpurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetworker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasettype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetcitylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetemployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(17, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(54, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "City Name";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // citynamebox
            // 
            this.citynamebox.Location = new System.Drawing.Point(95, 23);
            this.citynamebox.Name = "citynamebox";
            this.citynamebox.Size = new System.Drawing.Size(435, 20);
            this.citynamebox.TabIndex = 3;
            this.citynamebox.TextChanged += new System.EventHandler(this.citynamebox_TextChanged);
            // 
            // insertcitylist
            // 
            this.insertcitylist.Location = new System.Drawing.Point(37, 29);
            this.insertcitylist.Name = "insertcitylist";
            this.insertcitylist.Size = new System.Drawing.Size(75, 23);
            this.insertcitylist.TabIndex = 4;
            this.insertcitylist.Text = "Insert";
            this.insertcitylist.UseVisualStyleBackColor = true;
            this.insertcitylist.Click += new System.EventHandler(this.insertcitylist_Click);
            // 
            // updatecitylist
            // 
            this.updatecitylist.Location = new System.Drawing.Point(257, 29);
            this.updatecitylist.Name = "updatecitylist";
            this.updatecitylist.Size = new System.Drawing.Size(75, 23);
            this.updatecitylist.TabIndex = 5;
            this.updatecitylist.Text = "Update";
            this.updatecitylist.UseVisualStyleBackColor = true;
            this.updatecitylist.Click += new System.EventHandler(this.updatecitylist_Click);
            // 
            // deletecitylist
            // 
            this.deletecitylist.Location = new System.Drawing.Point(484, 29);
            this.deletecitylist.Name = "deletecitylist";
            this.deletecitylist.Size = new System.Drawing.Size(75, 23);
            this.deletecitylist.TabIndex = 6;
            this.deletecitylist.Text = "Delete";
            this.deletecitylist.UseVisualStyleBackColor = true;
            this.deletecitylist.Click += new System.EventHandler(this.deletecitylist_Click);
            // 
            // datagridstore
            // 
            this.datagridstore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridstore.Location = new System.Drawing.Point(20, 235);
            this.datagridstore.Name = "datagridstore";
            this.datagridstore.Size = new System.Drawing.Size(549, 217);
            this.datagridstore.TabIndex = 7;
            this.datagridstore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcitylist_CellContentClick);
            // 
            // storename
            // 
            this.storename.Location = new System.Drawing.Point(95, 49);
            this.storename.Name = "storename";
            this.storename.Size = new System.Drawing.Size(435, 20);
            this.storename.TabIndex = 9;
            this.storename.TextChanged += new System.EventHandler(this.storename_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(8, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(63, 13);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Store Name";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // storetypename
            // 
            this.storetypename.Location = new System.Drawing.Point(95, 77);
            this.storetypename.Name = "storetypename";
            this.storetypename.Size = new System.Drawing.Size(435, 20);
            this.storetypename.TabIndex = 11;
            this.storetypename.TextChanged += new System.EventHandler(this.storetypename_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(8, 84);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(63, 13);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Store Type";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(95, 107);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(435, 20);
            this.phone.TabIndex = 13;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(-1, 114);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(84, 13);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "Phone Number";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 20);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(384, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // storeinsert
            // 
            this.storeinsert.Controls.Add(this.Storenumber);
            this.storeinsert.Controls.Add(this.textBox3);
            this.storeinsert.Controls.Add(this.phone);
            this.storeinsert.Controls.Add(this.textBox6);
            this.storeinsert.Controls.Add(this.storetypename);
            this.storeinsert.Controls.Add(this.textBox5);
            this.storeinsert.Controls.Add(this.storename);
            this.storeinsert.Controls.Add(this.textBox4);
            this.storeinsert.Controls.Add(this.citynamebox);
            this.storeinsert.Controls.Add(this.textBox2);
            this.storeinsert.Location = new System.Drawing.Point(20, 99);
            this.storeinsert.Name = "storeinsert";
            this.storeinsert.Size = new System.Drawing.Size(545, 130);
            this.storeinsert.TabIndex = 15;
            this.storeinsert.Paint += new System.Windows.Forms.PaintEventHandler(this.storeinsert_Paint);
            // 
            // Storenumber
            // 
            this.Storenumber.Location = new System.Drawing.Point(95, 0);
            this.Storenumber.Name = "Storenumber";
            this.Storenumber.Size = new System.Drawing.Size(435, 20);
            this.Storenumber.TabIndex = 15;
            this.Storenumber.Visible = false;
            this.Storenumber.TextChanged += new System.EventHandler(this.Storenumber_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(6, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(83, 13);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Store Number";
            this.textBox3.Visible = false;
            // 
            // InsertStore
            // 
            this.InsertStore.Location = new System.Drawing.Point(37, 70);
            this.InsertStore.Name = "InsertStore";
            this.InsertStore.Size = new System.Drawing.Size(75, 23);
            this.InsertStore.TabIndex = 16;
            this.InsertStore.Text = "Insert";
            this.InsertStore.UseVisualStyleBackColor = true;
            this.InsertStore.Click += new System.EventHandler(this.InsertStore_Click);
            // 
            // UpdateStoreName
            // 
            this.UpdateStoreName.Location = new System.Drawing.Point(194, 70);
            this.UpdateStoreName.Name = "UpdateStoreName";
            this.UpdateStoreName.Size = new System.Drawing.Size(90, 23);
            this.UpdateStoreName.TabIndex = 17;
            this.UpdateStoreName.Text = "Update Name";
            this.UpdateStoreName.UseVisualStyleBackColor = true;
            this.UpdateStoreName.Visible = false;
            this.UpdateStoreName.Click += new System.EventHandler(this.UpdateStoreName_Click);
            // 
            // UpdatePhone
            // 
            this.UpdatePhone.Location = new System.Drawing.Point(290, 70);
            this.UpdatePhone.Name = "UpdatePhone";
            this.UpdatePhone.Size = new System.Drawing.Size(99, 23);
            this.UpdatePhone.TabIndex = 18;
            this.UpdatePhone.Text = "Update Phone";
            this.UpdatePhone.UseVisualStyleBackColor = true;
            this.UpdatePhone.Visible = false;
            this.UpdatePhone.Click += new System.EventHandler(this.UpdatePhone_Click);
            // 
            // deleteStore
            // 
            this.deleteStore.Location = new System.Drawing.Point(484, 70);
            this.deleteStore.Name = "deleteStore";
            this.deleteStore.Size = new System.Drawing.Size(75, 23);
            this.deleteStore.TabIndex = 19;
            this.deleteStore.Text = "Delete";
            this.deleteStore.UseVisualStyleBackColor = true;
            this.deleteStore.Visible = false;
            this.deleteStore.Click += new System.EventHandler(this.deleteStore_Click);
            // 
            // datasetinventory
            // 
            this.datasetinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetinventory.Location = new System.Drawing.Point(1188, 23);
            this.datasetinventory.Name = "datasetinventory";
            this.datasetinventory.Size = new System.Drawing.Size(258, 203);
            this.datasetinventory.TabIndex = 20;
            // 
            // dataGriditems
            // 
            this.dataGriditems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriditems.Location = new System.Drawing.Point(972, 640);
            this.dataGriditems.Name = "dataGriditems";
            this.dataGriditems.Size = new System.Drawing.Size(474, 161);
            this.dataGriditems.TabIndex = 21;
            // 
            // dataGridstorelist
            // 
            this.dataGridstorelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridstorelist.Location = new System.Drawing.Point(594, 640);
            this.dataGridstorelist.Name = "dataGridstorelist";
            this.dataGridstorelist.Size = new System.Drawing.Size(372, 161);
            this.dataGridstorelist.TabIndex = 22;
            // 
            // datagridsale
            // 
            this.datagridsale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridsale.Location = new System.Drawing.Point(972, 235);
            this.datagridsale.Name = "datagridsale";
            this.datagridsale.Size = new System.Drawing.Size(474, 217);
            this.datagridsale.TabIndex = 23;
            // 
            // datasetpurchase
            // 
            this.datasetpurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetpurchase.Location = new System.Drawing.Point(972, 458);
            this.datasetpurchase.Name = "datasetpurchase";
            this.datasetpurchase.Size = new System.Drawing.Size(474, 161);
            this.datasetpurchase.TabIndex = 24;
            // 
            // datasetworker
            // 
            this.datasetworker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetworker.Location = new System.Drawing.Point(594, 235);
            this.datasetworker.Name = "datasetworker";
            this.datasetworker.Size = new System.Drawing.Size(372, 217);
            this.datasetworker.TabIndex = 28;
            // 
            // datasettype
            // 
            this.datasettype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasettype.Location = new System.Drawing.Point(20, 640);
            this.datasettype.Name = "datasettype";
            this.datasettype.Size = new System.Drawing.Size(549, 161);
            this.datasettype.TabIndex = 27;
            // 
            // datasetcitylist
            // 
            this.datasetcitylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetcitylist.Location = new System.Drawing.Point(20, 458);
            this.datasetcitylist.Name = "datasetcitylist";
            this.datasetcitylist.Size = new System.Drawing.Size(549, 161);
            this.datasetcitylist.TabIndex = 26;
            // 
            // datasetemployee
            // 
            this.datasetemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetemployee.Location = new System.Drawing.Point(594, 458);
            this.datasetemployee.Name = "datasetemployee";
            this.datasetemployee.Size = new System.Drawing.Size(372, 161);
            this.datasetemployee.TabIndex = 29;
            // 
            // Inventory
            // 
            this.Inventory.Location = new System.Drawing.Point(611, 39);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(75, 23);
            this.Inventory.TabIndex = 30;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(611, 70);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(75, 23);
            this.purchase.TabIndex = 31;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // Sale
            // 
            this.Sale.Location = new System.Drawing.Point(611, 106);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(75, 23);
            this.Sale.TabIndex = 32;
            this.Sale.Text = "Sale";
            this.Sale.UseVisualStyleBackColor = true;
            this.Sale.Click += new System.EventHandler(this.Sale_Click);
            // 
            // Workeradd
            // 
            this.Workeradd.Location = new System.Drawing.Point(611, 135);
            this.Workeradd.Name = "Workeradd";
            this.Workeradd.Size = new System.Drawing.Size(75, 23);
            this.Workeradd.TabIndex = 33;
            this.Workeradd.Text = "Worker";
            this.Workeradd.UseVisualStyleBackColor = true;
            this.Workeradd.Click += new System.EventHandler(this.Workeradd_Click);
            // 
            // searchParams
            // 
            this.searchParams.Location = new System.Drawing.Point(711, 39);
            this.searchParams.Name = "searchParams";
            this.searchParams.Size = new System.Drawing.Size(369, 20);
            this.searchParams.TabIndex = 35;
            this.searchParams.TextChanged += new System.EventHandler(this.searchParams_TextChanged);
            // 
            // dataGridSearch
            // 
            this.dataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearch.Location = new System.Drawing.Point(711, 65);
            this.dataGridSearch.Name = "dataGridSearch";
            this.dataGridSearch.Size = new System.Drawing.Size(450, 150);
            this.dataGridSearch.TabIndex = 36;
            // 
            // storelistmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 848);
            this.Controls.Add(this.dataGridSearch);
            this.Controls.Add(this.searchParams);
            this.Controls.Add(this.Workeradd);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.datasetemployee);
            this.Controls.Add(this.datasetworker);
            this.Controls.Add(this.datasettype);
            this.Controls.Add(this.datasetcitylist);
            this.Controls.Add(this.datasetpurchase);
            this.Controls.Add(this.datagridsale);
            this.Controls.Add(this.dataGridstorelist);
            this.Controls.Add(this.dataGriditems);
            this.Controls.Add(this.datasetinventory);
            this.Controls.Add(this.deleteStore);
            this.Controls.Add(this.UpdatePhone);
            this.Controls.Add(this.UpdateStoreName);
            this.Controls.Add(this.InsertStore);
            this.Controls.Add(this.storeinsert);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.datagridstore);
            this.Controls.Add(this.updatecitylist);
            this.Controls.Add(this.insertcitylist);
            this.Controls.Add(this.deletecitylist);
            this.Name = "storelistmanage";
            this.Text = "storelistmanage";
            this.Load += new System.EventHandler(this.storelistmanage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridstore)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.storeinsert.ResumeLayout(false);
            this.storeinsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetinventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriditems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstorelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridsale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetpurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetworker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasettype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetcitylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetemployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox citynamebox;
        private System.Windows.Forms.Button insertcitylist;
        private System.Windows.Forms.Button updatecitylist;
        private System.Windows.Forms.Button deletecitylist;
        private System.Windows.Forms.DataGridView datagridstore;
        private System.Windows.Forms.TextBox storename;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox storetypename;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel storeinsert;
        private System.Windows.Forms.Button InsertStore;
        private System.Windows.Forms.Button UpdateStoreName;
        private System.Windows.Forms.Button UpdatePhone;
        private System.Windows.Forms.Button deleteStore;
        private System.Windows.Forms.TextBox Storenumber;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView datasetinventory;
        private System.Windows.Forms.DataGridView dataGriditems;
        private System.Windows.Forms.DataGridView dataGridstorelist;
        private System.Windows.Forms.DataGridView datagridsale;
        private System.Windows.Forms.DataGridView datasetpurchase;
        private System.Windows.Forms.DataGridView datasetworker;
        private System.Windows.Forms.DataGridView datasettype;
        private System.Windows.Forms.DataGridView datasetcitylist;
        private System.Windows.Forms.DataGridView datasetemployee;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Button Sale;
        private System.Windows.Forms.Button Workeradd;
        private System.Windows.Forms.TextBox searchParams;
        private System.Windows.Forms.DataGridView dataGridSearch;
    }
}