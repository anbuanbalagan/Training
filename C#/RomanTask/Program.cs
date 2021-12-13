using System;

namespace RomanTask
{
	class Program
	{
		static void Main(string[] args)
		{
			int nValue;
			Console.WriteLine("Enter the value ");
			if(int.TryParse(Console.ReadLine(), out nValue))
			{
				if(nValue > 0 && nValue <= 4999)
				{
					Decimal2Roman(nValue);
				}
				else
				{
					Console.WriteLine("Value out of Range ");
				}
			}
			else
			{
				Console.WriteLine("Invalid Input. Try again...");
			}
		}

		public static void Decimal2Roman(int nValue)
		{
			int nOnce , nTens , nHundreds , nThousands ,nNumber1, nNumber2, nNumber = nValue;

				nOnce = nNumber % 10;
				nNumber1 = nNumber / 10;
				nTens = nNumber1 % 10;
				nNumber2 = nNumber / 100;
				nHundreds = nNumber2 % 10;
				nThousands = nNumber / 1000;
			
			switch(nThousands)
			{
				case 1:
					Console.Write("M");
					break;
				case 2:
					Console.Write("MM");
					break;
				case 3:
					Console.Write("MMM");
					break;
				case 4:
					Console.Write("MMMM");
					break;
				default:
					break;
			}

			switch(nHundreds)
			{
				case 1:
					Console.Write("C");
					break;
				case 2:
					Console.Write("CC");
					break;
				case 3:
					Console.Write("CCC");
					break;
				case 4:
					Console.Write("CD");
					break;
				case 5:
					Console.Write("D");
					break;
				case 6:
					Console.Write("DC");
					break;
				case 7:
					Console.Write("DCC");
					break;
				case 8:
					Console.Write("DCCC");
					break;
				case 9:
					Console.Write("CM");
					break;
				default: break;
			}

			switch(nTens)
			{
				case 1:
					Console.Write("X");
					break;
				case 2:
					Console.Write("XX");
					break;
				case 3:
					Console.Write("XXX");
					break;
				case 4:
					Console.Write("XL");
					break;
				case 5:
					Console.Write("L");
					break;
				case 6:
					Console.Write("LX");
					break;
				case 7:
					Console.Write("LXX");
					break;
				case 8:
					Console.Write("LXXX");
					break;
				case 9:
					Console.Write("XC");
					break;
				default: break;
			}

			switch(nOnce)
			{
				case 1:
					Console.Write("I");
					break;
				case 2:
					Console.Write("II");
					break;
				case 3:
					Console.Write("III");
					break;
				case 4:
					Console.Write("IV");
					break;
				case 5:
					Console.Write("V");
					break;
				case 6:
					Console.Write("VI");
					break;
				case 7:
					Console.Write("VII");
					break;
				case 8:
					Console.Write("VIII");
					break;
				case 9:
					Console.Write("IX");
					break;
				default: break;
			}
		}
	}
}
