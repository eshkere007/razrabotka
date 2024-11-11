namespace ProductLib
{
    public class Drink : Product
    {
        public int Volume { get; set; }
        public override string GetInformation()
        {
            return $"{Name}\nОбъем: {Volume} мл, Цена: {Price}";
        }
    }
}