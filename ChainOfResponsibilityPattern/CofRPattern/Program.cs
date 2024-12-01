using ChainOfResponsibilityPattern;

class Program
{
    static void Main()
    {
        var englishToGerman = new EnglishToGermanTranslator();
        var englishToChinese = new EnglishToChineseTranslator();
        var englishToRussian = new EnglishToRussianTranslator();

        englishToGerman.SetNext(englishToChinese);
        englishToChinese.SetNext(englishToRussian);

        var req1 = new Request("Chinese", "English", "Нихао");
        englishToGerman.Translate(req1);

        var req2 = new Request("English", "Chinese", "Hello");
        englishToGerman.Translate(req2);

        var req3 = new Request("Japanese", "English", "Коничива");
        englishToGerman.Translate(req3);
    }
}