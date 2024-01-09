using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms
{
    public class Sorter<T>(List<T> values)
    {
        private List<T> Values = values;

        public List<T> Sort(string sortKey)
        {
            int Pivot = (int)Math.Floor((double)Values.Count / 2);

            T[] ValuesArray = new T[Pivot]; 
        }

        private List<T> Partition(int Start, int End)
        {
            throw new NotImplementedException();
        }

        private List<T> Merge(List<T> Left, List<T> Right)
        {
            throw new NotImplementedException();

        }
    }
}
