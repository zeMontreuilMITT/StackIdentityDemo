namespace StackwIdentity.Models
{
    public class Question
    {
        public int Id { get; set; }

        // One-To-Many: User, Answers, Votes, Comments
        public StackUser User { get; set; }
        public string UserId { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<VoteForQuestion> Votes { get; set; }
        public ICollection<Comment> Comments { get; set; }

        // Many to Many: Tags
        public ICollection<Tag> Tags { get; set; }


        public Question()
        {
            Answers = new HashSet<Answer>();
            Votes = new HashSet<VoteForQuestion>();
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
        }
    }
}
