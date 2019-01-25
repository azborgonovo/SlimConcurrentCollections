<a name='assembly'></a>
# SlimConcurrentCollections

## Contents

- [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1')
  - [Count](#P-SlimConcurrentCollections-ConcurrentCollection`1-Count 'SlimConcurrentCollections.ConcurrentCollection`1.Count')
  - [IsReadOnly](#P-SlimConcurrentCollections-ConcurrentCollection`1-IsReadOnly 'SlimConcurrentCollections.ConcurrentCollection`1.IsReadOnly')
  - [Item](#P-SlimConcurrentCollections-ConcurrentCollection`1-Item-System-Int32- 'SlimConcurrentCollections.ConcurrentCollection`1.Item(System.Int32)')
  - [Add(item)](#M-SlimConcurrentCollections-ConcurrentCollection`1-Add-`0- 'SlimConcurrentCollections.ConcurrentCollection`1.Add(`0)')
  - [Clear()](#M-SlimConcurrentCollections-ConcurrentCollection`1-Clear 'SlimConcurrentCollections.ConcurrentCollection`1.Clear')
  - [Contains(item)](#M-SlimConcurrentCollections-ConcurrentCollection`1-Contains-`0- 'SlimConcurrentCollections.ConcurrentCollection`1.Contains(`0)')
  - [CopyTo(array,arrayIndex)](#M-SlimConcurrentCollections-ConcurrentCollection`1-CopyTo-`0[],System-Int32- 'SlimConcurrentCollections.ConcurrentCollection`1.CopyTo(`0[],System.Int32)')
  - [Dispose()](#M-SlimConcurrentCollections-ConcurrentCollection`1-Dispose 'SlimConcurrentCollections.ConcurrentCollection`1.Dispose')
  - [GetEnumerator()](#M-SlimConcurrentCollections-ConcurrentCollection`1-GetEnumerator 'SlimConcurrentCollections.ConcurrentCollection`1.GetEnumerator')
  - [IndexOf(item)](#M-SlimConcurrentCollections-ConcurrentCollection`1-IndexOf-`0- 'SlimConcurrentCollections.ConcurrentCollection`1.IndexOf(`0)')
  - [Insert(index,item)](#M-SlimConcurrentCollections-ConcurrentCollection`1-Insert-System-Int32,`0- 'SlimConcurrentCollections.ConcurrentCollection`1.Insert(System.Int32,`0)')
  - [Remove(item)](#M-SlimConcurrentCollections-ConcurrentCollection`1-Remove-`0- 'SlimConcurrentCollections.ConcurrentCollection`1.Remove(`0)')
  - [RemoveAt(index)](#M-SlimConcurrentCollections-ConcurrentCollection`1-RemoveAt-System-Int32- 'SlimConcurrentCollections.ConcurrentCollection`1.RemoveAt(System.Int32)')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-SlimConcurrentCollections-ConcurrentCollection`1-System#Collections#IEnumerable#GetEnumerator 'SlimConcurrentCollections.ConcurrentCollection`1.System#Collections#IEnumerable#GetEnumerator')
- [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1')
  - [Count](#P-SlimConcurrentCollections-ConcurrentList`1-Count 'SlimConcurrentCollections.ConcurrentList`1.Count')
  - [IsReadOnly](#P-SlimConcurrentCollections-ConcurrentList`1-IsReadOnly 'SlimConcurrentCollections.ConcurrentList`1.IsReadOnly')
  - [Item](#P-SlimConcurrentCollections-ConcurrentList`1-Item-System-Int32- 'SlimConcurrentCollections.ConcurrentList`1.Item(System.Int32)')
  - [Add(item)](#M-SlimConcurrentCollections-ConcurrentList`1-Add-`0- 'SlimConcurrentCollections.ConcurrentList`1.Add(`0)')
  - [Clear()](#M-SlimConcurrentCollections-ConcurrentList`1-Clear 'SlimConcurrentCollections.ConcurrentList`1.Clear')
  - [Contains(item)](#M-SlimConcurrentCollections-ConcurrentList`1-Contains-`0- 'SlimConcurrentCollections.ConcurrentList`1.Contains(`0)')
  - [CopyTo(array,arrayIndex)](#M-SlimConcurrentCollections-ConcurrentList`1-CopyTo-`0[],System-Int32- 'SlimConcurrentCollections.ConcurrentList`1.CopyTo(`0[],System.Int32)')
  - [Dispose()](#M-SlimConcurrentCollections-ConcurrentList`1-Dispose 'SlimConcurrentCollections.ConcurrentList`1.Dispose')
  - [GetEnumerator()](#M-SlimConcurrentCollections-ConcurrentList`1-GetEnumerator 'SlimConcurrentCollections.ConcurrentList`1.GetEnumerator')
  - [IndexOf(item)](#M-SlimConcurrentCollections-ConcurrentList`1-IndexOf-`0- 'SlimConcurrentCollections.ConcurrentList`1.IndexOf(`0)')
  - [Insert(index,item)](#M-SlimConcurrentCollections-ConcurrentList`1-Insert-System-Int32,`0- 'SlimConcurrentCollections.ConcurrentList`1.Insert(System.Int32,`0)')
  - [Remove(item)](#M-SlimConcurrentCollections-ConcurrentList`1-Remove-`0- 'SlimConcurrentCollections.ConcurrentList`1.Remove(`0)')
  - [RemoveAt(index)](#M-SlimConcurrentCollections-ConcurrentList`1-RemoveAt-System-Int32- 'SlimConcurrentCollections.ConcurrentList`1.RemoveAt(System.Int32)')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-SlimConcurrentCollections-ConcurrentList`1-System#Collections#IEnumerable#GetEnumerator 'SlimConcurrentCollections.ConcurrentList`1.System#Collections#IEnumerable#GetEnumerator')

<a name='T-SlimConcurrentCollections-ConcurrentCollection`1'></a>
## ConcurrentCollection\`1 `type`

##### Namespace

SlimConcurrentCollections

##### Summary

Provides a base class for a generic thread-safe collection that can be accessed by multiple threads concurrently.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the collection. |

<a name='P-SlimConcurrentCollections-ConcurrentCollection`1-Count'></a>
### Count `property`

##### Summary

Gets the number of elements actually contained in the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Returns

The number of elements actually contained in the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='P-SlimConcurrentCollections-ConcurrentCollection`1-IsReadOnly'></a>
### IsReadOnly `property`

##### Summary

Gets a value indicating whether the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1')
is read-only.

##### Returns

true if the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1')is read-only; otherwise,
false.

<a name='P-SlimConcurrentCollections-ConcurrentCollection`1-Item-System-Int32-'></a>
### Item `property`

##### Summary

Gets or sets the element at the specified index.

##### Returns

The element at the specified index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the element to get or set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | index is less than zero.-or-index is equal to or greater than [Count](#P-SlimConcurrentCollections-ConcurrentCollection`1-Count 'SlimConcurrentCollections.ConcurrentCollection`1.Count'). |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | When using the getter, the [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. When using the setter, the [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered the lock in any mode. -or-The current thread has entered read mode, so trying to enter the lock in write mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-Add-`0-'></a>
### Add(item) `method`

##### Summary

Adds an object to the end of the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The object to be added to the end of the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1'). The value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-Clear'></a>
### Clear() `method`

##### Summary

Removes all elements from the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-Contains-`0-'></a>
### Contains(item) `method`

##### Summary

Determines whether an element is in the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Returns

true if item is found in the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1'); otherwise,
false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The object to locate in the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1'). The
value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-CopyTo-`0[],System-Int32-'></a>
### CopyTo(array,arrayIndex) `method`

##### Summary

Copies the entire [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1')to a compatible
one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'), starting at the specified index of the target array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`0[]](#T-`0[] '`0[]') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array')that is the destination of the elements copied
from [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1'). The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array')must have
zero-based indexing. |
| arrayIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | array is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | index is less than zero. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The number of elements in the source [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1')is greater than the available space from index to the end of the destination array. |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1')with the internal [ReaderWriterLockSlim](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim 'System.Threading.ReaderWriterLockSlim')object.

##### Parameters

This method has no parameters.

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Returns

An [IEnumerator\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator`1 'System.Collections.Generic.IEnumerator`1')for the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-IndexOf-`0-'></a>
### IndexOf(item) `method`

##### Summary

Searches for the specified object and returns the zero-based index of the first
occurrence within the entire [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Returns

The zero-based index of the first occurrence of item within the entire [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1'),
if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The object to locate in the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').
The value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-Insert-System-Int32,`0-'></a>
### Insert(index,item) `method`

##### Summary

Inserts an element into the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1')at the
specified index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index at which item should be inserted. |
| item | [\`0](#T-`0 '`0') | The object to insert. The value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | index is less than zero.-or-index is greater than [Count](#P-SlimConcurrentCollections-ConcurrentCollection`1-Count 'SlimConcurrentCollections.ConcurrentCollection`1.Count'). |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-Remove-`0-'></a>
### Remove(item) `method`

##### Summary

Removes the first occurrence of a specific object from the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Returns

true if item is successfully removed; otherwise, false.
This method also returns false if item was not found in the original [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The object to remove from the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1'). The value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-RemoveAt-System-Int32-'></a>
### RemoveAt(index) `method`

##### Summary

Removes the element at the specified index of the [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the element to remove. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | index is less than zero.-or-index is equal to or greater than [Count](#P-SlimConcurrentCollections-ConcurrentCollection`1-Count 'SlimConcurrentCollections.ConcurrentCollection`1.Count'). |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentCollection`1-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through a collection.

##### Returns

An System.Collections.IEnumerator object that can be used to iterate through
the collection.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='T-SlimConcurrentCollections-ConcurrentList`1'></a>
## ConcurrentList\`1 `type`

##### Namespace

SlimConcurrentCollections

##### Summary

Represents a thread-safe strongly typed list of objects that can be accessed by index.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |

##### Remarks

To guarantee thread safety during enumeration, the collection is locked during the entire enumeration.

<a name='P-SlimConcurrentCollections-ConcurrentList`1-Count'></a>
### Count `property`

##### Summary

Gets the number of elements actually contained in the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Returns

The number of elements actually contained in the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='P-SlimConcurrentCollections-ConcurrentList`1-IsReadOnly'></a>
### IsReadOnly `property`

##### Summary

Gets a value indicating whether the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1')
is read-only.

##### Returns

true if the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1')is read-only; otherwise,
false.

<a name='P-SlimConcurrentCollections-ConcurrentList`1-Item-System-Int32-'></a>
### Item `property`

##### Summary

Gets or sets the element at the specified index.

##### Returns

The element at the specified index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the element to get or set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | index is less than zero.-or-index is equal to or greater than [Count](#P-SlimConcurrentCollections-ConcurrentList`1-Count 'SlimConcurrentCollections.ConcurrentList`1.Count'). |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | When using the getter, the [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. When using the setter, the [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered the lock in any mode. -or-The current thread has entered read mode, so trying to enter the lock in write mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-Add-`0-'></a>
### Add(item) `method`

##### Summary

Adds an object to the end of the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The object to be added to the end of the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').
The value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-Clear'></a>
### Clear() `method`

##### Summary

Removes all elements from the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-Contains-`0-'></a>
### Contains(item) `method`

##### Summary

Determines whether an element is in the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Returns

true if item is found in the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1'); otherwise,
false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The object to locate in the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1'). The
value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-CopyTo-`0[],System-Int32-'></a>
### CopyTo(array,arrayIndex) `method`

##### Summary

Copies the entire [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1')to a compatible
one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'), starting at the specified index of the target array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`0[]](#T-`0[] '`0[]') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array')that is the destination of the elements copied
from [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1'). The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array')must have
zero-based indexing. |
| arrayIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | array is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | index is less than zero. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The number of elements in the source [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1')is greater than the available space from index to the end of the destination array. |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1')with the internal [ReaderWriterLockSlim](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim 'System.Threading.ReaderWriterLockSlim')object.

##### Parameters

This method has no parameters.

<a name='M-SlimConcurrentCollections-ConcurrentList`1-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Returns

An [IEnumerator\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator`1 'System.Collections.Generic.IEnumerator`1')for the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-IndexOf-`0-'></a>
### IndexOf(item) `method`

##### Summary

Searches for the specified object and returns the zero-based index of the first
occurrence within the entire [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Returns

The zero-based index of the first occurrence of item within the entire [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1'),
if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The object to locate in the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').
The value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-Insert-System-Int32,`0-'></a>
### Insert(index,item) `method`

##### Summary

Inserts an element into the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1')at the
specified index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index at which item should be inserted. |
| item | [\`0](#T-`0 '`0') | The object to insert. The value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | index is less than zero.-or-index is greater than [Count](#P-SlimConcurrentCollections-ConcurrentList`1-Count 'SlimConcurrentCollections.ConcurrentList`1.Count'). |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-Remove-`0-'></a>
### Remove(item) `method`

##### Summary

Removes the first occurrence of a specific object from the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Returns

true if item is successfully removed; otherwise, false.
This method also returns false if item was not found in the original [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The object to remove from the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1'). The value can be null for reference types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-RemoveAt-System-Int32-'></a>
### RemoveAt(index) `method`

##### Summary

Removes the element at the specified index of the [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the element to remove. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | index is less than zero.-or-index is equal to or greater than [Count](#P-SlimConcurrentCollections-ConcurrentList`1-Count 'SlimConcurrentCollections.ConcurrentList`1.Count'). |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')
and the current thread has already entered the lock in any mode. -or-The current
thread has entered read mode, so trying to enter the lock in write mode would
create the possibility of a deadlock. -or-The recursion number would exceed the
capacity of the counter. The limit is so large that applications should never
encounter it. |

<a name='M-SlimConcurrentCollections-ConcurrentList`1-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through a collection.

##### Returns

An System.Collections.IEnumerator object that can be used to iterate through
the collection.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.LockRecursionException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionException 'System.Threading.LockRecursionException') | The [RecursionPolicy](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ReaderWriterLockSlim.RecursionPolicy 'System.Threading.ReaderWriterLockSlim.RecursionPolicy')property is [NoRecursion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.LockRecursionPolicy.NoRecursion 'System.Threading.LockRecursionPolicy.NoRecursion')and the current thread has already entered read mode. -or-The current thread may not acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter it. |
