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
        private void LoadToGrid()
        {
            //need to change display formating
            var load = from g in test.stores select g;
            if (load != null)
            {
                datagridstore.DataSource = load.ToList();
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

                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void UpdateStoreName_Click(object sender, EventArgs e)
        {
            int numb = int.Parse(Storenumber.Text);
            var load = from g in test.stores where g.storenumber == numb select g.storeID;
            try
            {
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void UpdatePhone_Click(object sender, EventArgs e)
        {
            int numb = int.Parse(Storenumber.Text);
            var load = from g in test.stores where g.storenumber == numb select g;
            try
            {
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void deleteStore_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                int numb = int.Parse(Storenumber.Text);
                var load = from g in test.stores where g.storenumber == numb select g;
                store Store = load.First();
                
                test.stores.Remove(Store);
                test.SaveChanges();
                LoadToGrid();
                MessageBox.Show("Record Deleted successfully.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
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
    }
}
