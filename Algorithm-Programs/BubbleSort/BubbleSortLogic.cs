/*
 * Bubble Sort
a. Desc -> Reads in integers prints them in sorted order using Bubble Sort
b. I/P -> read in the list ints
c. O/P -> Print the Sorted List
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class BubbleSortLogic
    {
        public static void insertElement(int [] intArray)
        {
            

            for(int i=0;i<intArray.Length;i++)
            {
                Console.WriteLine("Enter Number");
                 intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        
        public static void sortArray(int[] intArray)
        {
            for (int j = 0; j <= intArray.Length - 2; j++)
            {
                for (int i = 0; i <= intArray.Length - 2; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in intArray)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
