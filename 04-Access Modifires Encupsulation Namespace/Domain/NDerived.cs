using _04_Access_Modifires_Encupsulation_Namespace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    internal class NDerived
    {
        public NDerived()
        {
            Person person = new Person();
            //Console.WriteLine(person.name);
        }
    }
}
