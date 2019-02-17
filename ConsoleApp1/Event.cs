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

        public Event (int id, string name, int order, DateTime startDate, bool isLive)
        {
            Id = id;
            Name = name;
            Order = order;
            StartDate = startDate;
            IsLive = isLive;
        }

        public string FullName
        {
            get => FullName;

            set => FullName = Name + StartDate;
        }
    }
   
}
