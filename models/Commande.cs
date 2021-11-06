using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.models
{
    public enum Statut
    {
        ENCOURS,
        VALIDER,
        ANNULER,
        LIVRER
    }
    public class Commande
    {
        private int id;
        private string numero;
        private DateTime date = DateTime.Now;
        private float total;
        private Statut etat = Statut.ENCOURS;

        //ManyToOne
        private Client client;
        public Commande()
        {
        }

        public Commande(string numero, DateTime date, float total, Statut etat)
        {
            this.numero = numero;
            this.date = date;
            this.total = total;
            this.etat = etat;
        }

        public Commande(int id, string numero, DateTime date, float total, Statut etat)
        {
            this.id = id;
            this.numero = numero;
            this.date = date;
            this.total = total;
            this.etat = etat;
        }

        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public DateTime Date { get => date; set => date = value; }
        public float Total { get => total; set => total = value; }
        public Statut Etat { get => etat; set => etat = value; }
        public Client Client { get => client; set => client = value; }
    }
}
