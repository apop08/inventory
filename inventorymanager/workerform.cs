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

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
            int storeId = 0;
            var load3 = from g in test.storelists where g.StoreName.Equals(Storename.Text) select g;
            if (load3 != null)
            {
                if (load3.Any())
                {
                    storeId = load3.First().storeid;
                }
                else
                {
                    //handle no city found
                }


            }
            int numb = int.Parse(WorkerNumb.Text);
            var load = from g in test.employees where g.employeenumber == numb select g;

                if (load != null)
                {
                    if (load.Any())
                    {
                        var load2 = from g in test.workers where g.workerid == load.First().workerid select g;
                        try
                        {
                            if (load2 != null)
                            {
                                if (load2.Any())
                                {
                                    employee employ = load.First();
                                    worker work = load2.First();
                                    employ.storeid = storeId;
                                    work.worker_lastname = Workername.Text;
                                    work.workerphone = int.Parse(Phone.Text);
                                    test.SaveChanges();
                                    formlast.LoadToGrid();
                                    MessageBox.Show("Record Updated successfully.");
                                    this.Hide();
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.InnerException.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numb = int.Parse(WorkerNumb.Text);
                var load = from g in test.employees where g.employeenumber == numb select g;

                if (load != null)
                {
                    if (load.Any())
                    {
                        var load2 = from g in test.workers where g.workerid == load.First().workerid select g;
                        try
                        {
                            if (load2 != null)
                            {
                                if (load2.Any())
                                {
                                    employee employ = load.First();
                                    worker work = load2.First();
                                    test.workers.Remove(work);
                                    test.employees.Remove(employ);
                                    test.SaveChanges();
                                    formlast.LoadToGrid();
                                    MessageBox.Show("Record deleted successfully.");
                                    this.Hide();
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.InnerException.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }
        }
    }
}
