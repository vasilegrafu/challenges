using System;

namespace Searching
{
    public class BinarySearch2
    {
        public static int Search(int[] a, int value)
        {
            return Search(a, value, 0, a.Length - 1);
        }

        private static int Search(int[] a, int value, int low, int high)
        {
            if(low == high)
            {
                if(value == a[low])
                {
                    return low;
                }
                else
                {
                    return -1;
                }
            }
            
            int middle = (low + high)/2;

            if(value <= a[middle])
            {
                return Search(a, value, low, middle);
            }
            else
            {
                return Search(a, value, middle + 1, high);
            }
        }
    }
}
