namespace Algorithms.Sorting
{
	/// <summary>
	/// Counts the number of times the given value is present.
	/// When to use:
	/// - Values are positive integers.
	/// - Most of the values in the range are present. For eg. Not suitable when array consist [ 1, 3, 15000(k)].
	/// Time Complexity: O(n+k) => O(n)
	/// Space Complexity: O(k)
	/// </summary>
	public class CountingSort
	{
		public void Sort(int[] array, int max)
		{
			int[] counts = new int[max + 1];
			foreach (var item in array)
				counts[item]++;

			var k = 0;
			for (int i = 0; i < counts.Length; i++)
				for (int j = 0; j < counts[i]; j++)
					array[k++] = i;
		}
	}
}
