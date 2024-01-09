using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms
{
    public class Sorter<T>
    {

        public List<T> Sort(List<T> values, Func<T, T, bool> condition)
        {
            if (values.Count <= 1)
            {
                // Base case: lists with 0 or 1 element are already sorted
                return values;
            }

            int pivot = (int)Math.Floor((double)values.Count / 2);

            List<T> left = Sort(Partition(values, 0, pivot), condition);  // Note: Pivot - 1 removed
            List<T> right = Sort(Partition(values, pivot, values.Count), condition);

            return Merge(left, right, condition);
        }

        private List<T> Partition(List<T> Values, int Start, int End)
        {
            List<T> NewBooks = [];

            for (int i = Start; i < End; i++)
            {
                NewBooks.Add(Values[i]);
            }

            return NewBooks;
        }

        private List<T> Merge(List<T> Left, List<T> Right, Func<T, T, bool> Condition)
        {
            int LeftIndex = 0;
            int RightIndex = 0;
            List<T> SortedBooks = [];

            while (LeftIndex < Left.Count && RightIndex < Right.Count)
            {
                if (Condition(Left[LeftIndex], Right[RightIndex]))
                {
                    SortedBooks.Add(Left[LeftIndex]);
                    LeftIndex++;
                }
                else
                {
                    SortedBooks.Add(Right[RightIndex]);
                    RightIndex++;
                }
            }

            SortedBooks.AddRange(Left.Skip(LeftIndex));
            SortedBooks.AddRange(Right.Skip(RightIndex));

            return SortedBooks;

        }
    }
}
