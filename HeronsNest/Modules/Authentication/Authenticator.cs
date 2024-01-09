using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeronsNest.Algorithms.Loaders;
using HeronsNest.Context;
using HeronsNest.Enums;
using HeronsNest.Models.DTO;
using HeronsNest.Singleton;

namespace HeronsNest.Algorithms.Authentication
{
    public class Authenticator(BookContext _context)
    {
        private readonly BookContext Context = _context;
        UserLoader UserLoader = new(_context);


        public AuthResult LoginUser(UserDTO credentials)
        {
            var User = UserLoader.FindUser(credentials.Id);

            if (User == null) return AuthResult.NotFound;

            UserSession.Instance.User = User;

            return User.Id == credentials.Id && User.Password == credentials.Password ? AuthResult.Success : AuthResult.Failed;
        }


    }
}
