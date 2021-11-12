using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
   public  class ListEg
   {
       public static void Main(string[] args)
       {
            var names = new List<string>();
            names.Add("Arun");
            names.Add("Siva");
            names.Add("Ajith");
            names.Add("Mani");
            names.Add("Anbu");

            names.RemoveAt(1);
            names.Remove("Anbu");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
       }
   }
}
