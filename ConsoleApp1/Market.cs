using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Market
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SportId { get; set; }
        public int LeagueId { get; set; }
        public List<Selection> Selections;

        public Market() { }

        public int Capasity;

        public Market( int c)
        {
            c = Capasity;
        }

        public void AddSelection(Selection value)
        {
            List<Selection> list = new List<Selection>();
            if (list.Count <= Capasity)
            {
                list.Add(value);
            }
            else
            {
                Console.WriteLine("you have reached the selection capacity");
            }
        }

      
    }

    

}
