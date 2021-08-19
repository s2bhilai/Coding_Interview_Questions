using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Merge_Intervals
{
    public class Conflict_Appointment
    {
        public void Start()
        {
            int[][] arrays = new int[][]
            {
                new int[] {4,5},
                new int[] {2,3},
                new int[] {3,6}
            };

            //Sort By first element
            Array.Sort(arrays, (arr1,arr2) => { return arr1[0] - arr2[0]; });
            
            bool canAttend = true;

            int[] current_interval = arrays[0];

            foreach (int[] interval in arrays.Skip(1))
            {
                int current_begin = current_interval[0];
                int current_end = current_interval[1];

                if (current_end > interval[0])
                {
                    canAttend = false;
                }
                else
                {
                    current_interval = interval;
                }
            }

            Console.WriteLine(canAttend);
        }

        /*
         Problem Statement 
        Given an array of intervals representing ‘N’ appointments, 
        find out if a person can attend all the appointments.

        Example 1:

        Appointments: [[1,4], [2,5], [7,9]]
        Output: false
        Explanation: Since [1,4] and [2,5] overlap, a person cannot attend both of these appointments.

        Example 2:

        Appointments: [[6,7], [2,4], [8,12]]
        Output: true
        Explanation: None of the appointments overlap, therefore a person can attend all of them.

        Example 3:

        Appointments: [[4,5], [2,3], [3,6]]
        Output: false
        Explanation: Since [4,5] and [3,6] overlap, a person cannot attend both of these appointments. 
         */
    }
}
