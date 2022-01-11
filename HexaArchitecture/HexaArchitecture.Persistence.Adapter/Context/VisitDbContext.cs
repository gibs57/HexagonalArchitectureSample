using HexaArchitecture.DomainApi.Model.Visitor;
using Microsoft.EntityFrameworkCore;

namespace HexaArchitecture.Persistence.Adapter.Context
{
    public class VisitDbContext : DbContext
    {
        public VisitDbContext(DbContextOptions<VisitDbContext> options) : base(options)
        {
        }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPreferences> Preferences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Site>().ToTable("Site");

            modelBuilder.HasSequence<int>("GroupId").StartsAt(1).IncrementsBy(1); ;

            modelBuilder.Entity<Visitor>(entity =>
            {
                entity.Property(e => e.IsPurged).HasDefaultValue(false);
                entity.ToTable("Visitor");
            });

            modelBuilder.Entity<Visit>(entity =>
            {
                entity.Property(e => e.IsReducedMobility).HasDefaultValue(false);
                entity.Property(e => e.IsIdentityMandatory).HasDefaultValue(false);
                entity.Property(e => e.IsAllowedToPass).HasDefaultValue(false);
                entity.Property(e => e.DontSendSMSToTransmitter).HasDefaultValue(false);
                entity.Property(e => e.DontSendEmailToTransmitter).HasDefaultValue(false);
                entity.Property(e => e.DontSendSMSToVisited).HasDefaultValue(false);
                entity.Property(e => e.DontSendEmailToVisited).HasDefaultValue(false);
                entity.ToTable("Visit");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.EmployeeID);
                entity.ToTable("Users");
            });

            modelBuilder.Entity<UserPreferences>(entity =>
            {
                entity.Property(e => e.AskID).HasDefaultValue(true);
                entity.Property(e => e.DelegationSendEmail).HasDefaultValue(true);
                entity.Property(e => e.DelegationSendSMS).HasDefaultValue(true);
                entity.Property(e => e.TransmitterSendEmail).HasDefaultValue(true);
                entity.Property(e => e.TransmitterSendSMS).HasDefaultValue(true);
                entity.ToTable("UserPreferences");
            });
        }
    }
}
