using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.models
{
   public  class DetailCommande
    {
        private int qteCom;

        //ManyToOne
        private Commande commande;
        private Produit produit;

        public int QteCom { get => qteCom; set => qteCom = value; }
        public Commande Commande { get => commande; set => commande = value; }
        public Produit Produit { get => produit; set => produit = value; }
    }
}
