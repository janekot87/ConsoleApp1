using System;

namespace ConsoleApp1
{
    public class Event
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsLive { get; set; }

        public string FullName
        {
            get => FullName;

            set => FullName = Name + StartDate;
        }

        public static Event GetEvent()
        {
            var evt = new Event();


            Console.WriteLine("Enter Id: ");
            evt.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            evt.Name = Console.ReadLine();
            Console.WriteLine("Enter Order: ");
            evt.Order = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter StartDate: ");
            evt.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter IsLive true or false: ");
            evt.IsLive = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();
            return evt;
            
        }

    }

   
}
