﻿using AutoRepair.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoRepair.Services
{
    public interface IModelsCarRepository
    {
        Task<IEnumerable<ModelCar>> GetModelsCarAsync();
        Task<ModelCar> GetModelCarAsync(string nameCar);
    }
}
