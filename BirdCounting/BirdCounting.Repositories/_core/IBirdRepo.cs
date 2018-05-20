using BirdCounting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Repositories
{
    public interface IBirdRepo
    {
        List<Bird> GetAllBirds();

        Bird GetBirdById(int id);
    }
}
