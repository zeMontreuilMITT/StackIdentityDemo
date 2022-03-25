using Microsoft.AspNetCore.Identity;

namespace StackwIdentity.Models
{
    public class StackUser: IdentityUser
    {
        // One to many: Questions, Answers, Votes, Comments
        public ICollection<Question> Questions { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<Vote> Votes { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public StackUser()
        {
            Questions = new HashSet<Question>();
            Answers = new HashSet<Answer>();
            Votes = new HashSet<Vote>();
            Comments = new HashSet<Comment>();
        }
    }
}
