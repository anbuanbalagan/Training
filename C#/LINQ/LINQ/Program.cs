using System;
using System.Linq;

namespace LINQ
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int nMinimum, nMaximum, nSum, nCount;
			double dAverage;
			Console.WriteLine("LINQ Operations\n");

			nMinimum = nNumber.Min();
			nMaximum = nNumber.Max();
			nSum = nNumber.Sum();
			nCount = nNumber.Count();
			dAverage = nNumber.Aggregate((a, b) => a * b);

			int nSecondMinimum = (from num in nNumber
							 orderby num ascending
							 select num).Distinct().Skip(1).First();
			int nSecondMaximum = (from num in nNumber
							 orderby num descending
							 select num).Distinct().Skip(1).First();

			Console.WriteLine("The Min Value is " + nMinimum);
			Console.WriteLine("The SecondMin Value is " + nSecondMinimum);
			Console.WriteLine("The Max Value is " + nMaximum);
			Console.WriteLine("The SecondMax Value is " + nSecondMaximum);
			Console.WriteLine("The Sum Value is " + nSum);
			Console.WriteLine("The Total Count is " + nCount);
			Console.WriteLine("The Product of the Total Numbers is " + dAverage);
		}
	}
}
