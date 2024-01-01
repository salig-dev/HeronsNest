using HeronsNest.Context;
using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms.Loaders
{
    public class CategoryLoader(BookContext _context)
    {
        readonly BookContext context = _context;

        public List<Category> GetRandomCategories(int amount)
        {
            var data = context.Categories.ToList();
            Debug.WriteLine(data.Count);
            List<Category> randomData = [];
            
            for (int i = 0; i < amount - 1; i++)
            {
                var randomIndex = new Random().Next(0, data.Count);
                randomData.Add(data[randomIndex]);
            }

            return randomData;
        }
    }
}
