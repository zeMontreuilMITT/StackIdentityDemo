namespace StackwIdentity.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }

        //One to many: Users, Questions, Answers
        
        public StackUser User { get; set; }
        public string UserId { get; set; }

        public Question? Question { get; set; }
        public int? QuestionId { get; set; }

        public Answer? Answer { get; set; }
        public int? AnswerId { get; set; }

    }
}
