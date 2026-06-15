using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.Concepts
{
    internal class Abstraction
    {
        static void Run()
        {
            Console.WriteLine("=== Abstract Class ===");

            NotificationChannel email = new EmailNotifier();
            email.SendMessage("john@example.com", "Welcome!");
            email.LogNotification();

            NotificationChannel sms = new SmsNotifier();
            sms.SendMessage("+919876543210", "OTP: 123456");
            sms.LogNotification();


            Console.WriteLine("\n=== Interface Abstraction ===");

            IExportService exporter = new ReportProcessor();
            exporter.Export();

            IPrintService printer = new ReportProcessor();
            printer.Print();
        }
    }
    // 1. Abstract Class (Partial Abstraction)
    abstract class NotificationChannel
    {
        // Abstract Method
        public abstract void SendMessage(string recipient, string message);

        // Non-Abstract Method
        public void LogNotification()
        {
            Console.WriteLine("Notification logged successfully.");
        }
    }

    class EmailNotifier : NotificationChannel
    {
        public override void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"Email sent to {recipient}: {message}");
        }
    }

    class SmsNotifier : NotificationChannel
    {
        public override void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"SMS sent to {recipient}: {message}");
        }
    }


    // 2. Interface (Full Abstraction)
    interface IExportService
    {
        void Export();
    }

    interface IPrintService
    {
        void Print();
    }

    class ReportProcessor : IExportService, IPrintService
    {
        public void Export()
        {
            Console.WriteLine("Report exported to PDF.");
        }

        public void Print()
        {
            Console.WriteLine("Report printed successfully.");
        }
    }
}
