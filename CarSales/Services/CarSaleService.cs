using CarSales.Data;
using Microsoft.EntityFrameworkCore;

namespace CarSales.Services;

public class CarSaleService : ICarSaleService
{
    private readonly DealershipContext _context;

    public CarSaleService(DealershipContext context)
    {
        _context = context;
    }

    public async Task<List<CarSale>> GetAllSalesAsync()
    {
        return await _context.CarSales.Include(s => s.Customer).Include(s => s.Car).ToListAsync();
    }

    public async Task<CarSale> GetSaleByIdAsync(int id)
    {
        return (await _context.CarSales.Include(s => s.Customer).Include(s => s.Car).FirstOrDefaultAsync(s => s.Id == id))!;
    }

    public async Task<List<CarSale>> GetSalesByCustomerIdAsync(int? id)
    {
        return await _context.CarSales.Include(s => s.Customer).Include(s => s.Car).Where(s => s.CustomerId == id).ToListAsync();
    }

    public async Task AddSaleAsync(CarSale sale)
    {
        _context.CarSales.Add(sale);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateSaleAsync(CarSale sale)
    {
        _context.CarSales.Update(sale);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteSaleAsync(int id)
    {
        var sale = await _context.CarSales.FindAsync(id);
        if (sale is not null)
        {
            _context.CarSales.Remove(sale);
            await _context.SaveChangesAsync();
        }
    }
}