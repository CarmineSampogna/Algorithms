using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Test
{
	[TestClass]
	public class InversionCountTest
	{

		[TestMethod]
		public void SimpleItemTest()
		{
			List<int> input = new List<int>() { 2, 1 };
			var output = InversionCount.MergeSortInversions(input);
			input.Sort();
			Assert.IsNotNull(output);
			//Assert.IsTrue(output.Count == 2);
			//for (int i = 0; i < output.Count; i++)
			//{
			//	Assert.IsTrue(input[i] == output[i]);
			//	Console.Write(output[i]);
			//}
		}

		[TestMethod]
		public void BiggerTest()
		{
			List<int> input = new List<int>() { 1, 3, 7, 5, 2, 4, 6, 8 };
			var output = InversionCount.MergeSortInversions(input);
			input.Sort();
			Assert.IsNotNull(output);
			//Assert.IsTrue(output.Count == 2);
			//for (int i = 0; i < output.Count; i++)
			//{
			//	Assert.IsTrue(input[i] == output[i]);
			//	Console.Write(output[i]);
			//}
		}

	}
}
