using CarSales.Data;
using CarSales.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CarSales;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        var services = new ServiceCollection();
        services.AddDbContext<DealershipContext>();
        services.AddScoped<ICarSaleService, CarSaleService>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<ICarService, CarService>();
        services.AddScoped<Form1>();
        services.AddScoped<FormAddCustomer>();
        services.AddScoped<FormCustomerList>();
        services.AddScoped<FormSellCar>();
        services.AddScoped<FormSalesList>();
        services.AddScoped<FormCustomerDetails>();
        using var serviceProvider = services.BuildServiceProvider();
        var form1 = serviceProvider.GetRequiredService<Form1>();
        
        Application.Run(form1);
    }
}