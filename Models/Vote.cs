namespace StackwIdentity.Models
{
    public abstract class Vote
    {
        // One to many: Users, Questions, Answers
        public int Id { get; set; }
        public bool IsUp { get; set; }
        public StackUser? User { get;set; }
        public string? UserId { get; set; }
        
        // add some logic in the controller to make sure that these are never mixed up

        // if (Vote.Answer != null && Vote.Question != null) something is wrong
    }

    // One user can have many votes
    // a vote can only have one user

    // a question or answer can have many votes
    // a vote can only have one question or answer
}
