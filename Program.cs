using challenges_and_data_structures1.MaxValue;
using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int[] findMax = new int[5] { 15, 35, 60, 80, 16 };
           // Console.WriteLine($"The maximmum number is: {MaximumValue.FindMaximum(findMax)}");

           // int[] Array = new int[5] { 1, 2, 3, 4, 5 };
           // saja(Array);


           //int[] Array2 = new int[12] { 4, 4, 4, 2, 1, 2, 2, 3, 3, 3, 5, 5 };
           //int mostFrequentNumber = saja2(Array2);

           //Console.WriteLine("Most Frequent Number: " + mostFrequentNumber);
           // Console.WriteLine();

            Console.WriteLine("insert 5 in the middle array");
            int[] array1 = { 1, 2, 3, 4 };
            int[] result1 = InsertMiddleValue(array1, 5);
            PrintArray(result1); 

        }

        private static int[] saja(int[] Array)
        {

            int[] reverseArr = new int[Array.Length];
            for (int i = 0, y = Array.Length - 1; i < reverseArr.Length; i++, y--)
            {
                reverseArr[i] = Array[y];
            }
            for (int i = 0; i < reverseArr.Length; i++)
            {
                Console.WriteLine(reverseArr[i]);
            }
            return reverseArr;
        }

        private static int saja2(int[] Array2)
        {

            int mostFrequent = Array2[0];
            int maxCount = 1;

            for (int i = 0; i < Array2.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < Array2.Length; j++)
                {
                    if (Array2[j] == Array2[i])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequent = Array2[i];
                }
            }

            return mostFrequent;
        }


        public static int[] InsertMiddleValue(int[] array, int value)
        {
            int middleIndex = (array.Length + 1) / 2;
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < middleIndex; i++)
            {
                newArray[i] = array[i];
            }
            newArray[middleIndex] = value;
            for (int i = middleIndex; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            return newArray;
        }

        public static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }


    }
}