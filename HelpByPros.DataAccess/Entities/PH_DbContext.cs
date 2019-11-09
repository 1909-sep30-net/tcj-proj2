using Microsoft.EntityFrameworkCore;

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
        public virtual DbSet<Professionals> Professionals { get; set; }
        public virtual DbSet<AccountInfo> AccountInfos { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(1, 1) // IDENTITY(1,1)
                    .IsRequired();
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
                    .HasMaxLength(64); // NVARCHAR(64)                 
                entity.Property(p => p.Email)
                   .HasMaxLength(100) // NVARCHAR(64)   
                   .IsRequired();
                entity.HasIndex(p => p.Username)
                    .IsUnique();// UNIQUE
                entity.HasIndex(p => p.Phone)
                    .IsUnique();// UNIQUE
                entity.HasIndex(p => p.Email)
                    .IsUnique();// UNIQUE
                entity.HasIndex(p => p.Id)
                    .IsUnique();// UNIQUE
            });

            modelBuilder.Entity<Admins>(entity =>
            {
                entity.Property(p => p.Id)
                     .UseIdentityColumn(1, 1) // IDENTITY(1,1)
                    .IsRequired();
                entity.HasOne(pt => pt.User) // configure one nav property
                   .WithMany(p => p.Admins) // configure the opposite nav property
                   .HasForeignKey(pt => pt.UsersID) // configure the foreign key property
                   .IsRequired() // NOT NULL
                   .OnDelete(DeleteBehavior.Cascade); // ON DELETE CASCADE
                entity.HasIndex(p => p.Id)
                   .IsUnique();// UNIQUE
            });
            modelBuilder.Entity<Members>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(1, 1) // IDENTITY(1,1)
                    .IsRequired();
                entity.HasOne(pt => pt.User) // configure one nav property
                  .WithMany(p => p.Members) // configure the opposite nav property
                  .HasForeignKey(pt => pt.UserID) // configure the foreign key property
                  .IsRequired() // NOT NULL
                  .OnDelete(DeleteBehavior.Cascade); // ON DELETE CASCADE

                entity.HasOne(pt => pt.AccInfo) // configure one nav property
                 .WithOne(p => p.Member) // configure the opposite nav property          
                 .HasForeignKey<Members>(p => p.AccountInfoID)
                 .IsRequired() // NOT NULL
                 .OnDelete(DeleteBehavior.Cascade); // ON DELETE CASCADE
                entity.HasIndex(p => p.Id)
                   .IsUnique();// UNIQUE
            });
            modelBuilder.Entity<Professionals>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(1, 1) // IDENTITY(1,1)
                    .IsRequired();

                entity.HasOne(pt => pt.User) // configure one nav property
                 .WithMany(p => p.Professionals) // configure the opposite nav property
                 .HasForeignKey(pt => pt.UserID) // configure the foreign key property
                 .IsRequired() // NOT NULL
                 .OnDelete(DeleteBehavior.Cascade); // ON DELETE CASCADE

                entity.HasOne(pt => pt.AccInfo) // configure one nav property
               .WithOne(p => p.Professional) // configure the opposite nav property          
               .HasForeignKey<Professionals>(p => p.AccountInfoID)
               .IsRequired() // NOT NULL
               .OnDelete(DeleteBehavior.Cascade);// ON DELETE CASCADE

                entity.Property(p => p.Expertise)
                    .IsRequired();

            });

            modelBuilder.Entity<AccountInfo>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(1, 1) // IDENTITY(1,1)
                    .IsRequired();
                entity.Property(p => p.PointAvailable)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(64); // NVARCHAR(64)   

                entity.HasIndex(p => p.Id)
                   .IsUnique();// UNIQUE
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.Property(p => p.Id)
                     .UseIdentityColumn(1, 1) // IDENTITY(1,1)
                    .IsRequired();
                entity.Property(p => p.UserQuestion)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(126); // NVARCHAR(64)   
                entity.Property(p => p.Answered)

                   .HasMaxLength(200)                   

                   .IsRequired(); // NOT NULL
                entity.Property(p => p.Category)
                  .HasMaxLength(200)
                  .IsRequired(); // NOT NULL
                entity.HasOne(pt => pt.Users) // configure one nav property
                    .WithMany(p => p.QueCollection) // configure the opposite nav property          
                    .HasForeignKey(p => p.UsersID)
                    .IsRequired() // NOT NULL
                    .OnDelete(DeleteBehavior.Cascade);// ON DELETE CASCADE
                entity.HasIndex(p => p.Id)
                   .IsUnique();// UNIQUE
            });

            modelBuilder.Entity<Answers>(entity =>
            {
                entity.Property(p => p.Id)
                    .UseIdentityColumn(1, 1) // IDENTITY(1,1)
                    .IsRequired();
                entity.Property(p => p.UpVote)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(4); // NVARCHAR(64)  
                entity.Property(p => p.DownVote)
                    .IsRequired() // NOT NULL
                    .HasMaxLength(4); // NVARCHAR(64)
                entity.Property(p => p.Sources)
                   .IsRequired() // NOT NULL
                   .HasMaxLength(64); // NVARCHAR(64)

                entity.Property(p => p.Best)
                   .IsRequired(); // NOT NULL

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
                entity.HasIndex(p => p.Id)
                   .IsUnique();// UNIQUE

            });




        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
