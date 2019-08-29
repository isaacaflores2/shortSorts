using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Tests
{
    [TestClass()]
    public class BucketSortTests
    {      
        [TestMethod()]
        public void SortTest()
        {
            List<int> items = new List<int> { 1, 5, 3, 9, 5, 6, 8, 7, 2, 8 };
            List<int> expectedItems = new List<int> {1, 2, 3, 5, 5, 6, 7, 8, 8, 9};

            int numBuckets = 10;
            items = (List<int>) BucketSort.Sort(items, numBuckets);

            CollectionAssert.AreEqual(expectedItems, items);
        }
    }
}