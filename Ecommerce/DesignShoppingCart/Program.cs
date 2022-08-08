using DesignShoppingCart;

var cart = new ShoppingCart();
cart.AddItem(new CartItem(new Product() { Name = "Camera", Price = 150, ImageFileName = "camera.png"}));
cart.AddItem(new CartItem(new Product() { Name = "Laptop", Price = 500, ImageFileName = "laptop.png"}));
cart.AddItem(new CartItem(new GiftCard() { Name = "50 Couppon", Price = 50, ImageFileName = "cuppon.png"}));

cart["Laptop"].UpdateQuantity(2);

foreach(var item in cart.Items)
{
    Console.WriteLine($"{item.Item.Name}-{item.Quantity}");
}

Console.WriteLine($"Total : {cart.Total}");