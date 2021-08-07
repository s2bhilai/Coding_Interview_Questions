using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Two_Pointers
{
    public class Three_Sum
    {
        public void Start()
        {
			int[] arr = new int[] { -1, 0, 1, 2, -1, -4 };
			int target = 0;
			List<string> qsum = new List<string>();

			Array.Sort(arr);

			for (int i = 0; i < arr.Length; i++)
			{
				int sum = target - arr[i];

				int low = i + 1;
				int high = arr.Length - 1;

				while (low < high)
				{
					int tempSum = arr[low] + arr[high];
					if (tempSum == sum)
					{
						qsum.Add(string.Format("{0},{1},{2}", arr[low], arr[high], arr[i]));
						low++;
						high--;
					}
					else if (tempSum < sum)
					{
						low++;
					}
					else
					{
						high--;
					}
				}
			}
		}
    }
}
