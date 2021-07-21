using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class Minimum_Window_Substring
    {
        public void Start()
        {

            string inputString = "aabdec";
            string pattern = "abc";

            int left = 0;
            int right = 0;

            //Find Ideal Window size containing pattern

            int[] patternHash = new int[26];
            int p = 0;
            while(p < pattern.Length)
            {
                patternHash[pattern[p] - 'a']++;
                p++;
            }

            int[] inputStringHash = new int[26];
            int pLen = 0;
            bool patternNotMatched = false;

            while(right < inputString.Length)
            {
                patternNotMatched = true;

                //Find window size containing the pattern then optimize
                inputStringHash[inputString[right] - 'a']++;

                //After each addition, verify if we have covered all chars in input pattern
                pLen = 0;
                while(pLen < pattern.Length)
                {
                    if (inputStringHash[pattern[pLen] - 'a'] == 0)
                    {
                        patternNotMatched = false;
                        break;
                    }
                    pLen++;
                }

                if(!patternNotMatched)
                {
                    right++;
                }

            }

        }


        /*
          Given a string and a pattern, find the smallest substring in the given string which has all the characters of the given pattern.
            Example 1:
            Input: String="aabdec", Pattern="abc"
            Output: "abdec"
            Explanation: The smallest substring having all characters of the pattern is "abdec"
            Example 2:
            Input: String="abdabca", Pattern="abc"
            Output: "abc"
            Explanation: The smallest substring having all characters of the pattern is "abc".
            Example 3:
            Input: String="adcad", Pattern="abc"
            Output: ""
            Explanation: No substring in the given string has all characters of the pattern.



          */

    }
}
