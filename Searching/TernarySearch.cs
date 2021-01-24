using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
	/// <summary>
	/// Divide the array into 3.
	/// Time and Space complexity: O(log3n)
	/// Binary search is faster than ternary search, because ternary requires more comparison as compared to binary search.
	/// </summary>
	public class TernarySearch
	{
		public int Search(int[] array, int target)
		{
			return LinearSearchRecursive(array, target, 0, array.Length - 1);
		}

		private int LinearSearchRecursive(int[] array, int target, int left, int right)
		{
			if (left > right) return -1;

			int partitionSize = (right - left) / 3;
			int mid1 = left + partitionSize;
			int mid2 = right - partitionSize;

			if (array[mid1] == target) return mid1;

			if (array[mid2] == target) return mid2;

			if (target < array[mid1]) LinearSearchRecursive(array, target, left, mid1 - 1);

			if (target > array[mid2]) LinearSearchRecursive(array, target, mid1 + 1, right);

			return LinearSearchRecursive(array, target, mid1 + 1, mid2 - 1);
		}
	}
}
