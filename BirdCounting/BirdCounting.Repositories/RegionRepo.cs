using BirdCounting.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirdCounting.Repositories
{
    public class RegionRepo : IRegionRepo
    {
        private ApplicationDbContext _context;

        public RegionRepo(ApplicationDbContext context)
        {
            this._context = context;
        }

        public List<string> GetAllRegionNames()
        {
            return _context.Regions.Select(r => r.Place)
                                   .Distinct()
                                   .ToList();
        }

        public int GetRegionIdByRegionName(string regionName)
        {
            return _context.Regions.Where(r => r.Place == regionName)
                                   .Select(r => r.ID)
                                   .Distinct()
                                   .SingleOrDefault();
        }
    }
}
