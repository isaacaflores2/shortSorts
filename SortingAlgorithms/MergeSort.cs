using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort : SortIntList
    {
        
        public MergeSort(IList<int> items) : base(items)
        {        
        }

        public override IList<int> Sort()
        {
            mergeSort(0, Items.Count - 1);
            return Items; 
        }  

        private void mergeSort(int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                mergeSort(leftIndex, middleIndex);
                mergeSort(middleIndex + 1, rightIndex);
                merge(leftIndex, middleIndex, rightIndex);
            }
        }

        private void merge(int leftIndex, int middleIndex, int rightIndex)
        {
            int sizeOfLeftSubArray = middleIndex - leftIndex + 1;
            int sizeOfRightSubArray = rightIndex - middleIndex;

            int[] leftSubArray = copyFromItems(leftIndex, sizeOfLeftSubArray); 
            int[] rightSubArray = copyFromItems(middleIndex +1, sizeOfRightSubArray);
            
            int lIndex = 0;
            int rIndex= 0;
            int index = leftIndex;
            int leftValue;
            int rightValue;

            while(lIndex < sizeOfLeftSubArray && rIndex < sizeOfRightSubArray)
            {
                leftValue = leftSubArray[lIndex];
                rightValue = rightSubArray[rIndex];

                if(leftValue < rightValue)
                {
                    Items[index] = leftValue;
                    lIndex++; 
                }
                else
                {
                    Items[index] = rightValue;
                    rIndex++;
                }
                index++; 
            }

            while(lIndex < sizeOfLeftSubArray)
            {
                Items[index] = leftSubArray[lIndex]; 
                lIndex++;
                index++;
            }

            while (lIndex < sizeOfLeftSubArray)
            {
                Items[index] = rightSubArray[rIndex]; ;
                lIndex++;
                index++;
            }
        }

        private int[] copyFromItems(int leftIndex, int size)
        {
            int[] array = new int[size];           

            for(int i = 0; i < size; i++)
            {
                array[i] = Items[leftIndex + i];
            }      
            return array;
        }

    }
}
