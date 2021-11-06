using gestion_commercial.dto;
using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public class DaoProduit : Database, IProduitDao
    {
        public DaoProduit()
        {
            tableName = "produit";
        }

        public int delete(int id)
        {
            string sql = string.Format("delete from produit where id={0} ", id);
             return executeUpdate(sql);
        }

        public DataTable findAll()
        {
            string sql = "select p.id,p.libelle as libelle_produit,stock,prix,reference,image," +
                      " id_sous_categorie,c.libelle as libelle_sous_cat,id_categorie " +
                         " from produit p,categorie c" +
                         " where p.id_sous_categorie=c.id ";
            return executeSelect(sql);
        }

        public Produit findById(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findProduitByReference(string reference)
        {
            string sql = string.Format("select id,libelle,stock,prix from produit" +
                                      " where reference like '{0}'", reference);
            return executeSelect(sql);
        }

        public int insert(Produit produit)
        {
            string sql = string.Format("insert into produit(libelle,stock,prix,reference,id_sous_categorie,image)" +
                        " values('{0}',{1},{2},'{3}',{4},@avatar)",
                        produit.Libelle, produit.QteStock,
                        produit.Prix, produit.Reference,
                        produit.SousCategorie.Id);

            return executeUpdate(sql,produit.Image);
        }

        public int update(Produit produit)
        {
            string sql = string.Format("update produit set libelle='{0}'," +
                            " stock={1},prix={2}, " +
                            " id_sous_categorie={3},image=@avatar where id={4}", 
                                produit.Libelle, produit.QteStock,
                                produit.Prix,
                                produit.SousCategorie.Id,
                                produit.Id);
            return executeUpdate(sql, produit.Image);
        }
        public int update(ProduitDto produit)
        {
            string sql = string.Format("update produit set stock={0} where id={1}",
                                produit.QteStock,produit.Id);
                            
            return executeUpdate(sql);
        }
    }
}
