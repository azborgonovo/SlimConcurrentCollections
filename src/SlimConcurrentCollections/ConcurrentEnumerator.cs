using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace SlimConcurrentCollections
{
    internal class ConcurrentEnumerator<T> : IEnumerator<T>
    {
        private readonly IEnumerator<T> _inner;
        private readonly ReaderWriterLockSlim _enteredReadLock;

        public ConcurrentEnumerator(IEnumerator<T> inner, ReaderWriterLockSlim enteredReadLock)
        {
            _inner = inner;
            _enteredReadLock = enteredReadLock;
        }

        public bool MoveNext()
        {
            return _inner.MoveNext();
        }

        public void Reset()
        {
            _inner.Reset();
        }

        public T Current => _inner.Current;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enteredReadLock.ExitReadLock();
        }
    }
}
