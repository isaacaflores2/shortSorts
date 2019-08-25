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
    public class MergeSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            List<int> items = new List<int> {40,20,30,2,5,90,15};            
            List<int> expectedItems = new List<int> {2,5,15,20,30,40,90};
            
            MergeSort mergeSort = new MergeSort(items);
            items = (List<int>) mergeSort.Sort(); 

            CollectionAssert.AreEqual(expectedItems, items);

        }
    }
}