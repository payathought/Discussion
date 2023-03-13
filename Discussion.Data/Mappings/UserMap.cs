using Discussion.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Discussion.Data.Mappings
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.Property(t => t.FirstName)
                .HasMaxLength(128)
                .IsRequired();

            entityBuilder.Property(t => t.LastName)
                .HasMaxLength(128)
                .IsRequired();

            entityBuilder.HasOne(u => u.CreatedBy)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            entityBuilder.HasOne(u => u.ModifiedBy)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);


            entityBuilder.HasData(new User[]
            {
                new User
                {
                    Id = new Guid("C7BF03EB-2696-4C5E-A2B0-228854FC81C8"),
                    FirstName = "Admin",
                    LastName = "Admin",
                    Deleted = false,
                    CreatedById = new Guid("C7BF03EB-2696-4C5E-A2B0-228854FC81C8"),
                    CreatedDate = DateTime.Now
                },
                new User
                {
                    Id = new Guid("0B411D1F-8C24-401C-9A93-6EBA12084334"),
                    FirstName = "Adam",
                    LastName = "Smith",
                    Deleted = false,
                    CreatedById = new Guid("C7BF03EB-2696-4C5E-A2B0-228854FC81C8"),
                    CreatedDate = DateTime.Now
                },
                new User
                {
                    Id = new Guid("F21C3F39-C8D3-4ACC-84EC-45CBDF6D9189"),
                    FirstName = "Joe",
                    LastName = "Parker",
                    Deleted = false,
                    CreatedById = new Guid("C7BF03EB-2696-4C5E-A2B0-228854FC81C8"),
                    CreatedDate = DateTime.Now
                },
                new User
                {
                    Id = new Guid("EABA0A44-F143-41D8-AC94-EF7A4AC66A27"),
                    FirstName = "Patrick",
                    LastName = "Gargoles",
                    Deleted = false,
                    CreatedById = new Guid("C7BF03EB-2696-4C5E-A2B0-228854FC81C8"),
                    CreatedDate = DateTime.Now
                },
                new User
                {
                    Id = new Guid("73A27840-BA70-4C90-866B-9246C779CA15"),
                    FirstName = "Shannon",
                    LastName = "Jones",
                    Deleted = false,
                    CreatedById = new Guid("C7BF03EB-2696-4C5E-A2B0-228854FC81C8"),
                    CreatedDate = DateTime.Now
                },
                new User
                {
                    Id = new Guid("557D9B82-BC9B-484D-94AA-6917ADE6C65F"),
                    FirstName = "Hurish",
                    LastName = "Williams",
                    Deleted = false,
                    CreatedById = new Guid("C7BF03EB-2696-4C5E-A2B0-228854FC81C8"),
                    CreatedDate = DateTime.Now
                },
             });
        }
    }
}
