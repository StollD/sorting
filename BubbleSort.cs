/*
 * Benutzer: admins
 * Datum: 04.05.2017
 * Zeit: 11:05
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Sortieralgorithmen
{
    /// <summary>
    /// BubbleSort Algorithmus
    /// </summary>
    public class BubbleSort : ISort
    {
        public IList<T> Sort<T>(IList<T> sort) where T : IComparable
        {
            IList<T> sorted = sort.ToList();
            for (Int32 i = 0; i < sorted.Count - 1; i++) 
            {
                for (Int32 j = sorted.Count - 1; j >= i + 1; j--) 
                {
                    if (sorted[j - 1].CompareTo(sorted[j]) > 0)
                    {
                        T value = sorted[j - 1];
                        sorted [j - 1] = sorted[j];
                        sorted[j] = value;
                    }
                }
            }
            return sorted;
        }
    }
}
