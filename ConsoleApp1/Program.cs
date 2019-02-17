using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            var evt1 = new Event(12, "dffd1", 23, DateTime.Today,  true);
            var evt2 = new Event(22, "dffd2", 33, DateTime.Today, false);
            var evt3 = new Event(32, "dffd3", 43, DateTime.Today, true);
           



            List<Event> allEvents = new List<Event>();
                allEvents.Add(evt1);
                allEvents.Add(evt2);
                allEvents.Add(evt3);

            List<Event> evtlive = new List<Event>();
            foreach (var i in allEvents)
            {
                if (i.IsLive)
                {
                    evtlive.Add(i);
                    
                }

            }
              foreach (var x in evtlive)
              {


                Console.WriteLine(x.Name);
                Console.WriteLine(x.Id);
                Console.WriteLine(x.IsLive);
                Console.WriteLine(x.Order);
                Console.WriteLine(x.StartDate);
                Console.Write("\r\n");


              }

            List<string> evtNames = new List<string>();
            foreach (var i in allEvents)
            {
                evtNames.Add(i.Name);
            }

            foreach (var a in evtNames)
            {
               Console.WriteLine(a);
            }













            /*Console.WriteLine("Write the name");
            string name =  Console.ReadLine();
            Console.WriteLine("How old are you?");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, "+ name +" "+ years+" years");
            if (years <= 18)
            {
                Console.WriteLine("Good girl!");
               
            }
            else
            {
                Console.WriteLine("Beautiful women!");
            }*/







        }
    }
}
