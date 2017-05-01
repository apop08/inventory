using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace inventorymanager
{

    public partial class storelistmanage : Form
    {
        inventoryEntities test = new inventoryEntities();
        public storelistmanage()
        {
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.store_FormClosed);

            test.Database.CreateIfNotExists();
            test.SaveChanges();
            idmanager.InitInvId();
            
            InitializeComponent();
            LoadToGrid();

        }

        private void insertcitylist_Click(object sender, EventArgs e)
        {
            this.InsertStore.Visible = true;
            this.UpdateStoreName.Visible = false;
            this.UpdatePhone.Visible = false;
            this.deleteStore.Visible = false;
            this.textBox3.Visible = false;
            this.Storenumber.Visible = false;
            this.textBox2.Visible = true;
            this.citynamebox.Visible = true;
            this.textBox4.Visible = true;
            this.storename.Visible = true;
            this.textBox5.Visible = true;
            this.storetypename.Visible = true;
            this.textBox6.Visible = true;
            this.phone.Visible = true;
        }
        public void LoadToGrid()
        {
            //need to change display formating
            var load = from g in test.stores select g;
            if (load != null)
            {
                datagridstore.DataSource = load.ToList();
            }
            var load2 = from g in test.inventories select g;
            if (load2 != null)
            {
                datasetinventory.DataSource = load2.ToList();
            }
            var load3 = from g in test.citylists select g;
            if (load3 != null)
            {
                datasetcitylist.DataSource = load3.ToList();
            }
            var load4 = from g in test.storelists select g;
            if (load4 != null)
            {
                dataGridstorelist.DataSource = load4.ToList();
            }
            var load5 = from g in test.items select g;
            if (load5 != null)
            {
                dataGriditems.DataSource = load5.ToList();
            }
            var load6 = from g in test.storetypelists select g;
            if (load6 != null)
            {
                datasettype.DataSource = load6.ToList();
            }
            var load7 = from g in test.sales select g;
            if (load7 != null)
            {
                datagridsale.DataSource = load7.ToList();
            }
            var load8 = from g in test.purchases select g;
            if (load8 != null)
            {
                datasetpurchase.DataSource = load8.ToList();
            }
            var load9 = from g in test.workers select g;
            if (load9 != null)
            {
                datasetworker.DataSource = load9.ToList();
            }
            var load10 = from g in test.employees select g;
            if (load10 != null)
            {
                datasetemployee.DataSource = load10.ToList();
            }


        }
        private void updatecitylist_Click(object sender, EventArgs e)
        {
            this.InsertStore.Visible = false;
            this.UpdateStoreName.Visible = true;
            this.UpdatePhone.Visible = true;
            this.deleteStore.Visible = false;
            this.textBox3.Visible = true;
            this.Storenumber.Visible = true;
            this.textBox2.Visible = false;
            this.citynamebox.Visible = false;
            this.textBox4.Visible = true;
            this.storename.Visible = true;
            this.textBox5.Visible = false;
            this.storetypename.Visible = false;
            this.textBox6.Visible = true;
            this.phone.Visible = true;

        }

        private void deletecitylist_Click(object sender, EventArgs e)
        {
            this.InsertStore.Visible = false;
            this.UpdateStoreName.Visible = false;
            this.UpdatePhone.Visible = false;
            this.deleteStore.Visible = true;
            this.textBox3.Visible = true;
            this.Storenumber.Visible = true;
            this.textBox2.Visible = false;
            this.citynamebox.Visible = false;
            this.textBox4.Visible = false;
            this.storename.Visible = false;
            this.textBox5.Visible = false;
            this.storetypename.Visible = false;
            this.textBox6.Visible = false;
            this.phone.Visible = false;
        }

        private void datagridcitylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void storelistmanage_Load(object sender, EventArgs e)
        {

        }

        private void storeinsert_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InsertStore_Click(object sender, EventArgs e)
        {
            
            try
            {
                //always add store since not unique name
                storelist storecheck = new storelist
                {
                    storeid = idmanager.getNextStoreId(),
                    StoreName = storename.Text
                };
                test.storelists.Add(storecheck);

                //check if city exists already else create
                int nextcityid = 0;
                var load = from g in test.citylists where g.cityname.Equals(citynamebox.Text) select g.cityid;
                if (load != null)
                {
                    if (load.Any())
                    {
                        nextcityid = load.First();
                    }
                    else
                    {
                        citylist city = new citylist
                        {
                            cityid = idmanager.getNextCityId(),
                            cityname = citynamebox.Text
                        };
                        nextcityid = city.cityid;
                        test.citylists.Add(city);
                    }

                }

                int nexttype = 0;
                //check if storetypelist exists already else create
                var load2 = from g in test.storetypelists where g.storetypename.Equals(storetypename.Text) select g.storetype;
                if (load2 != null)
                {
                    if (load2.Any())
                    {
                        nexttype = load.First();
                    }
                    else
                    {
                        storetypelist storetypecheck = new storetypelist
                        {
                            storetype = idmanager.getNextTypeId(),
                            storetypename = storetypename.Text
                        };
                        nexttype = storetypecheck.storetype;
                        test.storetypelists.Add(storetypecheck);
                    }

                }


                store storetoadd = new store
                {
                    storeID = storecheck.storeid,
                    inventoryid = idmanager.getNextInvId(),
                    cityid = nextcityid,
                    StoreType = nexttype,
                    storephone = int.Parse(phone.Text),

                };
                test.stores.Add(storetoadd);

                test.SaveChanges();
                LoadToGrid();
                MessageBox.Show("Record Inserted successfully.");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bad Input");
            }
        }

        private void UpdateStoreName_Click(object sender, EventArgs e)
        {

            try
            {
                int numb = int.Parse(Storenumber.Text);
                var load = from g in test.stores where g.storenumber == numb select g.storeID;
                if (load != null)
                {
                    if (load.Any())
                    {
                        numb = load.First();
                        var load2 = from h in test.storelists where numb == h.storeid select h;
                        if (load2 != null && load2.Any())
                        {
                            storelist store = load2.First();
                            store.StoreName = storename.Text;

                            test.SaveChanges();
                            LoadToGrid();
                            MessageBox.Show("Record Updated successfully.");
                            
                        }

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bad Input");
            }
        }

        private void UpdatePhone_Click(object sender, EventArgs e)
        {
            
            try
            {
                int numb = int.Parse(Storenumber.Text);
                var load = from g in test.stores where g.storenumber == numb select g;
                if (load != null)
                {
                    if (load.Any())
                    {
                        store Store = load.First();
                        Store.storephone = int.Parse(phone.Text);
                        test.SaveChanges();
                        LoadToGrid();
                        MessageBox.Show("Record Updated successfully.");
                        
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bad Input");
            }

        }


        private void searchParams_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var load = from g in test.storelists where g.StoreName.Contains(searchParams.Text) select g;
                if (load != null)
                {
                    dataGridSearch.DataSource = load.ToList();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bad Search Input");
            }
        }
        private void deleteStore_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                int numb = int.Parse(Storenumber.Text);
                var load = from g in test.stores where g.storenumber == numb select g;
                store Store = load.First();
                var load2 = from g in test.citylists where g.cityid == Store.cityid select g;
                citylist city = load2.First();
                test.citylists.Remove(city);
                var load3 = from g in test.storetypelists where g.storetype == Store.StoreType select g;
                storetypelist typelist = load3.First();
                test.storetypelists.Remove(typelist);
                var load4 = from g in test.storelists where g.storeid == Store.storeID select g;
                storelist storelist = load4.First();
                test.storelists.Remove(storelist);
                test.stores.Remove(Store);
                test.SaveChanges();
                LoadToGrid();
                MessageBox.Show("Record Deleted successfully.");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error on delete");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void storetypename_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void storename_TextChanged(object sender, EventArgs e)
        {

        }

        private void citynamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Storenumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void store_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            inventoryform form = new inventoryform(this);
            form.Show();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            purchaseform form = new purchaseform(this);
            form.Show();
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            saleform form = new saleform(this);
            form.Show();
        }

        private void Workeradd_Click(object sender, EventArgs e)
        {
            workerform form = new workerform(this);
            form.Show();
        }


    }
}
