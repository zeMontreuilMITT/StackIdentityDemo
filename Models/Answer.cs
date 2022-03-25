namespace StackwIdentity.Models
{
    public class Answer
    {
        public int Id { get; set; }

        //One to Many: Users, Questions, Votes, Comments
        public string? UserId { get; set; }
        public StackUser? User { get; set; }
        public bool isSelected { get; set; }
        public int? QuestionId { get; set; }
        public Question? Question { get; set; }

        public ICollection<VoteForAnswer> Votes { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public Answer()
        {
            Votes = new HashSet<VoteForAnswer>();
            Comments = new HashSet<Comment>();
        }

    }
}
