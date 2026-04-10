using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Class_Keyboards_Inheitances
{
    internal class Administrator:Person
    {
        public string Position;
        public string Department;
        public int AccessLevel;

        public Administrator(string firstName,string lastName ,byte age, string email, int id, string position, string department, int accessLevel):base(firstName,lastName,age,
            email,id)
        {
            this.Position = position;
            this.Department = department;
            this.AccessLevel = accessLevel;
        }
        public void ShowAdminInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Vezife:{Position} Sobe:{Department} Giris Seviyyesi:{AccessLevel}" );
        }
        public void GrantAccess(Student student)
        {
            Console.WriteLine($"adi:{student.FirstName} soyadi:{student.LastName} olan telebeye giris icazesi verildi" );
        }
    }
}
