using CarSales.Data;

namespace CarSales;

public class SaleExporter
{
    //Write a method that exports a list of CarSale objects to a markdown file. Use the following example
    /*
# 12 February 2022 | Cadillac Escalade ESV (2012)
- *Price*: 11511.57
- *Customer*: Eve McFarm
- *Phone no.*: 0624361890
- *Address*: Farlane 254b
- *Zip code & city*: 0925XD Farmwards
---
     */

    public static void ExportSales(List<CarSale> sales, string path)
    {
        using var writer = new StreamWriter(path);
        foreach (var sale in sales)
        {
            writer.WriteLine($"# {sale.SaleDate:dd MMMM yyyy} | {sale.Car.Brand} {sale.Car.Model} ({sale.Car.Year})");
            writer.WriteLine($"- *Price*: {sale.Price}");
            writer.WriteLine($"- *Customer*: {sale.Customer.Name}");
            writer.WriteLine($"- *Phone no.*: {sale.Customer.Phone}");
            writer.WriteLine($"- *Address*: {sale.Customer.Address}");
            writer.WriteLine($"- *Zip code & city*: {sale.Customer.ZipCode} {sale.Customer.City}");
            writer.WriteLine("---");
        }
    }
}