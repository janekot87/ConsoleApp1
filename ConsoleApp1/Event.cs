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

        public Event ()
        {
           
        }

        public string FullName
        {
            get => FullName;

            set => FullName = Name + StartDate;
        }

        public void AddId(int id)
        {
            Id = id;
        }

        public void AddName(string n)
        {
            Name = n;
        }

        public void AddOrder(int o)
        {
            Order = o;
        }

        public void AddStartDate(DateTime d)
        {
            StartDate = d;
        }

        public void AddIsLive(bool l)
        {
            IsLive = l;
        }

    }

   
}
