using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class Minimum_Window_Sort
    {
        public void Start()
        {
			int[] arr = new int[] { 1, 2, 5, 3, 7, 10, 9, 12 };

			int min = Int32.MaxValue;
			int max = Int32.MinValue;

			//Find min
			for (int i = 0; i < arr.Length-1; i++)
			{
				if (arr[i] < arr[i + 1])
					continue;
				else
				{
					min = Math.Min(min, arr[i + 1]);
				}
			}

			//Find MaxValue
			for (int j = arr.Length - 1; j > 0; j--)
			{
				if (arr[j] >= arr[j - 1])
					continue;
				else
				{
					max = Math.Max(max, arr[j - 1]);
				}
			}

			int left = 0;
			int right = 0;

			for (left = 0; left < arr.Length; left++)
			{
				if (arr[left] > min)
					break;
			}

			for (right = arr.Length - 1; right >= 0; right--)
			{
				if (arr[right] < max)
					break;
			}
		}

        /*
         Minimum Window Sort (medium)
    Given an array, find the length of the smallest subarray in it which when sorted will sort the whole array.
    Example 1:
    Input: [1, 2, 5, 3, 7, 10, 9, 12]
    Output: 5
    Explanation: We need to sort only the subarray [5, 3, 7, 10, 9] to make the whole array sorted
    Example 2:
    Input: [1, 3, 2, 0, -1, 7, 10]
    Output: 5
    Explanation: We need to sort only the subarray [1, 3, 2, 0, -1] to make the whole array sorted
    Example 3:
    Input: [1, 2, 3]
    Output: 0
    Explanation: The array is already sorted
    Example 4:
    Input: [3, 2, 1]
    Output: 3
    Explanation: The whole array needs to be sorted.
         */
    }
}
