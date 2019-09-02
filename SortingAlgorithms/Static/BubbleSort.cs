using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static IList<int> Items { get; set; }

        public static IList<int> Sort(IList<int> items)
        {
            Items = items;
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = bubble();                
            }
            return Items;
        }        

        private static bool bubble()
        {
            bool result = true;

            for (int i = 0; i < Items.Count - 1; i++)
            {
                if (Items[i] > Items[i + 1])
                {
                    swap(i, i + 1);
                    result = false;
                }
            }
            return result;
        }

        private static void swap(int firstIndex, int secondIndex)
        {
            int temp = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = temp;
        }
    }
}
