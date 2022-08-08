namespace DesignShoppingCart
{
    public class Product : IPurchasable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageFileName { get; set; }
        public string Description { get; set; }
    }
}
