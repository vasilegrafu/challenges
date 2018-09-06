using System;

namespace Searching
{
    public class LinearSearch
    {
        public static int Search(int[] a, int value)
        {
            int n = a.Length;
            for(int i = 1; i < n; i++)
            {
                if(a[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
