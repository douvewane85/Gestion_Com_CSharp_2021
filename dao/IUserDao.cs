using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public interface IUserDao : IDAO<User>
    {
        User findUserByLoginAndPassword(String login, String password);
        
    }
}
