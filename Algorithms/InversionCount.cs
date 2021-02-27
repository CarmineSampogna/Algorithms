using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class InversionCount
	{
		public static (List<int> Items, int Inversions) MergeSortInversions(IEnumerable<int> input)
		{
			if (input == null || input.Count() < 2) return (input.ToList(), 0);
			(int[] a, int[] b) = AlgorithmHelpers.SplitInHalf(input.ToArray());
			(List<int> sortedA, int ai) = MergeSortInversions(a);
			(List<int> sortedB, int bi) = MergeSortInversions(b);
			return Merge(sortedA.ToArray(), sortedB.ToArray(), ai + bi);
		}		

		private static (List<int>, int) Merge(int[] a, int[] b, int inversions)
		{
			try
			{
				int totalInversions = inversions;
				List<int> ret = null;
				if (a is null || a.Length == 0) ret = b.ToList();
				if (b is null || b.Length == 0) ret = a.ToList();

				if (ret != null)
				{
					return (ret, totalInversions);
				}
				else
				{
					ret = new List<int>();
				}

				int i = 0;
				int j = 0;

				while (i < a.Length || j < b.Length)
				{
					//If we're at the end of either list, just use the other list
					if (i == a.Length)
					{
						ret.Add(b[j]);
						j++;
					}
					else if (j == b.Length)
					{
						ret.Add(a[i]);
						i++;
					}
					else
					{
						if (a[i] <= b[j])
						{
							ret.Add(a[i]);
							i++;
						}
						else
						{
							totalInversions += a.Length - i;
							ret.Add(b[j]);
							j++;
						}
					}
				}

				return (ret, totalInversions);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error Merging:  {ex.Message}");
				throw;
			}
		}
	}
}
