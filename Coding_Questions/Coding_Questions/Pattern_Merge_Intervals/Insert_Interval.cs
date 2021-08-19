using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Merge_Intervals
{
    public class Insert_Interval
    {
        public void Start()
        {
            int[][] jaggedArray = new int[][]
            {
               new int[] {1,3},
               new int[] {5,7},
               new int[] {8,12},
               new int[] {20,30}
            };

            int[] newInterval = new int[] { 4, 10 };

            List<int[]> mergedArr = new List<int[]>();

            foreach (int[] interval in jaggedArray)
            {
                int current_begin = interval[0];
                int current_end = interval[1];

                int newBegin = newInterval[0];
                int newEnd = newInterval[1];

                if (current_end < newBegin) // To the left side
                {
                    mergedArr.Add(interval);
                }
                else if (current_begin > newEnd) // To the right side
                {
                    mergedArr.Add(newInterval);
                    newInterval = interval;
                }
                else if (current_end > newBegin)
                {
                    newInterval[0] = Math.Min(newBegin, current_begin);
                    newInterval[1] = Math.Max(current_end, newEnd);
                }                
            }

            mergedArr.Add(newInterval);
        }


        /*
         Problem Statement 
        Given a list of non-overlapping intervals sorted by their start time, 
        insert a given interval at the correct position and merge all necessary 
        intervals to produce a list that has only mutually exclusive intervals.

        Example 1:
        Input: Intervals=[[1,3], [5,7], [8,12]], New Interval=[4,6]
        Output: [[1,3], [4,7], [8,12]]
        Explanation: After insertion, since [4,6] overlaps with [5,7], we merged them into one [4,7].
        Example 2:
        Input: Intervals=[[1,3], [5,7], [8,12]], New Interval=[4,10]
        Output: [[1,3], [4,12]]
        Explanation: After insertion, since [4,10] overlaps with [5,7] & [8,12], we merged them into [4,12].
        Example 3:
        Input: Intervals=[[2,3],[5,7]], New Interval=[1,4]
        Output: [[1,4], [5,7]]
        Explanation: After insertion, since [1,4] overlaps with [2,3], we merged them into one [1,4]. 
         */
    }
}
