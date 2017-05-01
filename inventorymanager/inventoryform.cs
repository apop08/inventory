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
    public partial class inventoryform : Form
    {
        inventoryEntities test;
        storelistmanage formlast = null;
        public inventoryform(storelistmanage form)
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
                        var load3 = from g in test.stores where g.storeID == storeid select g.inventoryid;
                        if (load != null)
                        {
                            if (load.Any())
                            {
                                storeid = load3.First();
                            }
                            else
                            {
                                //handle no city found
                            }
                        }
                        else
                        {
                            //handle no city found
                        }

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

                inventory invtoadd = new inventory
                {
                    inventoryid = storeid,
                    itemid = nextitemid,
                    quantity = int.Parse(itemquantity.Text),
                    cost = int.Parse(ItemCost.Text),
                    sale_price = int.Parse(ItemPrice.Text),
                };
                test.inventories.Add(invtoadd);

                test.SaveChanges();
                formlast.LoadToGrid();
                MessageBox.Show("Record Inserted successfully.");
                this.Hide();

            }
            catch (Exception)
            {

                MessageBox.Show("Error on insert");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
