using System;
using System.Collections.Generic;

namespace JungleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Heading
            Console.WriteLine("Jungle Overloading Assignment:");
            Console.WriteLine("");

            // Employees
            Employee employee1 = new Employee("John", "Smith");
            Employee employee2 = new Employee("Austin", "Cumberlander");
            Employee employee3 = new Employee("James", "Brown");
            Employee employee4 = new Employee("Andrea", "Ellison");

            // Employee List
            // How to explicitly set objects in list without having to use the Add method?
            var companions = new List<Employee>();
            companions.Add(employee1);
            companions.Add(employee2);
            companions.Add(employee3);

            // Methods
            employee1.eat();
            Console.WriteLine("");

            employee2.eat("ramen");
            Console.WriteLine("");

            employee3.eat(companions);
            Console.WriteLine("");

            employee4.eat("steak", companions);
            Console.ReadLine();
        }
    }
}
