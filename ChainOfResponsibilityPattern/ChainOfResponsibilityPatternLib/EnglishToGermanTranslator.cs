namespace ChainOfResponsibilityPattern
{
    public class EnglishToGermanTranslator : Translator
    {
        public override void Translate(Request req)
        {
            if (req.SourceLanguage == "English" && req.TargetLanguage == "German")
            {
                Console.WriteLine($"Перевод с английского на немецкий: {req.Document}");
            }
            else if (req.SourceLanguage == "German" && req.TargetLanguage == "English")
            {
                Console.WriteLine($"Перевод с немецкого на английский: {req.Document}");
            }
            else if (_nextTranslator != null)
            {
                _nextTranslator.Translate(req);
            }
            else Console.WriteLine("Невозможно перевести документ");
        }
    }
}