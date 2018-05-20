using BirdCounting.Models;
using BirdCounting.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Services
{
    public class BirdService : IBirdService
    {
        public IBirdRepo _birdRepo;

        public BirdService(IBirdRepo birdRepo)
        {
            this._birdRepo = birdRepo;
        }

        public List<Bird> GetAllBirds()
        {
            return _birdRepo.GetAllBirds();
        }

        public Bird GetBirdById(int id)
        {
            return _birdRepo.GetBirdById(id);
        }
    }
}
