namespace DocumentLib
{
    public class Document : IDocumentComponent
    {
        private List<IDocumentComponent> sections;

        public Document()
        {
            sections = new List<IDocumentComponent>();
        }

        public void Add(IDocumentComponent component)
        {
            sections.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            sections.Remove(component);
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine("Документ:");
            foreach (var section in sections)
            {
                section.Display(indent + 2);
            }
        }
    }
}
