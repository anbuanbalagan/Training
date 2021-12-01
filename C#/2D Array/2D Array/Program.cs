using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];
            int i, j;
                        
            Console.WriteLine("Enter the First Array Elements");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] :",i,j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Enter the Second Array Elements");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] :",i,j);
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Array Addition ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.Write("\nAddition Output");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", c[i, j]);
                }
            }
        }
    }
}
