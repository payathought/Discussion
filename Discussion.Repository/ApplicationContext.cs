using Discussion.Data.Entities;
using Discussion.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Discussion.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Data.Entities.Discussion> Discussion { get; set; }
        public DbSet<DiscussionUser> DiscussionUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new UserMap(modelBuilder.Entity<User>().ToTable("User", "users"));
            new DiscussionMap(modelBuilder.Entity<Discussion.Data.Entities.Discussion>().ToTable("Discussion", "discussions"));
            new DiscussionUserMap(modelBuilder.Entity<DiscussionUser>().ToTable("DiscussionUser", "discussionUsers"));
        }
    }
}
