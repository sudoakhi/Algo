﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Arrays.LongestSubArrayWithSum
{
    internal static class Runner
    {
        public static void Run()
        {
            //This should return [4,8]
            int[] array = [1,2,3,4,3,3,1,2,1,2];
            var targetSum = 10;
            var longestSumArrayWithSum = Algorithm.FindLongestSubArrayWithSum(array, targetSum);
            Console.WriteLine(string.Join(", ", longestSumArrayWithSum));
            
            //This should return []
            int[] array2 = [1, 2, 3];
            targetSum = 10;
            longestSumArrayWithSum = Algorithm.FindLongestSubArrayWithSum(array2, targetSum);
            Console.WriteLine(string.Join(", ", longestSumArrayWithSum));

            //This should return [0,0]
            int[] array3 = [10];
            targetSum = 10;
            longestSumArrayWithSum = Algorithm.FindLongestSubArrayWithSum(array3, targetSum);
            Console.WriteLine(string.Join(", ", longestSumArrayWithSum));

            //This should return [0, 0]
            int[] array4 = [0];
            targetSum = 0;
            longestSumArrayWithSum = Algorithm.FindLongestSubArrayWithSum(array4, targetSum);
            Console.WriteLine(string.Join(", ", longestSumArrayWithSum));
        }
    }
}
