using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class Smallest_SubArray_Given_Sum
    {
        public void Start()
        {

            int[] inputArray = new int[] { 3, 4, 1, 1, 6 };
            int S = 8;

            int left = 0;
            int right = 0;
            int tempSum = 0;
            int minLength = Int32.MaxValue;

            while(right < inputArray.Length)
            {
                tempSum += inputArray[right];

                if(tempSum >= S)
                {
                    while(left <= right && tempSum >= S)
                    {
                        minLength = Math.Min(minLength, right - left + 1);

                        tempSum -= inputArray[left];
                        left++;
                    }                    
                }

                right++;
            }


        }


        /*
         Problem Statement 
            Given an array of positive numbers and a positive number ‘S’, 
           find the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’.
            Return 0, if no such subarray exists.
            Example 1:
            Input: [2, 1, 5, 2, 3, 2], S=7 
            Output: 2
            Explanation: The smallest subarray with a sum great than or equal to '7' is [5, 2].
            Example 2:
            Input: [2, 1, 5, 2, 8], S=7 
            Output: 1
            Explanation: The smallest subarray with a sum greater than or equal to '7' is [8].
            Example 3:
            Input: [3, 4, 1, 1, 6], S=8 
            Output: 3
            Explanation: Smallest subarrays with a sum greater than or equal to '8' are [3, 4, 1] or [1, 1, 6].
         */
    }
}
