using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Merge_Intervals
{
    public class Interval_Intersection
    {
        public void Start()
        {
            int[][] arr1 = new int[][]
            {
                new int[] { 1,3 },
                new int[] { 5,7 },
                new int[] { 9,12 }
            };

            int[][] arr2 = new int[][]
            {
                new int[] { 5,10 },
            };

            List<int[]> output = new List<int[]>();
            int aptr = 0;
            int bptr = 0;

            while(aptr < arr1.Length && bptr < arr2.Length)
            {
                if(arr1[aptr][1] >= arr2[bptr][0]  &&
                    arr1[aptr][0] <= arr2[bptr][1])
                {
                    int[] newInterval = new int[]
                    {
                        Math.Max(arr1[aptr][0],arr2[bptr][0]),
                        Math.Min(arr1[aptr][1],arr2[bptr][1])
                    };
                    output.Add(newInterval);
                }

                //Increment the one having less span
                if (arr1[aptr][1] > arr2[bptr][1])
                    bptr++;
                else
                    aptr++;
            }

        }


        /*
         Problem Statement 
        Given two lists of intervals, find the intersection of these two lists. Each list consists of disjoint intervals sorted on their start time.
        Example 1:
        Input: arr1=[[1, 3], [5, 6], [7, 9]], arr2=[[2, 3], [5, 7]]
        Output: [2, 3], [5, 6], [7, 7]
        Explanation: The output list contains the common intervals between the two lists.
        Example 2:
        Input: arr1=[[1, 3], [5, 7], [9, 12]], arr2=[[5, 10]]
        Output: [5, 7], [9, 10]
        Explanation: The output list contains the common intervals between the two lists.
         */
    }
}
