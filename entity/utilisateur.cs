namespace gestion_commercial.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("utilisateur")]
    public partial class utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public utilisateur()
        {
            commandes = new HashSet<commande>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string nom_complet { get; set; }

        [StringLength(25)]
        public string login { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        [Column(TypeName = "text")]
        public string adresse { get; set; }

        [StringLength(20)]
        public string telephone { get; set; }

        public int role_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] avatar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande> commandes { get; set; }

        public virtual role role { get; set; }

        public override string ToString()
        {
            return nom_complet;
        }
    }
}
