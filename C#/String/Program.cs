using System;

namespace String
{
	class Program
	{
		public static readonly string[] strAlphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
		
		static void Main(string[] args)
		{
			string strChar;			
			Console.WriteLine("Enter the string");
			strChar = Console.ReadLine();			
			int nLength = strAlphabet.Length;
			int nCharLength = strChar.Length;

			char[] cChar = strChar.ToCharArray();
			int nLen = cChar.Length;
			string name = string.Empty;

			for(int i = 0; i < nLen; i++)
			{
				for(int j = 0; j < nLength; j++)
				{
					if(cChar[i].ToString() == strAlphabet[j])
					{
						name += strAlphabet[nLength - j - 1];
						Console.ReadKey();
					}
				}
			}
			Console.Write(name);
		}
	}
}
