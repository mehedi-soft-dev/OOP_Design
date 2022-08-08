namespace DesignShoppingCart
{
    public class GiftCard : IPurchasable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageFileName { get; set; }
        public string Email { get; set; }
    }
}
