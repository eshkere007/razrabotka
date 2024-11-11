namespace ProductLib
{
    public class Clothing : Product
    {
        public string Size { get; set; }
        public override string GetInformation()
        {
            return $"{Name}\nРазмер: {Size}, Цена: {Price}";
        }
    }
}