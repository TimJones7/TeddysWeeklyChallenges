using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeddysWeeklyChallenges.Season1.TrialWeek
{
    internal class ListSum_MinusMinMax
    {
        [Benchmark]
        public void Benchmark_TIMTWO_One()
        {
            int[] list1 = { 6, 2, 1, 8, 10 };
            int sum = list1[0];
            int min = list1[0];
            int max = list1[0];

            for (int i = 1; i < list1.Length; i++)
            {
                if (list1[i] < min)
                {
                    min = list1[i];
                    sum += list1[i];
                    continue;
                }
                if (list1[i] > max)
                {
                    max = list1[i];
                    sum += list1[i];
                    continue;
                }
                sum += list1[i];
            }
            sum = sum - min - max;
        }

        [Benchmark]
        public void Benchmark_TIMTWO_Two()
        {
            int[] list1 = { 1, 1, 11, 2, 3 };
            int sum = list1[0];
            int min = list1[0];
            int max = list1[0];

            for (int i = 1; i < list1.Length; i++)
            {
                if (list1[i] < min)
                {
                    min = list1[i];
                    sum += list1[i];
                    continue;
                }
                if (list1[i] > max)
                {
                    max = list1[i];
                    sum += list1[i];
                    continue;
                }
                sum += list1[i];
            }
            sum = sum - min - max;
        }

        [Benchmark]
        public void Benchmark_TIMTWO_Three()
        {
            int[] list1 = { 68, 2, 1, 68, 50 };
            int sum = list1[0];
            int min = list1[0];
            int max = list1[0];

            for (int i = 1; i < list1.Length; i++)
            {
                if (list1[i] < min)
                {
                    min = list1[i];
                    sum += list1[i];
                    continue;
                }
                if (list1[i] > max)
                {
                    max = list1[i];
                    sum += list1[i];
                    continue;
                }
                sum += list1[i];
            }
            sum = sum - min - max;
        }

        [Benchmark]
        public void Benchmark_SOUP_One()
        {
            int[] list1 = { 6, 2, 1, 8, 10 };

            Array.Sort(list1);
            ArraySegment<int> nums = new(list1, 1, list1.Length - 2);
            int sum = default;
            foreach (var n in nums)
            {
                sum += n;
            }
        }

        [Benchmark]
        public void Benchmark_SOUP_Two()
        {
            int[] list1 = { 1, 1, 11, 2, 3 };
            Array.Sort(list1);
            ArraySegment<int> nums = new(list1, 1, list1.Length - 2);
            int sum = default;
            foreach (var n in nums)
            {
                sum += n;
            }
        }

        [Benchmark]
        public void Benchmark_SOUP_Three()
        {
            int[] list1 = { 68, 2, 1, 68, 50 };
            Array.Sort(list1);
            ArraySegment<int> nums = new(list1, 1, list1.Length - 2);
            int sum = default;
            foreach (var n in nums)
            {
                sum += n;
            }
        }

        [Benchmark]
        public void Benchmark_SHADY_One()
        {
            int[] list1 = { 6, 2, 1, 8, 10 };

            int x = list1.Sum() - list1.Min() - list1.Max();
        }

        [Benchmark]
        public void Benchmark_SHADY_Two()
        {
            int[] list1 = { 1, 1, 11, 2, 3 };
            int x = list1.Sum() - list1.Min() - list1.Max();
        }

        [Benchmark]
        public void Benchmark_SHADY_Three()
        {
            int[] list1 = { 68, 2, 1, 68, 50 };
            int x = list1.Sum() - list1.Min() - list1.Max();
        }
    }
}
