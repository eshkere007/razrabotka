namespace BuilderPatternLib
{
    public class Processor
    {
        public string Model { get; set; }
        public int Cores { get; set; }

        public Processor(string model, int cores)
        {
            Model = model;
            Cores = cores;
        }

        public override string ToString() => $"{Model} ({Cores} cores)";
    }
}
