using System.Collections.ObjectModel;

namespace DesignShoppingCart
{
    public class ShoppingCart
    {
        private List<CartItem> _items;
        public IReadOnlyCollection<CartItem> Items
        {
            get
            {
                return new ReadOnlyCollection<CartItem>(_items);
            }
        }
        public CartItem this[string name]
        {
            get
            {
                return _items.Where(x => x.Item.Name == name).FirstOrDefault();
            }
        }
        public CartItem this[int index]
        {
            get
            {
                return _items[index];
            }
        }

        public ShoppingCart() 
        {
            _items = new List<CartItem>();
        }

        public void AddItem(CartItem item)
        {
            _items.Add(item);
        }
        public void RemoveItem(CartItem item)
        {
            _items.Remove(item);
        }

        public double Total
        {
            get
            {
                var total = 0.00;
                foreach(var item in _items)
                {
                    total += item.Item.Price * item.Quantity;
                }

                return total;
            }
        }
    }
}
