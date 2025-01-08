using CarSales.Data;
using CarSales.Services;

namespace CarSales;

public partial class FormCustomerDetails : Form
{
    private readonly ICustomerService _customerService;
    private readonly ICarSaleService _carSaleService;
    private Customer _customer;

    public FormCustomerDetails(ICustomerService customerService, ICarSaleService carSaleService)
    {
        _customerService = customerService;
        _carSaleService = carSaleService;
        InitializeComponent();
    }

    public async void SetCustomer(Customer customer)
    {
        _customer = customer;
        lblName.Text = customer.Name;
        lblPhone.Text = customer.Phone;
        lblEmail.Text = customer.Email;

        var purchases = await _carSaleService.GetSalesByCustomerIdAsync(customer.Id);
        dataGridViewPurchases.DataSource = purchases.Select(s => new
        {
            s.Car.Brand,
            s.Car.Model,
            s.Car.Year,
            s.SaleDate,
            s.Price
        }).ToList();
    }
}