namespace ChainOfResponsibilityPattern
{
    public class EnglishToRussianTranslator : Translator
    {
        public override void Translate(Request req)
        {
            if (req.SourceLanguage == "English" && req.TargetLanguage == "Russian")
            {
                Console.WriteLine($"Перевод с английского на русский: {req.Document}");
            }
            else if (req.SourceLanguage == "Russian" && req.TargetLanguage == "English")
            {
                Console.WriteLine($"Перевод с русского на английский: {req.Document}");
            }
            else if (_nextTranslator != null)
            {
                _nextTranslator.Translate(req);
            }
            else Console.WriteLine("Невозможно перевести документ");
        }
    }
}