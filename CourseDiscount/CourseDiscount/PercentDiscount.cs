namespace CourseDiscount
{
    public class PercentDiscount : IDiscount
    {
        public double Percent { get; set; }
        public PercentDiscount(double percent)
        {
            Percent = percent;
        }

        public Price GetPriceAfterDiscount(Price originalPrice)
        {
            var discount = originalPrice.Amount*Percent/100.00;

            if(originalPrice.Amount >= discount)
                return new Price() { Amount = originalPrice.Amount - discount, Currency = originalPrice.Currency };

            return new Price() { Amount = 0, Currency = originalPrice.Currency };
        }
    }
}
