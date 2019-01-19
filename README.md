[![Build status](https://ci.appveyor.com/api/projects/status/jxt45i2v4xnyw881?svg=true)](https://ci.appveyor.com/project/AndreBorgonovo/slimconcurrentcollections)

# SlimConcurrentCollections
Provides thread-safe collection classes that implement the (missing) System.Collections.Generic interfaces.

Available Types:

    ConcurrentCollection<T>
    ConcurrentList<T>

Documentation is available at https://github.com/azborgonovo/SlimConcurrentCollections/tree/master/doc

> This package is in **experimental** phase. Feedback and bug report are really appreciated.

## Installing

You should install SlimConcurrentCollections with NuGet:

    Install-Package SlimConcurrentCollections

Or via the .NET Core command line interface:

    dotnet add package SlimConcurrentCollections

## Application & Design

Use the SlimConcurrentCollections ONLY if the [System.Collections.Concurrent](https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent) types do not satisfy your requirements and you need richer interfaces such as [ICollection&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1) and [IList&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1).

The SlimConcurrentCollections make use of the [ReadWriteLockSlim](https://docs.microsoft.com/en-us/dotnet/api/system.threading.readerwriterlockslim) class to provide thread-safety to collections by locking the entire collection according the nature of each operation. That means that *command/modifier* methods are locked with WriteLock and *query* methods are locked with ReadLock. This is a simplistic approach if compared to the sofisticated mechanisms used in the [System.Collections.Concurrent](https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent) types.

## Enumerating

An enumeration (foreach) of one of the SlimConcurrentCollections represents a snapshot of the collection at a precise point in time. If other threads are adding or removing items concurrently while you are executing the loop, then the loop might not represent the actual state of the collection.

The following examples illustrates some use cases.

```csharp
    // This works = the collection gets empty
    foreach (var item in concurrentCollection)
    {
        collectionConsumeTasks.Add(Task.Run(() =>
        {
            concurrentCollection.Remove(item);
        }));
    }
    Task.WaitAll(collectionConsumeTasks.ToArray());
```

```csharp
    // This works = the collection gets empty
    int total = concurrentCollection.Count;
    for (int i = 0; i < total; i++)
    {
        collectionConsumeTasks.Add(Task.Run(() =>
        {
            lock (_lock)
            {
                var item = concurrentCollection.FirstOrDefault();
                concurrentCollection.Remove(item);
            }
        }));
    }
    Task.WaitAll(collectionConsumeTasks.ToArray());
```

```csharp
    // This will not fail, but in the end the collection is not
    // empty given that diiferent threads can receive the same
    // item returned by the FirstOrDefault() method because
    // the enumeration returns a snapshot of the collection
    for (int i = 0; i < total; i++)
    {
        collectionConsumeTasks.Add(Task.Run(() =>
        {
            var item = concurrentCollection.FirstOrDefault();
            concurrentCollection.Remove(item);
        }));
    }
    Task.WaitAll(collectionConsumeTasks.ToArray());
```
