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
    public class BubbleSortTests
    {
     
        [TestMethod()]
        public void sortTest()
        {
            List<int> items = new List<int> {3,2,5,1,6};            
            List<int> expectedItems = new List<int> { 1,2,3,5,6};
            
            BubbleSort bubbleSort = new BubbleSort(items);
            items =  (List<int>) bubbleSort.Sort();
            
            CollectionAssert.AreEqual(expectedItems, items);            
        }
    }
}