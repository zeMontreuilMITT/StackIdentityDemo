namespace StackwIdentity.Models
{
    public class VoteForAnswer: Vote
    {
        public Answer? Answer { get; set; }
        public int? AnswerId { get; set; }
    }
}
