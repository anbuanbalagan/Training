using System;

namespace Matrix_Transpose
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, j, n;
			int[,] a = new int[3, 3];
			int[,] b = new int[3, 3];

			Console.Write("Enter the value of n ");
			n = int.Parse(Console.ReadLine());
			for(i = 0; i < n; i++)
			{
				for(j = 0; j < n; j++)
				{
					Console.Write("elements [{0} {1}] :", i, j);
					a[i, j] = int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("Matrix Before Transpose \n");
			for(i = 0; i < n; i++)
			{
				Console.Write(" \n");
				for(j = 0; j < n; j++)
				{
					Console.Write("{0}\t", a[i, j]);
				}
			}
			Console.WriteLine("\n Transpose the Matrix is done ");
			for(i = 0; i < n; i++)
			{
				for(j = 0; j < n; j++)
				{
					b[j, i] = a[i, j];
				}
			}
			Console.WriteLine("\n Matrix After Transpose \n");
			for(i = 0; i < n; i++)
			{
				Console.Write(" \n");
				for(j = 0; j < n; j++)
				{
					Console.Write("{0}\t", b[i, j]);
				}
			}
		}
	}
}
