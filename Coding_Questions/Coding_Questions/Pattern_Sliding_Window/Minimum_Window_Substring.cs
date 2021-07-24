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
            string inputString = "abdabca";
            string pattern = "abc";


            var requiredCharacters = BuildMappingOfCharactersToOccurences(pattern);
            var windowCharacterMapping = new Dictionary<char, int>();

            int left = 0;
            int right = 0;

            int totalCharFrequenciesToMatch = requiredCharacters.Count;
            int charFrequenciesInWindowThatMatch = 0;

            int minimumWindowLengthSeenSoFar = Int32.MaxValue;

            string minWindow = string.Empty;

            while(right < inputString.Length)
            {
                char characterAtRightPointer = inputString[right];
                AddCharacterToHashTableMapping(windowCharacterMapping, characterAtRightPointer);

                bool rightCharIsARequirement = requiredCharacters.ContainsKey(characterAtRightPointer);
                if(rightCharIsARequirement)
                {
                    bool requirementForCharacterMet = requiredCharacters[characterAtRightPointer]
                        == windowCharacterMapping[characterAtRightPointer];

                    if (requirementForCharacterMet)
                        charFrequenciesInWindowThatMatch++;
                }

                while(charFrequenciesInWindowThatMatch == totalCharFrequenciesToMatch && left <= right)
                {
                    char characterAtLeftPointer = inputString[left];
                    int windowSize = right - left + 1;

                    if(windowSize < minimumWindowLengthSeenSoFar)
                    {
                        minimumWindowLengthSeenSoFar = windowSize;
                        minWindow = inputString.Substring(left, right + 1 - left);
                    }

                    windowCharacterMapping[characterAtLeftPointer] = windowCharacterMapping[characterAtLeftPointer] - 1;

                    bool leftCharIsARequirement = requiredCharacters.ContainsKey(characterAtLeftPointer);
                    if(leftCharIsARequirement)
                    {
                        bool characterFailsRequirement = windowCharacterMapping[characterAtLeftPointer]
                            < requiredCharacters[characterAtLeftPointer];

                        if (characterFailsRequirement)
                            charFrequenciesInWindowThatMatch--;
                    }

                    left++;
                }

                right++;
            }




        }


        private Dictionary<char,int> BuildMappingOfCharactersToOccurences(string s)
        {
            var map = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                int occurencesOfChars = 0;
                if(map.ContainsKey(s[i]))
                {
                    occurencesOfChars = map[s[i]];
                }
                map[s[i]] = occurencesOfChars + 1;
            }

            return map;
        }


        private void AddCharacterToHashTableMapping(Dictionary<char,int> map,char c)
        {
            int occurences = 0;
            if(map.ContainsKey(c))
            {
                occurences = map[c];
            }

            map[c] = occurences + 1;
        }




        /*
          Given a string and a pattern, find the smallest substring in the given string which has all 
          the characters of the given pattern.
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
