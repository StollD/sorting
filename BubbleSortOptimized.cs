/*
 * Benutzer: admins
 * Datum: 05.05.2017
 * Zeit: 09:25
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Sortieralgorithmen
{
    /// <summary>
    /// Optimiertes BubbleSort
    /// </summary>
    public class BubbleSortOptimized : ISort
    {
        public IList<T> Sort<T>(IList<T> sort) where T : IComparable
        {
            IList<T> sorted = sort.ToList();
            for (Int32 i = 0; i < sorted.Count - 1; i++) 
            {
                Boolean swapped = false;
                for (Int32 j = sorted.Count - 1; j >= i + 1; j--) 
                {
                    if (sorted[j - 1].CompareTo(sorted[j]) > 0)
                    {
                        T value = sorted[j - 1];
                        sorted [j - 1] = sorted[j];
                        sorted[j] = value;
                        swapped = true;
                    }
                }
                if (!swapped) 
                {
                    break;
                }
            }
            return sorted;
        }
    }
}
