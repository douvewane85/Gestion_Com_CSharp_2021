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

        public int insert(Commande commande)
        {
            string sql = string.Format("insert  into commande(date_cmde,total,statut,client_id) OUTPUT INSERTED.ID  " +
                                        " values ('{0}',{1},'Encours',{2})",
                                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), 
                                        commande.Total,
                                        commande.Client.Id);
            return executeUpdate(sql);
        }

        public int update(Commande obj)
        {
            throw new NotImplementedException();
        }
    }
}
