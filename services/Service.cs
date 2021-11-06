using gestion_commercial.dao;
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
    public class Service : IService
    {
        //Couplage Faible
        private IUserDao userDao;
        private IClientDao clientDao;
        private ICommandeDao cmdeDao;
        private IRoleDao roleDao;
        private IProduitDao produitDao;
        private IDetailDao detailDao;
        private ISousCategorie sousCatDao;

        public Service()
        {
        }

        //Injection de Dépendance
        public Service(IUserDao userDao, IClientDao clientDao, ICommandeDao cmdeDao, 
            IRoleDao roleDao, IProduitDao produitDao, IDetailDao detailDao, ISousCategorie sousCatDao)
        {
            this.userDao = userDao;
            this.clientDao = clientDao;
            this.cmdeDao = cmdeDao;
            this.roleDao = roleDao;
            this.produitDao = produitDao;
            this.detailDao = detailDao;
            this.sousCatDao = sousCatDao;
        }

        public IUserDao UserDao { get => userDao; set => userDao = value; }
        public IClientDao ClientDao { get => clientDao; set => clientDao = value; }
        public ICommandeDao CmdeDao { get => cmdeDao; set => cmdeDao = value; }
        public IRoleDao RoleDao { get => roleDao; set => roleDao = value; }
        public IProduitDao ProduitDao { get => produitDao; set => produitDao = value; }
        public IDetailDao DetailDao { get => detailDao; set => detailDao = value; }
        public ISousCategorie SousCatDao { get => sousCatDao; set => sousCatDao = value; }

        public int addCommande(Commande commande, List<ProduitDto> produits, Client client)
        {
            commande.Client = client;
            int idCmde = CmdeDao.insert(commande);
            foreach (var produitDto in produits)
            {
                DetailCommande detail = new DetailCommande()
                {
                   Produit= produitDto.dtoToModel(),
                   Commande=new Commande() {Id= idCmde},
                   QteCom= produitDto.QteComd
                };
                if (DetailDao.insert(detail) != 0)
                {
                    produitDto.QteStock -= produitDto.QteComd;
                    ProduitDao.update(produitDto);
                }
            }

            return idCmde;
        }

        public int addProduit(Produit produit)
        {
           return ProduitDao.insert(produit);
        }

        public int addUser(User user)
        {
           return UserDao.insert(user);
        }

        public int deleteProduit(int id)
        {
            return ProduitDao.delete(id);
        }

        public int deleteUser(int id)
        {
            return UserDao.delete(id);
        }

        public DataTable searchClientByNumero(string numero)
        {
            return ClientDao.findClientByTelephone(numero);
        }

        public DataTable searchProduitByReference(string reference)
        {
            return ProduitDao.findProduitByReference(reference);
        }

        public User searchUserLoginAndPassword(string login, string password)
        {
            return UserDao.findUserByLoginAndPassword(login,password);
        }

        public DataTable showAllCategories()
        {
            return SousCatDao.findAllCategorie();
        }

        public List<Commande> showAllCommandes(DateTime date = default)
        {
            throw new NotImplementedException();
        }

        public List<Commande> showAllCommandes(DateTime date, Statut etat)
        {
            throw new NotImplementedException();
        }

        public List<Commande> showAllCommandes(DateTime date, Statut etat, Client client)
        {
            throw new NotImplementedException();
        }

        public DataTable showAllProduits()
        {
            return ProduitDao.findAll();
        }

        public DataTable showAllRole()
        {
           return RoleDao.findAll();
        }

        public DataTable showAllSousCategories()
        {
            throw new NotImplementedException();
        }

        public DataTable showAllSousCategories(int idCat)
        {
            return SousCatDao.findAllSousCategoriesByIDCategorie(idCat);
        }

        public DataTable showAllUsers()
        {
            return UserDao.findAll();
        }

        public int updateProduit(Produit produit)
        {
            return ProduitDao.update(produit);
        }

        public int updateUser(User user)
        {
            return userDao.update(user);
        }
    }
}
