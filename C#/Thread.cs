using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
public class MyThread
{
    public static void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine("");
           
        }
    }
    public static void Thread2()
    {
        for (int i = 12; i>=1; i--)
        {
            Console.WriteLine(i);
            Console.WriteLine("");
            //Thread.Sleep(100);
        }
    }

    public static void Thread3()
    {
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine("");

        }
    }

}
public class ThreadExample
{
    public static void Main()
    {
        Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
        Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));
        Thread t3 = new Thread(new ThreadStart(MyThread.Thread3));
        
        t1.Start();
        t2.Start();
        t3.Start();
    }
}