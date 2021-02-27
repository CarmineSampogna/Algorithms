namespace Algorithms
{
	public static class AlgorithmHelpers
	{
		public static (int[], int[]) SplitInHalf(int[] input)
		{
			int middle = input.Length / 2;

			int[] h1 = input[..middle];
			int[] h2 = input[middle..];

			return (h1, h2);
		}
	}
}
