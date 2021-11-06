using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dao
{
    public interface ICommandeDao: IDAO<Commande>
    {
        DataTable findAllCommandes(DateTime date = default(DateTime));
        DataTable findAllCommandes(DateTime date, Statut etat);
        DataTable findAllCommandes(DateTime date, Statut etat, Client client);
    }
}
