using System;

namespace Sorting
{
    public class MergeSort1
    {
        public static void Sort(int[] a)
        {
            int n = a.Length;
            int[] ax = new int[n];
            Sort(a, ax, 0, n - 1);
        }

        private static void Sort(int[] a, int[] ax, int low, int high)
        {
            if(low >= high)
            {
                return;
            }

            int mid = low + (high - low)/2;
            Sort(a, ax, low, mid);
            Sort(a, ax, mid + 1, high);
            Merge(a, ax, low, mid, high);
        }

        private static void Merge(int[] a, int[] ax, int low, int mid, int high)
        {
            int n = a.Length;
            for(int k = low; k <= high; k++)
            {
                ax[k] = a[k];
            }

            int i = low;
            int j = mid + 1;
            for(int k = low; k <= high; k++)
            {
                if(i <= mid && j <= high)
                {
                    if(ax[i] <= ax[j])
                    {
                        a[k] = ax[i];
                        i++;
                    }
                    else
                    {
                        a[k] = ax[j];
                        j++;
                    }
                }
                else if(i > mid && j <= high)
                {
                    a[k] = ax[j];
                    j++;
                }
                else if(i <= mid && j > high)
                {
                    a[k] = ax[i];
                    i++;
                }
                else
                { }
            }

        }
    }
}

