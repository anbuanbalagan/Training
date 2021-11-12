using System;
using System.Collections.Generic;

public class CollectionExample
{
    public static void Main(string[] args)
    {
        // Create a list of strings  
        /* var names = new LinkedList<string>();
         names.AddLast("Sonoo");
         names.AddLast("Ankit");
         names.AddLast("Peter");
         names.AddLast("Irfan");

         //insert new element before "Peter"  
         LinkedListNode<String> node = names.Find("Peter");
         names.AddBefore(node, "John");
         names.AddAfter(node, "Lucy");

         LinkedListNode<String> node1 = names.Find("John");
         names.AddBefore(node1, "Anbu");
         names.AddBefore(node1, "king");
         names.AddAfter(node1, "Arun");
         names.AddAfter(node1, "AntonyAjith");

         // Iterate list element using foreach loop  
         foreach (var name in names)
         {
             Console.WriteLine(name);
         }*/

        Queue<string> names = new Queue<string>();
        names.Enqueue("Sonoo");
        names.Enqueue("Peter");
        names.Enqueue("James");
        names.Enqueue("Ratan");
        names.Enqueue("Irfan");
        names.Enqueue("Arun");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Peek element: " + names.Peek());
        Console.WriteLine("Dequeue: " + names.Dequeue());
        Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
    }
}


