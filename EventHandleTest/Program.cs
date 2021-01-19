using System;
using System.Threading;

namespace EventHandleTest
{

    public class EventHandlerClass
    {
        public delegate void DataLoggedEventHandler(object source, EventArgs args);
        public event DataLoggedEventHandler MessageLogged;
        public void WriteLog(string message)
        {
            Console.WriteLine($"Message: {message}");
            
            OnMessageLogged();// raise event  
        }
       
        protected virtual void OnMessageLogged()
        {
            if (MessageLogged != null)
                MessageLogged(this, EventArgs.Empty);
        }
    }
    public class  MessageService
    {
        public void OnMessageLogged(object source, EventArgs args)
        {
            Console.WriteLine("Sending Message...");
            Thread.Sleep(3000);
            Console.WriteLine("Message Sent");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var EventHandlerClass  = new EventHandlerClass(); // publisher  
            var mailer = new MessageService();// subscriber  

 
            EventHandlerClass.MessageLogged += mailer.OnMessageLogged;


            // Will raise the events  
            EventHandlerClass.WriteLog("Calling EventHandler");

            Console.WriteLine("Event Completed");
            Console.Read();
        }
    }
}
