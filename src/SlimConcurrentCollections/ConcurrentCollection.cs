using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace SlimConcurrentCollections
{
    /// <summary>
    /// Provides a base class for a generic thread-safe collection that can be accessed by multiple threads concurrently.
    /// </summary>
    /// <remarks>To guarantee thread safety during enumeration, the collection is locked during the entire enumeration.</remarks>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    // [System.Runtime.InteropServices.ComVisible(false)]
    // [System.Serializable]
    public class ConcurrentCollection<T> : ICollection<T>, IDisposable //, IEnumerable<T>, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, IList
    {
        private readonly ICollection<T> _collection = new Collection<T>();
        private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        #region ICollection<T> implementation

        public IEnumerator<T> GetEnumerator()
        {
            // https://stackoverflow.com/questions/24820270/is-enumerator-thread-safe-after-getting-with-lock
            _lock.EnterReadLock();
            var collectionSnapshot = _collection.ToList();
            return new ConcurrentEnumerator<T>(collectionSnapshot.GetEnumerator(), _lock);
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

        public int Count
        {
            get
            {
                try
                {
                    _lock.EnterReadLock();
                    return _collection.Count;
                }
                finally
                {
                    _lock.ExitReadLock();
                }
            }
        }

        public bool IsReadOnly => _collection.IsReadOnly;

        #endregion

        #region IDisposable implementation

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            try
            {
                _lock?.Dispose();
            }
            catch
            {
            }
        }

        #endregion
    }
}