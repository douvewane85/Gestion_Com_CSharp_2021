using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
   public  interface IDataBase
    {
        void openConnexion();
        void closeConnexion();
        int executeUpdate(string sql, byte[] image=null);
        DataTable executeSelect(string sql);

    }
}
