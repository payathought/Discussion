﻿// <auto-generated />
using System;
using Discussion.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Discussion.Repository.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230309090855_ChangeMap2")]
    partial class ChangeMap2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Discussion.Data.Entities.Discussion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ObserverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Outcomes")
                        .HasMaxLength(5124)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("ObserverId");

                    b.ToTable("Discussion", "discussions");
                });

            modelBuilder.Entity("Discussion.Data.Entities.DiscussionUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("DiscussionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DiscussionId");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("UserId");

                    b.ToTable("DiscussionUser", "discussionUsers");
                });

            modelBuilder.Entity("Discussion.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.ToTable("User", "users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                            CreatedById = new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                            CreatedDate = new DateTime(2023, 3, 9, 17, 8, 54, 752, DateTimeKind.Local).AddTicks(7328),
                            Deleted = false,
                            FirstName = "Admin",
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("0b411d1f-8c24-401c-9a93-6eba12084334"),
                            CreatedById = new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                            CreatedDate = new DateTime(2023, 3, 9, 17, 8, 54, 753, DateTimeKind.Local).AddTicks(2397),
                            Deleted = false,
                            FirstName = "Adam",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"),
                            CreatedById = new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                            CreatedDate = new DateTime(2023, 3, 9, 17, 8, 54, 753, DateTimeKind.Local).AddTicks(2410),
                            Deleted = false,
                            FirstName = "Joe",
                            LastName = "Parker"
                        },
                        new
                        {
                            Id = new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"),
                            CreatedById = new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                            CreatedDate = new DateTime(2023, 3, 9, 17, 8, 54, 753, DateTimeKind.Local).AddTicks(2415),
                            Deleted = false,
                            FirstName = "Patrick",
                            LastName = "Gargoles"
                        },
                        new
                        {
                            Id = new Guid("73a27840-ba70-4c90-866b-9246c779ca15"),
                            CreatedById = new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                            CreatedDate = new DateTime(2023, 3, 9, 17, 8, 54, 753, DateTimeKind.Local).AddTicks(2418),
                            Deleted = false,
                            FirstName = "Shannon",
                            LastName = "Jones"
                        },
                        new
                        {
                            Id = new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"),
                            CreatedById = new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                            CreatedDate = new DateTime(2023, 3, 9, 17, 8, 54, 753, DateTimeKind.Local).AddTicks(2420),
                            Deleted = false,
                            FirstName = "Hurish",
                            LastName = "Williams"
                        });
                });

            modelBuilder.Entity("Discussion.Data.Entities.Discussion", b =>
                {
                    b.HasOne("Discussion.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Discussion.Data.Entities.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Discussion.Data.Entities.User", "Observer")
                        .WithMany()
                        .HasForeignKey("ObserverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");

                    b.Navigation("Observer");
                });

            modelBuilder.Entity("Discussion.Data.Entities.DiscussionUser", b =>
                {
                    b.HasOne("Discussion.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Discussion.Data.Entities.Discussion", "Discussion")
                        .WithMany("DiscussionUsers")
                        .HasForeignKey("DiscussionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Discussion.Data.Entities.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Discussion.Data.Entities.User", "User")
                        .WithMany("DiscussionUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Discussion");

                    b.Navigation("ModifiedBy");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Discussion.Data.Entities.User", b =>
                {
                    b.HasOne("Discussion.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Discussion.Data.Entities.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("Discussion.Data.Entities.Discussion", b =>
                {
                    b.Navigation("DiscussionUsers");
                });

            modelBuilder.Entity("Discussion.Data.Entities.User", b =>
                {
                    b.Navigation("DiscussionUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
