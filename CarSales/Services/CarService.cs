using CarSales.Data;
using Microsoft.EntityFrameworkCore;

namespace CarSales.Services;

public class CarService : ICarService
{
    private readonly DealershipContext _context;

    public CarService(DealershipContext context)
    {
        _context = context;
    }

    public async Task<List<Car?>> GetAllCarsAsync()
    { 
        return await _context.Cars.ToListAsync();
    }

    public async Task<Car> GetCarByIdAsync(int id)
    {
        return await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task AddCarAsync(Car car)
    {
        _context.Cars.Add(car);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCarAsync(Car car)
    {
        _context.Cars.Update(car);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCarAsync(int id)
    {
        var car = await _context.Cars.FindAsync(id);
        if (car is not null)
        {
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
        }
    }
}