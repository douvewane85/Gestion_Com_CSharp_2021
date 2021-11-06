using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public class DaoUser : Database, IUserDao
    {
        public DaoUser()
        {
            tableName = "user";
        }

        public int delete(int id)
        {
            string sql = string.Format("Delete from utilisateur where id={0}",id);
            return executeUpdate(sql);
        }

        public DataTable findAll()
        {
            string sql = string.Format("select u.id,u.nom_complet,u.login," +
                                       "u.password,r.id,r.libelle,avatar" +
                                       " from utilisateur u, role r " +
                                       " where u.role_id=r.id and r.libelle not like 'ROLE_CLIENT' " );
             return executeSelect(sql);

        }

        public User findById(int id)
        {
            throw new NotImplementedException();
        }

        public User findUserByLoginAndPassword(string login, string password)
        {
            string sql = string.Format("select u.id,u.nom_complet,u.login," +
                                       "u.password,r.id,r.libelle" +
                                       " from utilisateur u, role r " +
                                       " where u.role_id=r.id " +
                                       " and u.login like '{0}' and u.password like '{1}' ",
                                       login,password);
            DataTable dt= executeSelect(sql);

            if (dt.Rows.Count != 0)
            {
                User user = new User()
                {
                    Id = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString()),
                    NomComplet = dt.Rows[0].ItemArray[1].ToString(),
                    Login = dt.Rows[0].ItemArray[2].ToString(),
                    Password = dt.Rows[0].ItemArray[3].ToString()
                };
                Role role = new Role()
                {
                    Id = Convert.ToInt32(dt.Rows[0].ItemArray[4].ToString()),
                    Libelle = dt.Rows[0].ItemArray[5].ToString()
                };
                user.Role = role;

                return user;
            }
          
                return null;
            
           
        }

        public int insert(User user)
        {
            string sql = string.Format("insert into utilisateur  (nom_complet,login,password,role_id) OUTPUT INSERTED.ID  " +
                                       " values('{0}','{1}','{2}',{3})",
                                      user.NomComplet, user.Login, user.Password,user.Role.Id) ;
            return executeUpdate(sql);
        }

        public int update(User user)
        {
            string sql = string.Format("update utilisateur set nom_complet='{0}',login='{1}',password='{2}'," +
                                       " role_id={3} where id={4} ",
                                     user.NomComplet, user.Login, user.Password, user.Role.Id,user.Id);
            return executeUpdate(sql);
        }

        
    }
}
