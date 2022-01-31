using System;

namespace Prime_in_Binarystring
{
	class Program
	{
		static void Main(string[] args)
		{
			int nNumber;
			Console.WriteLine("Enter the number");
			nNumber = int.Parse(Console.ReadLine());

			while(Convert.ToBoolean(nNumber--))
			{
				int nlength;
				string s;
				s = Console.ReadLine();
				nlength = s.Length;

				if(nlength == 1)
					Console.WriteLine("No");
				//continue;

				int nCount = 0, nPosition = -1, i = 0;
				while(i < nlength)
				{
					if(s[i] == '1')
					{
						nCount++;
						nPosition = i + 1;
					}
					else i++;
				}

				if( nCount == 0 || (nCount == 1 && nPosition == nlength))
				{
					Console.WriteLine("No");
				}
				else Console.WriteLine("Yes");
			}
		}
	}
}
