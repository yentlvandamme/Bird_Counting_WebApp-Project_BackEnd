using BirdCounting.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Services
{
    public class RegionService : IRegionService
    {
        private IRegionRepo _regionRepo;

        public RegionService(IRegionRepo regionRepo)
        {
            this._regionRepo = regionRepo;
        }

        public List<string> GetAllRegionNames()
        {
            return _regionRepo.GetAllRegionNames();
        }

        public int GetRegionIdByRegionName(string regionName)
        {
            return _regionRepo.GetRegionIdByRegionName(regionName);
        }
    }
}
