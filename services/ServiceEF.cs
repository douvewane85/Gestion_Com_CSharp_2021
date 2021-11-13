using gestion_commercial.dto;
using gestion_commercial.entity;
using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.services
{
    public class ServiceEF 
    {
        private Database dao = new Database();
        public int addCommande(Commande commande, List<ProduitDto> produits, Client client)
        {
            throw new NotImplementedException();
        }

        public int addProduit(produit prod)
        {
            dao.produits.Add(prod);
            return dao.SaveChanges();
        }

        public int addUser(User user)
        {
            throw new NotImplementedException();
        }

        public int deleteProduit(int id)
        {
            produit prodDel = dao.produits.Where(prod => prod.Id == id).FirstOrDefault();
            dao.produits.Remove(prodDel);
            return dao.SaveChanges();


        }

        public int deleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable searchClientByNumero(string numero)
        {
            throw new NotImplementedException();
        }

        public DataTable searchProduitByReference(string reference)
        {
            throw new NotImplementedException();
        }

        public User searchUserLoginAndPassword(string login, string password)
        {
            throw new NotImplementedException();
        }

        public DataTable showAllCategories()
        {
            throw new NotImplementedException();
        }

        public List<commande> showAllCommandes()
        {
                  return dao.commandes.ToList();
        }

        public List<commande> showAllCommandes(DateTime date)
        {
            return dao.commandes.Where(cmde => cmde.date_cmde.CompareTo(date)==0)
                                           .OrderByDescending(cmde => cmde.date_cmde).ToList();
        }

        public List<commande> showAllCommandes(Statut etat)
        {
            //Expression Lamda
            return dao.commandes.Where(cmde => cmde.statut.CompareTo(etat.ToString()) == 0)
                                           .OrderByDescending(cmde => cmde.date_cmde).ToList();
        }

        public List<commande> showAllCommandes(String  telephone)
        {
            //Expression Lamda
            return dao.commandes.Where(cmde => cmde.utilisateur.telephone.CompareTo(telephone)==0).ToList();
        }
        public commande showCommandeById(int id)
        {
            //Expression Lamda
              return dao.commandes.Where(cmde => cmde.Id==id).FirstOrDefault();
        }
        public List<commande> showAllCommandes(Statut etat, String telephone)
        {
            //Link To Sql
            var result = from c in dao.commandes
                         orderby c.date_cmde descending
                         where
                                c.statut.CompareTo(etat.ToString()) == 0
                               && c.utilisateur.telephone.CompareTo(telephone)==0
                         select c;

            //select new { c.Id,c.date_cmde};
            return result.ToList();

        }

        public DataTable showAllProduits()
        {
            throw new NotImplementedException();
        }

        public DataTable showAllRole()
        {
            throw new NotImplementedException();
        }

        public DataTable showAllSousCategories()
        {
            throw new NotImplementedException();
        }

        public DataTable showAllSousCategories(int idCat)
        {
            throw new NotImplementedException();
        }

        public DataTable showAllUsers()
        {
            throw new NotImplementedException();
        }

        public int updateProduit(produit prod)
        {
            produit prodDel = dao.produits.Where(prods => prods.Id == prod.Id).SingleOrDefault();
            dao.produits.Add(prodDel);
            return dao.SaveChanges();

        }
        public int updateCommande(commande cmd)
        {            
            commande cmdeUp= dao.commandes.Where(cmde => cmde.Id == cmd.Id).SingleOrDefault();
            cmdeUp.statut = cmd.statut;
            return dao.SaveChanges();

        }
        public int updateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
