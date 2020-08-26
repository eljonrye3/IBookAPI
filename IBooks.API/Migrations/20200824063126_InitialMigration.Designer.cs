﻿// <auto-generated />
using IBooks.API.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IBooks.API.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20200824063126_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IBooks.API.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "George",
                            LastName = "RR Martin"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Stephen",
                            LastName = "Fry"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "James",
                            LastName = "Elroy"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Douglas",
                            LastName = "Adams"
                        });
                });

            modelBuilder.Entity("IBooks.API.Entities.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2500)")
                        .HasMaxLength(2500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "The book that seems impossible to write",
                            Title = "The Winds of Winter"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "A Game of Thrones is the first novel in A Song of Ice and Fire",
                            Title = "A Game of Thrones"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Description = "The Greek Myths are amongst the best stories ever told",
                            Title = "Mythos"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 3,
                            Description = "American Tabloid is a 1995 novel by James Elroy",
                            Title = "American Tabloid"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 4,
                            Description = "Another book to guide you in the galaxy",
                            Title = "The Hitchhiker's Guid to the Galaxy"
                        });
                });

            modelBuilder.Entity("IBooks.API.Entities.Books", b =>
                {
                    b.HasOne("IBooks.API.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
