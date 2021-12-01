using System;

namespace Basics
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, n, j;
			int[,] a = new int[3, 3];
			int[,] b = new int[3, 3];
			int[,] c = new int[3, 3];
			int[,] d = new int[3, 3];

			Console.Write("Enter the Array Size  ");
			n = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the Array Values of a");
			for(i = 0; i < n; i++)
			{
				for(j = 0; j < n; j++)
				{
					Console.Write("elements [{0},{1}] ", i, j);
					a[i, j] = int.Parse(Console.ReadLine());
				}
			}

			Console.WriteLine("Enter the Array Values of b");
			for(i = 0; i < n; i++)
			{
				for(j = 0; j < n; j++)
				{
					Console.Write("elements [{0},{1}] ", i, j);
					b[i, j] = int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("Array Multiplication is Processing here \n");

			for(i = 0; i < n; i++)
			{
				for(j = 0; j < n; j++)
				{
					c[i, j] = a[i, j] * b[i, j];
					d[i, j] = a[i, j] + b[i, j];
				}
			}
			Console.WriteLine("Printing the Array");

			for(i = 0; i < n; i++)
			{
				Console.Write("\n \n");
				for(j = 0; j < n; j++)
				{
					Console.Write(" {0}  ", c[i, j]);
				}
			}

			Console.WriteLine("\n \n Array Adding");

			for(i = 0; i < n; i++)
			{
				Console.Write("\n \n");
				for(j = 0; j < n; j++)
				{
					Console.Write(" {0}  ", d[i, j]);
				}
			}
		}
	}
}
