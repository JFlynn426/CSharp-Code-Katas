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
        public static class Kata3
        {
            public static int ArrayPlusArray(int[] arr1, int[] arr2)
            {
                return arr1.Sum() + arr2.Sum();
            }
        }
        class Kata4
        {
            public static string WorkNeeded(int projectMinutes, int[][] freelancers)
            {
                var freelancerTime = 0;
                for (int i = 0; i < freelancers.Length; i++)
                {
                    freelancerTime += freelancers[i][0] * 60;
                    freelancerTime += freelancers[i][1];
                }
                var myTime = projectMinutes - freelancerTime;
                if (myTime > 0)
                {
                    return $"I need to work {myTime / 60} hour(s) and {myTime % 60} minute(s)";
                }
                else
                {
                    return "Easy Money!";
                }
            }
        }
        public class Kata5
        {
            public static string Remove(string s, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (s.IndexOf("!") != -1)
                    {
                        s = s.Remove(s.IndexOf("!"), 1);
                    }
                }

                return s;
            }
        }
        public class DivisibleNb
        {
            public static bool isDivisible(long n, long x, long y)
            {

                if (n % x == 0 && n % y == 0)
                    return true;
                else
                    return false;
            }
        }
        public class Evaporator
        {

            public static int evaporator(double content, double evap_per_day, double threshold)
            {
                double remaining = 100;
                int days = 0;
                while (remaining > threshold)
                {
                    remaining = remaining - remaining * evap_per_day / 100;
                    days++;
                }
                return days;

            }
        }
        class Arge
        {

            public static int NbYear(int p0, double percent, int aug, int p)
            {
                int answer = 0;
                for (int n = 1; p0 < p; n++)
                {
                    p0 = Convert.ToInt32(Math.Floor(p0 + p0 * percent / 100 + aug));
                    answer = n;
                }
                return answer;
            }
        }
        public class Kata9
        {
            public static int FindMissing(List<int> list)
            {
                var answer = 0;
                var differences = new List<int>() { list[2] - list[1], list[1] - list[0] };
                for (int x = 0; x < list.Count - 1; x++)
                {
                    if (list[x] + differences.Min() != list[x + 1])
                    {
                        answer = list[x] + differences.Min();
                    }
                }
                return answer;

            }
        }
        class AreTheySame
        {
            public static bool comp(int[] a, int[] b)
            {
                if ((a == null) || (b == null))
                {
                    return false;
                }

                int[] copy = a.Select(x => x * x).ToArray();
                Array.Sort(copy);
                Array.Sort(b);

                return copy.SequenceEqual(b);
            }
        }
        public class Consecutives
        {
            public static List<int> SumConsecutives(List<int> s)
            {
                List<int> answer = new List<int>();
                int last = s[0], sum = 0;
                foreach (int i in s)
                {
                    if (i == last) sum += last;
                    else
                    {
                        answer.Add(sum);
                        sum = last = i;
                    }
                }
                answer.Add(sum);
                return answer;
            }

        }
    }
}