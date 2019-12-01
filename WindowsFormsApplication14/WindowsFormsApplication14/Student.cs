using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication13
{
    class Student
    {
        public Student()
        {

        }
        string enroll;
        string nam;
        string sem;
        string cgp;
        string dept;
        string uni;
        string path = "C://Users/Ali/Desktop/data.txt";
        string att = "null";
        public string Enrollment
        {
            get
            {
                return enroll;
            }
            set
            {
                enroll = value;
            }
        }
        public string Name
        {
            get
            {
                return nam;
            }
            set
            {
                nam = value;
            }
        }
        public string Semester
        {
            get
            {
                return sem;
            }
            set
            {
                sem = value;
            }
        }
        public string CGPA
        {
            get
            {
                return cgp;
            }
            set
            {
                cgp = value;
            }
        }
        public string Department
        {
            get
            {
                return dept;
            }
            set
            {
                dept = value;
            }
        }
        public string University
        {
            get
            {
                return uni;
            }
            set
            {
                uni = value;
            }
        }
        public string Attendance
        {
            get
            {
                return att;
            }
            set
            {
                att = value;
            }
        }
    }
}