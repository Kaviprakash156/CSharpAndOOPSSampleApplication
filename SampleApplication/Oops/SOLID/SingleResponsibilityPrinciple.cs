using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.SOLID
{
    internal class SingleResponsibilityPrinciple
    {
        static void Run()
        {
            StaffMember staff = new StaffMember
            {
                Name = "Kavi"
            };

            StaffRepository repository = new StaffRepository();
            repository.Save(staff);

            MailDispatcher dispatcher = new MailDispatcher();
            dispatcher.SendWelcomeMessage(staff);


            //Bad
            StaffProfile staffProfile = new StaffProfile
            {
                Name = "Kavi"
            };

            staffProfile.Display();
            staffProfile.SaveToDatabase();
            staffProfile.SendWelcomeEmail();

        }
    }

    // Responsibility 1: Employee Information
    class StaffMember
    {
        public string Name { get; set; }
    }

    // Responsibility 2: Database Operation
    class StaffRepository
    {
        public void Save(StaffMember staff)
        {
            Console.WriteLine($"{staff.Name} saved to database.");
        }
    }

    // Responsibility 3: Notification
    class MailDispatcher
    {
        public void SendWelcomeMessage(StaffMember staff)
        {
            Console.WriteLine($"Welcome email sent to {staff.Name}.");
        }
    }


    //Bad Example
    class StaffProfile
    {
        public string Name { get; set; }

        // Responsibility 1: Employee Information
        public void Display()
        {
            Console.WriteLine($"Employee Name: {Name}");
        }

        // Responsibility 2: Database Operation
        public void SaveToDatabase()
        {
            Console.WriteLine("Employee saved to database.");
        }

        // Responsibility 3: Notification
        public void SendWelcomeEmail()
        {
            Console.WriteLine("Welcome email sent.");
        }
    }
}
