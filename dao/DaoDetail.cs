using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public class DaoDetail : Database, IDetailDao
    {
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public DetailCommande findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(DetailCommande detail)
        {
            string sql = string.Format("insert into detail(produit_id,commande_id,qte_com) OUTPUT INSERTED.ID  " +
                                          " values ({0},{1},{2})",
                                          detail.Produit.Id,detail.Commande.Id,detail.QteCom);
            return executeUpdate(sql);
        }

        public int update(DetailCommande obj)
        {
            throw new NotImplementedException();
        }
    }
}
