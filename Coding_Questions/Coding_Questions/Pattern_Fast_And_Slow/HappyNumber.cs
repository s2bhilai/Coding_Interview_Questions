using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Fast_And_Slow
{
    public class HappyNumber
    {
        public void Start()
        {
			int n = 19;
			HashSet<int> seen = new HashSet<int>();
			int currentNum = 0;
			int sum = 0;
			bool isHappy = false;

			while (n != 1)
			{
				currentNum = n;
				sum = 0;
				while (currentNum > 0)
				{
					sum += (currentNum % 10) * (currentNum % 10);
					currentNum = currentNum / 10;
				}

				if (seen.Contains(sum))
				{
					isHappy = false;
					break;
				}

				seen.Add(sum);
				n = sum;
			}

			isHappy = true;
		}


        /*
         Any number will be called a happy number if, 
        after repeatedly replacing it with a number equal to the sum of the square of all of its digits, 
        leads us to number ‘1’. All other (not-happy) numbers will never reach ‘1’. 
        Instead, they will be stuck in a cycle of numbers which does not include ‘1’.
         */
    }
}
