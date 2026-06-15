using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.SOLID
{
    internal class LiskovSubstitutionPrinciple
    {
        static void Run()
        {
            //Bad 
            MessageSender sender = new DisabledSender();

            sender.Send("Hello");   // Runtime Exception


            //Good
            AlertChannel[] channels =
        {
            new EmailAlert(),
            new SmsAlert(),
            new PushAlert()
        };

            foreach (AlertChannel channel in channels)
            {
                channel.Notify("System maintenance at 10 PM.");
            }

        }
    }

    //Bad 
    class MessageSender
    {
        public virtual void Send(string message)
        {
            Console.WriteLine($"Message Sent: {message}");
        }
    }

    class DisabledSender : MessageSender
    {
        public override void Send(string message)
        {
            throw new NotSupportedException("Sending messages is disabled.");
        }
    }


    //Good

    // Base Contract
    abstract class AlertChannel
    {
        public abstract void Notify(string message);
    }

    // Substitution 1
    class EmailAlert : AlertChannel
    {
        public override void Notify(string message)
        {
            Console.WriteLine($"Email Alert: {message}");
        }
    }

    // Substitution 2
    class SmsAlert : AlertChannel
    {
        public override void Notify(string message)
        {
            Console.WriteLine($"SMS Alert: {message}");
        }
    }

    // Substitution 3
    class PushAlert : AlertChannel
    {
        public override void Notify(string message)
        {
            Console.WriteLine($"Push Notification: {message}");
        }
    }
}
