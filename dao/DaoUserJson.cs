using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    class DaoUserJson : IUserDao
    {
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public User findById(int id)
        {
            throw new NotImplementedException();
        }

        public User findUserByLoginAndPassword(string login, string password)
        {
            throw new NotImplementedException();
        }

        public DataTable findUserByTelephone(string telephone)
        {
            throw new NotImplementedException();
        }

        public int insert(User obj)
        {
            throw new NotImplementedException();
        }

        public int update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
