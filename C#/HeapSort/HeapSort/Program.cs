using System;

namespace HeapSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 72, 56, 10, 25, 6, 77, 8, 42, 84, 20, 50, 15 };
			Console.WriteLine("Heap Sort");
			Print(array);
			Console.WriteLine("\nCalling the Sort function");
			HeapSort(array);
			Console.WriteLine("\nAfter Sorting the Array");
			Print(array);
		}

		static void Print(int[] array)
		{
			for(int i = 0; i < array.Length; i++)
			{
				Console.Write("\t" +array[i]);
			}
		}

		static void HeapSort(int[] array)
		{
			int length = array.Length;

			for(int i = length / 2 - 1; i >= 0; i--)
			{
				Heap(array, length, i);
			}

			for(int i = length - 1; i >= 0; i--)
			{
				int temp = array[0];
				array[0] = array[i];
				array[i] = temp;
				Heap(array, i, 0);
			}
		}

		static void Heap(int[] array, int length, int i)
		{
			int largest = i;
			int left = 2 * i + 1;
			int right = 2 * i + 2;

			if(left < length && array[left] > array[largest])
			{
				largest = left;
			}

			if(right < length && array[right] > array[largest])
			{
				largest = right;
			}

			if(largest != i)
			{
				int swap = array[i];
				array[i] = array[largest];
				array[largest] = swap;
				Heap(array, length, largest);
			}
		}
	}
}
