using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Class_Keyboards_Inheitances
{
    internal class Student:Person
    {
        public string StudentNumber {  get; set; }
        public string Faculty {  get; set; }
        public double GPA {  get; set; }
        public int Year {  get; set; }

        public Student()
        {

        }

            public Student(string firstName,string lastName, byte age, string email, int id, string studentNumber, string faculty, double gpa, int year) :base(firstName,lastName,age,email,id)
        {
            this.StudentNumber = studentNumber;
            this.Faculty = faculty;
            this.GPA = gpa;
            this.Year = year;
        }
            public void ShowStudentInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Telebe No:{StudentNumber} Fakulte:{Faculty} GPA:{GPA} Kurs:{Year} ");
        }
        public int CalculateScholarship()
        {
            if (GPA >= 90) return 500;
            if (GPA >= 80) return 350;
            if  (GPA >= 70) return 200;
            return 0;
        }
    }
}










