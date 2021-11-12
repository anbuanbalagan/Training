using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> Names = new SortedList<int, string>();
            Names.Add(3, "Three");
            Names.Add(1, "One ");
            Names.Add(2, "Two ");
            Names.Add(5, "Five ");
            Names.Add(4, null);
            Names.Add(6, "Six ");
            Names.Add(8, "Eight");
            Names.Add(10, "Ten");
           
            Console.WriteLine("NUMBER NAMES");
            foreach(var item in Names)
            {
                Console.WriteLine("key:{0}, Value:{1}", item.Key, item.Value);
            }

            Console.WriteLine("\n\n");
            SortedList<string, string> cities = new SortedList<string, string>();
            cities.Add("Londan", "UK");
            cities.Add("New York", "USA");
            cities.Add("Mumbai", "India");
            cities.Add("Dubai", "UAE");

            Console.WriteLine("CITIES NAMES");
            foreach (var item in cities)
            {
                Console.WriteLine("key:{0}, Value:{1}", item.Key, item.Value);
            }

        }
    }
}
