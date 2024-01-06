using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Enums
{
    public class SearchEventArgs(string keyword, string filter) : EventArgs
    {
        public string Keyword = keyword;
        public string Filter = filter;

    }
}
