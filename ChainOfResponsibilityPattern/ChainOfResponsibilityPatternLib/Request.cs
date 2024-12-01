namespace ChainOfResponsibilityPattern
{
    public class Request
    {
        public string SourceLanguage { get; }
        public string TargetLanguage { get; }
        public string Document { get; }

        public Request(string sourceLanguage, string targetLanguage, string document)
        {
            SourceLanguage = sourceLanguage;
            TargetLanguage = targetLanguage;
            Document = document;
        }
    }
}