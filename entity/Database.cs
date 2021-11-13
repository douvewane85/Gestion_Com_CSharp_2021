using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace gestion_commercial.entity
{
    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<categorie> categories { get; set; }
        public virtual DbSet<commande> commandes { get; set; }
        public virtual DbSet<detail> details { get; set; }
        public virtual DbSet<produit> produits { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<utilisateur> utilisateurs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<categorie>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<categorie>()
                .HasMany(e => e.produits)
                .WithRequired(e => e.categorie)
                .HasForeignKey(e => e.id_sous_categorie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<commande>()
                .Property(e => e.statut)
                .IsUnicode(false);

            modelBuilder.Entity<commande>()
                .HasMany(e => e.details)
                .WithRequired(e => e.commande)
                .HasForeignKey(e => e.commande_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.reference)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .HasMany(e => e.details)
                .WithRequired(e => e.produit)
                .HasForeignKey(e => e.produit_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.utilisateurs)
                .WithRequired(e => e.role)
                .HasForeignKey(e => e.role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.nom_complet)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .HasMany(e => e.commandes)
                .WithRequired(e => e.utilisateur)
                .HasForeignKey(e => e.client_id)
                .WillCascadeOnDelete(false);
        }
    }
}
