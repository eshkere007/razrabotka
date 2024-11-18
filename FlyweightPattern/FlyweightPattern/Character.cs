
namespace FlyweightPattern
{
    class Character
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

    class CharacterAttributes
    {
        public int Level { get; set; }
        public int Experience { get; set; }

        public CharacterAttributes(int level, int experience)
        {
            Level = level;
            Experience = experience;
        }

        public void DisplayAttributes()
        {
            Console.WriteLine($"Уровень: {Level}, Опыт: {Experience}");
        }
    }

    class CharacterFactory
    {
        private Dictionary<string, Character> _characters = new Dictionary<string, Character>();

        public Character GetCharacter(string name, string type, string image)
        {
            string key = $"{name}-{type}";

            if (!_characters.ContainsKey(key))
            {
                Character character = new Character(name, type, image);
                _characters[key] = character;
            }

            return _characters[key];
        }
    }
}
