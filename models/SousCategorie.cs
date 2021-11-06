using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.models
{
   public  class SousCategorie
    {
        private int id;
        private string libelle;

        //ManyToOne 
        private Categorie categorie;

        public SousCategorie()
        {
        }

        public SousCategorie(string libelle)
        {
            this.libelle = libelle;
        }

        public SousCategorie(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public Categorie Categorie { get => categorie; set => categorie = value; }
    }
}
