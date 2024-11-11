namespace DocumentLib
{
    public class Paragraph : IDocumentComponent
    {
        public string Text { get; }

        public Paragraph(string text)
        {
            Text = text;
        }

        public void Add(IDocumentComponent component)
        {
            Console.WriteLine("Невозможно добавить элементы в параграф");
        }

        public void Remove(IDocumentComponent component)
        {
            Console.WriteLine("Невозможно удалить элементы из параграфа");
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + Text);
        }
    }
}
