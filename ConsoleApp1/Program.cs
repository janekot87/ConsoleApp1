using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            var evt1 = new Event();
            Console.WriteLine("Enter Id: ");
            evt1.AddId(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Name: ");
            evt1.AddName(Console.ReadLine());
            Console.WriteLine("Enter Order: ");
            evt1.AddOrder(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter StartDate: ");
            evt1.AddStartDate(Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Enter IsLive true or false: ");
            evt1.AddIsLive(Convert.ToBoolean(Console.ReadLine()));
            Console.Write("\r\n");

            var evt2 = new Event();
            Console.WriteLine("Enter Id: ");
            evt2.AddId(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Name: ");
            evt2.AddName(Console.ReadLine());
            Console.WriteLine("Enter Order: ");
            evt2.AddOrder(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter StartDate: ");
            evt2.AddStartDate(Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Enter IsLive true or false: ");
            evt2.AddIsLive(Convert.ToBoolean(Console.ReadLine()));
            Console.Write("\r\n");

            var evt3 = new Event();
            Console.WriteLine("Enter Id: ");
            evt3.AddId(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Name: ");
            evt3.AddName(Console.ReadLine());
            Console.WriteLine("Enter Order: ");
            evt3.AddOrder(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter StartDate: ");
            evt3.AddStartDate(Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Enter IsLive true or false: ");
            evt3.AddIsLive(Convert.ToBoolean(Console.ReadLine()));
            Console.Write("\r\n");



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
                Console.Write("\r\n");


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
            Console.Write("\r\n");

            List<string> evtFuture = new List<string>();
            foreach (var b in allEvents)
            {
                if (b.StartDate > DateTime.Now)
                {
                    evtlive.Add(b);
                }

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
