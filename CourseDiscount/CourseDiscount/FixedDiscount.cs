namespace CourseDiscount
{
    public class FixedDiscount : IDiscount
    {
        public double DiscountAmount { get; set; }
        public Price GetPriceAfterDiscount(Price originalPrice)
        {
            if(originalPrice.Amount >= DiscountAmount)
                return new Price() { Amount = originalPrice.Amount - DiscountAmount, Currency = originalPrice.Currency };

            return new Price() { Amount = 0, Currency = originalPrice.Currency };
        }
    }
}
