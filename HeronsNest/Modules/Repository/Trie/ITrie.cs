using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Modules.Repository.Trie
{
    public interface ITrie<T>
    {
        public void Insert(T data);
        public void Update(T data);
        public void Delete(T data);

        public T SearchFirst(int id);
        public List<T> SearchRelated(Func<T, bool> Term);
    }
}
