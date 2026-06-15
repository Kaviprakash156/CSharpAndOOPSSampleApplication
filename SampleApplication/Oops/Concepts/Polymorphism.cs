using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.Concepts
{
    internal class Polymorphism
    {
        static void Run()
        {
            Console.WriteLine("=== Method Overloading ===");

            CalculatorEngine calc = new CalculatorEngine();

            Console.WriteLine(calc.Multiply(2, 3));
            Console.WriteLine(calc.Multiply(2, 3, 4));
            Console.WriteLine(calc.Multiply(2.5, 4.0));


            Console.WriteLine("\n=== Method Overriding ===");

            Transport t1 = new Bicycle();
            t1.Start();

            Transport t2 = new Subway();
            t2.Start();


            Console.WriteLine("\n=== Interface Polymorphism ===");

            INotificationSender sender = new Subway();
            sender.Send();


            Console.WriteLine("\n=== Operator Overloading ===");

            Distance d1 = new Distance(10);
            Distance d2 = new Distance(15);

            Distance total = d1 + d2;

            total.Display();
        }
    }

    // Interface for Interface Polymorphism
    interface INotificationSender
    {
        void Send();
    }

    // Base Class for Runtime Polymorphism
    class Transport
    {
        public virtual void Start()
        {
            Console.WriteLine("Transport started");
        }
    }

    // Derived Classes
    class Bicycle : Transport
    {
        public override void Start()
        {
            Console.WriteLine("Bicycle ride started");
        }
    }

    class Subway : Transport, INotificationSender
    {
        public override void Start()
        {
            Console.WriteLine("Subway service started");
        }

        public void Send()
        {
            Console.WriteLine("Subway notification sent");
        }
    }

    // Operator Overloading
    class Distance
    {
        public int Kilometers { get; set; }

        public Distance(int kilometers)
        {
            Kilometers = kilometers;
        }

        public static Distance operator +(Distance d1, Distance d2)
        {
            return new Distance(d1.Kilometers + d2.Kilometers);
        }

        public void Display()
        {
            Console.WriteLine($"Distance: {Kilometers} km");
        }
    }

    // Compile-Time Polymorphism (Method Overloading)
    class CalculatorEngine
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
