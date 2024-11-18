using BuilderPatternLib;

class Program
{
    static void Main(string[] args)
    {
        var computer = new ComputerBuilder()
            .SetCPU("Intel Core i9", 8)
            .SetMotherboard("ASUS ROG Strix")
            .SetRAM(32)
            .SetStorage("SSD", 1024)
            .SetGraphicsCard("NVIDIA RTX 3080")
            .Build();

        Console.WriteLine(computer);
    }
}
