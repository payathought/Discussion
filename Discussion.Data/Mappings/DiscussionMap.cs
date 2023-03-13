using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discussion.Data.Mappings
{
    public class DiscussionMap
    {
        public DiscussionMap(EntityTypeBuilder<Discussion.Data.Entities.Discussion> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.Property(t => t.Subject)
             .HasMaxLength(512)
             .IsRequired();

            entityBuilder.HasOne(u => u.Observer)
                  .WithMany()
                  .OnDelete(DeleteBehavior.NoAction);

            entityBuilder.Property(t => t.Outcomes)
                .HasMaxLength(5124);

            entityBuilder.HasOne(u => u.CreatedBy)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            entityBuilder.HasOne(u => u.ModifiedBy)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
