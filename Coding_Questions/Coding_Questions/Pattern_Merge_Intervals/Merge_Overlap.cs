using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Merge_Intervals
{
    public class Merge_Overlap
    {
        public void Start()
        {
		  int[][] jaggedintervals = new int[][]
		   {
               new int[] {1,3},
               new int[] {8,10},
               new int[] {2,6},
               new int[] {15,18}
           };

			Array.Sort(jaggedintervals, (arr1, arr2) => { return arr1[0] - arr2[0]; });

			//Array.Sort(intervals, (arr1, arr2) => { return arr1[0] - arr2[0]; });

			List<int[]> output_arr = new List<int[]>();
			int[] current_interval = jaggedintervals[0];
			output_arr.Add(current_interval);

			foreach (int[] interval in jaggedintervals)
			{
				int current_begin = current_interval[0];
				int current_end = current_interval[1];
				int next_begin = interval[0];
				int next_end = interval[1];

				if (current_end >= next_begin)
				{
					current_interval[1] = Math.Max(current_end, next_end);
				}
				else
				{
					current_interval = interval;
					output_arr.Add(current_interval);
				}
			}
		}
    }


    /*
     Merge all overlapping intervals 
     */
}
