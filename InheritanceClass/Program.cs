using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    class School
    {
        private string schoolName;
        private string schoolAddress;
        public School(string schoolName, string schoolAddress)
        {
            this.schoolName = schoolName;
            this.schoolAddress = schoolAddress;
        }
        public virtual void printAll()
        {
            Console.WriteLine("School Name: " + schoolName);
            Console.WriteLine("School Address: " + schoolAddress);
        }
    }
    class Student : School
    {
        private string name;
        private string address;
        protected int studentID;
        protected char grades;

        public Student(string name, string address, int studentID, char grades, string schoolName, string schoolAddress) 
               :base(schoolName,schoolAddress) 
        {
            this.name = name;
            this.address = address;
            this.studentID = studentID;
            this.grades = grades;
        }
        public override void printAll()
        {
            base.printAll();
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Student ID : " + studentID);
            Console.WriteLine("Student's Grades: " + grades);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("John", "Hogwarts Gryfindor Dorm",1004025, 'A', "The Singapore International", "32 Aveneu, C-Block, 13110");

            stud1.printAll();

            Console.ReadLine();
        }
    }
}
