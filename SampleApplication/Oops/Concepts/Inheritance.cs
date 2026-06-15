using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.Concepts
{
    internal class Inheritance
    {
        static void Run()
        {
            Console.WriteLine("=== Single Inheritance ===");
            WashingMachine wm = new WashingMachine();
            wm.PowerOn();
            wm.Wash();

            Console.WriteLine("\n=== Multilevel Inheritance ===");
            SmartWashingMachine swm = new SmartWashingMachine();
            swm.PowerOn();
            swm.Wash();
            swm.ScheduleWash();

            Console.WriteLine("\n=== Hierarchical Inheritance ===");
            Refrigerator fridge = new Refrigerator();
            fridge.PowerOn();
            fridge.Cool();

            Microwave oven = new Microwave();
            oven.PowerOn();
            oven.Heat();

            Console.WriteLine("\n=== Multiple Inheritance (Interfaces) ===");
            SmartTV tv = new SmartTV();
            tv.PowerOn();
            tv.ConnectWifi();
            tv.VoiceCommand();
            tv.Watch();

            Console.WriteLine("\n=== Invalid in C# ===");
            Console.WriteLine("Multiple inheritance using classes is NOT supported.");
        }
    }
    // Base Class
    class Appliance
    {
        public void PowerOn()
        {
            Console.WriteLine("Appliance is powered ON");
        }
    }

    // Single Inheritance
    class WashingMachine : Appliance
    {
        public void Wash()
        {
            Console.WriteLine("Washing clothes");
        }
    }

    // Multilevel Inheritance
    class SmartWashingMachine : WashingMachine
    {
        public void ScheduleWash()
        {
            Console.WriteLine("Wash scheduled");
        }
    }

    // Hierarchical Inheritance
    class Refrigerator : Appliance
    {
        public void Cool()
        {
            Console.WriteLine("Cooling food items");
        }
    }

    class Microwave : Appliance
    {
        public void Heat()
        {
            Console.WriteLine("Heating food");
        }
    }

    // Multiple Inheritance using Interfaces
    interface IWifiEnabled
    {
        void ConnectWifi();
    }

    interface IVoiceControlled
    {
        void VoiceCommand();
    }

    // Hybrid Inheritance using Class + Interfaces
    class SmartTV : Appliance, IWifiEnabled, IVoiceControlled
    {
        public void Watch()
        {
            Console.WriteLine("Watching TV");
        }

        public void ConnectWifi()
        {
            Console.WriteLine("Connected to WiFi");
        }

        public void VoiceCommand()
        {
            Console.WriteLine("Voice command executed");
        }
    }
}
