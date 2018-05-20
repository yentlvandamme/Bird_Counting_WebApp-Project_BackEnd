using BirdCounting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Services
{
    public interface IBirdService
    {
        List<Bird> GetAllBirds();

        Bird GetBirdById(int id);
    }
}
