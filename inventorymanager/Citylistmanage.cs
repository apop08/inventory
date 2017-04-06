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
    public partial class Citylistmanage : Form
    {
        public Citylistmanage()
        {
            InitializeComponent();
        }

        private void insertcitylist_Click(object sender, EventArgs e)
        {
            inventoryEntities test = new inventoryEntities();
            try
            {

                citylist emp = new citylist
                {
                    cityid = int.Parse(cityidbox.Text),
                    cityname = citynamebox.Text,
                };
                test.citylists.Add(emp);
                test.SaveChanges();
                MessageBox.Show("Record Inserted successfully.");
                LoadToGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void updatecitylist_Click(object sender, EventArgs e)
        {

        }

        private void deletecitylist_Click(object sender, EventArgs e)
        {

        }
        private void LoadToGrid()
        {
            inventoryEntities test = new inventoryEntities();
            var load = from g in test.citylists select g;
            if (load != null)
            {
                datagridcitylist.DataSource = load.ToList();
            }
        }
        private void datagridcitylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
