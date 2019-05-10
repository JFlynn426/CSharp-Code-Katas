using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

//KATA #1
namespace CSharp_Code_Katas
{
    class Program
    {
        static void Main(string[] args)
        { }


        public class Kata
        {
            public static int[] SquareOrSquareRoot(int[] array)
            {
                List<int> listOfInts = new List<int>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (Math.Sqrt(array[i]) == Math.Floor(Math.Sqrt(array[i])))
                    {
                        listOfInts.Add(Convert.ToInt32(Math.Sqrt(array[i])));
                    }
                    else
                    {
                        listOfInts.Add(array[i] * array[i]);
                    }

                }
                return listOfInts.ToArray();
            }
        }
        public class KataTests
        {
            [Test]
            public void BasicTests()
            {
                var input = new int[] { 4, 3, 9, 7, 2, 1 };
                var expected = new int[] { 2, 9, 3, 49, 4, 1 };
                Assert.AreEqual(string.Join(",", expected), string.Join(",", Kata.SquareOrSquareRoot(input)));

                input = new int[] { 100, 101, 5, 5, 1, 1 };
                expected = new int[] { 10, 10201, 25, 25, 1, 1 };
                Assert.AreEqual(string.Join(",", expected), string.Join(",", Kata.SquareOrSquareRoot(input)));

                input = new int[] { 1, 2, 3, 4, 5, 6 };
                expected = new int[] { 1, 4, 9, 2, 25, 36 };
                Assert.AreEqual(string.Join(",", expected), string.Join(",", Kata.SquareOrSquareRoot(input)));
            }
        }
        public class NthSeries
        {

            public static string seriesSum(int n)
            {
                double sum = 0;
                if (n == 0)
                {
                    return "0.00";
                }
                else
                {
                    for (double i = 1; i <= n * 3; i += 3)
                    {
                        sum += 1 / i;
                    }
                }
                return sum.ToString("F");
            }
        }
        [TestFixture]
        public class NthSeriesTests
        {

            [Test]
            public void Test1()
            {
                Assert.AreEqual("0.00", NthSeries.seriesSum(0));
            }
            [Test]
            public void Test2()
            {
                Assert.AreEqual("1.77", NthSeries.seriesSum(9));
            }

        }

    }
}