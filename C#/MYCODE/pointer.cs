using System;

public class Class1
{
	public static void Main(string[] args)
	{
		int a;
		Console.WriteLine(" enter the value of a");
		a = int.Parse(Console.ReadLine());
		int* ptr = &a;
		Console.WriteLine((int)ptr);
		Console.WriteLine(*ptr);
	}
}
