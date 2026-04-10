using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Class_Keyboards_Inheitances
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public byte Age {  get; set; }
        public string Email {  get; set; }
        public int Id {  get; set; }

        public Person()
        {
            
        }

        public Person(string firstName, string lastName, byte age, string email, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
            this.Id = id;
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine($" Id:{Id} , Ad :{GetFullName()}, Yas: {Age}, Email: {Email}");
        }
    }

}
