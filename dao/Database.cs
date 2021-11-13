using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public class Database : IDataBase
    {
        //1-Objet Connexion
        SqlConnection conn = new SqlConnection();
        //2-Objet Commande , executer les requetes
     
        //3-Objet DataAdapteur , convertir le flux Relationnel en Objet
        SqlDataAdapter da = new SqlDataAdapter();

        protected string tableName;

        public void closeConnexion()
        {
            if(conn.State==ConnectionState.Open ||
               conn.State==ConnectionState.Connecting)
            {
                conn.Close();
            }
        }

        public DataTable executeSelect(string sql)
        {
            //1-Ouvre la Connexion
            openConnexion();
            //2-Donner la Connexion à l'objet Commande
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //3-Passer la requete à l'objet Commande
            cmd.CommandText = sql;
            //4-Affectation de l'objet Commande au DataAdapter
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            //5-Conversion du Flux relationnel en Flux Objet
            //puis stocker le resultat de la requete dans un 
            //DataTable d'un DataSet
            if (ds.Tables[tableName] != null) {
                //Est ce que le DataTable existe
                ds.Tables[tableName].Clear();
            }
            da.Fill(ds, tableName);

            closeConnexion();

            return ds.Tables[tableName];
        }

        public int executeUpdate(string sql,byte[] image=null)
        {
            int result = 0;
            //Executer les requetes de Mis a Jour
            //insert,update et le delete 
            //Resultat est un entier
            //insert le dernier id inserer
            //update ou delete nbreLigne Modifiée
            //1-Ouvre la Connexion
            openConnexion();
            //2-Donner la Connexion à l'objet Commande
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //3-Passer la requete à l'objet Commande
              cmd.CommandText = sql;
                if (image != null)
                {
                    cmd.Parameters.AddWithValue("@avatar", SqlDbType.Image).Value = image;
                } 
            if (sql.ToLower().StartsWith("insert")){  
                //requete insert
                  result = Convert.ToInt32(cmd.ExecuteScalar());

               }
                else{
                //requete delete ou update
                  result = cmd.ExecuteNonQuery();
                }
            //Ferme la Connexion
            closeConnexion();
            return result;
        }

        public void openConnexion()
        {
           if(conn.State==ConnectionState.Closed 
                || conn.State==ConnectionState.Broken)
            {
                //Chaine de Connexion
                 conn.ConnectionString = @"Data Source=DESKTOP-Q57ESL7\SQLEXPRESS01;Initial Catalog=gescom_ism_2021;Integrated Security=True;Pooling=False";
                //Ouvrir la connexion
                conn.Open();

            }
        }
    }
}
