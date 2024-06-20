using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public static class SortingAlgorithms
    {
        private static void Swap(char[] stringArray, int pos1, int pos2)
        {
            char tempChar = stringArray[pos1];
            stringArray[pos1] = stringArray[pos2];
            stringArray[pos2] = tempChar;
        }
        public static string BubbleSort(string stringToSort)
        {
            char[] stringToSortList = stringToSort.ToCharArray();
            bool pass = true;

            while (pass)
            {
                int numOfSwaps = 0;
                for (int i = 0; i < stringToSort.Length - 1; i++)
                {
                    if (string.Compare(stringToSortList[i].ToString(), stringToSortList[i + 1].ToString()) > 0)
                    {
                        Swap(stringToSortList, i + 1, i);
                        numOfSwaps++;
                    }
                }
                if (numOfSwaps == 0)
                {
                    pass = false;
                }
            }
            return new string(stringToSortList);
        }

        private static int Partition(char[] stringArray, int firstIndex, int lastIndex) 
        {
            int pivotPos = firstIndex; 
            char pivotElement = stringArray[firstIndex];

            for (int i = firstIndex + 1; i <= lastIndex; i++)
            {
                if (string.Compare(stringArray[i].ToString(), pivotElement.ToString()) < 0) 
                {
                    pivotPos++;
                    Swap(stringArray, pivotPos, i);
                }
            }
            Swap(stringArray, pivotPos, firstIndex);
            return pivotPos;
        }
        public static char[] QuickSort(char[] stringToSortList, int firstIndex, int lastIndex)
        {
            if (firstIndex < lastIndex)
            {
                int pivotPos = Partition(stringToSortList, firstIndex, lastIndex);
                QuickSort(stringToSortList, firstIndex, pivotPos - 1);
                QuickSort(stringToSortList, pivotPos + 1, lastIndex);
            }
            return stringToSortList;
        }
    }
}
