using System.Globalization;
using CarSales.Data;
using CarSales.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CarSales;

public partial class FormSellCar : Form
{
    private readonly ICarService _carService;
    private readonly ICustomerService _customerService;
    private readonly ICarSaleService _carSaleService;
    private readonly IServiceProvider _serviceProvider;
    private Car _selectedCar;

    public FormSellCar(ICarService carService, ICustomerService customerService, ICarSaleService carSaleService, IServiceProvider serviceProvider)
    {
        _carService = carService;
        _customerService = customerService;
        _carSaleService = carSaleService;
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }
    
    public void SetSelectedCar(Car car)
    {
        _selectedCar = car;
        txtSalePrice.Text = car.Price.ToString(CultureInfo.InvariantCulture);
        comboBoxCars.SelectedItem = car;
    }

    private async void FormSellCar_Load(object sender, EventArgs e)
    {
        var cars = await _carService.GetAllCarsAsync();
        comboBoxCars.DataSource = cars.Where(c => !c.IsSold).ToList();
        comboBoxCars.DisplayMember = "FullName";
        comboBoxCars.ValueMember = "Id";
        if (_selectedCar is not null)
        {
            comboBoxCars.SelectedItem = _selectedCar;
        }
    }

    private async void btnSearchCustomer_Click(object sender, EventArgs e)
    {
        var customers = await _customerService.GetAllCustomersAsync();
        var searchQuery = txtSearchCustomer.Text.ToLower();
        var filteredCustomers = customers.Where(c => c.Phone.ToLower().Contains(searchQuery) || c.Email.ToLower().Contains(searchQuery)).ToList();
        listBoxCustomers.DataSource = filteredCustomers;
        listBoxCustomers.DisplayMember = "Name";
        listBoxCustomers.ValueMember = "Id";
    }

    private async void btnSellCar_Click(object sender, EventArgs e)
    {
        if (comboBoxCars.SelectedItem is Car selectedCar && listBoxCustomers.SelectedItem is Customer selectedCustomer)
        {
            if (decimal.TryParse(txtSalePrice.Text, out decimal salePrice))
            {
                var carSale = new CarSale
                {
                    CarId = selectedCar.Id,
                    CustomerId = selectedCustomer.Id,
                    SaleDate = DateTime.Now,
                    Price = salePrice
                };

                await _carSaleService.AddSaleAsync(carSale);
                selectedCar.IsSold = true;
                await _carService.UpdateCarAsync(selectedCar);

                MessageBox.Show("Car sold successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid sale price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Please select a car and a customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAddCustomer_Click(object sender, EventArgs e)
    {
        var formAddCustomer = _serviceProvider.GetRequiredService<FormAddCustomer>();
        formAddCustomer.ShowDialog();
    }
}