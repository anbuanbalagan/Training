using System;

namespace ArrayProblem
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nNumbers = new int[5];    //Without using inbuilt function Find Second Largest number in array
			int i, max1, max2;
			Console.WriteLine("Enter the Array values");

			for(i = 0; i < 5; i++)
			{
				nNumbers[i] = int.Parse(Console.ReadLine());
			}

			max1 = max2 = nNumbers[0];

			for(i = 0; i < 5; i++)
			{
				if(nNumbers[i] > max1)
				{
					max2 = max1;
					max1 = nNumbers[i];
				}
				else if(nNumbers[i] > max2 && nNumbers[i] < max1)
				{
					max2 = nNumbers[i];
				}
			}
			Console.WriteLine("The Largest Num is " + max1);
			Console.WriteLine("The Second Largest Num is " + max2);
		}
	}
}
