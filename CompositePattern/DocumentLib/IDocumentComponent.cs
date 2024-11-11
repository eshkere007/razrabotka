namespace DocumentLib
{
    public interface IDocumentComponent
    {
        void Add(IDocumentComponent component);
        void Remove(IDocumentComponent component);
        void Display(int indent = 0);
    }
}
