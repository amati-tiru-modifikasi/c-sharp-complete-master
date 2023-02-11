using System.Text;

namespace LinqPlayground.Entities
{
    public class Cast
    {
        public int Id { get; set; }
        public int? MovieId { get; set; }
        public int? ActorId { get; set; }
        public int? RoleId { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"------ {Name} ------");
            stringBuilder.AppendLine($"Character {Order} : {Character}");
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }

    }
}