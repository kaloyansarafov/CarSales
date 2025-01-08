using CarSales.Data;
using Microsoft.EntityFrameworkCore;

namespace CarSales.Services;

public class CustomerService : ICustomerService
{
    private readonly DealershipContext _context;

    public CustomerService(DealershipContext context)
    {
        _context = context;
    }

    public async Task<List<Customer>> GetAllCustomersAsync()
    {
        return await _context.Customers.Include(c => c.CarSales).AsNoTracking().ToListAsync();
    }
    
    public async Task<List<Customer>> GetAllCustomersWithIdsAsync()
    {
        return await _context.Customers.AsNoTracking().ToListAsync();
    }

    public async Task<Customer> GetCustomerByIdAsync(int id)
    {
        return await _context.Customers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task AddCustomerAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCustomerAsync(Customer customer)
    {
        var existingCustomer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == customer.Id);

        if (existingCustomer is not null)
        {
            existingCustomer.Name = customer.Name;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Address = customer.Address;
            existingCustomer.ZipCode = customer.ZipCode;
            existingCustomer.City = customer.City;
            existingCustomer.Email = customer.Email;

            await _context.SaveChangesAsync();
        }
    }

    public async Task DeleteCustomerAsync(int? id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer is not null)
        {
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
}