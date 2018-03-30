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
    public partial class New_Record : Form
    {
        public string id;
        public string name;
        public string sem;
        public string cgpa;
        public string dept;
        public string uni;
        public New_Record()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            id = idTextBox.Text;
            StudentProfileData.StudentProperty.setId(id);
            name = nameTextBox.Text;
            StudentProfileData.StudentProperty.setName(name);
            sem = semTextBox.Text;
            StudentProfileData.StudentProperty.setSem(sem);
            cgpa = cgpaTextBox.Text;
            StudentProfileData.StudentProperty.setCgpa(cgpa);
            dept = deptTextBox.Text;
            StudentProfileData.StudentProperty.setDept(dept);
            uni = uniTextBox.Text;
            StudentProfileData.StudentProperty.setUni(uni);
            StudentProfileData.StudentProperty.WriteFile();
            
        }
        
        
      
      

      
    }
}
