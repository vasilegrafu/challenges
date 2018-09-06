using System;

namespace Sorting
{
    public class InsertionSort
    {
        public static void Sort(int[] a)
        {
            int n = a.Length;
            for(int i = 1; i < n; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if(a[j-1] > a[j])
                    {
                        int t = a[j];
                        a[j] = a[j-1];
                        a[j-1] = t;
                    }
                }
            }
        }
    }
}
