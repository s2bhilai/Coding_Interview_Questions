using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class Dutch_National_Flag_Problem
    {
        public void Start()
        {
            int[] inputArray = new int[] { 2, 2, 0, 1, 2, 0 };

            int start = 0;
            int end = inputArray.Length - 1;
            int index = 0;

            while(index <= end)
            {
                if(inputArray[index] == 0)
                {
                    //Move to Beginning
                    int temp = inputArray[start];
                    inputArray[start] = inputArray[index];
                    inputArray[index] = temp;
                    start++;
                    index++;
                }
                else if(inputArray[index] == 2)
                {
                    //Move to End
                    inputArray[index] = inputArray[end];
                    inputArray[end] = 2;
                    end--;
                    //index++; Dont increment the index as as after swapping from last, 
                    //it can contain 0 also which again has to be processed
                }
                else
                {
                    index++;
                }
            }


        }

        /*
         Problem Statement 
            Given an array containing 0s, 1s and 2s, sort the array in-place. 
            You should treat numbers of the array as objects, 
            hence, we can’t count 0s, 1s, and 2s to recreate the array.
            The flag of the Netherlands consists of three colors: red, white and blue; 
            and since our input array also consists of three different numbers that is why it is called Dutch National Flag problem.
            Example 1:
            Input: [1, 0, 2, 1, 0]
            Output: [0 0 1 1 2]
            Example 2:
            Input: [2, 2, 0, 1, 2, 0]
            Output: [0 0 1 2 2 2 ] 
         */
    }
}
