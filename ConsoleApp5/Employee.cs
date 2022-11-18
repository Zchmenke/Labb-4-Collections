using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Employee

    {
        public string _name { get; set; }
        public string _gender { get; set; }
        public int _id { get; set; }
        public int _salary { get; set; }

        public Employee() : this("No name found", "No gender found", 00, 00)
        { }
        public Employee(string Name, string Gender, int Id, int Salary)
        {
            _name = Name;
            _gender = Gender;
            _id = Id;
            _salary = Salary;
        }

        // testing 2 different methods to pring information, one own method and one override.
        public void PrintInfo()
        {
            Console.WriteLine("ID : {0} - Name : {1}\nGender : {2} - Salary : {3}", _id, _name, _gender, _salary);
        }
        public override string ToString()
        {
            return $"ID : {_id} - Name : {_name}\nGender : {_gender} - Salary : {_salary} ";
        }
    }
}
