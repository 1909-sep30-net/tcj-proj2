using Microsoft.EntityFrameworkCore;

namespace HelpByPros.DataAccess.Entities
{
    public partial class Proj1Context : DbContext
    {
        public Proj1Context()
        {
        }

        public Proj1Context(DbContextOptions<Proj1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Professional> Professionals { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<AccountInfo> AccountInfos { get; set; }
        public virtual DbSet<Questions> RoleTypes { get; set; }
        public virtual DbSet<Answers> Stores { get; set; }
        public virtual DbSet<Categorys> Categorys { get; set; }
        public virtual DbSet<Professions> Professions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
