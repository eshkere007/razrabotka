namespace FlyweightPatternLib
{
    public class CharacterAttributes
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
}
