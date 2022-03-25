using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StackwIdentity.Models;

namespace StackwIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<StackUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Answer>().HasOne(a => a.Question)
                .WithMany(a => a.Answers)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Answer>().HasOne(a => a.User)
                .WithMany(u => u.Answers)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Answer>().HasMany(a => a.Votes)
                .WithOne(v => v.Answer)
                .HasForeignKey(v => v.AnswerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Answer>().HasMany(a => a.Comments)
                .WithOne(c => c.Answer)
                .HasForeignKey(c => c.AnswerId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<VoteForAnswer> VotesForAnswer { get; set;}
        public DbSet<VoteForQuestion> VotesForQuestion { get; set;}

    }
}