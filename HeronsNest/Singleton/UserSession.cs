using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Singleton
{
    public sealed class UserSession()
    {
        public User? User { get; set; }

        private static UserSession? instance;

        public static UserSession Instance
        {
            get
            {
                if (instance == null) {
                    instance = new();
                }

                return instance!;
            }
        }
    }
}
