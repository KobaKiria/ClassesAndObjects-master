using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjectsTask
{
    public class Employee
    {
        private string surname { get; set; }
        private int age { get; set; }

        public Employee()
        {
               
        }

        public Employee(string Surname, int Age)
        {
            surname = Surname;
            age = Age;
        }

        private string GetAgeInSring()
        {
            return Convert.ToString(age);
        }
        public void Set_Surname(string newName) 
        {
            surname = newName;
        }
        public string Get_Emploee_Info()
        {
            return $"surname: {surname}, Age: {GetAgeInSring()}";
        }
    }
}
