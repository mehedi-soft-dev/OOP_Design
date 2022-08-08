namespace CourseDiscount
{
    public interface IDiscount
    {
        Price GetPriceAfterDiscount(Price originalPrice);
    }
}
