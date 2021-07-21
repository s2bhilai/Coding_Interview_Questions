using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class Maximum_sum_subarray
    {
        public void Start()
        {
            int[] arr = new int[] { 2, 3, 4, 1, 5 };
            int k = 2;
            int j = 0;int i = 0;
            int sum = 0;
            int maxCount = 0;

            while(i < arr.Length)
            {
                //compute initial sum
                while(i < k)
                {
                    sum += arr[i];
                    i++;
                    maxCount = sum;
                }

                //Slide thru array
                sum = sum - arr[j];             
                sum = sum + arr[i];

                maxCount = Math.Max(maxCount, sum);
                i++; j++;
            }
        }
        //Problem Statement #
        //Given an array of positive numbers and a positive number ‘k’, 
        //find the maximum sum of 
                //any contiguous subarray of size ‘k’.
        //Example 1:
        //Input: [2, 1, 5, 1, 3, 2], k=3 
        //Output: 9
        //Explanation: Subarray with maximum sum is [5, 1, 3].
        //Example 2:
        //Input: [2, 3, 4, 1, 5], k=2 
        //Output: 7
        //Explanation: Subarray with maximum sum is [3, 4].
    }
}
