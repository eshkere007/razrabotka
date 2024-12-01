namespace ChainOfResponsibilityPattern
{
    public class EnglishToChineseTranslator : Translator
    {
        public override void Translate(Request req)
        {
            if (req.SourceLanguage == "English" && req.TargetLanguage == "Chinese")
            {
                Console.WriteLine($"Перевод с английского на китайский: {req.Document}");
            }
            else if (req.SourceLanguage == "Chinese" && req.TargetLanguage == "English")
            {
                Console.WriteLine($"Перевод с китайского на английский: {req.Document}");
            }
            else if (_nextTranslator != null)
            {
                _nextTranslator.Translate(req);
            }
            else Console.WriteLine("Невозможно перевести документ");
        }
    }
}