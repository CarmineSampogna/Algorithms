using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Test
{
	[TestClass]
	public class MergeSortTests
	{
		[TestMethod]
		public void EmptyListsTest()
		{
			int[] input = new int[0] ;
			var output = MergeSort.Sort(input);
			Assert.IsNotNull(output);
			Assert.IsTrue(output.Count == 0);
		}

		[TestMethod]
		public void SingleItemTest()
		{
			int[] input = new[] { 1 };
			var output = MergeSort.Sort(input);
			Assert.IsNotNull(output);
			Assert.IsTrue(output.Count == 1);
			Assert.IsTrue(output[0] == 1);
		}

		[TestMethod]
		public void SimpleItemTest()
		{
			int[] input = new [] { 2, 1 };
			var output = MergeSort.Sort(input);
			Array.Sort(input);
			Assert.IsNotNull(output);
			Assert.IsTrue(output.Count == 2);
			for (int i = 0; i < output.Count; i++)
			{
				Assert.IsTrue(input[i] == output[i]);
				Console.Write(output[i]);
			}
		}

		[TestMethod]
		public void LargerTest()
		{
			int count = 10000000;
			List<int> input = GetRandomList(count);
			var output = MergeSort.Sort(input.ToArray());
			input.Sort();
			Assert.IsNotNull(output);
			Assert.IsTrue(output.Count == count);
			for (int i = 0; i < output.Count; i++)
			{
				Assert.IsTrue(input[i] == output[i]);
				Console.Write(output[i]);
			}
		}

		private List<int> GetRandomList(int length)
		{
			List<int> output = new List<int>();
			for (int i = 0; i < length; i++)
			{
				output.Add(new Random(i).Next());
			}
			return output;
		}
	}
}
