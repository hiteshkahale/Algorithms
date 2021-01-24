namespace Algorithms.Sorting
{
	/// <summary>
	/// Each pass gives the smallest number at first index. Divides the array into- sorted and unsorted.
	/// Complexity: Best Case: O(n2), Worst Case: O(n2)
	/// </summary>
	public class SelectionSort
	{
		public void Sort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				var minIndex = i;
				for (int j = i; j < array.Length; j++)
					if (array[j] < array[minIndex]) minIndex = j;
				Swap(array, minIndex, i);
			}
		}

		private void Swap(int[] array, int index1, int index2)
		{
			var temp = array[index1];
			array[index1] = array[index2];
			array[index2] = temp;
		}
	}
}
