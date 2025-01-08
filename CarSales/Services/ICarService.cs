﻿using CarSales.Data;

namespace CarSales.Services;

public interface ICarService
{
    Task<List<Car?>> GetAllCarsAsync();
    Task<Car> GetCarByIdAsync(int id);
    Task AddCarAsync(Car car);
    Task UpdateCarAsync(Car car);
    Task DeleteCarAsync(int id);
}