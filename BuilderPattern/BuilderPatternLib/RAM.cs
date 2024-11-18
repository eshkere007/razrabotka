namespace BuilderPatternLib
{
    public class RAM
    {
        public int SizeGB { get; set; }

        public RAM(int sizeGB)
        {
            SizeGB = sizeGB;
        }

        public override string ToString() => $"{SizeGB} GB RAM";
    }
}
