using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class String_BackSpaces
    {
        public void Start()
        {
			string S = "xy#z";
			string T = "xyz#";

			int s_pointer = S.Length - 1;
			int t_pointer = T.Length - 1;

			int s_skips = 0;
			int t_skips = 0;

			bool resultFlag = true;

			while(s_pointer >= 0 || t_pointer >= 0)
	        {
				while (s_pointer >= 0)
				{
					if (S[s_pointer].Equals('#'))
					{
						s_skips += 1;
						s_pointer -= 1;
					}
					else if (s_skips > 0)
					{
						s_pointer -= 1;
						s_skips -= 1;
					}
					else
					{
						break;
					}
				}

				while (t_pointer >= 0)
				{
					if (T[t_pointer].Equals('#'))
					{
						t_skips += 1;
						t_pointer -= 1;
					}
					else if (t_skips > 0)
					{
						t_pointer -= 1;
						t_skips -= 1;
					}
					else
					{
						break;
					}
				}

				if (!S[s_pointer].Equals(T[t_pointer]))
				{
					resultFlag = false;
				}

				if (s_pointer != t_pointer)
					resultFlag = false;

				s_pointer -= 1;
				t_pointer -= 1;
		
			}
		}



        /*
         Problem Challenge 2
            Comparing Strings containing Backspaces (medium)
            Given two strings containing backspaces (identified by the character ‘#’), check if the two strings are equal.
            Example 1:
            Input: str1="xy#z", str2="xzz#"
            Output: true
            Explanation: After applying backspaces the strings become "xz" and "xz" respectively.
            Example 2:
            Input: str1="xy#z", str2="xyz#"
            Output: false
            Explanation: After applying backspaces the strings become "xz" and "xy" respectively.
            Example 3:
            Input: str1="xp#", str2="xyz##"
            Output: true
            Explanation: After applying backspaces the strings become "x" and "x" respectively.
            In "xyz##", the first '#' removes the character 'z' and the second '#' removes the character 'y'.
            Example 4:
            Input: str1="xywrrmp", str2="xywrrmu#p"
            Output: true
            Explanation: After applying backspaces the strings become "xywrrmp" and "xywrrmp" respectively. 
         */
    }
}
