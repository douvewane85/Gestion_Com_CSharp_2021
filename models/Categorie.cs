using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.models
{
    public class Categorie
    {
        private int id;
        private string libelle;


        //OneToMany
        private List<SousCategorie> sousCategories;
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public List<SousCategorie> SousCategories { get => sousCategories; set => sousCategories = value; }

        public Categorie()
        {
        }

        public Categorie(string libelle)
        {
            this.libelle = libelle;
        }

        public Categorie(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    }
}
