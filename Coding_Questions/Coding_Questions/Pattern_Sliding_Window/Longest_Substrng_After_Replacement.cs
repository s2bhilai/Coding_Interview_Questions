using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class Longest_Substrng_After_Replacement
    {
        public void Start()
        {
            string s = "AABCCBB";//AABABBA(1)
            int k = 2;

            int[] char_counts = new int[26];

            int window_start = 0;
            int max_length = 0;
            int max_count = 0;

            for (int window_end = 0; window_end < s.Length; window_end++)
            {
                char_counts[s[window_end] - (int)'A']++;

                int current_char_count = char_counts[s[window_end] - (int)'A']; // computing occurence of each character

                max_count = Math.Max(max_count, current_char_count);

                while(window_end - window_start - max_count + 1 > k) // checking the remaining values which can be replaced. If > 1 slide
                {
                    char_counts[s[window_start] - (int)'A']--; // shrink the window from beginning
                    window_start++;
                }

                max_length = Math.Max(max_length, window_end - window_start + 1);
            }

        }
    }



//Problem Statement
//Given a string with lowercase letters only, if you are allowed to replace 
    //no more than ‘k’ letters with any letter, 
    //find the length of the longest substring having the same letters after replacement.
//Example 1:
//Input: String= "aabccbb", k= 2 
//Output: 5
//Explanation: Replace the two 'c' with 'b' to have a longest repeating substring "bbbbb".
//Example 2:
//Input: String= "abbcb", k= 1
//Output: 4
//Explanation: Replace the 'c' with 'b' to have a longest repeating substring "bbbb".
//Example 3:
//Input: String= "abccde", k= 1
//Output: 3
//Explanation: Replace the 'b' or 'd' with 'c' to have the longest repeating substring "ccc".

}
