using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.Concepts
{
    internal class Encapsulation
    {
        static void Run()
        {
            Employee emp = new Employee(101);

            // Private Field through Methods
            emp.SetName("Kaviprakash");

            // Read-Write Property
            emp.Salary = 50000;

            // Read-Only Property
            Console.WriteLine($"Employee ID: {emp.EmployeeId}");

            // Write-Only Property
            emp.Password = "Secret@123";

            // Auto Property
            emp.Department = "IT";

            emp.Display();

            // Validation Example
            emp.Salary = -1000;
        }
    }
    class Employee
    {
        // 1. Private Field (Hidden Data)
        private string _name;

        // 2. Read-Write Property
        private decimal _salary;
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    _salary = value;
                else
                    Console.WriteLine("Salary cannot be negative.");
            }
        }

        // 3. Read-Only Property
        private readonly int _employeeId;
        public int EmployeeId
        {
            get { return _employeeId; }
        }

        // 4. Write-Only Property
        private string _password;
        public string Password
        {
            set { _password = value; }
        }

        // 5. Auto-Implemented Property
        public string Department { get; set; }

        // Constructor
        public Employee(int employeeId)
        {
            _employeeId = employeeId;
        }

        // Encapsulation using Methods
        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID : {EmployeeId}");
            Console.WriteLine($"Name        : {_name}");
            Console.WriteLine($"Salary      : {Salary}");
            Console.WriteLine($"Department  : {Department}");
        }
    }
}
