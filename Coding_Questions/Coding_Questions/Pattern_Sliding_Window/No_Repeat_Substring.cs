using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class No_Repeat_Substring
    {
        public void Start()
        {
            string input = "abccde";

            HashSet<char> hs = new HashSet<char>();
            int i = 0;
            int j = 0;
            int max = 0;

            while(j < input.Length)
            {
                if(!hs.Contains(input[j]))
                {
                    hs.Add(input[j]);
                    max = Math.Max(max, j - i+1);
                    j++;
                }
                else
                {
                    hs.Remove(input[i]);
                    i++;
                }
            }
        }

        /*
         * 
         Problem Statement 
Given a string, find the length of the longest substring which has no repeating characters.
Example 1:
Input: String="aabccbb"
Output: 3
Explanation: The longest substring without any repeating characters is "abc".
Example 2:
Input: String="abbbb"
Output: 2
Explanation: The longest substring without any repeating characters is "ab".
Example 3:
Input: String="abccde"
Output: 3
Explanation: Longest substrings without any repeating characters are "abc" & "cde".
         
         
         
         */

    }
}
