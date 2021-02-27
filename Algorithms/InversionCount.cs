using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class InversionCount
	{
		public static (List<int>, int) MergeSortInversions(List<int> input)
		{
			if (input == null || input.Count < 2) return (input, 0);
			var (a, b) = SplitInHalf(input);
			var (sortedA, ai) = MergeSortInversions(a);
			var (sortedB, bi) = MergeSortInversions(b);
			return Merge(sortedA, sortedB, ai + bi);
		}

		private static (List<int>, List<int>) SplitInHalf(List<int> input)
		{
			List<int> h1 = new List<int>();
			List<int> h2 = new List<int>();
			for (int i = 0; i < input.Count / 2; i++)
			{
				h1.Add(input[i]);
			}

			for (int j = input.Count / 2; j < input.Count; j++)
			{
				h2.Add(input[j]);
			}

			return (h1, h2);
		}

		private static (List<int>, int) Merge(List<int> a, List<int> b, int inversions)
		{
			try
			{
				int totalInversions = inversions;
				List<int> ret = null;
				if (a is null || a.Count == 0) ret = b;
				if (b is null || b.Count == 0) ret = a;

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

				do
				{
					//If we're at the end of either list, just use the other list
					if (i == a.Count)
					{
						ret.Add(b[j]);
						j++;
					}
					else if (j == b.Count)
					{
						ret.Add(a[i]);
						i++;
					}
					else
					{
						if (a[i] < b[j])
						{
							ret.Add(a[i]);
							i++;
						}
						else
						{
							totalInversions += a.Count - i;
							ret.Add(b[j]);
							j++;
						}
					}
				} while (i < a.Count || j < b.Count);

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
