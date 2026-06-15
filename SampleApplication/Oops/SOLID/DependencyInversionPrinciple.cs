using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.SOLID
{
    internal class DependencyInversionPrinciple
    {
        
        static void Main()
        {
            //Bad
            AlertService service = new AlertService();

            service.SendAlert("Server Down!");



            // Good

            Console.WriteLine("=== Email Notification ===");

            IMessageDispatcher email = new EmailDispatcher();

            AlertManager emailAlert = new AlertManager(email);

            emailAlert.SendAlert("Database backup completed.");


            Console.WriteLine("\n=== SMS Notification ===");

            IMessageDispatcher sms = new SmsDispatcher();

            AlertManager smsAlert = new AlertManager(sms);

            smsAlert.SendAlert("Payment received.");
        }

        
    }

    //Bad
    class EmailSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }
    }

    class AlertService
    {
        private EmailSender _emailSender = new EmailSender();

        public void SendAlert(string message)
        {
            _emailSender.Send(message);
        }
    }

    //Good

    // Abstraction
    interface IMessageDispatcher
    {
        void Send(string message);
    }

    // Low-Level Module 1
    class EmailDispatcher : IMessageDispatcher
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }
    }

    // Low-Level Module 2
    class SmsDispatcher : IMessageDispatcher
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS Sent: {message}");
        }
    }

    // High-Level Module
    class AlertManager
    {
        private readonly IMessageDispatcher _dispatcher;

        public AlertManager(IMessageDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public void SendAlert(string message)
        {
            _dispatcher.Send(message);
        }
    }
}
