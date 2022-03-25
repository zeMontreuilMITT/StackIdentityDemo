namespace StackwIdentity.Models
{
    public class QuestionDetailsVM
    {
        public Question Question { get;set; }
        public List<Answer> Answers { get;set; }

        public QuestionDetailsVM()
        {

        }
    }
}
