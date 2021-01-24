using System;

namespace Algorithms.Searching
{
	/// <summary>
	/// Check the last item if its not equal to target, then increase the range.
	/// Time Complexity: O(logi)
	/// </summary>
	public class ExponentialSearch
	{
		private readonly BinarySearch binarySearch;

		public ExponentialSearch()
		{
			binarySearch = new BinarySearch();
		}

		public int Search(int[] array, int target)
		{
			int bound = 1;
			while (bound < array.Length && array[bound] < target)
				bound *= 2;

			int left = bound / 2;
			int right = Math.Min(bound, array.Length - 1);
			return binarySearch.Search(array, target);
		}
	}
}
