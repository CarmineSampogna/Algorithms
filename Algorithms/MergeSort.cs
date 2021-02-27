using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
	public static class MergeSort
	{
		public static List<int> Sort(int[] input)
		{
			if (input == null || input.Length < 2) return input.ToList();
			(int[] h1, int[] h2) = AlgorithmHelpers.SplitInHalf(input.ToArray());
			return Merge(Sort(h1).ToArray(), Sort(h2).ToArray());
		}

		private static List<int> Merge(int[] h1, int[] h2)
		{
			try
			{
				List<int> ret = null;
				if (h1 is null || h1.Length == 0) ret = new List<int>(h2);
				if (h2 is null || h2.Length == 0) ret = new List<int>(h1);

				if (ret != null)
				{
					return ret;
				}
				else
				{
					ret = new List<int>();
				}

				int i = 0;
				int j = 0;

				while (i < h1.Length || j < h2.Length)
				{
					//If we're at the end of either list, just use the other list
					if (i == h1.Length)
					{
						ret.Add(h2[j]);
						j++;
					}
					else if (j == h2.Length)
					{
						ret.Add(h1[i]);
						i++;
					}
					else
					{
						if (h1[i] < h2[j])
						{
							ret.Add(h1[i]);
							i++;
						}
						else
						{
							ret.Add(h2[j]);
							j++;
						}
					}
				}

				return ret;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error Merging:  {ex.Message}");
				throw;
			}
		}
	}
}
