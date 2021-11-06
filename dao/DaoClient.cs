using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public class DaoClient : Database, IClientDao
    {
        public DaoClient()
        {
            tableName = "client";
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public Client findById(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findClientByTelephone(string telephone)
        {
            string sql = string.Format("select id,nom_complet,adresse from utilisateur" +
                                       " where telephone like '{0}' ",telephone);
            return executeSelect(sql);
        }

        public int insert(Client obj)
        {
            throw new NotImplementedException();
        }

        public int update(Client obj)
        {
            throw new NotImplementedException();
        }
    }
}
