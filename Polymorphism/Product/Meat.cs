namespace ProductLib
{
    public class Meat : Product
    {
        public string ExpiryDate { get; set; }
        public override string GetInformation()
        {
            return $"{Name}\nСрок годности: {ExpiryDate}, Цена: {Price}";
        }
    }
}
