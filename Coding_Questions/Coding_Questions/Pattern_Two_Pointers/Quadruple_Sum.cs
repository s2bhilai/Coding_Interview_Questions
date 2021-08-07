using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class Quadruple_Sum
    {
        public void Start()
        {
			int[] arr = new int[] { 4, 1, 2, -1, 1, -3 };
			int target = 1;
			List<string> qsum = new List<string>();

			Array.Sort(arr);

			for (int i = 0; i < arr.Length - 3; i++)
			{
				for (int j = i + 1; j < arr.Length - 2; j++)
				{
					int sum = target - (arr[i] + arr[j]);

					int start = j + 1;
					int end = arr.Length - 1;

					while (start < end)
					{
						int t = arr[start] + arr[end];
						if (t == sum)
						{
							qsum.Add(string.Format("{0},{1},{2},{3}", arr[i], arr[j], arr[start], arr[end]));
							start++;
							end--;
						}
						else if (t < sum)
						{
							start++;
						}
						else
						{
							end--;
						}
					}
				}
			}
		}


        /*
         Quadruple Sum to Target (medium) 
        Given an array of unsorted numbers and a target number, 
        find all unique quadruplets in it, 
        whose sum is equal to the target number.

        Example 1:
        Input: [4, 1, 2, -1, 1, -3], target=1
        Output: [-3, -1, 1, 4], [-3, 1, 1, 2]
        Explanation: Both the quadruplets add up to the target.
        Example 2:
        Input: [2, 0, -1, 1, -2, 2], target=2
        Output: [-2, 0, 2, 2], [-1, 0, 1, 2]
        Explanation: Both the quadruplets add up to the target. 
         */
    }
}
