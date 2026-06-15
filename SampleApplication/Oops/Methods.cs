using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class Methods
    {
        public void Show()
        {
            Dog dog = new Dog();

            // Instance Method
            dog.InstanceMethod();

            // Static Method
            Dog.StaticMethod();

            // Method with Parameters
            dog.Greet("Kavi");

            // Method without Parameters
            dog.Welcome();

            // Method with Return Type
            int result = dog.Add(10, 20);
            Console.WriteLine($"Addition: {result}");

            // Method without Return Type
            dog.Display();

            // Method Overloading
            dog.Print();
            dog.Print("Hello");

            // Method Overriding (Runtime Polymorphism)
            Animal animal = new Dog();
            animal.Sound();

            // Abstract Method
            animal.Eat();

            // Explicit Interface Method
            ITest test = new Dog();
            test.Show();
        }

    }
    interface ITest
    {
        void Show();
    }

    abstract class Animal
    {
        // Virtual Method
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes sound");
        }

        // Abstract Method
        public abstract void Eat();
    }

    class Dog : Animal, ITest
    {
        // Instance Method
        public void InstanceMethod()
        {
            Console.WriteLine("Instance Method");
        }

        // Static Method
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }

        // Method with Parameters
        public void Greet(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        // Method without Parameters
        public void Welcome()
        {
            Console.WriteLine("Welcome!");
        }

        // Method with Return Type
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method without Return Type
        public void Display()
        {
            Console.WriteLine("Void Method");
        }

        // Method Overloading
        public void Print()
        {
            Console.WriteLine("Print() called");
        }

        public void Print(string message)
        {
            Console.WriteLine($"Print(string): {message}");
        }

        // Method Overriding
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }

        // Abstract Method Implementation
        public override void Eat()
        {
            Console.WriteLine("Dog eats food");
        }

        // Explicit Interface Method
        void ITest.Show()
        {
            Console.WriteLine("Explicit Interface Method");
        }
    }
}
