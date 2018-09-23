using System;

namespace Sorting
{
    public class BubbleSort
    {
        public static void Sort(int[] a)
        {
            int n = a.Length;
            for(int i = 0; i < (n - 1); i++)
            {
                for(int j = 1; j < n; j++)
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
