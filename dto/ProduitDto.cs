using gestion_commercial.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.dto
{
    public class ProduitDto : IDto<ProduitDto, Produit>
    {

        private int id;
        private string libelle;
        private float prix;
        private int qteComd;
        private float mntStock;
        private int qteStock;
        public ProduitDto()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public float Prix { get => prix; set => prix = value; }
        public int QteComd { get => qteComd; set => qteComd = value; }
        public float MntStock { get => mntStock; set => mntStock = value; }
        public int QteStock { get => qteStock; set => qteStock = value; }

        public Produit dtoToModel()
        {
            return new Produit()
            {
               Id=this.Id,
               QteStock=this.QteStock
            };
        }

        public ProduitDto modelToDto(Produit model )
        {
            throw new NotImplementedException();
        }

        public void  calculMntStock()
        {
            MntStock = Prix * QteComd;
            
        }
    }
}
