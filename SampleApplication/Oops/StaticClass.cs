using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class StaticClass
    {
        static void Run()
        {
            int result = MathHelper.Add(10, 20);
            Console.WriteLine(result);
        }

    }
    static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

}
