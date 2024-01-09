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

        public List<T> Sort(List<T> Values, Func<List<T>, List<T>, bool> Condition)
        {
            int Pivot = (int)Math.Floor((double)Values.Count / 2);

            List<T> Left = Sort(Partition(Values, 0, Pivot - 1), Condition); 
            List<T> Right = Sort(Partition(Values, Pivot, Values.Count), Condition);

            return Merge(Left, Right, Condition);
        }

        private List<T> Partition(List<T> Values, int Start, int End)
        {
            List<T> NewBooks = [];

            for (int i = Start; i < End; i++)
            {
                NewBooks.Add(Values[i]);
            }

            return [.. NewBooks];
        }

        private List<T> Merge(List<T> Left, List<T> Right, Func<List<T>, List<T>, bool> Condition)
        {
            int LeftIndex = 0;
            int RightIndex = 0;
            List<T> SortedBooks = [];

            while (LeftIndex < Left.Count && RightIndex < Right.Count)
            {
                if (Condition(Left, Right))
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
