namespace BuilderPatternLib
{
    public class GraphicsCard
    {
        public string Model { get; set; }

        public GraphicsCard(string model)
        {
            Model = model;
        }

        public override string ToString() => Model;
    }
}
