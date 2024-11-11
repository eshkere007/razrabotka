namespace ProductLib
{
    public class Toy : Product
    {
        public string Material { get; set; }
        public override string GetInformation()
        {
            return $"{Name}\nМатериал: {Material}, Цена: {Price}";
        }
    }
}