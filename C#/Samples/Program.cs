using System;

namespace Samples
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = 2;
			while(t > 0)
			{
				char cFirst, cSecond, cThird, cX, cY;
				cFirst = Convert.ToChar(Console.ReadLine());
				cSecond = Convert.ToChar(Console.ReadLine());
				cThird = Convert.ToChar(Console.ReadLine());
				cX = Convert.ToChar(Console.ReadLine());
				cY = Convert.ToChar(Console.ReadLine());

				if(cFirst == cX)
					Console.WriteLine(cX);
				else if(cFirst == cY)
					Console.WriteLine(cY);
				else if(cSecond == cX)
					Console.WriteLine(cX);
				else
					Console.WriteLine(cY);
				t--;
			}
		}
	}
}
