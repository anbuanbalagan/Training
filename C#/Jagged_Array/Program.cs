using System;

namespace Jagged_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int i;
			int[][] array1 = new int[2][]{
								new int[3]{1, 2, 3},
								new int[4]{4, 5, 6, 7}
			};

			int[][,] array2 = new int[2][,];

			array2[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
			array2[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };

			int[][] array3 = new int[4][] {
				new int[3]{ 1, 2, 3 },
				new int[4]{ 1, 3, 2, 4 },
				new int[2]{3,7},
				new int[5]{3,5,7,9,2}
			};
			Console.WriteLine("\nPrinting Array One");
			for(i = 0; i < array1.Length; i++)
			{
				for(int j = 0; j < array1[i].Length; j++)
				{
					Console.Write(array1[i][j] + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("\nPrinting Array Two");

			Console.WriteLine(array2[0][0, 0]);
			Console.WriteLine(array2[0][0, 1]);
			Console.WriteLine(array2[0][1, 0]);
			Console.WriteLine(array2[0][1, 1]);

			Console.WriteLine(array2[1][0, 0]);
			Console.WriteLine(array2[1][0, 1]);
			Console.WriteLine(array2[1][1, 0]);
			Console.WriteLine(array2[1][1, 1]);

			Console.WriteLine("\nPrinting Array Three");
			for( i = 0; i < array3.Length; i++)
			{
				for(int j = 0; j < array3[i].Length; j++)
				{
					Console.Write(array3[i][j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
