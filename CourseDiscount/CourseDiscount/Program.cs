using CourseDiscount;

var course = new Course()
{
    Title = "Asp.Net Core MVC",
    Description = "This is a full package",
    OriginalPrice = new Price() { Amount = 30000, Currency = "BDT" },
    //Discount = new FixedDiscount() { DiscountAmount = 3000 }
    Discount = new PercentDiscount(10)
};

Console.WriteLine($"Title: {course.Title}, Final Price: {course.GetFinalPrice().Amount} {course.GetFinalPrice().Currency}");

