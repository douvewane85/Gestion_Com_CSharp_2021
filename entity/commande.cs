namespace gestion_commercial.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("commande")]
    public partial class commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public commande()
        {
            details = new HashSet<detail>();
        }

        public int Id { get; set; }

        public DateTime date_cmde { get; set; }

        public double total { get; set; }

        [Required]
        [StringLength(50)]
        public string statut { get; set; }

        public int client_id { get; set; }

        public virtual utilisateur utilisateur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detail> details { get; set; }
    }
}
