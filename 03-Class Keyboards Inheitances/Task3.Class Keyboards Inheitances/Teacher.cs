using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Task3.Class_Keyboards_Inheitances
{
    internal class Teacher:Person
    {
        public string Department;
        public string MainSubject;
        public decimal BaseSalary;
        public int ExperienceYears;

        public Teacher ( string department, string mainSubject,decimal baseSalary,int experienceYears, string firstName,string lastName, byte age, string email , int id) :base(firstName,lastName,
            age,email,id)
        {
            this.Department = department;
            this.MainSubject = mainSubject;
            this.BaseSalary = baseSalary;
            this.ExperienceYears = experienceYears;
        }
        public void ShowTeacherInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Kafedra:{Department} Fenn:{MainSubject} Tecrube ili:{ExperienceYears}" );
        }
        public decimal CalculateSalary()
        {
            return BaseSalary + (ExperienceYears * 50);
        }
    }
}
