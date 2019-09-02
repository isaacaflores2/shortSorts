using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public abstract class SortIntList : ISort<int>
    {
        public IList<int> Items {get; set;}

        public SortIntList(IList<int> items)
        {
            if (items == null)
            {
                throw new System.ArgumentException("Provided list of items is null. Provide a valid list to create an instance of the class.");
            }
            Items = items;
        }
        
        public abstract IList<int> Sort();

        protected void swap(int firstIndex, int secondIndex)
        {
            int temp = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = temp;
        }
    }
}
