using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace SlimConcurrentCollections
{
    /// <summary>
    /// Provides a base class for a generic thread-safe collection that can be accessed by multiple threads concurrently.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    [System.Runtime.InteropServices.ComVisible(false)]
    public class ConcurrentCollection<T> : IList<T>, ICollection<T>, IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable, IDisposable
    {
        private readonly Collection<T> _collection = new Collection<T>();
        private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        #region ICollection<T> implementation

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="ConcurrentCollection{T}"/>.
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerator{T}"/> for the <see cref="ConcurrentCollection{T}"/>.
        /// </returns>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered read mode. -or-The current thread
        /// may not acquire the read lock when it already holds the write lock. -or-The recursion
        /// number would exceed the capacity of the counter. This limit is so large that
        /// applications should never encounter it.
        /// </exception>
        public IEnumerator<T> GetEnumerator()
        {
            var collectionSnapshot = new Collection<T>();
            try
            {
                _lock.EnterReadLock();
                foreach (T item in _collection)
                {
                    collectionSnapshot.Add(item);
                }
            }
            finally
            {
                _lock.ExitReadLock();
            }
            return collectionSnapshot.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An System.Collections.IEnumerator object that can be used to iterate through
        /// the collection.
        /// </returns>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered read mode. -or-The current thread
        /// may not acquire the read lock when it already holds the write lock. -or-The recursion
        /// number would exceed the capacity of the counter. This limit is so large that
        /// applications should never encounter it.
        /// </exception>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Adds an object to the end of the <see cref="ConcurrentCollection{T}"/>.
        /// </summary>
        /// <param name="item">
        /// The object to be added to the end of the <see cref="ConcurrentCollection{T}"/>.
        /// The value can be null for reference types.
        /// </param>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered the lock in any mode. -or-The current
        /// thread has entered read mode, so trying to enter the lock in write mode would
        /// create the possibility of a deadlock. -or-The recursion number would exceed the
        /// capacity of the counter. The limit is so large that applications should never
        /// encounter it.
        /// </exception>
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

        /// <summary>
        /// Removes all elements from the <see cref="ConcurrentCollection{T}"/>.
        /// </summary>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered the lock in any mode. -or-The current
        /// thread has entered read mode, so trying to enter the lock in write mode would
        /// create the possibility of a deadlock. -or-The recursion number would exceed the
        /// capacity of the counter. The limit is so large that applications should never
        /// encounter it.
        /// </exception>
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

        /// <summary>
        /// Determines whether an element is in the <see cref="ConcurrentCollection{T}"/>.
        /// </summary>
        /// <param name="item">
        /// The object to locate in the <see cref="ConcurrentCollection{T}"/>. The
        /// value can be null for reference types.
        /// </param>
        /// <returns>
        /// true if item is found in the <see cref="ConcurrentCollection{T}"/>; otherwise,
        /// false.
        /// </returns>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered read mode. -or-The current thread
        /// may not acquire the read lock when it already holds the write lock. -or-The recursion
        /// number would exceed the capacity of the counter. This limit is so large that
        /// applications should never encounter it.
        /// </exception>
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

        /// <summary>
        /// Copies the entire <see cref="ConcurrentCollection{T}"/> to a compatible
        /// one-dimensional <see cref="Array"/>, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">
        /// The one-dimensional <see cref="System.Array"/> that is the destination of the elements copied
        /// from <see cref="ConcurrentCollection{T}"/>. The <see cref="Array"/> must have
        /// zero-based indexing.
        /// </param>
        /// <param name="arrayIndex"></param>
        /// <exception cref="ArgumentNullException">
        /// array is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// index is less than zero.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The number of elements in the source <see cref="ConcurrentCollection{T}"/>
        /// is greater than the available space from index to the end of the destination
        /// array.
        /// </exception>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered read mode. -or-The current thread
        /// may not acquire the read lock when it already holds the write lock. -or-The recursion
        /// number would exceed the capacity of the counter. This limit is so large that
        /// applications should never encounter it.
        /// </exception>
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

        /// <summary>
        /// Removes the first occurrence of a specific object from the <see cref="ConcurrentCollection{T}"/>.
        /// </summary>
        /// <param name="item">
        /// The object to remove from the <see cref="ConcurrentCollection{T}"/>. The value can be null for reference types.
        /// </param>
        /// <returns>
        /// true if item is successfully removed; otherwise, false.
        /// This method also returns false if item was not found in the original <see cref="ConcurrentCollection{T}"/>.
        /// </returns>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered the lock in any mode. -or-The current
        /// thread has entered read mode, so trying to enter the lock in write mode would
        /// create the possibility of a deadlock. -or-The recursion number would exceed the
        /// capacity of the counter. The limit is so large that applications should never
        /// encounter it.
        /// </exception>
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
        
        /// <summary>
        /// Gets the number of elements actually contained in the <see cref="ConcurrentCollection{T}"/>.
        /// </summary>
        /// <returns>
        /// The number of elements actually contained in the <see cref="ConcurrentCollection{T}"/>.
        /// </returns>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered read mode. -or-The current thread
        /// may not acquire the read lock when it already holds the write lock. -or-The recursion
        /// number would exceed the capacity of the counter. This limit is so large that
        /// applications should never encounter it.
        /// </exception>
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

        /// <summary>
        /// Gets a value indicating whether the <see cref="ICollection{T}"/>
        /// is read-only.
        /// </summary>
        /// <returns>
        /// true if the <see cref="ICollection{T}"/> is read-only; otherwise,
        /// false.
        /// </returns>
        public bool IsReadOnly => false;

        #endregion

        #region IList<T> implementation

        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <returns>The element at the specified index.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// index is less than zero.-or-index is equal to or greater than <see cref="ConcurrentCollection{T}.Count"/>.
        /// </exception>
        /// <exception cref="LockRecursionException">
        /// When using the getter, the <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered read mode. -or-The current thread
        /// may not acquire the read lock when it already holds the write lock. -or-The recursion
        /// number would exceed the capacity of the counter. This limit is so large that
        /// applications should never encounter it.
        /// When using the setter, the <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered the lock in any mode. -or-The current
        /// thread has entered read mode, so trying to enter the lock in write mode would
        /// create the possibility of a deadlock. -or-The recursion number would exceed the
        /// capacity of the counter. The limit is so large that applications should never
        /// encounter it.
        /// </exception>
        public T this[int index]
        {
            get
            {
                try
                {
                    _lock.EnterReadLock();
                    return _collection[index];
                }
                finally
                {
                    _lock.ExitReadLock();
                }
            }
            set
            {
                try
                {
                    _lock.EnterWriteLock();
                    _collection[index] = value;
                }
                finally
                {
                    _lock.ExitWriteLock();
                }
            }
        }

        /// <summary>
        /// Searches for the specified object and returns the zero-based index of the first
        /// occurrence within the entire <see cref="ConcurrentCollection{T}"/>.
        /// </summary>
        /// <param name="item">
        /// The object to locate in the <see cref="ConcurrentCollection{T}"/>.
        /// The value can be null for reference types.
        /// </param>
        /// <returns>
        /// The zero-based index of the first occurrence of item within the entire <see cref="ConcurrentCollection{T}"/>,
        /// if found; otherwise, -1.
        /// </returns>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered read mode. -or-The current thread
        /// may not acquire the read lock when it already holds the write lock. -or-The recursion
        /// number would exceed the capacity of the counter. This limit is so large that
        /// applications should never encounter it.
        /// </exception>
        public int IndexOf(T item)
        {
            try
            {
                _lock.EnterReadLock();
                return _collection.IndexOf(item);
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }

        /// <summary>
        /// Inserts an element into the <see cref="ConcurrentCollection{T}"/> at the
        /// specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="item">The object to insert. The value can be null for reference types.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// index is less than zero.-or-index is greater than <see cref="ConcurrentCollection{T}.Count"/>.
        /// </exception>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered the lock in any mode. -or-The current
        /// thread has entered read mode, so trying to enter the lock in write mode would
        /// create the possibility of a deadlock. -or-The recursion number would exceed the
        /// capacity of the counter. The limit is so large that applications should never
        /// encounter it.
        /// </exception>
        public void Insert(int index, T item)
        {
            try
            {
                _lock.EnterWriteLock();
                _collection.Insert(index, item);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Removes the element at the specified index of the <see cref="ConcurrentCollection{T}"/>.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// index is less than zero.-or-index is equal to or greater than <see cref="ConcurrentCollection{T}.Count"/>.
        /// </exception>
        /// <exception cref="LockRecursionException">
        /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
        /// and the current thread has already entered the lock in any mode. -or-The current
        /// thread has entered read mode, so trying to enter the lock in write mode would
        /// create the possibility of a deadlock. -or-The recursion number would exceed the
        /// capacity of the counter. The limit is so large that applications should never
        /// encounter it.
        /// </exception>
        public void RemoveAt(int index)
        {
            try
            {
                _lock.EnterWriteLock();
                _collection.RemoveAt(index);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        #endregion

        #region IDisposable implementation

        /// <summary>
        /// Disposes the <see cref="ConcurrentCollection{T}"/> with the internal <see cref="ReaderWriterLockSlim"/> object.
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