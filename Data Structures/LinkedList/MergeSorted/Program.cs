using challenges_and_data_structures1;
using System;
using System.Collections.Generic;

namespace ConsoleApp11
{

    //        //private static int[] saja(int[] Array)
    //        //{

    //        //    int[] reverseArr = new int[Array.Length];
    //        //    for (int i = 0, y = Array.Length - 1; i < reverseArr.Length; i++, y--)
    //        //    {
    //        //        reverseArr[i] = Array[y];
    //        //    }
    //        //    for (int i = 0; i < reverseArr.Length; i++)
    //        //    {
    //        //        Console.WriteLine(reverseArr[i]);
    //        //    }
    //        //    return reverseArr;
    //        //}

    //        //private static int saja2(int[] Array2)
    //        //{

    //        //    int mostFrequent = Array2[0];
    //        //    int maxCount = 1;

    //        //    for (int i = 0; i < Array2.Length; i++)
    //        //    {
    //        //        int count = 1;
    //        //        for (int j = i + 1; j < Array2.Length; j++)
    //        //        {
    //        //            if (Array2[j] == Array2[i])
    //        //            {
    //        //                count++;
    //        //            }
    //        //        }

    //        //        if (count > maxCount)
    //        //        {
    //        //            maxCount = count;
    //        //            mostFrequent = Array2[i];
    //        //        }
    //        //    }
    //        //    return mostFrequent;
    //        //}
    //        public static int[] CommonElements(int[] array1, int[] array2)
    //        {
    //            List<int> commonElements = new List<int>();

    //            for (int i = 0; i < array1.Length; i++) // o(n^3)
    //            {
    //                for (int j = 0; j < array2.Length; j++)
    //                {
    //                    if (array1[i] == array2[j])
    //                    {
    //                        bool isAlreadyInCommon = false;
    //                        for (int k = 0; k < commonElements.Count; k++)
    //                        {
    //                            if (commonElements[k] == array1[i])
    //                            {
    //                                isAlreadyInCommon = true;
    //                                break;
    //                            }
    //                        }
    //                        if (!isAlreadyInCommon)
    //                        {
    //                            commonElements.Add(array1[i]);
    //                        }
    //                        break;
    //                    }
    //                }
    //            }

    //            int[] result = new int[commonElements.Count];
    //            for (int i = 0; i < commonElements.Count; i++)
    //            {
    //                result[i] = commonElements[i];
    //            }
    //            return result;
    //        }
    //    }
    //})
    public class Program
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
            //string input = "csharp is programming language";
            //string result = ReverseWords.ReverseOrder(input);
            //Console.WriteLine(result);

            //Console.WriteLine("insert 5 in the middle array");
            //int[] array1 = { 1, 2, 3, 4 };
            //int[] result1 = InsertMiddleValue(array1, 5);
            //PrintArray(result1);


            //LinkedList list1 = new LinkedList();
            //LinkedList list2 = new LinkedList();
            //LinkedList list3 = new LinkedList();

            //int[] arr1 = { 5, 20, 20, 10, 5, 10 };
            //int[] arr2 = { 1, 2, 3, 2, 4, 3 };
            //int[] arr3 = { 7, 7, 7, 7 };

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    list1.AddNode(arr1[i]);
            //}
            //Console.WriteLine("Case 1 input and output");
            //list1.PrintList();
            //list1.RemoveDuplicate();
            //list1.PrintList();

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    list2.AddNode(arr2[i]);
            //}
            //Console.WriteLine("\nCase 2 input and output");
            //list2.PrintList();
            //list2.RemoveDuplicate();
            //list2.PrintList();

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    list3.AddNode(arr3[i]);
            //}
            //Console.WriteLine("\nCase 3 input and output");
            //list3.PrintList();
            //list3.RemoveDuplicate();
            //list3.PrintList();

            LinkedList sortedList1 = new LinkedList();
            sortedList1.AddNode(1);
            sortedList1.AddNode(3);
            sortedList1.AddNode(5);
            Console.WriteLine("Case 1:");
            sortedList1.PrintList();

            LinkedList sortedList2 = new LinkedList();
            sortedList2.AddNode(2);
            sortedList2.AddNode(4);
            sortedList2.AddNode(6);

            sortedList2.PrintList();

            LinkedList mergedList = new LinkedList();
            mergedList = mergedList.MergeSortedLists(sortedList1, sortedList2);

            Console.WriteLine("\nMerged Sorted List:");
            mergedList.PrintList();


            //            List 1: Head-> 5-> 10-> 15->Null
            //List 2: Head-> 2-> 3-> 20->Null
            //Merged List: Head-> 2-> 3-> 5-> 10-> 15-> 20->Null

            //List 1: Head-> 10-> 20-> 30->Null
            //List 2: Head-> 5-> 15-> 25-> 35->Null
            //Merged List: Head-> 5-> 10-> 15-> 20-> 25-> 30-> 35->Null
            LinkedList sortedList3 = new LinkedList();
            sortedList3.AddNode(5);
            sortedList3.AddNode(10);
            sortedList3.AddNode(15);
            Console.WriteLine("\nCase 2:");
            sortedList3.PrintList();

            LinkedList sortedList4 = new LinkedList();
            sortedList4.AddNode(2);
            sortedList4.AddNode(3);
            sortedList4.AddNode(20);
            sortedList4.PrintList();


            LinkedList mergedList2 = new LinkedList();
            mergedList2 = mergedList2.MergeSortedLists(sortedList3, sortedList4);

            Console.WriteLine("\nMerged Sorted List:");
            mergedList2.PrintList();

        }
        //public static int[] CommonElements(int[] array1, int[] array2)
        //{
        //    List<int> commonElements = new List<int>();

        //    for (int i = 0; i < array1.Length; i++)
        //    {
        //        for (int j = 0; j < array2.Length; j++)
        //        {
        //            if (array1[i] == array2[j])
        //            {
        //                bool isAlreadyInCommon = false;
        //                for (int k = 0; k < commonElements.Count; k++)
        //                {
        //                    if (commonElements[k] == array1[i])
        //                    {
        //                        isAlreadyInCommon = true;
        //                        break;
        //                    }
        //                }
        //                if (!isAlreadyInCommon)
        //                {
        //                    commonElements.Add(array1[i]);
        //                }
        //                break;
        //            }
        //        }
        //    }

        //    int[] result = new int[commonElements.Count];
        //    for (int i = 0; i < commonElements.Count; i++)
        //    {
        //        result[i] = commonElements[i];
        //    }
        //    return result;
        //}
        //private static int[] saja(int[] Array)
        //{

        //    int[] reverseArr = new int[Array.Length];
        //    for (int i = 0, y = Array.Length - 1; i < reverseArr.Length; i++, y--)
        //    {
        //        reverseArr[i] = Array[y];
        //    }
        //    for (int i = 0; i < reverseArr.Length; i++)
        //    {
        //        Console.WriteLine(reverseArr[i]);
        //    }
        //    return reverseArr;
        //}

        //private static int saja2(int[] Array2)
        //{

        //    int mostFrequent = Array2[0];
        //    int maxCount = 1;

        //    for (int i = 0; i < Array2.Length; i++)
        //    {
        //        int count = 1;
        //        for (int j = i + 1; j < Array2.Length; j++)
        //        {
        //            if (Array2[j] == Array2[i])
        //            {
        //                count++;
        //            }
        //        }

        //        if (count > maxCount)
        //        {
        //            maxCount = count;
        //            mostFrequent = Array2[i];
        //        }
        //    }

        //    return mostFrequent;
        //}


        //public static int[] InsertMiddleValue(int[] array, int value)
        //{
        //    int middleIndex = (array.Length + 1) / 2;
        //    int[] newArray = new int[array.Length + 1];
        //    for (int i = 0; i < middleIndex; i++)
        //    {
        //        newArray[i] = array[i];
        //    }
        //    newArray[middleIndex] = value;
        //    for (int i = middleIndex; i < array.Length; i++)
        //    {
        //        newArray[i + 1] = array[i];
        //    }

        //    return newArray;
        //}

        //public static void PrintArray(int[] array)
        //{
        //    Console.Write("[");
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i]);
        //        if (i < array.Length - 1)
        //        {
        //            Console.Write(", ");
        //        }
        //    }
        //    Console.WriteLine("]");
        //}


    }
}