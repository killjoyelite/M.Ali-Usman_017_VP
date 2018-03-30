using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{
    public partial class Display_All : Form
    {
        private string[] idRead = new string[10];
        private string[] nameRead = new string[10];
        private string[] semRead = new string[10];
        private string[] cgpaRead = new string[10];
        private string[] deptRead = new string[10];
        private string[] uniRead = new string[10];
        private string filePath;
        private int count;
        public Display_All()
        {
            filePath = @"C:\Users\SMile\Desktop\file.txt";
            InitializeComponent();
        }
        public void ReadFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    int lenghtCounter = 0;
                    while (!sr.EndOfStream)
                    {
                        idRead[lenghtCounter] = sr.ReadLine();
                        nameRead[lenghtCounter] = sr.ReadLine();
                        semRead[lenghtCounter] = sr.ReadLine();
                        cgpaRead[lenghtCounter] = sr.ReadLine();
                        deptRead[lenghtCounter] = sr.ReadLine();
                        uniRead[lenghtCounter] = sr.ReadLine();
                        lenghtCounter++;
                    }
                    count = lenghtCounter;
                    MessageBox.Show("Successfully read!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error! File not found!");
            }
        }
        private void Display_All_Load(object sender, EventArgs e)
        {
            ReadFile();
            DataTable dtObj = new DataTable();
            dtObj.Columns.Add("ID", typeof(string));
            dtObj.Columns.Add("Name", typeof(string));
            dtObj.Columns.Add("Semester", typeof(string));
            dtObj.Columns.Add("Cgpa", typeof(string));
            dtObj.Columns.Add("Department", typeof(string));
            dtObj.Columns.Add("University", typeof(string));
            for (int i = 0; i < count; i++)
            {
                string id = null;
                string name = null;
                string sem = null;
                string cgpa = null;
                string dept = null;
                string uni = null;
                for (int j = 0; j < count; j++)
                {
                    id = idRead[i];
                }
                for (int k = 0; k < count; k++)
                {
                    name = nameRead[i];
                }
                for (int l = 0; l < count; l++)
                {
                    sem = semRead[i];
                }
                for (int m = 0; m < count; m++)
                {
                    cgpa = cgpaRead[i];
                }
                for (int n = 0; n < count; n++)
                {
                    dept = deptRead[i];
                }
                for (int o = 0; o < count; o++)
                {
                    uni = uniRead[i];
                }
                dtObj.Rows.Add(id, name, sem, cgpa, dept, uni);
            }

            dataGridView1.DataSource = dtObj;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}
