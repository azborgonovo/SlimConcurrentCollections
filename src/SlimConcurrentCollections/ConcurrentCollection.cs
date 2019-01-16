using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace SlimConcurrentCollections
{
    /// <summary>
    /// Provides a thread-safe base class for a generic collection that can be accessed by multiple threads concurrently.
    /// </summary>
    /// <remarks>To guarantee thread safety during enumeration, the collection is locked during the entire enumeration.</remarks>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    public class ConcurrentCollection<T> : ICollection<T>
    {
        private readonly ICollection<T> _collection = new Collection<T>();
        private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        // public ReaderWriterLockSlim Lock => _lock;

        #region ICollection<T> implementation

        public IEnumerator<T> GetEnumerator()
        {
            return new ConcurrentEnumerator<T>(_collection.GetEnumerator(), _lock);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            try
            {
                _lock.EnterWriteLock();
                _collection.Add(item);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        public void Clear()
        {
            try
            {
                _lock.EnterWriteLock();
                _collection.Clear();
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        public bool Contains(T item)
        {
            try
            {
                _lock.EnterReadLock();
                return _collection.Contains(item);
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            try
            {
                _lock.EnterReadLock();
                _collection.CopyTo(array, arrayIndex);
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }

        public bool Remove(T item)
        {
            try
            {
                _lock.EnterWriteLock();
                return _collection.Remove(item);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        public int Count => _collection.Count;

        public bool IsReadOnly => _collection.IsReadOnly;

        #endregion
    }
}