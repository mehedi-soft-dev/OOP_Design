namespace DesignShoppingCart
{
    public interface IPurchasable
    {
        string Name { get; set; }
        double Price { get; set; }
        string ImageFileName { get; set; }
    }
}
