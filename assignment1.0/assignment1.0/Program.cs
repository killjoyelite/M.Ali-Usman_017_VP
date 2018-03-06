using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace assignment1._0
{
    class Program
    {
        private int count;
        private string filePath;
        private string attendancePath;
        private string[] idRead = new string[10];
        private string[] nameRead = new string[10];
        private string[] semRead = new string[10];
        private string[] cgpaRead = new string[10];
        private string[] deptRead = new string[10];
        private string[] uniRead = new string[10];
        public string idWrite;
        private string nameWrite;
        public string semWrite;
        public string cgpaWrite;
        public string deptWrite;
        public string uniWrite;
        private bool eCheck;
        private bool uniqueCheck;
        private string[] attendanceRead = new string[10];
        public Program(string recordPath, string attPath)
        {
            count = 0;
            filePath = recordPath;
            attendancePath =attPath;
            idWrite = "";
            nameWrite = "";
            semWrite = "";
            cgpaWrite = "";
            deptWrite = "";
            uniWrite = "";
            eCheck = false;
            uniqueCheck = false;
        }
        public void AttendanceIncrementer()
        {
            string searchEnroll = "";
            Console.WriteLine("Enter Enrollment ID to mark attendance of: ");
            searchEnroll = Console.ReadLine();
            try
            {
                int attendanceVal = Convert.ToInt32(attendanceRead[Array.IndexOf(idRead, searchEnroll)]);
                attendanceVal = attendanceVal + 1;
                attendanceRead[Array.IndexOf(idRead, searchEnroll)] = Convert.ToString(attendanceVal);
                using (StreamWriter sr = new StreamWriter(attendancePath))
                {
                    for (int i = 0; i < count; i++)
                    {
                        sr.WriteLine(attendanceRead[i]);
                    }
                    Console.WriteLine("Changes Stored!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Value Not found");
                Console.WriteLine(e.Message);
            }
        }
        public void AttendanceReader()
        {
            using (StreamReader sr = new StreamReader(attendancePath))
            {
                for (int i = 0; i < count; i++)
                {

                    attendanceRead[i] = sr.ReadLine();
                    Console.WriteLine("Student ID: " + idRead[i] + "\tHours Present: " + attendanceRead[i]);
                }
            }
        }
        public void AttendanceMarker()
        {
            string attTemp = "";
            Console.WriteLine("Enter Attendance for student: ");
            attTemp = Console.ReadLine();
            try
            {
                using (StreamWriter sw = File.AppendText(attendancePath))
                {
                    sw.WriteLine(attTemp);
                    Console.WriteLine("Attendance Added!\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error writing attendance! " + e.Message);
            }
        }
        public void ClassToppers()
        {
            Console.WriteLine("==================");
            Console.WriteLine("ID: " + idRead[Array.IndexOf(cgpaRead, cgpaRead.Max())]);
            Console.WriteLine("Name: " + nameRead[Array.IndexOf(cgpaRead, cgpaRead.Max())]);
            Console.WriteLine("Semester: " + semRead[Array.IndexOf(cgpaRead, cgpaRead.Max())]);
            Console.WriteLine("CGPA: " + cgpaRead[Array.IndexOf(cgpaRead, cgpaRead.Max())]);
            Console.WriteLine("Department: " + deptRead[Array.IndexOf(cgpaRead, cgpaRead.Max())]);
            Console.WriteLine("University: " + uniRead[Array.IndexOf(cgpaRead, cgpaRead.Max())]);
            Console.WriteLine("==================");
        }
        public void SemesterSearchDisp()
        {
            int matchCount = 0;
            string sem = "";
            Console.WriteLine("Enter Semester: ");
            sem = Console.ReadLine();
            try
            {
                for (int index = 0; index < count; index++)
                {
                    if (semRead[index] == sem)
                    {
                        Console.WriteLine("==================");
                        Console.WriteLine("ID: " + idRead[index]);
                        Console.WriteLine("Name: " + nameRead[index]);
                        Console.WriteLine("Semester: " + semRead[index]);
                        Console.WriteLine("CGPA: " + cgpaRead[index]);
                        Console.WriteLine("Department: " + deptRead[index]);
                        Console.WriteLine("University: " + uniRead[index]);
                        Console.WriteLine("==================");
                        matchCount++;
                    }
                }
                if (matchCount == 0)
                {
                    Console.WriteLine("Semester not found!");
                }
                else
                {
                    Console.WriteLine("Total matches: " + matchCount + "\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void NameSearchDisp()
        {
            Console.WriteLine("Enter Name: ");
            try
            {
                int index = Array.IndexOf(nameRead, Console.ReadLine());
                Console.WriteLine("==================");
                Console.WriteLine("ID: " + idRead[index]);
                Console.WriteLine("Name: " + nameRead[index]);
                Console.WriteLine("Semester: " + semRead[index]);
                Console.WriteLine("CGPA: " + cgpaRead[index]);
                Console.WriteLine("Department: " + deptRead[index]);
                Console.WriteLine("University: " + uniRead[index]);
                Console.WriteLine("==================");
            }
            catch (Exception)
            {
                Console.WriteLine("Name not found!");
            }
        }
        public void IDSearchDisp()
        {
            Console.WriteLine("Enter ID: ");
            try
            {
                int index = Array.IndexOf(idRead, Console.ReadLine());
                Console.WriteLine("==================");
                Console.WriteLine("ID: " + idRead[index]);
                Console.WriteLine("Name: " + nameRead[index]);
                Console.WriteLine("Semester: " + semRead[index]);
                Console.WriteLine("CGPA: " + cgpaRead[index]);
                Console.WriteLine("Department: " + deptRead[index]);
                Console.WriteLine("University: " + uniRead[index]);
                Console.WriteLine("==================");
            }
            catch (Exception)
            {
                Console.WriteLine("ID not found!");
            }
        }
        public void UserInput()
        {
            Console.WriteLine("Enter ID:");
            idWrite = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            nameWrite = Console.ReadLine();
            Console.WriteLine("Enter Semester:");
            semWrite = Console.ReadLine();
            Console.WriteLine("Enter CGPA:");
            cgpaWrite = Console.ReadLine();
            Console.WriteLine("Enter Department:");
            deptWrite = Console.ReadLine();
            Console.WriteLine("Enter University:");
            uniWrite = Console.ReadLine();
        }
        public void WriteFile()
        {
            UserInput();
            if (!idRead.Contains(idWrite))
                uniqueCheck = true;
            if (uniqueCheck == true)
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(idWrite);
                        sw.WriteLine(nameWrite);
                        sw.WriteLine(semWrite);
                        sw.WriteLine(cgpaWrite);
                        sw.WriteLine(deptWrite);
                        sw.WriteLine(uniWrite);
                        Console.WriteLine("Written!\n");
                    }
                    AttendanceMarker();
                    ReadFile();
                    AttendanceReader();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Enter unique value");
            }
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
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    Console.WriteLine("student file created!");
                }
                using (StreamWriter sw = new StreamWriter(attendancePath))
                {
                    Console.WriteLine("Attendance file created!");
                }
            }
        }
        public void DisplayProfile()
        {
            for (int j = 0; j < count; j++)
            {
                Console.WriteLine("==================");
                Console.WriteLine("ID: " + idRead[j]);
                Console.WriteLine("Name: " + nameRead[j]);
                Console.WriteLine("Semester: " + semRead[j]);
                Console.WriteLine("CGPA: " + cgpaRead[j]);
                Console.WriteLine("Department: " + deptRead[j]);
                Console.WriteLine("University: " + uniRead[j]);
            }
            Console.WriteLine("==================");
            Console.WriteLine("\nScan Successful!\n");
        }
        public void Gui()
        {
            Console.WriteLine("1-> Write");
            Console.WriteLine("2-> Display List");
            Console.WriteLine("3-> Search by ID");
            Console.WriteLine("4-> Search by Name");
            Console.WriteLine("5-> Search by Semester");
            Console.WriteLine("6-> Highest CGPA");
            Console.WriteLine("7-> Open Attendance");
            Console.WriteLine("8-> Mark Attendance");
            Console.WriteLine("9-> Exit");
        }
        public void OptionSelector(int opt)
        {
            try
            {
                if (opt == 1)
                {
                    WriteFile();
                }
                else if (opt == 2)
                {
                    DisplayProfile();
                }
                else if (opt == 3)
                {
                    IDSearchDisp();
                }
                else if (opt == 4)
                {
                    NameSearchDisp();
                }
                else if (opt == 5)
                {
                    SemesterSearchDisp();
                }
                else if (opt == 6)
                {
                    ClassToppers();
                }
                else if (opt == 7)
                {
                    AttendanceReader();
                }
                else if (opt == 8)
                {
                    AttendanceIncrementer();
                }
                else if (opt == 9)
                {
                    eCheck = true;
                }
                else
                {
                    Console.WriteLine("Chose options listed only!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public bool getExitVal()
        {
            return eCheck;
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Program ob = new Program(args[0],args[1]);

            ob.ReadFile();
            ob.Gui();
            int option = Convert.ToInt32(Console.ReadLine());
            ob.OptionSelector(option);
            while (ob.getExitVal() == false)
            {
                ob.Gui();
                option = Convert.ToInt32(Console.ReadLine());
                ob.OptionSelector(option);
            }
        }
    }
}
