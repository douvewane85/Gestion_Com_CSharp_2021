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
   public  interface IProduitDao: IDAO<Produit>
    {
        DataTable findProduitByReference(string reference);
       int update(ProduitDto produit);
    }
}
