namespace Algorithms.Sorting
{
	/// <summary>
	/// Insertion is like sorting cards, we pick one card and then compare and arrange accordingly.
	/// Complexity: Best Case: O(n), Worst Case: O(n2)
	/// </summary>
	public class InsertionSort
	{
		public void Sort(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				var current = array[i];
				var j = i - 1;
				while(j >= 0 && array[j] > current)
				{
					array[j + 1] = array[j];
					j--;
				}
				array[j + 1] = current;
			}
		}
	}
}
