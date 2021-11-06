using gestion_commercial.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.models
{

  
    public class Produit
    {
        private static int nbreProduit;
        private int id;
        private string libelle;
        private string reference;
        private byte[] image;
        private int qteStock;
        private float prix;

        //OneToMany
        private SousCategorie sousCategorie;

        public Produit()
        {
            NbreProduit++;
        }

        public Produit(string libelle, string reference,  int qteStock, float prix)
        {
            this.libelle = libelle;
            this.reference = reference;
            this.qteStock = qteStock;
            this.prix = prix;
            NbreProduit++;
        }

        public Produit(int id, string libelle, string reference,  int qteStock, float prix)
        {
            this.id = id;
            this.libelle = libelle;
            this.reference = reference;
            this.qteStock = qteStock;
            this.prix = prix;
            NbreProduit++;
        }

        public static int NbreProduit { get => nbreProduit; set => nbreProduit = value; }
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public string Reference { get => reference; set => reference = value; }
        public byte[] Image { get => image; set => image = value; }
        public int QteStock { get => qteStock; set => qteStock = value; }
        public float Prix { get => prix; set => prix = value; }
        public SousCategorie SousCategorie { get => sousCategorie; set => sousCategorie = value; }

        public static string getReference()
        {
            //si nbreProduit est sur 1 chiffre(1..9)  00Chiffre
            //si nbreProduit est sur 2 chiffre(10..99) 02Chiffre
            //si nbreProduit est sur 3 chiffre(10..99) 3Chiffre
            string refProd;
            //convertir le Nbre de Produits en chaine
            int seq = MyFile.generateSeqence();
            string stringNbreProduit = string.Format("{0}", seq);
            switch (stringNbreProduit.Length)
            {
                case 1:
                    refProd = "REF00" + seq;
                    break;
                case 2:
                    refProd = "REF0" + seq;
                    break;
                default:
                    refProd = string.Format("REF{0}", seq);
                    break;
            }

            return refProd;

        }
    }

   
}
