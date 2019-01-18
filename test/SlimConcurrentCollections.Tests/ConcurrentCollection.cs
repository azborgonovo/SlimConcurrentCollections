using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace SlimConcurrentCollections.Tests
{
    public class ConcurrentCollection
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ConcurrentCollection(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }
        
        private readonly object _lock = new object();
        [Fact]
        public void Remove_Should_WorkWhenLockIsDoneBetweenIteratorAndModifier()
        {
            // Arrange
            var concurrentCollection = new ConcurrentCollection<int>();
            for (int i = 0; i < 500; i++)
            {
                concurrentCollection.Add(i);
            }

            // Act
            var collectionConsumeTasks = new List<Task>();
            int collectionTotalSize = concurrentCollection.Count;
            for (int i = 0; i < collectionTotalSize; i++)
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

            // Assert
            Assert.Empty(concurrentCollection);
        }

        [Fact]
        public void Remove_Should_ReturnFalseForSomeItemsWhenNoExternalLockIsUsed()
        {
            // Arrange
            var concurrentCollection = new ConcurrentCollection<int>();
            for (int i = 0; i < 500; i++)
            {
                concurrentCollection.Add(i);
            }

            // Act
            var collectionConsumeTasks = new List<Task>();
            int collectionTotalSize = concurrentCollection.Count;
            int removedItems = 0;
            for (int i = 0; i < collectionTotalSize; i++)
            {
                collectionConsumeTasks.Add(Task.Run(() =>
                {
                    var item = concurrentCollection.FirstOrDefault();
                    var removed = concurrentCollection.Remove(item);
                    if (removed)
                    {
                        removedItems++;
                    }
                }));
            }
            Task.WaitAll(collectionConsumeTasks.ToArray());

            // Assert
            Assert.Equal(collectionTotalSize - removedItems, concurrentCollection.Count);
        }

        [Fact]
        public void Remove_Should_WorkWhenIteratingDirectlyOnTheCollection()
        {
            // Arrange
            var concurrentCollection = new ConcurrentCollection<int>();
            for (int i = 0; i < 500; i++)
            {
                concurrentCollection.Add(i);
            }

            // Act
            var collectionConsumeTasks = new List<Task>();
            foreach (var item in concurrentCollection)
            {
                collectionConsumeTasks.Add(Task.Run(() =>
                {
                    concurrentCollection.Remove(item);
                }));
            }
            Task.WaitAll(collectionConsumeTasks.ToArray());

            // Assert
            Assert.Empty(concurrentCollection);
        }
    }
}
