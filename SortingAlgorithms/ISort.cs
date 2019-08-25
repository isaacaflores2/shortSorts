using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    interface ISort<T>
    {
        IList<T> Sort();
    }
}
