namespace StudyingLib
{
    public class Student : Entity
    {
        public string Name { get; set; }
        public List<int> Courses { get; set; } = new List<int>();

        public override string ToStringRepresentation()
            => $"id:{Id}|name:{Name}|courses:{string.Join(",", Courses)}";

        public override void FromStringRepresentation(string data)
        {
            var parts = data.Split('|');
            Id = int.Parse(parts[0]);
            Name = parts[1];
            Courses = new List<int>(Array.ConvertAll(parts[2].Split(','), int.Parse));
        }
    }
}