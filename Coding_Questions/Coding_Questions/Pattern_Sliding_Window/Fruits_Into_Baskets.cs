using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Questions.Pattern_Sliding_Window
{
    public class Fruits_Into_Baskets
    {
        public int Start_Chars()
        {
            char[] fruits = new char[] { 'A', 'B', 'C', 'B', 'B', 'C' };

            //move only forward
            int max_fruits = 0;
            int current_max = 0;
            int last_fruit_count = 0;
            char last_fruit = '\0';
            char second_last_fruit = '\0';

            foreach (char fruit in fruits)
            {
                if(fruit == last_fruit || fruit == second_last_fruit)
                {
                    current_max += 1;
                }
                else
                {
                    current_max = last_fruit_count + 1;
                }

                if (fruit == last_fruit)
                    last_fruit_count += 1;
                else
                    last_fruit_count = 1;

                if(fruit != last_fruit)
                {
                    second_last_fruit = last_fruit;
                    last_fruit = fruit;
                }

                max_fruits = Math.Max(current_max, max_fruits);
            }

            return max_fruits;

        }

        public void Start()
        {
            int[] fruits = new int[] { 3,3,3,1,2,1,1,2,3,3,4 };

            int last_fruit = -1;
            int second_last_fruit = -1;
            int last_fruit_count = 0;
            int current_max = 0;
            int max = 0;

            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == last_fruit || fruits[i] == second_last_fruit)
                    current_max += 1;
                else
                    current_max = last_fruit_count + 1;

                if (fruits[i] == last_fruit)
                    last_fruit_count += 1;
                else
                    last_fruit_count = 1;

                if (fruits[i] != last_fruit)
                {
                    second_last_fruit = last_fruit;
                    last_fruit = fruits[i];
                }

                max = Math.Max(current_max, max);

            }

            

        }
    }
}



/*
 Problem Statement 
Given an array of characters where each character represents a fruit tree, 
you are given two baskets and your goal is to put maximum number of fruits in each basket. 
The only restriction is that each basket can have only one type of fruit.

You can start with any tree, but once you have started you can’t skip a tree. 
You will pick one fruit from each tree until you cannot, i.e., you will stop when you have to pick from a third fruit type.

Write a function to return the maximum number of fruits in both the baskets.

Example 1:

Input: Fruit=['A', 'B', 'C', 'A', 'C']
Output: 3
Explanation: We can put 2 'C' in one basket and one 'A' in the other from the subarray ['C', 'A', 'C']

Example 2:

Input: Fruit=['A', 'B', 'C', 'B', 'B', 'C']
Output: 5
Explanation: We can put 3 'B' in one basket and two 'C' in the other basket. 
This can be done if we start with the second letter: ['B', 'C', 'B', 'B', 'C']
 */
