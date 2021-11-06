using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
     public  interface IDAO<T>
    {
         int insert(T obj);
         int update(T obj);
         int delete(int id);
         DataTable findAll();
         T findById(int id);

    }
}
