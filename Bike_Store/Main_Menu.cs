using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_Store
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void mainMenuLabel_Click(object sender, EventArgs e)
        {

        }

        private void maintencanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productMaintenanceFormBttn_Click(object sender, EventArgs e)
        {

        }

        private void customerMaintenanceFormBttn_Click(object sender, EventArgs e)
        {
            using (Customer_Maintenance form = new Customer_Maintenance())
            {
                form.ShowDialog();
            }
        }

        private void errorLogFormBttn_Click(object sender, EventArgs e)
        {

        }

        private void logoutBttn_Click(object sender, EventArgs e)
        {

        }

        private void salesReportsFormBttn_Click(object sender, EventArgs e)
        {

        }

        private void shoppingCartFormBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
