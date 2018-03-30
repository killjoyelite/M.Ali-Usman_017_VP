using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Record newObj = new New_Record();
            newObj.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            Display_All dispObj = new Display_All();
            dispObj.Show();
        }

        private void cGPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sorting_Cgpa sortObj = new Sorting_Cgpa();
            sortObj.Show();
        }

        private void searchIdBtn_Click(object sender, EventArgs e)
        {
            Search_ID searchIdObj = new Search_ID();
            searchIdObj.Show();
        }

        private void searchNameBtn_Click(object sender, EventArgs e)
        {
            Search_Name searchNameObj = new Search_Name();
            searchNameObj.Show();
        }

        private void searchSemBtn_Click(object sender, EventArgs e)
        {
            Search_Semester searchSemObj = new Search_Semester();
            searchSemObj.Show();
        }

        

        
    }
}
