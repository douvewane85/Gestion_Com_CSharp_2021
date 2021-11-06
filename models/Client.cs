using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.models
{
    public class Client:User
    {
        private string tel;
        private string adresse;

        //OneToMany
        private List<Commande> commandes;

        public Client()
        {
            Role = new Role("ROLE_CLIENT");
        }

        public Client(string nomComplet,string tel,string adresse) 
                      : base(nomComplet, null, null)
        {
            this.Adresse = adresse;
            this.Tel = tel;
            Role = new Role("ROLE_CLIENT");
        }
        public Client(int id,string nomComplet, string tel, string adresse)
                     : base(id,nomComplet, null, null)
        {
            this.Adresse = adresse;
            this.Tel = tel;
            Role = new Role("ROLE_CLIENT");
        }

        public string Tel { get => tel; set => tel = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<Commande> Commandes { get => commandes; set => commandes = value; }
    }
}
