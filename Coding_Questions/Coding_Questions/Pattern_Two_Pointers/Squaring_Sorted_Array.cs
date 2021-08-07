using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class Squaring_Sorted_Array
    {
        public void Start()
        {
			int[] nums = new int[] { -4, -1, 0, 3, 10 };


			int negative_pointer = 0;
			int positive_pointer = 0;

			while (positive_pointer < nums.Length && nums[positive_pointer] < 0)
			{
				positive_pointer++;
			}

			negative_pointer = positive_pointer - 1;

			int length = nums.Length;
			int[] squaredArray = new int[length];
			int counter = 0;

			while (negative_pointer >= 0 && positive_pointer < length)
			{
				if (nums[negative_pointer] * nums[negative_pointer] <
				   nums[positive_pointer] * nums[positive_pointer])
				{
					squaredArray[counter] = nums[negative_pointer] * nums[negative_pointer];
					negative_pointer -= 1;
				}
				else
				{
					squaredArray[counter] = nums[positive_pointer] * nums[positive_pointer];
					positive_pointer += 1;
				}

				counter++;
			}

			while (negative_pointer >= 0)
			{
				squaredArray[counter] = nums[negative_pointer] * nums[negative_pointer];
				counter++;
				negative_pointer -= 1;
			}

			while (positive_pointer <= length - 1)
			{
				squaredArray[counter] = nums[positive_pointer] * nums[positive_pointer];
				counter++;
				positive_pointer += 1;
			}
		}



        /*
         Problem Statement 
        Given a sorted array, create a new array containing squares of all the number 
        of the input array in the sorted order.
        Example 1:
        Input: [-2, -1, 0, 2, 3]
        Output: [0, 1, 4, 4, 9]
        Example 2:
        Input: [-3, -1, 0, 1, 2]
        Output: [0 1 1 4 9]
         */
    }
}
