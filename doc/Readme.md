<a name='assembly'></a>
# SlimConcurrentCollections

## Contents

- [ConcurrentCollection\`1](#T-SlimConcurrentCollections-ConcurrentCollection`1 'SlimConcurrentCollections.ConcurrentCollection`1')
- [ConcurrentList\`1](#T-SlimConcurrentCollections-ConcurrentList`1 'SlimConcurrentCollections.ConcurrentList`1')

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

##### Remarks

To guarantee thread safety during enumeration, the collection is locked during the entire enumeration.

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
