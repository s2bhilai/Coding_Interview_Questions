using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class Remove_Duplicates
    {
        public void Start()
        {
            int[] nums = new int[] { 2, 2, 2, 11 };


            int index = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[index] = nums[i + 1];
                    index++;
                }
            }
        }

        /*
         Given an array of sorted numbers, remove all duplicates from it.
        You should not use any extra space; 
        after removing the duplicates in-place return the new length of the array.
        Example 1:
        Input: [2, 3, 3, 3, 6, 9, 9]
        Output: 4
        Explanation: The first four elements after removing the duplicates will be [2, 3, 6, 9].
        Example 2:
        Input: [2, 2, 2, 11]
        Output: 2
        Explanation: The first two elements after removing the duplicates will be [2, 11]. 
         */
    }
}
