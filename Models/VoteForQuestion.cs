namespace StackwIdentity.Models
{
    public class VoteForQuestion: Vote
    {
        public Question? Question { get; set; }
        public int? QuestionId { get; set; }
    }
}
