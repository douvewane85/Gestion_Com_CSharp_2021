using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public class DaoRole : Database, IRoleDao
    {
        public DaoRole()
        {
            tableName = "role";
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findAll()
        {
            string sql = "select * from role where libelle not like 'ROLE_CLIENT'";
            return executeSelect(sql);
        }

        public Role findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Role obj)
        {
            throw new NotImplementedException();
        }

        public int update(Role obj)
        {
            throw new NotImplementedException();
        }
    }
}
