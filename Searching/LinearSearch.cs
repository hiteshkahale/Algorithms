namespace Algorithms.Searching
{
	/// <summary>
	/// Search item from start to end.
	/// Complexity: Best Case: O(1), Worst Case: O(n)
	/// </summary>
	public class LinearSearch
	{
		public int Search(int[] array, int target)
		{
			for (int i = 0; i < array.Length; i++)
				if (array[i] == target) return i;
			return -1;
		}
	}
}
