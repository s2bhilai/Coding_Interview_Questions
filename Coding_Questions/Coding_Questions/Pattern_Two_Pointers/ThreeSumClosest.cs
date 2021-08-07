using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class ThreeSumClosest
    {
        public void Start()
        {
            int[] nums = new int[] { -1, 2, 1, -4 };
            int target = -1;

            int result = nums[0] + nums[1] + nums[nums.Length - 1];

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int a_pointer = i + 1;
                int b_pointer = nums.Length - 1;

                while (a_pointer < b_pointer)
                {
                    int current_sum = nums[i] + nums[a_pointer] + nums[b_pointer];

                    if (current_sum > target)
                        b_pointer -= 1;
                    else
                        a_pointer += 1;

                    if (Math.Abs(current_sum - target) < Math.Abs(result - target))
                        result = current_sum;
                }
            }
        }


        /*
         Problem Statement 
        Given an array of unsorted numbers and a target number, 
        find a triplet in the array whose sum is as close to the target number 
        as possible, return the sum of the triplet. 
        If there are more than one such triplet, 
        return the sum of the triplet with the smallest sum.
        Example 1:
        Input: [-2, 0, 1, 2], target=2
        Output: 1
        Explanation: The triplet [-2, 1, 2] has the closest sum to the target.
        Example 2:
        Input: [-3, -1, 1, 2], target=1
        Output: 0
        Explanation: The triplet [-3, 1, 2] has the closest sum to the target.
        Example 3:
        Input: [1, 0, 1, 1], target=100
        Output: 3
        Explanation: The triplet [1, 1, 1] has the closest sum to the target.
         */
    }
}
