using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class string_anagram
    {
        public void Start()
        {
            string inputString = "abbcabc";
            string pattern = "abc";

            //Create 2 hashes
            int[] patternHash = new int[26];
            int[] inputStringHash = new int[26];

            int startpointer = 0;
            int endpointer = 0;
            List<int> positionCounter = new List<int>();

            while(endpointer < pattern.Length)
            {
                patternHash[pattern[endpointer] - 'a']++;
                inputStringHash[inputString[endpointer] - 'a']++;

                endpointer++;
            }

            if(patternHash.SequenceEqual(inputStringHash))
            {
                positionCounter.Add(startpointer);
            }

            while(endpointer < inputString.Length)
            {
                inputStringHash[inputString[endpointer] - 'a']++;

                inputStringHash[inputString[startpointer] - 'a']--;

                startpointer++;
                if (patternHash.SequenceEqual(inputStringHash))
                {
                    positionCounter.Add(startpointer);
                }

                
                endpointer++;
            }

            foreach (int counter in positionCounter)
            {
                Console.WriteLine(counter);
            }



        }

        /*
        Given a string and a pattern, find all anagrams of the pattern in the given string.
        Anagram is actually a Permutation of a string. For example, “abc” has the following six anagrams:
        abc
        acb
        bac
        bca
        cab
        cba
        Write a function to return a list of starting indices of the anagrams 
        of the pattern in the given string.

        Example 1:
        Input: String="ppqp", Pattern="pq"
        Output: [1, 2]
        Explanation: The two anagrams of the pattern in the given string are "pq" and "qp".
        Example 2:
        Input: String="abbcabc", Pattern="abc"
        Output: [2, 3, 4]
        Explanation: The three anagrams of the pattern in the given string are "bca", "cab", and "abc". 
         * */


    }
}
