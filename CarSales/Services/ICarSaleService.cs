using CarSales.Data;

namespace CarSales.Services;

public interface ICarSaleService
{
    Task<List<CarSale>> GetAllSalesAsync();
    Task<CarSale> GetSaleByIdAsync(int id);
    Task<List<CarSale>> GetSalesByCustomerIdAsync(int? id);
    Task AddSaleAsync(CarSale sale);
    Task UpdateSaleAsync(CarSale sale);
    Task DeleteSaleAsync(int id);
}