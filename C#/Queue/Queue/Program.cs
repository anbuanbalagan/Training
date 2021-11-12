using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* var names = new Queue<string>();
             names.Enqueue("Ajith");
             names.Enqueue("Arun");
             names.Enqueue("Anbu");
             names.Enqueue("Maran");
             names.Enqueue("King");
             names.Enqueue("Dominic");

             names.Dequeue();

             foreach (var name in names)
                 Console.WriteLine(name);*/

            Queue<int> num = new Queue<int>();
            num.Enqueue(1);
            num.Enqueue(2);
            num.Enqueue(3);
            num.Enqueue(4);
            num.Enqueue(5);
            num.Enqueue(6);
            num.Enqueue(7);

            num.Dequeue();

            foreach(var item in num)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
