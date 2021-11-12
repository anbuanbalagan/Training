using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[5];
            int num1,num2, i, j;
            Console.WriteLine("Enter the Array num1");
            num1 = int.Parse(Console.ReadLine());
           
            for(i=0;i<num1;i++)
            {
                Console.Write("elements1 - {0}  ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the Array num2");
            num2 = int.Parse(Console.ReadLine());
           
            for (i = 0; i < num2; i++)
            {
                Console.Write("elements2 - {0}  ", i);
                b[i] = int.Parse(Console.ReadLine());
            }
            
            for(i=0;i<num1;i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine(" ");
            
            for (i = 0; i < num2; i++)
            {
                Console.Write("{0} ", b[i]);
            }
           
            /* Addition of Two Array*/
            for(i=0; i<num1;i++)
            {
                for(j=0;j<num2;j++)
                {
                    c[i] = a[i] + b[i];
                }
            }
            Console.WriteLine("\nAddition of two Array is ");
            for (i = 0; i < num1; i++)
            {
                Console.Write("{0} ", c[i]);
            }

        }
    }
}
