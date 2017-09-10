using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCodeExamples
{
    class Program
    {
        /// <summary>
        /// Application Entry
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var ans1 = TwoSum(new[] { 3, 3 }, 6);
        }

        /// <summary>
        /// Probrem 1. Two Sum
        /// https://leetcode.com/problems/two-sum/description/
        /// </summary>
        public static int[] TwoSum(int[] nums, int target)
        {
            ///英語
            ///-----------------------------------------------
            ///Given an array of integers, return indices of the two numbers such that they add up to a specific target.
            ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
            ///
            ///日本語訳（意）
            ///-----------------------------------------------
            ///数値の配列から、加算して指定した数値になる２つの数値のインデックスを返却します。
            ///返却するのは１組だけでいいです。また、加算に同じ数字は2回使用できません。
            ///
            ///例
            ///-----------------------------------------------
            ///Given nums = [2, 7, 11, 15], target = 9
            ///return [0, 1]

            return new[] { Array.IndexOf(nums, xxx), Array.IndexOf(nums, target - xxx) };

            //return nums.SelectMany((x, i) =>
            //            nums.Select((y, j) =>
            //            {
            //                if (i != j && x + y == target)
            //                {
            //                    return new[] { i, j };
            //                }
            //                else
            //                    return null;
            //            })
            //        ).First(x => x != null);

            //for(int i = 0; i < nums.Length; i++)
            //    for (int j = 0; j < nums.Length; j++)
            //        if(i != j)
            //            if(nums[i] + nums[j] == target)
            //                return new[] { i, j };

            //return null;
        }
    }
}
