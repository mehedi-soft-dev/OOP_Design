namespace CourseDiscount
{
    public class Course
    {
        public string Title { get; set; }   
        public string Description { get; set; }   
        public Price OriginalPrice { get; set; }
        public IDiscount Discount { get; set; }

        public Price GetFinalPrice()
        {
            if (Discount == null)
                return OriginalPrice;

            return Discount.GetPriceAfterDiscount(OriginalPrice);
        }
    }
}
