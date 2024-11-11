using DocumentLib;

class Program
{
    static void Main()
    {
        var paragraph1 = new Paragraph("Первый параграф");
        var paragraph2 = new Paragraph("Второй параграф");

        var section1 = new Section("Вступление");
        section1.Add(paragraph1);
        section1.Add(paragraph2);

        var section2 = new Section("Заключение");
        section2.Add(new Paragraph("Последний параграф"));

        var document = new Document();
        document.Add(section1);
        document.Add(section2);

        document.Display();
    }
}