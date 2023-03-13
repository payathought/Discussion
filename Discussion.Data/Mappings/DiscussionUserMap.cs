using Discussion.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discussion.Data.Mappings
{
    public class DiscussionUserMap
    {

        public DiscussionUserMap(EntityTypeBuilder<DiscussionUser> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);

            entityBuilder.HasOne(pt => pt.User)
                .WithMany(p => p.DiscussionUsers)
                .HasForeignKey(pt => pt.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            entityBuilder.HasOne(pt => pt.Discussion)
                .WithMany(t => t.DiscussionUsers)
                .HasForeignKey(pt => pt.DiscussionId);

            entityBuilder.HasOne(u => u.CreatedBy)
             .WithMany()
             .OnDelete(DeleteBehavior.Restrict);

            entityBuilder.HasOne(u => u.ModifiedBy)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
