using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutionsCSharp
{
    internal class Algorithms
    {
		public static int SolveMeFirst(int a, int b)
		{
			/*
			 * Complete the function solveMeFirst to compute the sum of two integers.
			 */

			return a + b;
		}

		public static int SimpleArraySum(List<int> ar)
        {
			/*
			 * For example, if the array ar =[1,2,3],1 + 2 + 3 = 6, so return 6.
			 */

			int sum = 0;
			for (int i = 0; i < ar.Count; i++)
				sum += ar[i];
			return sum;
        }

		public static List<int> CompareTheTriplets(int[] a, int[] b)
        {
			/*
			 * Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges,
			 * awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.
			 * The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).
			 * The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].
			 * If a[i] > b[i], then Alice is awarded 1 point.
			 * If a[i] < b[i], then Bob is awarded 1 point.
			 * If a[i] = b[i], then neither person receives a point.
			 * Comparison points is the total points a person earned.
			 * Given a and b, determine their respective comparison points.
			*/

			List<int> result = new List<int> { 0, 0 };

            for (int i = 0; i < 3; i++)
            {
				if (a[i] > b[i])
					result[0]++;
				else if (a[i] < b[i])
					result[1]++;
			}
			return result;
		}

		public static long aVeryBigSum(List<long> ar)
        {
			/*
			 *In this challenge, you are required to calculate and 
			 *print the sum of the elements in an array,
			 *keeping in mind that some of those integers may be quite large.
			 */

			long sum = 0;
			for (int i = 0; i < ar.Count; i++)
				sum += ar[i];
			
			return sum;
		}

		public static int DiagonalDifference(List<List<int>> ar)
		{
			/*
			 *Given a square matrix,
			 *calculate the absolute difference between the sums of its diagonals.
			 */

			int sum = 0;
			int columncounter = 0;
			int rowcounter = 0;
            while (true)
            {
				sum += ar[rowcounter][columncounter];
				rowcounter++;
				columncounter++;
            }
		}

		/*
		 * Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
		 * Print the decimal value of each fraction on a new line with  places after the decimal.
		 */
		public static void PlusMinus(List<int> arr)
		{
			decimal poscount = 0;
			decimal negcount = 0;
			decimal zerocount = 0;
			decimal arrsize = arr.Count;
			for (int i = 0; i < arr.Count; i++)
			{
				if (arr[i] > 0)
					poscount++;
				else if (arr[i] < 0)
					negcount++;
				else
					zerocount++;
			}
			decimal posratio = (poscount / arrsize);
			decimal negratio = (negcount / arrsize);
			decimal zeroratio = (zerocount / arrsize);
			Console.WriteLine(posratio.ToString("N6"));
			Console.WriteLine(negratio.ToString("N6"));
			Console.WriteLine(zeroratio.ToString("N6"));
		}

	}
}
