using BirdCounter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BirdCounter.Repositories
{
    public interface IRegionRepo
    {
        // Get all regions
        Task<IEnumerable<Region>> GetAllRegionsAsync();

        // Get region by ID
        Task<Region> GetRegionByIdAsync(int id);

        // Get region by name
        Task<Region> GetRegionByNameAsync(string name);
    }
}
