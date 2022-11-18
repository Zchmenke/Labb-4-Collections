using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating new stack
            Stack<Employee> empStack = new Stack<Employee>();
            //Creating five new objects from employee class
            var emp1 = new Employee("James Hetfield", "Male", 1001, 200);
            var emp2 = new Employee("Kirk Hammet", "Male", 1002, 160);
            var emp3 = new Employee("Lars Ulrich", "Male", 1003, 100);
            var emp4 = new Employee("Dolly Parton", "Female", 1004, 300);
            var emp5 = new Employee("Joelene Jonsson", "Female", 1005, 310);

            //Adding objects to stack with push.
            empStack.Push(emp1); 
            empStack.Push(emp2); 
            empStack.Push(emp3); 
            empStack.Push(emp4); 
            empStack.Push(emp5);

            //sending parameters to methods.
            CollectionHold(empStack);
            PopFunc(empStack);
            PeekFunc(empStack);
            ContainsFunc(empStack);

            Console.WriteLine("----------Del två-----------\n");

            List<Employee> empList = new List<Employee>();
            Employee emp6 = new Employee("David Gilmour", "Male", 1006, 400);
            Employee emp7 = new Employee("Roger Waters", "Male", 1007, 439);
            Employee emp8 = new Employee("Richard Wright", "Male", 1008, 341);
            Employee emp9 = new Employee("Nick Mason","Male", 1009, 235);
            Employee emp10 = new Employee("Frida kahlo","Female", 1010, 264);

            //adding objects to List and sending to method.
            empList.Add(emp6); 
            empList.Add(emp7); 
            empList.Add(emp8); 
            empList.Add(emp9); 
            empList.Add(emp10);
            ListMethod(empList);


            //Different functions to handle the different tasks regarding "Stack"
            void CollectionHold(Stack<Employee> empStack)
            {
                Console.WriteLine("-- Print with own function --\n-----------------------------");
                foreach (var emp in empStack)
                {
                    emp.PrintInfo();
                    Console.WriteLine($"Items left in stack : {empStack.Count}\n-----------------------------");
                }
            }
            void PopFunc(Stack<Employee> empStack)
            {
                Console.WriteLine("\n");
                Console.WriteLine("-- Print and pop all items --\n-----------------------------");
                Console.WriteLine($"Items left in stack : {empStack.Count}");
                do
                {
                    Console.WriteLine(empStack.Pop());
                    Console.WriteLine($"Items left in stack : {empStack.Count}\n-----------------------------");
                }
                while (empStack.Count > 0);

                empStack.Push(emp1);
                empStack.Push(emp2);
                empStack.Push(emp3);
                empStack.Push(emp4);
                empStack.Push(emp5);
            }
            void PeekFunc(Stack<Employee> empStack)
            {
                Console.WriteLine("\n");
                Console.WriteLine("------- Peek 2 items --------\n-----------------------------");

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Items left in stack : {empStack.Count}");
                    Console.WriteLine(empStack.Peek());
                    empStack.Pop();
                    Console.WriteLine("-----------------------------");
                }
                empStack.Push(emp4);
                empStack.Push(emp5);
            }
            void ContainsFunc(Stack<Employee> empStack)
            {
                Console.WriteLine("\n");
                Console.WriteLine("- Check if emp3 is in stack -\n-----------------------------");
                if (empStack.Contains(emp3))
                {
                    Console.WriteLine(emp3._name + " is in the stack");
                }
                else
                {
                    Console.WriteLine(emp3._name + " Is not in the stack.");
                }
                Console.WriteLine("\n");

            }


            // Method to handle Lists.
            void ListMethod(List<Employee> empList)
            {
                // see if a certain employee is inside the list.
                Console.WriteLine("------Contains method-------");
                var listResult = empList.Contains(emp8) ? $"{emp8._name} exists inside the list." : $"{emp8._name} Does not exist inside the list.";
                Console.WriteLine(listResult);
                Console.WriteLine("\n");

                //Find first Object that is Male.
                Console.WriteLine("------Find method-------");
                Console.WriteLine(empList.Find(gender => gender._gender.Contains("Male")));
                Console.WriteLine("\n");

               // creating a list that will add every employee who has the property "_gender" set to "Male".
                Console.WriteLine("------FindAll method-------\n");
                List<Employee> maleEmployees = empList.FindAll(Male => Male._gender.Contains("Male"));
                Console.WriteLine("--Print every male employee--\n");
                foreach (object Male in maleEmployees)
                {
                    Console.WriteLine(Male);
                    Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}




