using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public class DaoSousCategorie : Database, ISousCategorie
    {
        public DaoSousCategorie()
        {
            tableName = "sous_categorie";
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public DataTable findAllCategorie()
        {
            string sql = "select * from categorie where id_categorie is null";
            return executeSelect(sql);
        }

        public DataTable findAllSousCategoriesByIDCategorie(int idCat)
        {
            string sql = string.Format( "select * from categorie where id_categorie={0}",idCat);
            return executeSelect(sql);
        }

        public SousCategorie findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(SousCategorie obj)
        {
            throw new NotImplementedException();
        }

        public int update(SousCategorie obj)
        {
            throw new NotImplementedException();
        }
    }
}
