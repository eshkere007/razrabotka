namespace BuilderPatternLib
{
    public class ComputerBuilder
    {
        private Processor _processor;
        private Motherboard _motherboard;
        private RAM _ram;
        private Storage _storage;
        private GraphicsCard _graphicsCard;

        public ComputerBuilder SetCPU(string model, int cores)
        {
            _processor = new Processor(model, cores);
            return this;
        }

        public ComputerBuilder SetMotherboard(string model)
        {
            _motherboard = new Motherboard(model);
            return this;
        }

        public ComputerBuilder SetRAM(int sizeGB)
        {
            _ram = new RAM(sizeGB);
            return this;
        }

        public ComputerBuilder SetStorage(string type, int sizeGB)
        {
            _storage = new Storage(type, sizeGB);
            return this;
        }

        public ComputerBuilder SetGraphicsCard(string model)
        {
            _graphicsCard = new GraphicsCard(model);
            return this;
        }

        public Computer Build()
        {
            return new Computer
            {
                CPU = _processor,
                Motherboard = _motherboard,
                RAM = _ram,
                Storage = _storage,
                GPU = _graphicsCard
            };
        }
    }

}
