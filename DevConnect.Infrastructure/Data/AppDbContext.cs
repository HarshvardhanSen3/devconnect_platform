using DevConnect.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        // ── DbSets ────────────────────────────────────────
        public DbSet<User> Users { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<AdminLog> AdminLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ── User Configuration ─────────────────────────
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(u => u.Username)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(u => u.Email)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(u => u.PasswordHash)
                      .IsRequired();

                entity.Property(u => u.Bio)
                      .HasMaxLength(500);

                // Unique constraints
                entity.HasIndex(u => u.Email)
                      .IsUnique();

                entity.HasIndex(u => u.Username)
                      .IsUnique();

                // Enum stored as string — readable in DB
                entity.Property(u => u.Role)
                      .HasConversion<string>();

                entity.Property(u => u.Status)
                      .HasConversion<string>();

                entity.Property(u => u.ExperienceLevel)
                      .HasConversion<string>();
            });

            // ── UserSkill Configuration ────────────────────
            modelBuilder.Entity<UserSkill>(entity =>
            {
                entity.HasKey(us => us.Id);

                entity.HasOne(us => us.User)
                      .WithMany(u => u.Skills)
                      .HasForeignKey(us => us.UserId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.Property(us => us.SkillName)
                      .IsRequired()
                      .HasMaxLength(100);
            });

            // ── AdminLog Configuration ─────────────────────
            modelBuilder.Entity<AdminLog>(entity =>
            {
                entity.HasKey(al => al.Id);

                entity.HasOne(al => al.Admin)
                      .WithMany()
                      .HasForeignKey(al => al.AdminId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}