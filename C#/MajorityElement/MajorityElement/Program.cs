using System;

namespace MajorityElement
{
	class Program
	{
		static void Main(string[] args)
		{
			int nLength, i;
			Console.WriteLine("Enter Length");
			nLength = int.Parse(Console.ReadLine());
			int[] nArray = new int[nLength];

			Console.WriteLine("Enter Array Values ");

			for(i = 0; i < nLength; i++)
			{
				nArray[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("Output is " + MajorityElement(nArray));
		}
	
		static int MajorityElement(int[] nArray)
		{
			int i, j, nCount, nLength;
			nLength = nArray.Length;
			for(i = 0; i < nLength; i++)
			{
				nCount = 1;
				for(j = 1; j < nLength; j++)
				{
					if(nArray[i] == nArray[j])
					{
						nCount++;
					}
				}

				if(nCount > nLength / 2)
				{
					return nArray[i];
				}			
			}
			return -1;
		}
	}
}


