using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AcademyDBFirst
{
    public partial class AcademyContext : DbContext
    {
        public AcademyContext()
        {
        }

        public AcademyContext(DbContextOptions<AcademyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Site> Sites { get; set; } = null!;
        public virtual DbSet<Spartan> Spartans { get; set; } = null!;
        public virtual DbSet<SpartanTrainer> SpartanTrainers { get; set; } = null!;
        public virtual DbSet<SpartanUniversity> SpartanUniversities { get; set; } = null!;
        public virtual DbSet<Stream> Streams { get; set; } = null!;
        public virtual DbSet<StreamTrainer> StreamTrainers { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;
        public virtual DbSet<University> Universities { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Site>(entity =>
            {
                entity.ToTable("Site");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Spartan>(entity =>
            {
                entity.Property(e => e.CityOfResidence)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Course)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateJoined).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GradeAchieved)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HasGraduated).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOnSite).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpartanTrainer>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Spartan)
                    .WithMany()
                    .HasForeignKey(d => d.SpartanId)
                    .HasConstraintName("FK__SpartanTr__Spart__48CFD27E");

                entity.HasOne(d => d.Trainer)
                    .WithMany()
                    .HasForeignKey(d => d.TrainerId)
                    .HasConstraintName("FK__SpartanTr__Train__49C3F6B7");
            });

            modelBuilder.Entity<SpartanUniversity>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SpartanId).HasColumnName("SpartanID");

                entity.Property(e => e.UniversityId).HasColumnName("UniversityID");

                entity.HasOne(d => d.Spartan)
                    .WithMany()
                    .HasForeignKey(d => d.SpartanId)
                    .HasConstraintName("FK__SpartanUn__Spart__3F466844");

                entity.HasOne(d => d.University)
                    .WithMany()
                    .HasForeignKey(d => d.UniversityId)
                    .HasConstraintName("FK__SpartanUn__Unive__403A8C7D");
            });

            modelBuilder.Entity<Stream>(entity =>
            {
                entity.ToTable("Stream");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StreamTrainer>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Stream)
                    .WithMany()
                    .HasForeignKey(d => d.StreamId)
                    .HasConstraintName("FK__StreamTra__Strea__45F365D3");

                entity.HasOne(d => d.Trainer)
                    .WithMany()
                    .HasForeignKey(d => d.TrainerId)
                    .HasConstraintName("FK__StreamTra__Train__46E78A0C");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("Trainer");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.ToTable("University");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UK')");

                entity.Property(e => e.Name)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
