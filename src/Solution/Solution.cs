﻿using System;
using System.Linq;

namespace Solution
{
    /*
    Suppose an array sorted in ascending order is rotated at
    some pivot unknown to you beforehand.

    (i.e.,  [0,1,2,4,5,6,7] might become  [4,5,6,7,0,1,2]).

    Find the minimum element.

    You may assume no duplicate exists in the array.
    */
    public interface ISolution
    {
        int FindMin(int[] nums);
    }

    public class NaiveSolution : ISolution
    {
        public int FindMin(int[] nums)
        {
            int min = nums[0];

            foreach (var num in nums)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }

    public class LinqSolution : ISolution
    {
        public int FindMin(int[] nums) => nums.Min();
    }

    public class SlidingWindowSolution : ISolution
    {
        public int FindMin(int[] nums)
        {
            var (min, startIndex, endIndex) = (nums[0], 0, nums.Length - 1);

            while (startIndex < endIndex)
            {
                int midIndex = startIndex + ((endIndex - startIndex) / 2);

                (min, startIndex, endIndex) = (nums[startIndex], nums[midIndex], nums[endIndex]) switch
                {
                    var (startValue, middleValue, endValue)
                        when startValue < middleValue && startValue < endValue
                            => (startValue, startIndex, midIndex - 1),

                    var (_, middleValue, endValue)
                        when middleValue < endValue
                            => (middleValue, startIndex, midIndex - 1),

                    var (_, _, endValue)
                        => (endValue, midIndex + 1, endIndex),
                };
            }

            return min;
        }
    }
}
