using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Interfaces
{
    public interface DataLoader<T>
    {
        T Find();
    }
}
