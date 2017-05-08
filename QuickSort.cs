/*
 * Benutzer: admins
 * Datum: 08.05.2017
 * Zeit: 09:15
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Sortieralgorithmen
{
    /// <summary>
    /// QuickSort Algorithmus
    /// </summary>
    public class QuickSort : ISort
    {
        public IList<T> Sort<T>(IList<T> sort) where T : IComparable
        {
            IList<T> sorted = sort.ToList();
            SortInternal(ref sorted, 0, sorted.Count - 1);
            return sorted;
        }
        
        protected void SortInternal<T>(ref IList<T> sort, Int32 left, Int32 right) where T : IComparable 
        {
            if (left < right) 
            {
                Int32 i = left;
                Int32 j = right - 1;
                T pivot = sort[right];
                do
                {
                    while (sort[i].CompareTo(pivot) <= 0 && i < right) 
                    {
                        i++;
                    }
                    while (sort[j].CompareTo(pivot) >= 0 && j > left)
                    {
                        j--;
                    }
                    if (i < j) 
                    {
                        T value = sort[i];
                        sort[i] = sort[j];
                        sort[j] = value;
                    }
                }
                while (i < j);
                if (sort[i].CompareTo(pivot) > 0) 
                {
                        T value = sort[i];
                        sort[i] = sort[right];
                        sort[right] = value;                    
                }                
                SortInternal(ref sort, left, i - 1);
                SortInternal(ref sort, i + 1, right);
            }
        }
        
    }
}
