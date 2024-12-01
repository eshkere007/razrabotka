namespace StudyingLib
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public abstract string ToStringRepresentation();
        public abstract void FromStringRepresentation(string data);

        public static Entity CreateEntity(string type, string data)
        {
            Entity entity;
            if (type == "student") entity = new Student();
            else if (type == "teacher") entity = new Teacher();
            else if (type == "course") entity = new Course();
            else throw new ArgumentException($"Неизвестный тип: {type}");

            entity.FromStringRepresentation(data);
            return entity;
        }
    }

}
