using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class Triplet_Sum_Zero
    {
        public void Start()
        {
			int[] arr = new int[] { -3, 0, 1, 2, -1, 1, -2 };

			int leftPointer = 0;
			int rightPointer = 0;

			StringBuilder builder = new StringBuilder();

			int target = 0;

			Array.Sort(arr); // -3,-2,-1,0,1,1,2

			int result_Counter = 0;

			for (int i = 0; i < arr.Length - 2; i++)
			{
				leftPointer = i + 1;
				rightPointer = arr.Length - 1;

				while (leftPointer < rightPointer)
				{
					int currentSum = arr[i] + arr[leftPointer] + arr[rightPointer];

					if (currentSum == 0)
                    {
						result_Counter++;
						builder.AppendLine($"{arr[i]} {arr[leftPointer]} {arr[rightPointer]}");
					}
						

					if (currentSum < target)
					{
						leftPointer++;
					}
					else
					{
						rightPointer--;
					}
				}
			}

            Console.WriteLine(builder.ToString());
		}



        /*
         Given an array of unsorted numbers, 
         find all unique triplets in it that add up to zero.
            Example 1:
            Input: [-3, 0, 1, 2, -1, 1, -2]
            Output: [-3, 1, 2], [-2, 0, 2], [-2, 1, 1], [-1, 0, 1]
            Explanation: There are four unique triplets whose sum is equal to zero.
            Example 2:
            Input: [-5, 2, -1, -2, 3]
            Output: [[-5, 2, 3], [-2, -1, 3]]
            Explanation: There are two unique triplets whose sum is equal to zero.
         */
    }
}
