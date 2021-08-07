using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class SubArray_Product_lessthan_k
    {
        public void Start()
        {
			int[] nums = new int[] { 8, 2, 6, 5 };
			int k = 50;

			int result = 0;
			int prod = 1;

			int left = 0;
			int right = 0;

			while (right < nums.Length)
			{
				prod = prod * nums[right];

				while (prod >= k)
				{
					prod = prod / nums[left];
					left++;
				}

				result += right - left + 1;

				right++;

			}
		}


        /*
         Given an array with positive numbers and a target number, 
        find all of its contiguous subarrays whose product is less than the target number.
        Example 1:
        Input: [2, 5, 3, 10], target=30 
        Output: [2], [5], [2, 5], [3], [5, 3], [10]
        Explanation: There are six contiguous subarrays whose product is less than the target.
        Example 2:
        Input: [8, 2, 6, 5], target=50 
        Output: [8], [2], [8, 2], [6], [2, 6], [5], [6, 5] 
        Explanation: There are seven contiguous subarrays whose product is less than the target. 
         */
    }
}
