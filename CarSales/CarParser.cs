using CarSales.Data;

namespace CarSales;

public class CarParser
{
    public static async Task<List<Car>> ParseCars(string path)
    {
        var carDtos = new List<Car>();
        var lines = await File.ReadAllLinesAsync(path);
        foreach (var line in lines.Skip(1)) // Skip header
        {
            var values = line.Split(',');
            var carDto = new Car
            {
                Brand = values[0],
                Model = values[1],
                Year = int.Parse(values[2]),
                Price = decimal.Parse(values[3])
            };
            carDtos.Add(carDto);
        }
        return carDtos;
    }
}