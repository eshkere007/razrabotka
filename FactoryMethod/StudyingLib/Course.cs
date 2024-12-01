namespace StudyingLib
{
    public class Course : Entity
    {
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public List<int> Students { get; set; } = new List<int>();

        public override string ToStringRepresentation()
            => $"id:{Id}|name:{Name}|teacher_id:{TeacherId}|students:{string.Join(",", Students)}";

        public override void FromStringRepresentation(string data)
        {
            var parts = data.Split('|');
            Id = int.Parse(parts[0]);
            Name = parts[1];
            TeacherId = int.Parse(parts[2]);
            Students = new List<int>(Array.ConvertAll(parts[3].Split(','), int.Parse));
        }
    }
}
