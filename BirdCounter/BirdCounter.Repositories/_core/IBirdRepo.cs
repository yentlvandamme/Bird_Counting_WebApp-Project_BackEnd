using BirdCounter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BirdCounter.Repositories
{
    public interface IBirdRepo
    {
        // Get all birds
        Task<IEnumerable<Bird>> GetAllBirdsAsync();

        // Get bird by ID
        Task<Bird> GetBirdByIdAsync(int id);

        // Get bird by name
        Task<Bird> GetBirdByNameAsync(string name);
    }
}
