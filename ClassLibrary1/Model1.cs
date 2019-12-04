namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<conge> conge { get; set; }
        public virtual DbSet<contrat> contrat { get; set; }
        public virtual DbSet<evaluation> evaluation { get; set; }
        public virtual DbSet<evaluation360> evaluation360 { get; set; }
        public virtual DbSet<formation> formation { get; set; }
        public virtual DbSet<pidevds_conge> pidevds_conge { get; set; }
        public virtual DbSet<pidevds_contrat> pidevds_contrat { get; set; }
        public virtual DbSet<pidevds_evaluation> pidevds_evaluation { get; set; }
        public virtual DbSet<pidevds_formation> pidevds_formation { get; set; }
        public virtual DbSet<pidevds_user> pidevds_user { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<conge>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<contrat>()
                .Property(e => e.typeContrat)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.critere)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.notation)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.typeEval)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation360>()
                .Property(e => e.nameEvaluation)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation360>()
                .Property(e => e.avisEvaluation)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.categories)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.nomFormateur)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_conge>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_contrat>()
                .Property(e => e.typeContrat)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_evaluation>()
                .Property(e => e.critere)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_evaluation>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_evaluation>()
                .Property(e => e.notation)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_evaluation>()
                .Property(e => e.typeEval)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_formation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_formation>()
                .Property(e => e.categories)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_formation>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_formation>()
                .Property(e => e.nomFormateur)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_user>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_user>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<pidevds_user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.conge)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_idUser);

            modelBuilder.Entity<user>()
                .HasMany(e => e.contrat)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_idUser);

            modelBuilder.Entity<user>()
                .HasMany(e => e.evaluation)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.employe_idUser);

            modelBuilder.Entity<user>()
                .HasMany(e => e.formation)
                .WithMany(e => e.user)
                .Map(m => m.ToTable("formation_user").MapLeftKey("users_idUser").MapRightKey("Formation_idFormation"));
        }
    }
}
