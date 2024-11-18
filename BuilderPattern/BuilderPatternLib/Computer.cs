namespace BuilderPatternLib
{
    public class Computer
    {
        public Processor CPU { get; set; }
        public Motherboard Motherboard { get; set; }
        public RAM RAM { get; set; }
        public Storage Storage { get; set; }
        public GraphicsCard GPU { get; set; }

        public override string ToString()
        {
            return $"Computer Configuration: \n" +
                   $"CPU: {CPU}\n" +
                   $"Motherboard: {Motherboard}\n" +
                   $"RAM: {RAM}\n" +
                   $"Storage: {Storage}\n" +
                   $"GPU: {GPU}\n";
        }
    }
}
