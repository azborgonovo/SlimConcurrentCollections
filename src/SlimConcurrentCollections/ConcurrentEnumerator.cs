using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace SlimConcurrentCollections
{
    internal class ConcurrentEnumerator<T> : IEnumerator<T>
    {
        private readonly IEnumerator<T> _inner;
        private readonly ReaderWriterLockSlim _lock;

        public ConcurrentEnumerator(IEnumerator<T> inner, ReaderWriterLockSlim @lock)
        {
            _inner = inner;
            _lock = @lock;
            _lock.EnterUpgradeableReadLock();
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
            _lock.ExitUpgradeableReadLock();
        }
    }
}
