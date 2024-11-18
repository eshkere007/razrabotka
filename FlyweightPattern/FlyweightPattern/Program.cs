using FlyweightPattern;

class Program
{
    static void Main(string[] args)
    {
        CharacterFactory factory = new CharacterFactory();

        Character char1 = factory.GetCharacter("Лала", "Воин", "warrior_image.png");
        Character char2 = factory.GetCharacter("Лала", "Маг", "mage_image.png");
        Character char3 = factory.GetCharacter("Лала", "Воин", "warrior_image.png");

        char1.Display();
        char2.Display();
        char3.Display();

        Console.WriteLine("char1 == char3: " + (char1 == char3));

        CharacterAttributes char1Attributes = new CharacterAttributes(10, 150);
        CharacterAttributes char2Attributes = new CharacterAttributes(12, 200);

        Console.WriteLine("Лала-воин:");
        char1Attributes.DisplayAttributes();

        Console.WriteLine("Лала-маг:");
        char2Attributes.DisplayAttributes();
    }
}