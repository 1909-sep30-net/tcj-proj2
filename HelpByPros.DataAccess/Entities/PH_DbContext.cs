﻿using Microsoft.EntityFrameworkCore;
namespace HelpByPros.DataAccess.Entities
{
    public partial class PH_DbContext : DbContext
    {
        public PH_DbContext()
        {
        }

        public PH_DbContext(DbContextOptions<PH_DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Admins> Admin { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Professional> Professionals { get; set; }
        public virtual DbSet<AccountInfo> AccountInfos { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Categorys> Categorys { get; set; }
        public virtual DbSet<Professions> Professions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(); // IDENTITY(1,1)
                entity.Property(p => p.FirstName)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(64); // NVARCHAR(64)
                entity.Property(p => p.LastName)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(64); // NVARCHAR(64)
                entity.Property(p => p.Profile_Pic);
                entity.Property(p => p.Password)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(64); // NVARCHAR(64)
                entity.Property(p => p.Username)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(64); // NVARCHAR(64)
                entity.Property(p => p.Phone)
                    .HasMaxLength(10); // NVARCHAR(64)   
                entity.Property(p => p.Email)
                   .HasMaxLength(100) // NVARCHAR(64)   
                   .IsRequired();
                entity.HasIndex(p => p.Username)
                    .IsUnique();// UNIQUE
            });

            modelBuilder.Entity<Admins>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(); // IDENTITY(1,1)

                entity.HasOne(pt => pt.User) // configure one nav property
                   .WithMany(p=> p.Admins) // configure the opposite nav property
                   .HasForeignKey(pt => pt.UsersID) // configure the foreign key property
                   .IsRequired() // NOT NULL
                   .OnDelete(DeleteBehavior.Cascade); // ON DELETE CASCADE

            });
            modelBuilder.Entity<Members>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(); // IDENTITY(1,1)
                entity.HasOne(pt => pt.User) // configure one nav property
                  .WithMany(p => p.Members) // configure the opposite nav property
                  .HasForeignKey(pt => pt.Id) // configure the foreign key property
                  .IsRequired() // NOT NULL
                  .OnDelete(DeleteBehavior.Cascade); // ON DELETE CASCADE

                entity.HasOne(pt => pt.AccountInfo) // configure one nav property
                 .WithOne(p => p.Member) // configure the opposite nav property          
                 .HasForeignKey<Members>(p => p.AccountInfoID)
                 .IsRequired() // NOT NULL
                 .OnDelete(DeleteBehavior.Cascade); // ON DELETE CASCADE

            });
            modelBuilder.Entity<Professional>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(); // IDENTITY(1,1)
                entity.HasOne(pt => pt.User) // configure one nav property
                  .WithMany(p => p.Professionals) // configure the opposite nav property
                  .HasForeignKey(pt => pt.Id) // configure the foreign key property
                  .IsRequired() // NOT NULL
                  .OnDelete(DeleteBehavior.Cascade); // ON DELETE CASCADE

                entity.HasOne(pt => pt.AccountInfo) // configure one nav property
               .WithOne(p => p.Professional) // configure the opposite nav property          
               .HasForeignKey<Professional>(p => p.AccountInfoID)
               .IsRequired() // NOT NULL
               .OnDelete(DeleteBehavior.Cascade);// ON DELETE CASCADE

               entity.HasOne(pt => pt.Profession) // configure one nav property
              .WithOne(p => p.Professional) // configure the opposite nav property          
              .HasForeignKey<Professional>(p => p.ProfessionID)
              .IsRequired() // NOT NULL
              .OnDelete(DeleteBehavior.Cascade);// ON DELETE CASCADE
            });
            
            modelBuilder.Entity<AccountInfo>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(); // IDENTITY(1,1)
                entity.Property(p => p.PointAvailable)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(64); // NVARCHAR(64)   
              

            });
            modelBuilder.Entity<Questions>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(); // IDENTITY(1,1)
                entity.Property(p => p.UserQuestion)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(126); // NVARCHAR(64)   

                entity.HasOne(pt => pt.Category) // configure one nav property
                    .WithOne(p => p.Question) // configure the opposite nav property          
                    .HasForeignKey<Questions>(p => p.CategoryID)
                    .IsRequired() // NOT NULL
                    .OnDelete(DeleteBehavior.Cascade);// ON DELETE CASCADE

                entity.HasOne(pt => pt.Users) // configure one nav property
                    .WithMany(p => p.QueCollection) // configure the opposite nav property          
                    .HasForeignKey(p => p.UsersID)
                    .IsRequired() // NOT NULL
                    .OnDelete(DeleteBehavior.Cascade);// ON DELETE CASCADE

            });
           
            modelBuilder.Entity<Answers>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(); // IDENTITY(1,1)
                entity.Property(p => p.UpVote)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(4); // NVARCHAR(64)  
                entity.Property(p => p.DownVote)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(4); // NVARCHAR(64)

                entity.HasOne(pt => pt.User) // configure one nav property
                   .WithMany(p => p.AnsCollection) // configure the opposite nav property          
                   .HasForeignKey(p => p.UserID)
                   .IsRequired() // NOT NULL
                   .OnDelete(DeleteBehavior.Cascade);// ON DELETE CASCADE

                entity.HasOne(pt => pt.Question) // configure one nav property
                  .WithMany(p => p.AnsCollection) // configure the opposite nav property          
                  .HasForeignKey(p => p.QuestionID)
                  .IsRequired() // NOT NULL
                  .OnDelete(DeleteBehavior.Cascade);// ON DELETE CASCADE


            });
            modelBuilder.Entity<Categorys>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(); // IDENTITY(1,1)   
            });

            modelBuilder.Entity<Professions>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(); // IDENTITY(1,1)
                entity.Property(p => p.Summary)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(126); // NVARCHAR(126)  
                entity.Property(p => p.YearsOfExperience)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(2); // NVARCHAR(64)


            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
