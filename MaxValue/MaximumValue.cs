using System;

namespace challenges_and_data_structures1.MaxValue
{
    internal class MaximumValue
    {
        public static int FindMaximum(int[] array)
        {
            int maximum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maximum)
                {
                    maximum = array[i];
                }
            }
            return maximum;
        }
    }
}
