using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Services
{
    public interface IRegionService
    {
        List<string> GetAllRegionNames();

        int GetRegionIdByRegionName(string regionName);
    }
}
