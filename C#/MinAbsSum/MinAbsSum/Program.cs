using System;

namespace MinAbsSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int nLength, i;
			Console.WriteLine("Enter Array Length");
			nLength = int.Parse(Console.ReadLine());
			int[] nArray = new int[nLength];
			Console.WriteLine("Enter Array Values");

			for(i = 0; i < nLength; i++)
			{
				nArray[i] = int.Parse(Console.ReadLine());
			}

			Array.Sort(nArray);
			
			int nMinDiff = nArray[i - 1] - nArray[0];
			Console.WriteLine("The mD value is " +nMinDiff);

			for(i = 0; i < nLength - 1; i++)
			{
				int nTempDiff = nArray[i + 1] - nArray[i];
				if(nTempDiff < nMinDiff)
				{
					nMinDiff = nTempDiff;
				}
			}
			Console.WriteLine("The MinDiff is " +nMinDiff);
		}
	}
}
