using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort : SortIntList
    {

        public BubbleSort(IList<int> items) : base(items)
        {
        }
        
        public override IList<int> Sort()
        {                     
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = bubble();                
            }
            return Items;
        }        

        private bool bubble()
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
    }
}
