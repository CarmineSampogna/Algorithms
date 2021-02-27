using System;

namespace Algorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var merged = MergeSort.Sort(new System.Collections.Generic.List<int> { 2, 1 });
			Console.WriteLine(merged.ToString());
		}
	}
}
