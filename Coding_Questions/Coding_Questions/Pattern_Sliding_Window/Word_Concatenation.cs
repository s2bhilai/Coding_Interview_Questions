using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class Word_Concatenation
    {
        public void Start()
        {
            string inputString = "catcatfoxfox";
            string[] words = new string[] { "cat", "fox" };

            //compute words collection
            int[] wordsCount = new int[26];
            List<char> firstLettersCount = new List<char>();

            int windowSize = 0;
            foreach (var word in words)
            {
                for(int i=0;i < word.Length;i++)
                {
                    if (i == 0)
                        firstLettersCount.Add(word[i]);

                    windowSize += 1;
                    wordsCount[word[i] - 'a']++;
                }
            }

            int left = 0;
            int right = 0;

            int[] sourceStrCount = new int[26];
            List<int> finalCount = new List<int>();

            while(right < inputString.Length)
            {
                sourceStrCount[inputString[right] - 'a']++;

                if (right - left == windowSize - 1)
                {
                    if(sourceStrCount.SequenceEqual(wordsCount) && firstLettersCount.Contains(inputString[left]))
                    {
                        finalCount.Add(left);
                    }

                    sourceStrCount[inputString[left] - 'a']--;
                    left++;                    
                }
             
                right++;
            }
            

        }
    }



    /*
     Words Concatenation (hard) 
      Given a string and a list of words, find all the starting indices of substrings 
      in the given string that are a concatenation of all the given words 
      exactly once without any overlapping of words. 
      It is given that all words are of the same length.

    Example 1:
    Input: String="catfoxcat", Words=["cat", "fox"]
    Output: [0, 3]
    Explanation: The two substring containing both the words are "catfox" & "foxcat".
    Example 2:
    Input: String="catcatfoxfox", Words=["cat", "fox"]
    Output: [3]
    Explanation: The only substring containing both the words is "catfox".
     * */
}
