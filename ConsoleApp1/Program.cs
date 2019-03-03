using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            /*var evt1 = Event.GetEvent();
            var evt2 = Event.GetEvent();
            var evt3 = Event.GetEvent();

            

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
                }*/


                var sel1 = Selection.GetSelection();
                var sel2 = Selection.GetSelection();
                var sel3 = Selection.GetSelection();
                var sel4 = Selection.GetSelection();

                var mrk1 = new Market(3);
                mrk1.Id = 1;
                mrk1.Name = "Market1";
                mrk1.SportId = 1;
                mrk1.LeagueId = 1;
                mrk1.AddSelection(sel1);
                mrk1.AddSelection(sel2);
                mrk1.AddSelection(sel3);
                mrk1.AddSelection(sel4);

            foreach (var i in mrk1.Selections)
            {
                Console.WriteLine(i.Id);
                Console.WriteLine(i.Name);
                Console.WriteLine(i.Title);
                Console.WriteLine(i.IsDisabled);
                Console.WriteLine(i.Status);
                Console.WriteLine();
            }












            















        }
    }
}
