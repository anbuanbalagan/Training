using System;

namespace CovidSpread
{
	class Program
	{
		static void Main(string[] args)
		{
			int nNumber;
			Console.WriteLine("Enter the Number");
			nNumber = int.Parse(Console.ReadLine());	//determine the number of inputs

			while(Convert.ToBoolean(nNumber--))
			{
				double a, b, s = 1;
				a = Convert.ToDouble(Console.ReadLine());
				b = Convert.ToDouble(Console.ReadLine());

				for(int i = 1; i <= b && s < a; i++)
				{
					if(i < 11)
						s *= 2;
					else
						s = a;
				}

				if(s >= a)
					s = a;
				Console.WriteLine(s);
				Console.WriteLine(" ");
			}
		}
	}
}
