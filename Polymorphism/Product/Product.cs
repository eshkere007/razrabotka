namespace ProductLib
{
    public abstract class Product
    {
        public virtual decimal Price { get; set; }
        public virtual string Name { get; set; }
        public abstract string GetInformation();
        public int Discount { get; set; }
        public string GetDiscountedPrice()
        {
            return $"Цена со скидкой: {Price - Price * Discount / 100}";
        }
    }
}
