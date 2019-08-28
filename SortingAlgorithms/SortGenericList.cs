using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public abstract class SortGenericList<T> : ISort<T>
    {
        public IList<T> Items {get; set;}

        public SortGenericList(IList<T> items)
        {
            if (items == null)
            {
                throw new System.ArgumentException("Provided list of items is null. Provide a valid list to create an instance of the class.");                
            }

            
            Items = items; 
        }

        public abstract IList<T> Sort();        
    }
}
