using System;
using System.Collections.Generic;

namespace MYCODE
{
    public class StackEg
    {
        public static void Main(string[] args)
        {
            /* Stack<string> names = new Stack<string>();
             names.Push("Anbu");
             names.Push("Arun");
             names.Push("Siva");
             names.Push("Ajith");
             names.Push("Mani");

             foreach(string name in names)
             {
                 Console.WriteLine(name);
             }

             Console.WriteLine("Peek elements :" +names.Peek());
             Console.WriteLine("Pop elements :" +names.Pop());
             names.Push("King");

             foreach (string name in names)
             {
                 Console.WriteLine(name);
             }
             //Console.WriteLine("Push elements :" +names.Push("King"));
             Console.WriteLine("After Pop operation,Peek elements :" + names.Peek());*/

            Stack<string> names = new Stack<string>();
            names.Push("Sonoo");
            names.Push("Peter");
            names.Push("James");
            names.Push("Ratan");
            names.Push("Irfan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());

        }
    }
}
