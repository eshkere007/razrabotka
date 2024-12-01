namespace ChainOfResponsibilityPattern
{
    public abstract class Translator
    {
        protected Translator _nextTranslator;
        public void SetNext(Translator translator)
        {
            _nextTranslator = translator;
        }
        public abstract void Translate(Request req);
    }
}