using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class AccessModifier
    {
        static void Run()
        {
            Parent parent = new Parent();

            Console.WriteLine("Accessing through Parent Object:");

            parent.PublicMethod();
            parent.InternalMethod();
            parent.ProtectedInternalMethod();

            // parent.PrivateMethod();          // Error
            // parent.ProtectedMethod();        // Error
            // parent.PrivateProtectedMethod(); // Error

            parent.CallPrivateMethod();

            Console.WriteLine("\nAccessing through Child Object:");

            Child child = new Child();
            child.PublicMethod();
            child.InternalMethod();
            child.ProtectedInternalMethod();

            child.TestMethods();
        }
    }
    class Parent
    {
        // Public - Accessible everywhere
        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }

        // Private - Accessible only within this class
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }

        // Protected - Accessible within this class and derived classes
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method");
        }

        // Internal - Accessible within the same assembly
        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }

        // Protected Internal - Same assembly OR derived classes
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method");
        }

        // Private Protected - Same assembly AND derived classes
        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Private Protected Method");
        }

        // Calling private method inside the same class
        public void CallPrivateMethod()
        {
            PrivateMethod();
        }
    }

    class Child : Parent
    {
        public void TestMethods()
        {
            // Accessible
            PublicMethod();

            // Accessible (Inherited)
            ProtectedMethod();

            // Accessible (Same Assembly)
            InternalMethod();

            // Accessible (Same Assembly OR Derived)
            ProtectedInternalMethod();

            // Accessible (Same Assembly AND Derived)
            PrivateProtectedMethod();

            // Not Accessible
            // PrivateMethod();
        }
    }
}
