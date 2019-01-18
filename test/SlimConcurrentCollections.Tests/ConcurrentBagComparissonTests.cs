using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace SlimConcurrentCollections.Tests
{
    public class ConcurrentBagComparissonTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ConcurrentBagComparissonTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        #region ConcurrentCollection_ShouldBeFasterThanAddingAndRemovingItensConcurrentBagExample

        [Fact]
        public void ConcurrentCollection_ShouldBeFasterThanAddingAndRemovingItensConcurrentBagExample()
        {
            var bagStopWatch = Stopwatch.StartNew();
            ConcurrentBagTest();
            bagStopWatch.Stop();
            _testOutputHelper.WriteLine(bagStopWatch.Elapsed.ToString(@"ss\.ff"));

            var collectionStopWatch = Stopwatch.StartNew();
            ConcurrentCollectionTest();
            collectionStopWatch.Stop();
            _testOutputHelper.WriteLine(collectionStopWatch.Elapsed.ToString(@"ss\.ff"));

            Assert.True(bagStopWatch.Elapsed > collectionStopWatch.Elapsed);
        }

        private void ConcurrentBagTest()
        {
            // Add to ConcurrentBag concurrently
            ConcurrentBag<int> cb = new ConcurrentBag<int>();
            List<Task> bagAddTasks = new List<Task>();
            for (int i = 0; i < 500; i++)
            {
                var numberToAdd = i;
                bagAddTasks.Add(Task.Run(() => cb.Add(numberToAdd)));
            }

            // Wait for all tasks to complete
            Task.WaitAll(bagAddTasks.ToArray());

            // Consume the items in the bag
            var bagConsumeTasks = new List<Task>();
            int itemsInBag = 0;
            _testOutputHelper.WriteLine($"There are {cb.Count} items in the bag");
            while (!cb.IsEmpty)
            {
                bagConsumeTasks.Add(Task.Run(() =>
                {
                    int item;
                    if (cb.TryTake(out item))
                    {
                        itemsInBag++;
                    }
                }));
            }
            Task.WaitAll(bagConsumeTasks.ToArray());

            _testOutputHelper.WriteLine($"There were {itemsInBag} items in the bag");

            // Checks the bag for an item
            // The bag should be empty and this should not print anything
            int unexpectedItem;
            if (cb.TryPeek(out unexpectedItem))
                _testOutputHelper.WriteLine("Found an item in the bag when it should be empty");
        }

        private object _lock = new object();
        private void ConcurrentCollectionTest()
        {
            // Add to ConcurrentCollection concurrently
            var concurrentCollection = new ConcurrentCollection<int>();
            var collectionAddTasks = new List<Task>();
            for (int i = 0; i < 500; i++)
            {
                var numberToAdd = i;
                collectionAddTasks.Add(Task.Run(() => concurrentCollection.Add(numberToAdd)));
            }

            // Wait for all tasks to complete
            Task.WaitAll(collectionAddTasks.ToArray());

            // Consume the items in the collection
            var collectionConsumeTasks = new List<Task>();
            int itemsInCollection = 0;
            int notRemoved = 0;
            foreach (var item in concurrentCollection)
            {
                collectionConsumeTasks.Add(Task.Run(() =>
                {
                    if (concurrentCollection.Remove(item))
                    {
                        itemsInCollection++;
                    }
                    else
                    {
                        notRemoved++;
                    }
                }));
            }
            Task.WaitAll(collectionConsumeTasks.ToArray());

            _testOutputHelper.WriteLine($"There were {itemsInCollection} items in the collection");
            _testOutputHelper.WriteLine($"Not removed {notRemoved}");

            // Checks the bag for an item
            // The bag should be empty and this should not print anything
            if (concurrentCollection.Count > 0)
                _testOutputHelper.WriteLine("Found an item in the collection when it should be empty");
        }

        #endregion


    }
}
