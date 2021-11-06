using gestion_commercial.dto;
using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.services
{
   public  interface IService
    {
        //Gerer User
              int addUser(User user);
              int updateUser(User user);
              int deleteUser(int id);
              DataTable showAllUsers();
              DataTable showAllCategories();
         //Se Connecter
              User searchUserLoginAndPassword(string login,string password);
               DataTable showAllRole();
               int addProduit(Produit produit);
               int updateProduit(Produit produit);
               int deleteProduit(int id);
        DataTable showAllSousCategories();
              DataTable showAllSousCategories(int idCat);
              DataTable showAllProduits();
              DataTable searchClientByNumero(string numero);
              DataTable searchProduitByReference(string reference);
              int addCommande(Commande commande, List<ProduitDto> produits,Client client);
              List<Commande> showAllCommandes(DateTime date=default(DateTime));
              List<Commande> showAllCommandes(DateTime date,Statut etat);
              List<Commande> showAllCommandes(DateTime date, Statut etat,Client client);
    }
}
