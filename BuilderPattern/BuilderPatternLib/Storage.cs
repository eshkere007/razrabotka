namespace BuilderPatternLib
{
    public class Storage
    {
        public string Type { get; set; }
        public int SizeGB { get; set; }

        public Storage(string type, int sizeGB)
        {
            Type = type;
            SizeGB = sizeGB;
        }

        public override string ToString() => $"{SizeGB} GB {Type}";
    }
}
