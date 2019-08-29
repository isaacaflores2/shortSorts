using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class BucketSort
    {
        static List<LinkedList<int>> buckets;
        static List<int> Items {get; set;}
        static int NumBuckets { get; set; }
      
        public static IList<int> Sort(List<int> items, int numBuckets)
        {
            Items = items;
            NumBuckets = numBuckets;
            createBuckets();
            sortAllBuckets();
            mergeAllBuckets();
            return Items;
        }

        static void createBuckets()
        {
            buckets = new List<LinkedList<int>>();
            initializeBuckets();
            addAllItemsToBuckets();
        }
        
        static void initializeBuckets()
        {
            for(int i = 0; i < NumBuckets; i++)
            {
                buckets.Add(null);
            }
        }

        static void addAllItemsToBuckets()
        {
            foreach (int item in Items)
            {
                int bucketIndex = item % NumBuckets;
                addItemToBucket(item, bucketIndex);
            }
        }

        static void addItemToBucket(int item, int bucketIndex)
        {
            LinkedList<int> bucketLinkedList = buckets[bucketIndex];
            if(bucketLinkedList == null)
            {
                bucketLinkedList = new LinkedList<int>(); 
            }            
            bucketLinkedList.AddLast(item);
            buckets[bucketIndex] = bucketLinkedList;
        }

        static void sortAllBuckets()
        {
            foreach (LinkedList<int> bucket in buckets)
            {
                if(bucket != null )
                    sortBucket(bucket);
            }
        }

        static void sortBucket(LinkedList<int> linkedList)
        {
            List<int> bucketList = new List<int>(linkedList);
            QuickSort quickSort = new QuickSort(bucketList);
            bucketList = (List<int>) quickSort.Sort();
            linkedList = new LinkedList<int>(bucketList);
        }

        static void mergeAllBuckets()
        {
            int itemsIndex = 0; 
            foreach (LinkedList<int> bucket in buckets)
            {
                if(bucket != null)
                    itemsIndex = mergeBucket(bucket, itemsIndex);                 
            }
        }

        static int mergeBucket(LinkedList<int> bucket, int startIndex)
        {
            int itemsIndex = startIndex; 
            foreach(int item in bucket)
            {
                Items[itemsIndex] = item; 
                itemsIndex++; 
            }
            return itemsIndex; 
        }
    }
}
