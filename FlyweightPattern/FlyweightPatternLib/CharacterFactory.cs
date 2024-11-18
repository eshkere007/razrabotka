namespace FlyweightPatternLib
{
    public class CharacterFactory
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
