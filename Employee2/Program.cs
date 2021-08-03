using System;
using System.Collections.Generic;
using System.Globalization;


namespace Employee2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Employee #{i+1}");
                Console.Write("Enter id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.WriteLine();
                
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idSearch = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == idSearch);
            if ( emp != null) {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percent);
            }
            else Console.WriteLine("*INVALID ID*");

            Console.WriteLine();
            Console.WriteLine("Updated list of employees");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
