/*
 * Benutzer: admins
 * Datum: 04.05.2017
 * Zeit: 10:00
 */ 
using System;
using System.Linq;
using System.Collections.Generic;

namespace Sortieralgorithmen
{
    /// <summary>
    /// MinimumSort Algorithmus
    /// </summary>
    public class MinimumSort : ISort
    {        
        public IList<T> Sort<T>(IList<T> sort) where T : IComparable
        {
            IList<T> sorted = sort.ToList();
            for (Int32 i = 0; i < sorted.Count - 1; i++) 
            {
                Int32 min = i;
                for (Int32 search = i + 1; search < sorted.Count; search++) 
                {
                    if (sorted[search].CompareTo(sorted[min]) < 0)
                    {
                        min = search;
                    }                    
                }
                T value = sorted[i];
                sorted[i] = sorted[min];
                sorted[min] = value;
            }
            return sorted;
        }
    }
}
