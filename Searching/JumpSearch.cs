using System;

namespace Algorithms.Searching
{
	/// <summary>
	/// Create a block size(sqrt(n)) and then compare last element in the block with the target. 
	/// Time Complexity: O(sqrt(n))
	/// </summary>
	public class JumpSearch
	{
		public int Search(int[] array, int target)
		{
			int blockSize = (int)Math.Sqrt(array.Length);
			int start = 0;
			int next = blockSize - 1;

			while(start < array.Length && array[next - 1] < target)
			{
				start = next;
				next += blockSize;
				if (next > array.Length) next = array.Length;
			}

			for (int i = start; i < next; i++)
				if (array[i] == target) return i;

			return -1;
		}
	}
}
