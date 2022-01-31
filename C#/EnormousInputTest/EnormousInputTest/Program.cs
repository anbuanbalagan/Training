using System;

namespace EnormousInputTest
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, k, nCount = 0;
			Console.WriteLine("Enter the n");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the k");
			k = int.Parse(Console.ReadLine());
			Console.WriteLine("The Input numbers are ");

			for(int i = 0; i < n ; i++)
			{				
				int nInput = int.Parse(Console.ReadLine());
				if(nInput % k == 0)
				{
					nCount++;
				}
			}

			Console.WriteLine("The Total count value is " +nCount);
		}
	}
}
