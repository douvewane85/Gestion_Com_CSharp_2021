namespace gestion_commercial.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("detail")]
    public partial class detail
    {
        public int Id { get; set; }

        public int produit_id { get; set; }

        public int commande_id { get; set; }

        public double qte_com { get; set; }

        public virtual commande commande { get; set; }

        public virtual produit produit { get; set; }
    }
}
