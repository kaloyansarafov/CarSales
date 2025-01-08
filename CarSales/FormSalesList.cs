using CarSales.Data;
using CarSales.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CarSales;

public partial class FormSalesList : Form
{
    private readonly ICarSaleService _carSaleService;
    private readonly IServiceProvider _serviceProvider;

    public FormSalesList(ICarSaleService carSaleService, IServiceProvider serviceProvider)
    {
        _carSaleService = carSaleService;
        _serviceProvider = serviceProvider;
        InitializeComponent();
        LoadSalesAsync();
    }

    private async void LoadSalesAsync()
    {
        var sales = await _carSaleService.GetAllSalesAsync();
        var salesViewModel = sales.Select(s => new CarSaleViewModel
        {
            Id = s.Id,
            CarBrand = s.Car.Brand,
            CarModel = s.Car.Model,
            CarYear = s.Car.Year,
            CustomerName = s.Customer.Name,
            CustomerPhone = s.Customer.Phone,
            CustomerEmail = s.Customer.Email,
            SaleDate = s.SaleDate,
            SalePrice = s.Price
        }).ToList();

        dataGridViewSales.DataSource = salesViewModel;

        dataGridViewSales.Columns["Id"]!.Visible = false;

        dataGridViewSales.Columns["CarBrand"]!.HeaderText = "Car Brand";
        dataGridViewSales.Columns["CarModel"]!.HeaderText = "Car Model";
        dataGridViewSales.Columns["CarYear"]!.HeaderText = "Car Year";
        dataGridViewSales.Columns["CustomerName"]!.HeaderText = "Customer Name";
        dataGridViewSales.Columns["CustomerPhone"]!.HeaderText = "Customer Phone";
        dataGridViewSales.Columns["CustomerEmail"]!.HeaderText = "Customer Email";
        dataGridViewSales.Columns["SaleDate"]!.HeaderText = "Sale Date";
        dataGridViewSales.Columns["SalePrice"]!.HeaderText = "Sale Price";

        dataGridViewSales.ReadOnly = true;
    }
    
    private async void btnExportSales_Click(object sender, EventArgs e)
    {
        using var saveFileDialog = new SaveFileDialog
        {
            Filter = "Markdown files (*.md)|*.md",
            Title = "Export Sales to Markdown"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            var sales = await _carSaleService.GetAllSalesAsync();
            SaleExporter.ExportSales(sales, saveFileDialog.FileName);
            MessageBox.Show("Sales exported successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}