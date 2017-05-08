/*
 * Benutzer: admins
 * Datum: 04.05.2017
 * Zeit: 10:29
 */ 
using System;

namespace Sortieralgorithmen
{
    /// <summary>
    /// Basisklasse für einen vergleichbaren Wert
    /// </summary>
    public abstract class Compareable<T> : IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj == null) {
                return 1;
            }
            if (!(obj is T)) {
                throw new ArgumentException();
            }
            T value = (T)obj;
            return CompareTo(value);
        }
        
        protected abstract Int32 CompareTo(T obj);
    }
}
