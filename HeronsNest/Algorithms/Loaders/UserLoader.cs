using HeronsNest.Context;
using HeronsNest.Models.DTO;
using HeronsNest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms.Loaders
{
    public class UserLoader(BookContext _context)
    {
        readonly BookContext context = _context;

        public User? FindUser(string userId) {
            var data =  _context.Users.Find(userId);
            if (data != null)
            {
                return data;
            }

            return null;
        }

        public List<User> GetAllUsers()
        {
            return [.. _context.Users];
        }
    }
}
