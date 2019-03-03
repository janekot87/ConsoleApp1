using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            var evt1 = Event.GetEvent();
            var evt2 = Event.GetEvent();
            var evt3 = Event.GetEvent();





            /*var evt1 = new Event();
            Console.WriteLine("Enter Id: ");
            evt1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            evt1.Name = Console.ReadLine();
            Console.WriteLine("Enter Order: ");
            evt1.Order = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter StartDate: ");
            evt1.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter IsLive true or false: ");
            evt1.IsLive = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\r\n");

            var evt2 = new Event();
            Console.WriteLine("Enter Id: ");
            evt2.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            evt2.Name = Console.ReadLine();
            Console.WriteLine("Enter Order: ");
            evt2.Order = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter StartDate: ");
            evt2.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter IsLive true or false: ");
            evt2.IsLive = Convert.ToBoolean(Console.ReadLine());
            Console.Write("\r\n");

            var evt3 = new Event();
            Console.WriteLine("Enter Id: ");
            evt3.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            evt3.Name = Console.ReadLine();
            Console.WriteLine("Enter Order: ");
            evt3.Order = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter StartDate: ");
            evt3.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter IsLive true or false: ");
            evt3.IsLive = Convert.ToBoolean(Console.ReadLine());
            Console.Write("\r\n");*/



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
            Console.WriteLine("Live Events list");
            foreach (var x in evtlive)
              {

                Console.WriteLine(x.Id);
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Order);
                Console.WriteLine(x.StartDate);
                Console.WriteLine(x.IsLive);
                Console.WriteLine(); 


              }

            List<string> evtNames = new List<string>();
            foreach (var i in allEvents)
            {
                evtNames.Add(i.Name);
            }

            Console.WriteLine("Event names list");

            foreach (var a in evtNames)
            {
               Console.WriteLine(a);

            }
            Console.WriteLine();

            List<Event> evtFuture = new List<Event>();
            foreach (var b in allEvents)
            {
                if (b.StartDate > DateTime.Now)
                {
                    evtFuture.Add(b);
                }

            }

            Console.WriteLine("Pre-match Events list");
            foreach (var x in evtFuture)
            {

                Console.WriteLine(x.Id);
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Order);
                Console.WriteLine(x.StartDate);
                Console.WriteLine(x.IsLive);
                Console.WriteLine(); 


            }















        }
    }
}
