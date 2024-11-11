namespace ProductLib
{
    public class Gadget : Product
    {
        public string Mark { get; set; }
        public override string GetInformation()
        {
            return $"{Name}\nМарка: {Mark}, Цена: {Price}";
        }
    }
}