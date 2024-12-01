namespace StudyingLib
{
    public class Teacher : Entity
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public List<int> Courses { get; set; } = new List<int>();

        public override string ToStringRepresentation()
            => $"id:{Id}|name:{Name}|experience:{Experience}|courses:{string.Join(",", Courses)}";

        public override void FromStringRepresentation(string data)
        {
            var parts = data.Split('|');
            Id = int.Parse(parts[0]);
            Name = parts[1];
            Experience = int.Parse(parts[2]);
            Courses = new List<int>(Array.ConvertAll(parts[3].Split(','), int.Parse));
        }
    }
}
