namespace FlyweightPatternLib
{
    public class Character
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Image { get; private set; }

        public Character(string name, string type, string image)
        {
            Name = name;
            Type = type;
            Image = image;
        }

        public void Display()
        {
            Console.WriteLine($"Персонаж: {Name}, Класс: {Type}, Изображение: {Image}");
        }
    }
}
