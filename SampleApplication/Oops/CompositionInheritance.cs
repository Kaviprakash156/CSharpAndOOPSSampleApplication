using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class CompositionInheritance
    {
        static void Run()
        {
            Console.WriteLine("=== Inheritance (IS-A) ===");

            ElectricScooter scooter = new ElectricScooter();

            scooter.StartEngine();   // Inherited Method
            scooter.Ride();


            Console.WriteLine("\n=== Composition (HAS-A) ===");

            DeliveryDrone drone = new DeliveryDrone();

            drone.Fly();
        }
    }

    // =====================
    // Inheritance Example
    // =====================

    class VehicleUnit
    {
        public void StartEngine()
        {
            Console.WriteLine("Vehicle engine started.");
        }
    }

    class ElectricScooter : VehicleUnit
    {
        public void Ride()
        {
            Console.WriteLine("Electric scooter is moving.");
        }
    }

    // =====================
    // Composition Example
    // =====================

    class BatteryPack
    {
        public void SupplyPower()
        {
            Console.WriteLine("Battery supplying power.");
        }
    }

    class DeliveryDrone
    {
        // HAS-A relationship
        private readonly BatteryPack _battery;

        public DeliveryDrone()
        {
            _battery = new BatteryPack();
        }

        public void Fly()
        {
            _battery.SupplyPower();
            Console.WriteLine("Delivery drone is flying.");
        }
    }
}
