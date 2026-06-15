using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class SealedClass 
    {
        static void Run()
        {
            Logger log = new Logger();
            log.Write();
        }
    }

    sealed class Logger
    {
        public void Write()
        {
            Console.WriteLine("Log Written");
        }
    }

}
