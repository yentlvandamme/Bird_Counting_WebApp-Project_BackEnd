using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Repositories
{
    public interface IRegionRepo
    {
        List<string> GetAllRegionNames();

        int GetRegionIdByRegionName(string regionName);
    }
}
