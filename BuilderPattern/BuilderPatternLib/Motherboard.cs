namespace BuilderPatternLib
{
    public class Motherboard
    {
        public string Model { get; set; }

        public Motherboard(string model)
        {
            Model = model;
        }

        public override string ToString() => Model;
    }
}
