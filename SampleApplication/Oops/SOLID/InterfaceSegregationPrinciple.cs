using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.SOLID
{
    internal class InterfaceSegregationPrinciple
    {
        static void Run()
        {
            //Bad
            IOfficeDevice device = new BasicPrinter();

            device.Print();

            // These will fail at runtime
            // device.Scan();
            // device.Fax();

            //Good
            Console.WriteLine("=== Laser Printer ===");

            IPrinter printer = new LaserPrinter();
            printer.Print();


            Console.WriteLine("\n=== Multi Function Device ===");

            MultiFunctionDevice mfd = new MultiFunctionDevice();

            mfd.Print();
            mfd.Scan();


            Console.WriteLine("\n=== Enterprise Machine ===");

            EnterpriseMachine enterprise = new EnterpriseMachine();

            enterprise.Print();
            enterprise.Scan();
            enterprise.Fax();

        }
    }

    //Bad

    interface IOfficeDevice
    {
        void Print();
        void Scan();
        void Fax();
    }

    class BasicPrinter : IOfficeDevice
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }

        public void Fax()
        {
            throw new NotImplementedException();
        }
    }


    // Good

    interface IPrinter
    {
        void Print();
    }

    interface IScanner
    {
        void Scan();
    }

    interface IFaxMachine
    {
        void Fax();
    }

    // Supports only printing
    class LaserPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }

    // Supports printing and scanning
    class MultiFunctionDevice : IPrinter, IScanner
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }

    // Supports all operations
    class EnterpriseMachine : IPrinter, IScanner, IFaxMachine
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }

        public void Fax()
        {
            Console.WriteLine("Sending fax...");
        }
    }

}
