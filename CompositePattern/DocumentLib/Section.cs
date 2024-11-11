namespace DocumentLib
{
    public class Section : IDocumentComponent
    {
        public string Title { get; }
        private List<IDocumentComponent> components;

        public Section(string title)
        {
            Title = title;
            components = new List<IDocumentComponent>();
        }

        public void Add(IDocumentComponent component)
        {
            components.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            components.Remove(component);
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + "Раздел: " + Title);
            foreach (var component in components)
            {
                component.Display(indent + 2);
            }
        }
    }
}
