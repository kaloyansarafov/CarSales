namespace CarSales
{
    public class CarSaleViewModel
    {
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SalePrice { get; set; }
    }
}