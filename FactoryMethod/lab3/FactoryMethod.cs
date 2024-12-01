using StudyingLib;

namespace lab3
{
    public static class FactoryMethod
    {
        public static Entity CreateEntity(string type, string data)
            => Entity.CreateEntity(type, data);
    }
}
