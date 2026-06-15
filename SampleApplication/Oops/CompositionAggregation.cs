using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class CompositionAggregation
    {
        static void Run()
        {
            Console.WriteLine("=== Aggregation ===");

            Instructor instructor = new Instructor("Sophia");

            TrainingCenter center = new TrainingCenter(instructor);

            center.ShowDetails();

            // Instructor still exists independently
            Console.WriteLine($"Instructor still exists: {instructor.Name}");


            Console.WriteLine("\n=== Composition ===");

            SportsCar car = new SportsCar();

            car.Drive();
        }
    }

    // =======================
    // Aggregation Example
    // =======================

    class Instructor
    {
        public string Name { get; set; }

        public Instructor(string name)
        {
            Name = name;
        }
    }

    class TrainingCenter
    {
        private readonly Instructor _instructor;

        // Instructor is passed from outside
        public TrainingCenter(Instructor instructor)
        {
            _instructor = instructor;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Training Center has instructor: {_instructor.Name}");
        }
    }

    // =======================
    // Composition Example
    // =======================

    class EngineModule
    {
        public void Start()
        {
            Console.WriteLine("Engine module started.");
        }
    }

    class SportsCar
    {
        private readonly EngineModule _engine;

        // SportsCar creates EngineModule internally
        public SportsCar()
        {
            _engine = new EngineModule();
        }

        public void Drive()
        {
            _engine.Start();
            Console.WriteLine("Sports car is driving.");
        }
    }
}
