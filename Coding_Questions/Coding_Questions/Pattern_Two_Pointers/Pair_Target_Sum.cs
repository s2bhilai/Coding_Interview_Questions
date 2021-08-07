using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class Pair_Target_Sum
    {
        public void Start()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 6 };
            int target = 6;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                dict.Add(arr[i], i);
            }

            int right = 0;

            int firstIndex = 0;
            int LastIndex = 0;

            while (right < arr.Length)
            {
                int diff = target - arr[right];

                if (dict.ContainsKey(diff))
                {
                    firstIndex = right;
                    LastIndex = dict[diff];
                    break;
                }

                right++;
            }

        }

        /*
         Given an array of sorted numbers and a target sum, 
        find a pair in the array whose sum is equal to the given target.
        Write a function to return the indices of the two numbers (i.e. the pair) 
        such that they add up to the given target.

        Example 1:
        Input: [1, 2, 3, 4, 6], target=6
        Output: [1, 3]
        Explanation: The numbers at index 1 and 3 add up to 6: 2+4=6
        Example 2:
        Input: [2, 5, 9, 11], target=11
        Output: [0, 2]
        Explanation: The numbers at index 0 and 2 add up to 11: 2+9=11

         */

    }
}
