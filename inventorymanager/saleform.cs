using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanager
{
    public partial class saleform : Form
    {
        inventoryEntities test;
        storelistmanage formlast = null;
        public saleform(storelistmanage form)
        {
            InitializeComponent();
            test = new inventoryEntities();
            formlast = form;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventoryform_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //check if city exists already else create
                int storeid = 0;
                var load = from g in test.storelists where g.StoreName.Equals(Storename.Text) select g;
                if (load != null)
                {
                    if (load.Any())
                    {
                        storeid = load.First().storeid;
                    }
                    else
                    {
                        //handle no city found
                    }

                    
                }
                //check if city exists already else create
                int nextitemid = 0;
                var load2 = from g in test.items where g.itemname.Equals(ItemName.Text) select g.itemid;
                if (load2 != null)
                {
                    if (load2.Any())
                    {
                        nextitemid = load2.First();
                    }
                    else
                    {
                        item itemtoAdd = new item
                        {
                            itemid = idmanager.getNextItemId(),
                            itemname = ItemName.Text
                        };
                        nextitemid = itemtoAdd.itemid;
                        test.items.Add(itemtoAdd);
                    }

                }
                //check if worker exists already else create
                int nextworker = 0;
                var load3 = from g in test.workers where g.worker_lastname.Equals(workername.Text) select g.workerid;
                if (load3 != null)
                {
                    if (load3.Any())
                    {
                        nextworker = load2.First();
                    }
                    else
                    {

                    }

                }
                sale purchasetoadd = new sale
                {
                    storeid = storeid,
                    itemid = nextitemid,
                    sale_qty = int.Parse(itemquantity.Text),
                    totalsale = int.Parse(ItemCost.Text),
                    workerid = nextworker,
                };
                test.sales.Add(purchasetoadd);

                test.SaveChanges();
                formlast.LoadToGrid();
                MessageBox.Show("Record Inserted successfully.");
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }
        }
    }
}
