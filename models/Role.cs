using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.models
{
   public  class Role
    {
        private int id;
        private string libelle;

        public Role()
        {
        }

        public Role(string libelle)
        {
            this.libelle = libelle;
        }

        public Role(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
