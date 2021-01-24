namespace Algorithms.Searching
{
	/// <summary>
	/// Divide and conquer, array should be already sorted.
	/// Time Complexity: O(logn)
	/// Space Complexity: O(logn)
	/// </summary>
	public class BinarySearch
	{
		public int Search(int[] array, int target)
		{
			// return BinarySearchRecursive(array, target, 0, array.Length - 1);
			return BinarySearchIterative(array, target);
		}

		public int BinarySearchRecursive(int[] array, int target, int left, int right)
		{
			if (right < left) return -1;

			var middle = (left + right) / 2;

			if (array[middle] == target) return middle;

			if (target < array[middle]) return BinarySearchRecursive(array, target, left, middle - 1);

			else return BinarySearchRecursive(array, target, middle + 1, right);
		}

		private int BinarySearchIterative(int[] array, int target)
		{
			int left = 0;
			int right = array.Length - 1;

			while(left <= right)
			{
				var middle = (left + right) / 2;

				if (array[middle] == target) return middle;

				if (target < array[middle]) right = middle - 1;
				else left = middle + 1;
			}
			return -1;
		}
	}
}
