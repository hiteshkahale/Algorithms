using Algorithms.Searching;
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
			// ExecuteBucketSort();

			// Searching
			// ExecuteLinearSearch();
			// ExecuteBinarySearch();
			// ExecuteTernarySearch();
			// ExecuteJumpSearch();
			ExecuteExponentialSearch();
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

		#region Searching

		#region Linear Search

		private static void ExecuteLinearSearch()
		{
			var array = new int[] { 7, 2, 7, 9, 1, 3, 3 };
			var item = 7;
			Console.WriteLine($"Array - {string.Join(",", array)}");
			Console.WriteLine($"Linear Search - {item}");
			var algo = new LinearSearch();
			var index = algo.Search(array, item);
			Console.WriteLine($"Item {item} present at index- {index}");
		}

		#endregion

		#region Binary Search

		private static void ExecuteBinarySearch()
		{
			var array = new int[] { 1, 3, 4, 8, 14, 21 };
			var item = 56;
			Console.WriteLine($"Array - {string.Join(",", array)}");
			Console.WriteLine($"Binary Search - {item}");
			var algo = new BinarySearch();
			var index = algo.Search(array, item);
			Console.WriteLine($"Item {item} present at index- {index}");
		}

		#endregion

		#region Ternary Search

		private static void ExecuteTernarySearch()
		{
			var array = new int[] { 1, 3, 4, 8, 14, 21 };
			var item = 4;
			Console.WriteLine($"Array - {string.Join(",", array)}");
			Console.WriteLine($"Ternary Search - {item}");
			var algo = new TernarySearch();
			var index = algo.Search(array, item);
			Console.WriteLine($"Item {item} present at index- {index}");
		}

		#endregion

		#region Jump Search

		private static void ExecuteJumpSearch()
		{
			var array = new int[] { 1, 3, 4, 8, 14, 21 };
			var item = 40;
			Console.WriteLine($"Array - {string.Join(",", array)}");
			Console.WriteLine($"Jump Search - {item}");
			var algo = new JumpSearch();
			var index = algo.Search(array, item);
			Console.WriteLine($"Item {item} present at index- {index}");
		}

		#endregion

		#region Exponential Search

		private static void ExecuteExponentialSearch()
		{
			var array = new int[] { 1, 3, 4, 8, 14, 21 };
			var item = 87;
			Console.WriteLine($"Array - {string.Join(",", array)}");
			Console.WriteLine($"Exponential Search - {item}");
			var algo = new ExponentialSearch();
			var index = algo.Search(array, item);
			Console.WriteLine($"Item {item} present at index- {index}");
		}

		#endregion

		#endregion
	}
}
