using System;

namespace Searching
{
    public class BinarySearch1
    {
        public static int Search(int[] a, int value)
        {
            return Search(a, value, 0, a.Length - 1);
        }

        private static int Search(int[] a, int value, int low, int high)
        {
            if(low > high)
            {
                return -1;
            }
            
            int middle = (low + high)/2;

            if(value == a[middle])
            {
                return middle;
            }
            else if(value < a[middle])
            {
                return Search(a, value, low, middle - 1);
            }
            else if(value > a[middle])
            {
                return Search(a, value, middle + 1, high);
            }
            else
            {
                throw new NotSupportedException();
            }
        }
    }
}
