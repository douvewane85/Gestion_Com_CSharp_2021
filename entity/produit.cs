namespace gestion_commercial.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("produit")]
    public partial class produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produit()
        {
            details = new HashSet<detail>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string libelle { get; set; }

        public double stock { get; set; }

        public double prix { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }

        public int id_sous_categorie { get; set; }

        [StringLength(150)]
        public string reference { get; set; }

        public virtual categorie categorie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detail> details { get; set; }
    }
}
