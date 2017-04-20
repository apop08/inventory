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
    public partial class workerform : Form
    {
        inventoryEntities test;
        storelistmanage formlast = null;
        public workerform(storelistmanage form)
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
                int storeId = 0;
                var load = from g in test.storelists where g.StoreName.Equals(Storename.Text) select g;
                if (load != null)
                {
                    if (load.Any())
                    {
                        storeId = load.First().storeid;
                    }
                    else
                    {
                        //handle no city found
                    }


                }

                worker workertoadd = new worker
                {
                    workerid = idmanager.getNextWorkerId(),
                    worker_lastname = Workername.Text,
                    workerphone = int.Parse(Phone.Text),
                };
                test.workers.Add(workertoadd);
                employee employeetoadd = new employee
                {
                    storeid = storeId,
                    workerid = workertoadd.workerid,
                };
                test.employees.Add(employeetoadd);
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
