using HeronsNest.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Modules.Response
{
    internal class BorrowResponse<T> : Response<T>
    {
        public BorrowResponse(T data, ActionResult result, string message = "") : base(data, result, message: message)
        {
        }
    }
}
