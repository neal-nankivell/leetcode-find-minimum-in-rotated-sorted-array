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

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            return min;
        }
    }
}
