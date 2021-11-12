using System;

public class Program
{
	public static void Main(string[] args)
	{
		int[] a = new int[5];
		int i;
		Console.WriteLine("Enter the Array Value");

		for (i = 0; i < 5; i++)
		{
			Console.Write("elements -{0} ", i);
			a[i] = int.Parse(Console.ReadLine());
		}

		Console.WriteLine(" Array values are");

		for (i = 0; i < 5; i++)
		{
			Console.Write("{0} ", a[i]);
		}
	}
}
