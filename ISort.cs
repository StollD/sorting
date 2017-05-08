/*
 * Benutzer: admins
 * Datum: 04.05.2017
 * Zeit: 10:01
 */ 
using System;
using System.Collections.Generic;

namespace Sortieralgorithmen
{
    /// <summary>
    /// Implementiert eine Schnittstelle für Sortieralgorithmen
    /// </summary>
    public interface ISort
    {
        IList<T> Sort<T>(IList<T> sort) where T : IComparable;
    }
}
