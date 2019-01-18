using System.Collections.Generic;

namespace SlimConcurrentCollections
{
    /// <summary>
    /// Represents a thread-safe strongly typed list of objects that can be accessed by index.
    /// </summary>
    /// <remarks>To guarantee thread safety during enumeration, the collection is locked during the entire enumeration.</remarks>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    // [System.Serializable]
    public class ConcurrentList<T> // : ICollection<T>, IEnumerable<T>, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, IList
    {
        private List<T> _list = new List<T>();
    }
}

