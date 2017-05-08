/*
 * Benutzer: admins
 * Datum: 04.05.2017
 * Zeit: 10:32
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Sortieralgorithmen
{
    /// <summary>
    /// Sortiert Listen
    /// </summary>
    public static class Sort
    {
        /// <summary>
        /// Sortiert Dinge
        /// </summary>
        public static IList<TC> SortList<TC, TS>(IList<TC> list) where TC : IComparable
            where TS : ISort, new() 
        {
            TS sorter = new TS();
            return sorter.Sort(list);
        }
        
        /// <summary>
        /// Sortiert Dinge
        /// </summary>
        public static TC[] SortList<TC, TS>(TC[] list) where TC : IComparable
            where TS : ISort, new() 
        {
            TS sorter = new TS();
            return sorter.Sort(list).ToArray();
        }
        
        /// <summary>
        /// Sortiert Dinge
        /// </summary>
        public static IList<TC> SortList<TC>(IList<TC> list, ISort sorter) where TC : IComparable
        {
            return sorter.Sort(list);
        }
        
        /// <summary>
        /// Sortiert Dinge
        /// </summary>
        public static TC[] SortList<TC>(TC[] list, ISort sorter) where TC : IComparable
        {
            return sorter.Sort(list).ToArray();
        }
    }
}
