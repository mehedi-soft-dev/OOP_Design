namespace DesignShoppingCart
{
    public class CartItem
    {
        public IPurchasable Item { get; set; }
        public uint Quantity { get; set; }

        public CartItem(IPurchasable item)
        {
            Item = item;
            Quantity = 1;
        }
        public CartItem(IPurchasable item, uint quantity)
        {
            if (quantity == 0)
                throw new InvalidOperationException("Quantity can't be zero");

            Item = item;
            Quantity = quantity;
        }

        public void UpdateQuantity(uint quantity)
        {
            if (quantity == 0)
                throw new InvalidOperationException("Quantity can't be zero");

            Quantity = quantity;
        }
    }
}
