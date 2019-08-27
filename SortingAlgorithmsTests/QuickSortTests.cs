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
    public class QuickSortTests
    {        
        [TestMethod()]
        public void SortTest()
        {
            List<int> items = new List<int> { 40, 20, 30, 2, 5, 90, 15 };
            List<int> expectedItems = new List<int> { 2, 5, 15, 20, 30, 40, 90 };

            QuickSort quickSort = new QuickSort(items);
            items = (List<int>) quickSort.Sort(); 

            CollectionAssert.AreEqual(expectedItems, items);            
        }
    }
}