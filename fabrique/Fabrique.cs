using gestion_commercial.dao;
using gestion_commercial.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.fabrique
{
    public class Fabrique
    {
        public static IService getInstanceService()
        {
          return new Service(){
              ClientDao = new DaoClient(),
              UserDao = new DaoUser(),
              ProduitDao = new DaoProduit(),
              CmdeDao = new DaoCommande(),
              RoleDao = new DaoRole(),
              SousCatDao = new DaoSousCategorie(),
              DetailDao = new DaoDetail()
          };


        }
    }
}
