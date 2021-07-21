using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class Longest_SubArray_Ones
    {
        public void Start()
        {
            int[] arr = new int[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1 };
            int j = 0;
            int i = 0;
            int k = 2;

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    k--;

                if(k < 0)
                {
                    if (arr[j] == 0)
                        k++;

                    j++;
                }
            }

            int length = i - j;

        }
    }

//Problem Statement
//Given an array containing 0s and 1s, if you are allowed to replace no more than 
//‘k’ 0s with 1s, find the length of the longest contiguous subarray having all 1s.
//Example 1:
//Input: Array=[0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1], k=2
//Output: 6
//Explanation: Replace the '0' at index 5 and 8 to have the longest contiguous subarray of 1s having length 6.
//Example 2:
//Input: Array=[0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1], k=3
//Output: 9
//Explanation: Replace the '0' at index 6, 9, and 10 to have the longest contiguous subarray of 1s having length 9.
}
