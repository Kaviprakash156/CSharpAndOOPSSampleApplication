using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.SOLID
{
    internal class OpenClosedPrinciple
    {
        static void Run()
        {
            //Bad Example

            DiscountCalculator calculator = new DiscountCalculator();

            Console.WriteLine(calculator.CalculateDiscount("Regular", 1000));
            Console.WriteLine(calculator.CalculateDiscount("Premium", 1000));


            //Good Example

            CustomerDiscount regular = new RegularCustomerDiscount();
            CustomerDiscount premium = new PremiumCustomerDiscount();
            CustomerDiscount gold = new GoldCustomerDiscount();

            Console.WriteLine($"Regular: {regular.CalculateDiscount(1000)}");
            Console.WriteLine($"Premium: {premium.CalculateDiscount(1000)}");
            Console.WriteLine($"Gold: {gold.CalculateDiscount(1000)}");
        }
    }

    //Bad Example
    class DiscountCalculator
    {
        public double CalculateDiscount(string customerType, double amount)
        {
            if (customerType == "Regular")
                return amount * 0.05;

            if (customerType == "Premium")
                return amount * 0.10;

            return 0;
        }
    }

    //Good

    // Abstraction
    abstract class CustomerDiscount
    {
        public abstract double CalculateDiscount(double amount);
    }

    // Extension 1
    class RegularCustomerDiscount : CustomerDiscount
    {
        public override double CalculateDiscount(double amount)
        {
            return amount * 0.05;
        }
    }

    // Extension 2
    class PremiumCustomerDiscount : CustomerDiscount
    {
        public override double CalculateDiscount(double amount)
        {
            return amount * 0.10;
        }
    }

    // Extension 3 (Added later without modifying existing code)
    class GoldCustomerDiscount : CustomerDiscount
    {
        public override double CalculateDiscount(double amount)
        {
            return amount * 0.15;
        }
    }
}
