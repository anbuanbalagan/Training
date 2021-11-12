using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* var names = new Stack<string>();
             names.Push("Ajith");
             names.Push("Arun");
             names.Push("Anbu");
             names.Push("Mani");
             names.Push("Siva");
             names.Push("Vicky");

             names.Pop();

             foreach( var name in names)
             {
                 Console.WriteLine(name);
             }*/
            Stack<int> num = new Stack<int>();
            num.Push(1);
            num.Push(2);
            num.Push(3);
            num.Push(4);
            num.Push(5);
            num.Push(6);
            num.Push(7);

            num.Pop();
            foreach (var item in num)
                Console.WriteLine(item + " ");


        }
    }
}
