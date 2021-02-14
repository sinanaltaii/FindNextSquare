using System;

namespace FindNextSquare
{
	class Program
	{
		static void Main(string[] args)
		{
			var result = FindNextSquare(15241383936L);
			Console.WriteLine(result);
		}

		static long FindNextSquare(long num)
		{

			if (!IsNotPerfectQuareItSelf(num))
			{
				return -1;
			}

			// find the square root of given N
			var sqrtOfN = Math.Sqrt(num);

			// Get the lowest or equal integer of the result
			var floor = (long)Math.Floor(sqrtOfN);

			// Add 1 to the result of floor
			floor++;
			long nextPerfectSquare = floor * floor;
			return nextPerfectSquare;
		}

		private static bool IsNotPerfectQuareItSelf(long num)
		{
			var sqrt  = Math.Sqrt(num);
			var squared = Math.Ceiling(sqrt) * Math.Ceiling(sqrt);
			return (long)squared == num;
		}
	}
}
