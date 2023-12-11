namespace E_commerce_Product_Management_API.Models
{
    public class Product
    {
        //Product model with properties such as ProductID, Name, Description, Price, StockQuantity, and Category
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
    }
}
