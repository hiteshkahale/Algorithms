using System.Collections.Generic;

namespace Algorithms.Sorting
{
	/// <summary>
	/// Allocates number of bucket(say k) and put the values into the bucket.
	/// Time Complexity: Best Case: O(1), Worst Case: O(n2) depends on sorting algorithm used.
	/// Space Complexity: O(n+k)
	/// </summary>
	public class BucketSort
	{
		public void Sort(int[] array, int numberOfBuckets)
		{
			var i = 0;
			foreach (var bucket in CreateBuckets(array, numberOfBuckets))
			{
				bucket.Sort();
				foreach (var item in bucket) array[i++] = item;
			}
		}

		private List<List<int>> CreateBuckets(int[] array, int numberOfBuckets)
		{
			var buckets = new List<List<int>>();
			for (int i = 0; i < numberOfBuckets; i++)
				buckets.Add(new List<int>());

			foreach (var item in array)
				buckets[item/numberOfBuckets].Add(item);

			return buckets;
		}
	}
}
