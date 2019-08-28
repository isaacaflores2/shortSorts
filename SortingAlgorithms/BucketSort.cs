using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BucketSort : SortIntList
    {
        private List<LinkedList<int>> buckets;

        public BucketSort(List<int> items): base(items)
        {
        }

        public override IList<int> Sort()
        {
            createBuckets(); 
            
            foreach(LinkedList<int> bucket in buckets)
            {
                sortBucket(bucket);
            }

            return Items; 
        }

        protected IList<int> createBuckets()
        {
            buckets = new List<LinkedList<int>>();
            int itemsSize = Items.Count();

            foreach( int item in Items)
            {
                int bucketIndex = item % itemsSize;
                addItemToBucket(item, bucketIndex);
            }

            mergeBuckets();
            return Items;
        }

        private void addItemToBucket(int item, int bucketIndex)
        {
            LinkedList<int> bucketLinkedList = buckets[bucketIndex];
        }

        protected void sortBucket(LinkedList<int> linkedList)
        {
            throw new NotImplementedException();           
        }

        protected void mergeBuckets()
        {
            throw new NotImplementedException();
        }

    }
}
