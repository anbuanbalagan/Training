using System;

namespace Prime_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int a ;
			while(a) 
			{
				int num, flag = 0, n;
				Console.WriteLine("Enter the number ");
				num = int.Parse(Console.ReadLine());
				n = num / 2;
				for(int i = 2; i <= n; i++)
				{
					if(num % i == 0)
					{
						flag = 1;
						break;
					}
				}
				Console.WriteLine(flag == 0 ? "prime" : "Not a Prime");
				Console.WriteLine("Do you want to continue..");
				
			} 

		}
	}
}
