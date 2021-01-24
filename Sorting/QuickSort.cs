namespace Algorithms.Sorting
{
	/// <summary>
	/// Select last element as pivot element, then move all items which are less than pivot element to the left and viceversa
	/// Time Complexity: Best Case: O(nlogn), Worst Case: O(n2)
	/// Space Complexity: Best Case: O(logn), Worst Case: O(n)
	/// </summary>
	public class QuickSort
	{
		public void Sort(int[] array)
		{
			Sort(array, 0, array.Length - 1);
		}

		private void Sort(int[] array, int start, int end)
		{
			if (start >= end) return;

			var boundary = Partition(array, start, end);

			Sort(array, start, boundary - 1);
			Sort(array, boundary + 1, end);
		}

		private int Partition(int[] array, int start, int end)
		{
			var pivot = array[end];
			var boundary = start - 1;
			for (int i = start; i <= end; i++)
				if (array[i] <= pivot)
					Swap(array, i, ++boundary);

			return boundary;
		}

		private void Swap(int[] array, int index1, int index2)
		{
			var temp = array[index1];
			array[index1] = array[index2];
			array[index2] = temp;
		}
	}
}
