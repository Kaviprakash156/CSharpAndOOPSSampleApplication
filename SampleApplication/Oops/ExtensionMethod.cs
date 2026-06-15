using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class ExtensionMethod
    {
        static void Run()
        {
            string name = "Kaviprakash";

            string reversed = name.ReverseString();

            Console.WriteLine(reversed);

            bool result = DateTime.Now.IsWeekend();

            Console.WriteLine(result);
        }
    }
    public static class StringExtensions
    {
        public static string ReverseString(this string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }
    }
    public static class DateTimeExtensions
    {
        public static bool IsWeekend(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday ||
                   date.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
