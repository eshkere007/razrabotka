using lab1;
using ProductLib;

CustomConverter converter = new CustomConverter();
converter.CConvert("123", out int output1);
Console.WriteLine(output1);
converter.CConvert("123,4", out double output2);
Console.WriteLine(output2);
converter.CConvert("12/3/2024", out DateTime output3);
Console.WriteLine(output3);

Console.WriteLine();

List<Product> products = new List<Product>
{
    new Toy { Name = "Игрушечный котик", Price = 100, Material = "Пластик", Discount = 10 },
    new Meat { Name = "Стейк из свинины", Price = 200, ExpiryDate = "30/10/2024", Discount = 7 },
    new Drink { Name = "Добрый Кола", Price = 50, Volume = 500, Discount = 15 },
    new Clothing { Name = "Зимняя куртка", Price = 150, Size = "L", Discount = 3 },
    new Gadget { Name = "IPhone 16", Price = 150, Mark = "Apple", Discount = 0 },
};

foreach (var product in products)
{
    Console.WriteLine(product.GetInformation());
    Console.WriteLine(product.GetDiscountedPrice());
    Console.WriteLine();
}