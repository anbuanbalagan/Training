using System;

namespace Sum_of_a_digit
{
	class Program
	{
		static void Main(string[] args)
		{
			int nNumber, nOnce, nTens, nHundreds, nThoudands, nSum = 0;
			Console.WriteLine("Enter the Digit");
			if(int.TryParse(Console.ReadLine(), out nNumber))
			{
				nOnce = nNumber % 10;
				nTens = (nNumber / 10) % 10;
				nHundreds = (nNumber / 100) % 10;
				nThoudands = nNumber / 1000;

				nSum = nOnce + nTens + nHundreds + nThoudands;
				Console.WriteLine(nSum);
			}
			else
			{
				Console.WriteLine("Invalid input. Try again...");
			}

		}
	}
}
