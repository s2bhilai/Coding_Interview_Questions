using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class Longest_substrng_k_Distinct
    {
        public void Start()
        {
            string inputString = "cbbebi";
            int k = 3;
            int startIndex = 0;
            int endIndex = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            int max = 0;

            while(endIndex < inputString.Length)
            {
                if(!dict.ContainsKey(inputString[endIndex]))
                {
                    dict.Add(inputString[endIndex], endIndex);
                    k--;  // For New Element
                }
                else
                {
                    //Update Index
                    dict[inputString[endIndex]]++;
                }

                //shrink the window
                while(k < 0)
                {
                    if(dict[inputString[startIndex]] == startIndex)
                    {
                        k += 1;
                        dict.Remove(inputString[startIndex]);
                    }

                    startIndex += 1;
                }


                max = Math.Max(max, endIndex - startIndex + 1);

                endIndex++;
            }


        }


//        Problem Statement #
//Given a string, find the length of the longest substring in it with no more than K distinct characters.
//Example 1:
//Input: String= "araaci", K= 2
//Output: 4
//Explanation: The longest substring with no more than '2' distinct characters is "araa".
//Example 2:
//Input: String= "araaci", K= 1
//Output: 2
//Explanation: The longest substring with no more than '1' distinct characters is "aa".
//Example 3:
//Input: String= "cbbebi", K= 3
//Output: 5
//Explanation: The longest substrings with no more than '3' distinct characters are "cbbeb" & "bbebi".
    }
}
