using System;

namespace ArraySum
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, n,sum1 = 0 , sum2 = 0;
			int[] array = new int[5];
			int[] low1 = new int[5];
			int[] low2 = new int[5];

			Console.WriteLine("Enter the number of elements in Array");
			n = int.Parse(Console.ReadLine());			

			for(i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}

			Array.Sort(array);

			for(i = 0; i < n; i++)
			{
				Console.Write("{0} ", array[i]);
			}

			Console.WriteLine(" ");

			for(i = 0; i < n; i += 2)
			{				
				low1[i] = array[i];								
			}

			for(i = 0; i < 5; i++)
			{
				Console.Write("{0} ", low1[i]);
			}

			for(i = 1; i < n; i += 2)
			{
				low2[i] = array[i];
			}
			  
		}
	}
}
