namespace StackwIdentity.Models
{
    public class Tag
    {
        // Many-to-many: Questions
        public int Id { get; set; }
        public ICollection<Question> Questions { get; set; }

        public Tag()
        {
            Questions = new HashSet<Question>();
        }
    }
}
