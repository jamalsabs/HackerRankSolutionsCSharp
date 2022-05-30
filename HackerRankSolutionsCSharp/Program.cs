using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutionsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SolveMeFirstSetup();
            SimpleArraySetup();
            CompareTheTripletsSetup();
            AVeryBigSumSetup();
            PlusMinusSetup();


            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        public static void SolveMeFirstSetup()
        {
            int sum = Algorithms.SolveMeFirst(3,4);
            Console.WriteLine($"SolveMeFirst for input 3, 4 = {sum}");
        }

        public static void SimpleArraySetup()
        {
            List<int> ar = new List<int>() { 1,2,3,4 };
            int sum = Algorithms.SimpleArraySum(ar);
            Console.WriteLine($"SimpleArraySum for input array 1,2,3,4 = {sum}");
        }

        public static void CompareTheTripletsSetup()
        {
            int[] alice = new int[3] { 5, 6, 7 };
            int[] bob = new int[3] { 3, 6, 10 };
            List<int> result = Algorithms.CompareTheTriplets(alice, bob);
            Console.WriteLine($"CompareTheTriplets for Alice and Bob, Alice score = {result[0]} Bob score = {result[1]}");
        }

        public static void AVeryBigSumSetup()
        {
            List<long> ar = new List<long>() { 1000000001,1000000002,1000000003,1000000004,1000000005 };
            long sum = Algorithms.aVeryBigSum(ar);
            Console.WriteLine($"aVeryBigSum for input array = {sum}");
        }

        public static void DiagonalDifferenceSetup()
        {
            List<long> ar = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long sum = Algorithms.aVeryBigSum(ar);
            Console.WriteLine($"aVeryBigSum for input array = {sum}");
        }

        public static void PlusMinusSetup()
        {
            int[] ar = { -4,3,-9,0,4,1 };
            Algorithms.PlusMinus(ar.ToList());
        }

    }
}
