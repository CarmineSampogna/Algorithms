using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public static class MergeSort
	{
		public static List<int> Sort(List<int> input)
		{
			if (input == null || input.Count < 2) return input;
			var (h1, h2) = SplitInHalf(input);
			return Merge(Sort(h1), Sort(h2));
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


		private static List<int> Merge(List<int> h1, List<int> h2)
		{
			try
			{
				List<int> ret = null;
				if (h1 is null || h1.Count == 0) ret = h2;
				if (h2 is null || h2.Count == 0) ret = h1;

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

				do
				{
					//If we're at the end of either list, just use the other list
					if (i == h1.Count)
					{
						ret.Add(h2[j]);
						j++;
					}
					else if (j == h2.Count)
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
				} while (i < h1.Count || j < h2.Count);

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
