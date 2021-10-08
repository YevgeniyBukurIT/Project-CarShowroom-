using CarShowrooms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowrooms
{
    public partial class Menu : Form
    {
        


        public Menu()
        {
            InitializeComponent();
            
        }

        

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        public void BtnOpenMainForm_Click(object sender, EventArgs e)
        {
            
            new FormShowroom().Show();
            
                       
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();

        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            new Help().ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void openMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new FormShowroom().ShowDialog();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help().Show();
        }

        private void BtnCreateCarMenu_Click(object sender, EventArgs e)
        {
            
            new CreateCare().ShowDialog();
            
        }

        
        private void btnDetail_Click(object sender, EventArgs e)
        {
            new FormDetail().Show();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            new FormSeller().Show();
        }
    }
}
