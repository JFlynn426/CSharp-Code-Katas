using System;
using System.Collections.Generic;
using System.Linq;
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
        public static class Kata1
        {
            public static int СenturyFromYear(int year)
            {
                return Convert.ToInt32(Math.Ceiling(Convert.ToDouble(year) / 100));
            }
        }
        
    }

}
