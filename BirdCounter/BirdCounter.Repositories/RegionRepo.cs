using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BirdCounter.Models;

namespace BirdCounter.Repositories
{
    public class RegionRepo : IRegionRepo
    {
        public async Task<IEnumerable<Region>> GetAllRegionsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Region> GetRegionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Region> GetRegionByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
