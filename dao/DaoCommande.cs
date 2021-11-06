using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public class DaoCommande : Database, ICommandeDao
    {
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public DataTable findAllCommandes(DateTime date = default)
        {
            throw new NotImplementedException();
        }

        public DataTable findAllCommandes(DateTime date, Statut etat)
        {
            throw new NotImplementedException();
        }

        public DataTable findAllCommandes(DateTime date, Statut etat, Client client)
        {
            throw new NotImplementedException();
        }

        public Commande findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Commande obj)
        {
            throw new NotImplementedException();
        }

        public int update(Commande obj)
        {
            throw new NotImplementedException();
        }
    }
}
