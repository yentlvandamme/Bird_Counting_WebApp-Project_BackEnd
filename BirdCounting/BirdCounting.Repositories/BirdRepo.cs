using BirdCounting.Models;
using BirdCounting.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirdCounting.Repositories
{
    public class BirdRepo : IBirdRepo
    {
        private ApplicationDbContext _context;

        public BirdRepo(ApplicationDbContext context)
        {
            this._context = context;
        }

        public List<Bird> GetAllBirds()
        {
            return _context.Birds.OrderBy(b => b.Name).ToList();
        }

        public Bird GetBirdById(int id)
        {
            return _context.Birds.Where(b => b.ID == id).FirstOrDefault();
        }
    }
}
