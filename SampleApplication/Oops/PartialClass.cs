using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class PartialClass
    {
        static void Run()
        {
            Employee1 emp = new Employee1();

            emp.Show();
            emp.Save();
        }

    }

    public partial class Employee1
    {
        public void Show()
        {
            Console.WriteLine("Show Method");
        }
    }

    public partial class Employee1
    {
        public void Save()
        {
            Console.WriteLine("Save Method");
        }
    }

}
