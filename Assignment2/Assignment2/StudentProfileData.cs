using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Assignment2
{
    class StudentProfileData
    {
        string id;
        string name;
        string sem;
        string cgpa;
        string dept;
        string uni;

        string[] idRead = new string[10];
        string[] nameRead = new string[10];
        string[] semRead = new string[10];
        string[] cgpaRead = new string[10];
        string[] deptRead = new string[10];
        string[] uniRead = new string[10];

        private string filePath;
        private bool uniqueCheck;
        private int count;
        private static StudentProfileData obj;

        private StudentProfileData()
        {
            uniqueCheck = false;
            filePath = @"C:\Users\SMile\Desktop\file.txt";
        }

        public static StudentProfileData StudentProperty
        {
            get
            {
                if (obj == null)
                {
                    obj = new StudentProfileData();
                }
                return obj;
            }
        }

        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return this.id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setSem(string sem)
        {
            this.sem = sem;
        }
        public string getSem()
        {
            return this.sem;
        }
        public void setCgpa(string cgpa)
        {
            this.cgpa = cgpa;
        }
        public string getCgpa()
        {
            return this.cgpa;
        }
        public void setDept(string dept)
        {
            this.dept = dept;
        }
        public string getDept()
        {
            return this.dept;
        }
        public void setUni(string uni)
        {
            this.uni = uni;
        }
        public string getUni()
        {
            return this.uni;
        }


        public string getIDRead()
        {
            return this.idRead[10];
        }
        public string getnameRead()
        {
            return this.nameRead[10];
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
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    MessageBox.Show("Student file created!");
                }
            }
        }
        public void WriteFile()
        {
            if (!idRead.Contains(id))
                uniqueCheck = true;

            if (uniqueCheck == true)
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(id);
                        sw.WriteLine(name);
                        sw.WriteLine(sem);
                        sw.WriteLine(cgpa);
                        sw.WriteLine(dept);
                        sw.WriteLine(uni);
                    }

                    MessageBox.Show("Saved!");
                    ReadFile();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Enter unique value");
            }
        }
    }
}
