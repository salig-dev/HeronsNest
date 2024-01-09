using HeronsNest.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Modules.Response
{
    public class Response<T>(T? data, ActionResult result, string message = "")
    {
        public T? Data { get; set; } = data;
        public ActionResult Result { get; set; } = result;
        public string Message { get; } = message;  
    }
}
