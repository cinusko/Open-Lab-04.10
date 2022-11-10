using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            int sum = 0;
            float average = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            average = (float)sum / nums.Length;
            return average;
            
            
        }
    }
}
