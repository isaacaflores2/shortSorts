using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSort : SortIntList
    {
        public QuickSort(List<int> items) : base(items)
        {
        }

        public override IList<int> Sort()
        {
            int initialPivotIndex = selectPivotIndex();
            quickSort(0, initialPivotIndex, initialPivotIndex);
            return Items;
        }

        protected int selectPivotIndex()
        {
            return Items.Count() - 1;            
        }

        protected void quickSort(int leftIndex, int rightIndex, int pivotIndex)
        {            
            int newPivot = partition(leftIndex, rightIndex, pivotIndex);

            if (newPivot == -1)
                return;

            quickSort(leftIndex, newPivot - 1, newPivot -1);
            quickSort(newPivot + 1, rightIndex, rightIndex);
        }

        protected int partition(int leftIndex, int rightIndex, int pivotIndex)
        {
            if (pivotIndex < 0 || (leftIndex == rightIndex ) || (leftIndex > rightIndex) )
            {
                return -1;
            }

            int pivotPoint = leftIndex;
            int pivotValue = Items[pivotIndex];

            for(int i = leftIndex; i < rightIndex; i++)
            {
                if(Items[i] < pivotValue)
                {                    
                    swap(i, pivotPoint);
                    pivotPoint++;
                }               
            }

            if (pivotValue < Items[pivotPoint])
            {
                swap(pivotPoint, pivotIndex);
            }

            return pivotPoint;
        }
    }
}
