using System;

namespace Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] a)
        {
            int n = a.Length;
            for(int i = 0; i < (n - 1); i++)
            {
                int min_ai = a[i];
                int min_i = i;
                for(int j = (i + 1); j < n; j++)
                {
                    if(min_ai > a[j])
                    {
                        min_ai = a[j];
                        min_i = j;
                    }
                }
                int t = a[i];
                a[i] = a[min_i];
                a[min_i] = a[i];
            }
        }
    }
}
