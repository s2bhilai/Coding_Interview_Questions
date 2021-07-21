﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class Permutation_String
    {

        public void Start()
        {
            string sourceString = "bcdxabcdy";
            string pattern = "bcdyabcdx";

            //Calculate Hash of Pattern

            int[] patternHash = new int[26];
            int[] sourceHash = new int[26];
            int p = 0;
            while(p < pattern.Length)
            {
                sourceHash[sourceString[p] - 'a'] += 1;
                patternHash[pattern[p] - 'a'] += 1;
                
                p++;
            }

            p--;
            //Compute hash of source string
           
            int s = 0;
            bool result = false;

            while(p < sourceString.Length)
            {
                if (patternHash.SequenceEqual(sourceHash))
                {
                    result = true; break;
                }  
                else
                {
                    p++;
                    if (p != sourceString.Length)
                        sourceHash[sourceString[p] - 'a'] += 1;

                    sourceHash[sourceString[s] - 'a'] -= 1;
                    s++;
                }
            }
        }


        /*
   
        Problem Challenge 1
        Permutation in a String (hard) 
        Given a string and a pattern, find out if the string contains any permutation of the pattern.
        Permutation is defined as the re-arranging of the characters of the string. 
        For example, “abc” has the following six permutations:
        abc
        acb
        bac
        bca
        cab
        cba
        If a string has ‘n’ distinct characters it will have n!n! permutations.
        Example 1:
        Input: String="oidbcaf", Pattern="abc"
        Output: true
        Explanation: The string contains "bca" which is a permutation of the given pattern.
        Example 2:
        Input: String="odicf", Pattern="dc"
        Output: false
        Explanation: No permutation of the pattern is present in the given string as a substring.
        Example 3:
        Input: String="bcdxabcdy", Pattern="bcdyabcdx"
        Output: true
        Explanation: Both the string and the pattern are a permutation of each other.
        Example 4:
        Input: String="aaacb", Pattern="abc"
        Output: true
        Explanation: The string contains "acb" which is a permutation of the given pattern.
         
         
         */

    }
}
