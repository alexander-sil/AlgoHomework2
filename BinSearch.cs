using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoHomework2
{
    internal class BinSearch
    {

        // O(log(n))
        internal static int BinarySearch(int[] array, int term)
        {
            int leftIndex = 0;
            int rightIndex = array.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;

                if (array[middleIndex] < term)
                {
                    leftIndex = middleIndex++;
                }
                else if (array[middleIndex] > term)
                {
                    rightIndex = middleIndex--;
                }
                else
                {
                    return middleIndex;
                }
            }
            return -1;
        }
    }
}
