using System.Globalization;
using CarSales.Data;
using CarSales.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CarSales
{
    public partial class Form1 : Form
    {
        private readonly ICarService _carService;
        private readonly IServiceProvider _serviceProvider;

        public Form1(ICarService carService, IServiceProvider serviceProvider)
        {
            _carService = carService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            LoadAvailableCarsAsync();
        }

        private async void LoadAvailableCarsAsync()
        {
            var cars = await _carService.GetAllCarsAsync();
            dataGridViewCars.AutoGenerateColumns = false;
            dataGridViewCars.DataSource = cars.Where(c => c.IsSold == false).ToList();

            dataGridViewCars.Columns.Clear();
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Brand", HeaderText = "Brand" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Model", HeaderText = "Model" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Year", HeaderText = "Year" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Price" });
        }

        private async void btnImportCars_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Import Cars from CSV"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filePath = openFileDialog.FileName;
            var carDtos = await CarParser.ParseCars(filePath);
            
            var cars = await _carService.GetAllCarsAsync();
            var unsoldCars = cars.Where(c => c.IsSold == false).ToList();
            
            foreach (var car in unsoldCars)
            {
                await _carService.DeleteCarAsync(car.Id);
            }
            
            foreach (var carDto in carDtos)
            {
                await _carService.AddCarAsync(carDto);
            }
            
            await Task.Delay(1000);
            LoadAvailableCarsAsync();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var cars = await _carService.GetAllCarsAsync();
            var filteredCars = cars.Where(car =>
                (car.IsSold == false) &&
                (string.IsNullOrEmpty(txtBrand.Text) || car.Brand.Contains(txtBrand.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(txtModel.Text) || car.Model.Contains(txtModel.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(txtPrice.Text) || car.Price.ToString(CultureInfo.InvariantCulture).Contains(txtPrice.Text))
            ).ToList();
            dataGridViewCars.DataSource = filteredCars;
        }
        
        private void dataGridViewCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var selectedCar = (Car)dataGridViewCars.Rows[e.RowIndex].DataBoundItem;

            var formSellCar = _serviceProvider.GetRequiredService<FormSellCar>();
            formSellCar.SetSelectedCar(selectedCar);
            formSellCar.ShowDialog();

            LoadAvailableCarsAsync();
        }
        
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var formAddCustomer = _serviceProvider.GetRequiredService<FormCustomerList>();
            formAddCustomer.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var formSales = _serviceProvider.GetRequiredService<FormSalesList>();
            formSales.ShowDialog();
        }
    }
}