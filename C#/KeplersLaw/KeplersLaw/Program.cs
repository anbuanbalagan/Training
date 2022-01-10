using System;

namespace KeplersLaw
{
	class Program
	{
		static void Main(string[] args)
		{
			int nNumbers;
			Console.WriteLine("Enter the values of num");
			nNumbers = int.Parse(Console.ReadLine());

			while(Convert.ToBoolean(nNumbers--))
			{
				double T1, T2, R1, R2, a, b;
				T1 = Convert.ToDouble(Console.ReadLine());
				T2 = Convert.ToDouble(Console.ReadLine());
				R1 = Convert.ToDouble(Console.ReadLine());
				R2 = Convert.ToDouble(Console.ReadLine());

				a = Math.Pow(T1, 2) / Math.Pow(R1, 3);
				b = Math.Pow(T2, 2) / Math.Pow(R2, 3);

				if(a == b)
					Console.WriteLine("Yes");
				else
					Console.WriteLine("No");
			}
		}
	}
}
