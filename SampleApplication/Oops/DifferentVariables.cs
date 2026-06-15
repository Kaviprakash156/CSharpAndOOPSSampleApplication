using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class DifferentVariables
    {
        static void Run()
        {
            Console.WriteLine("=== var ===");

            // 1. var
            var employeeName = "Kaviprakash";
            var experience = 6;

            Console.WriteLine(employeeName);
            Console.WriteLine(experience);



            Console.WriteLine("\n=== dynamic ===");

            // 2. dynamic
            dynamic data = 100;

            Console.WriteLine(data);

            data = "Hello World";

            Console.WriteLine(data);

            data = DateTime.Now;

            Console.WriteLine(data);



            Console.WriteLine("\n=== const ===");

            // 3. const
            Console.WriteLine(
                ConfigurationManager.ApplicationName);



            Console.WriteLine("\n=== Singleton + readonly ===");

            // 4 & 6
            ConfigurationManager config1 =
                ConfigurationManager.Instance;

            config1.DisplayConfiguration();

            ConfigurationManager config2 =
                ConfigurationManager.Instance;

            Console.WriteLine(
                $"Same Instance: {ReferenceEquals(config1, config2)}");



            Console.WriteLine("\n=== static field ===");

            // 5. static field
            Console.WriteLine(
                $"Instance Count: {ConfigurationManager.InstanceCount}");



            Console.WriteLine("\n=== static method ===");

            // 5. static method
            ConfigurationManager.ShowApplicationInfo();
        }
    }

    // Singleton Pattern
    class ConfigurationManager
    {
        // 3. const
        public const string ApplicationName = "Employee Portal";

        // 4. readonly
        public readonly DateTime CreatedOn;

        // 5. static field
        public static int InstanceCount;

        // Singleton instance
        private static readonly ConfigurationManager _instance =
            new ConfigurationManager();

        // Private constructor
        private ConfigurationManager()
        {
            CreatedOn = DateTime.Now;
            InstanceCount++;

            Console.WriteLine("Singleton Instance Created");
        }

        // Singleton accessor
        public static ConfigurationManager Instance
        {
            get { return _instance; }
        }

        // 5. static method
        public static void ShowApplicationInfo()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine($"Created On: {CreatedOn}");
        }
    }
}
