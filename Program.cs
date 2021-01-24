using Algorithms.Sorting;
using System;

namespace Algorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			// Sorting 
			// ExecuteBubbleSort();
			// ExecuteSelectionSort();
			// ExecuteMergeSort();
			// ExecuteQuickSort();
			// ExecuteCountingSort();
			ExecuteBucketSort();
			Console.ReadLine();
		}

		#region Sorting

		#region Bubble Sort

		private static void ExecuteBubbleSort()
		{
			var array = new int[] { 7, 2, 5, 9, 1, 13, 3 };
			Console.WriteLine($"Bubble sort - {string.Join(",", array)}");
			var sorter = new BubbleSort();
			sorter.Sort(array);
			Console.WriteLine($"Sorted array - {string.Join(",", array)}");
		}

		#endregion

		#region Selection Sort

		private static void ExecuteSelectionSort()
		{
			var array = new int[] { 7, 2, 5, 9, 1, 13, 3 };
			Console.WriteLine($"Selection sort - {string.Join(",", array)}");
			var sorter = new SelectionSort();
			sorter.Sort(array);
			Console.WriteLine($"Sorted array - {string.Join(",", array)}");
		}

		#endregion

		#region Insertion Sort

		private static void ExecuteInsertionSort()
		{
			var array = new int[] { 7, 2, 17, 9, 1, 3, 3 };
			Console.WriteLine($"Insertion sort - {string.Join(",", array)}");
			var sorter = new InsertionSort();
			sorter.Sort(array);
			Console.WriteLine($"Sorted array - {string.Join(",", array)}");
		}

		#endregion

		#region Merge Sort

		private static void ExecuteMergeSort()
		{
			var array = new int[] { 7, 2, 17, 9, 1, 3, 3 };
			Console.WriteLine($"Merge sort - {string.Join(",", array)}");
			var sorter = new MergeSort();
			sorter.Sort(array);
			Console.WriteLine($"Sorted array - {string.Join(",", array)}");
		}

		#endregion

		#region Quick Sort

		private static void ExecuteQuickSort()
		{
			var array = new int[] { 7, 2, 17, 9, 1, 3, 3 };
			Console.WriteLine($"Quick sort - {string.Join(",", array)}");
			var sorter = new QuickSort();
			sorter.Sort(array);
			Console.WriteLine($"Sorted array - {string.Join(",", array)}");
		}

		#endregion

		#region Counting Sort

		private static void ExecuteCountingSort()
		{
			var array = new int[] { 7, 2, 7, 9, 1, 3, 3 };
			Console.WriteLine($"Counting sort - {string.Join(",", array)}");
			var sorter = new CountingSort();
			sorter.Sort(array, 9);
			Console.WriteLine($"Sorted array - {string.Join(",", array)}");
		}

		#endregion

		#region Bucket Sort

		private static void ExecuteBucketSort()
		{
			var array = new int[] { 7, 2, 7, 9, 1, 3, 3 };
			Console.WriteLine($"Bucket sort - {string.Join(",", array)}");
			var sorter = new BucketSort();
			sorter.Sort(array, 4);
			Console.WriteLine($"Sorted array - {string.Join(",", array)}");
		}

		#endregion

		#endregion
	}
}
