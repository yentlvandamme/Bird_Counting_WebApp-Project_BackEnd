using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BirdCounter.Models;

namespace BirdCounter.Repositories
{
    public class BirdRepo : IBirdRepo
    {
        public async Task<IEnumerable<Bird>> GetAllBirdsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Bird> GetBirdByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Bird> GetBirdByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
