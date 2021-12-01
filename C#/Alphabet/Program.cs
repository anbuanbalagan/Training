using System;

namespace Alphabet
{
	class Program
	{
		static void Main(string[] args)
		{
			char cAlphabet;
			Console.WriteLine("Enter the Char");
			cAlphabet = Convert.ToChar(Console.ReadLine());
			//Console.WriteLine(cAlphabet);
			switch(cAlphabet)
			{
				case 'A' :
					Console.WriteLine('Z');
					break;
				case 'B':
					Console.WriteLine('Y');
					break;
				default:
					Console.WriteLine("Invalid");
					break;
			}
		}
	}
}
