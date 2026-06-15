using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class Constructors
    {
        static void Run()
        {
            Console.WriteLine("1. Default Constructor");
            Person p1 = new Person();

            Console.WriteLine("\n2. Parameterized Constructor");
            Person p2 = new Person("Kavi", 28);

            Console.WriteLine("\n3. Copy Constructor");
            Person p3 = new Person(p2);

            Console.WriteLine("\n4. Constructor Chaining");
            Person p4 = new Person("John");

            Console.WriteLine("\n5. Base Constructor");
            Employee emp = new Employee("David", 30, 1001);

            Console.WriteLine("\n6. Static Constructor");
            Company c1 = new Company();
            Company c2 = new Company();

            Console.WriteLine("\n7. Private Constructor");
            Singleton obj = Singleton.Instance;
        }
    }
    class Person
    {
        public string Name;
        public int Age;

        // 1. Default Constructor
        public Person()
        {
            Console.WriteLine("Default Constructor Called");
        }

        // 2. Parameterized Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Parameterized Constructor: {Name}, {Age}");
        }

        // 3. Copy Constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
            Console.WriteLine($"Copy Constructor: {Name}, {Age}");
        }

        // Constructor Chaining using this
        public Person(string name) : this(name, 0)
        {
            Console.WriteLine("Constructor Chaining using this");
        }
    }

    // 7. Base Constructor Example
    class Employee : Person
    {
        public int EmployeeId;

        public Employee(string name, int age, int employeeId)
            : base(name, age)
        {
            EmployeeId = employeeId;
            Console.WriteLine($"Base Constructor Called. Employee ID: {EmployeeId}");
        }

        //Destructor
        ~Employee()
        {
            Console.WriteLine("Destructor Called");
        }

    }

    // 4. Static Constructor
    class Company
    {
        static Company()
        {
            Console.WriteLine("Static Constructor Called");
        }

        public Company()
        {
            Console.WriteLine("Company Object Created");
        }
    }

    // 5. Private Constructor
    class Singleton
    {
        private Singleton()
        {
            Console.WriteLine("Private Constructor Called");
        }

        public static Singleton Instance { get; } = new Singleton();
    }

}
