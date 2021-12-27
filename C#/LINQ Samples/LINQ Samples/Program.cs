using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_Samples
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new List<int> {15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

			//Filtering -> First
			var first = numbers.Where(x => x < 1).FirstOrDefault();	
			Console.WriteLine("First Value is : " +first);			

			var evenNumbers = numbers.Where(x => x % 2 == 0);
			Console.WriteLine("The Even numbers are: ");
			foreach(int i in evenNumbers)
			{
				Console.WriteLine(i);
			}   

			//IEnumerable<T> and Conversion
			int[] array = evenNumbers.ToArray();

			for(int i = 0; i < array.Length;i++)
			{
				Console.WriteLine("Even Numbers are : " +array[i]);
			}

			//Aggregation Methods
			Console.WriteLine("Sum is : " + numbers.Sum());
			Console.WriteLine("Minimum Value is : " + numbers.Where(x => x >= 5).Min());
			Console.WriteLine("Maximum Value is : " + numbers.Where(x => x < 15).Max());
			Console.WriteLine("Total Count is : " + numbers.Count());
			Console.WriteLine("Average : " + numbers.Where(x => x < 15).Average());

			//Existence operation
			bool hasAny = numbers.Any();
			bool contain = numbers.Contains(15);

			if(hasAny && contain)
				Console.WriteLine("Records Exists");
			else
				Console.WriteLine("No records");

			//Set Operations
			var intersectionList1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 9 ,10};
			var intersectionList2 = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

			var intersection = intersectionList1.Intersect(intersectionList2);  //Intersection
			Console.WriteLine("\nThe Intersection Result ");
			foreach(int i in intersection)
			{
				Console.WriteLine(i);
			}

			var unionList1 = new List<int> { 1, 3, 5, 7, 8, 9, 11, 14 };
			var unionList2 = new List<int> { 2, 4, 6, 3, 7, 10, 11, 9 };

			var union = unionList1.Union(unionList2);
			Console.WriteLine("\nThe Union Result ");
			foreach(int i in union)
			{				
				Console.WriteLine(i);
			}
		}
	}
}
