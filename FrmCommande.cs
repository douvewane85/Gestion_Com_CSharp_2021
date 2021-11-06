using gestion_commercial.fabrique;
using gestion_commercial.models;
using gestion_commercial.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_commercial
{
    public partial class FrmCommande : Form
    {
        IService service = Fabrique.getInstanceService();
        public FrmCommande()
        {
            InitializeComponent();
        }


        private int idClient;
        private void txtCmdTel_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt = service.searchClientByNumero(txtbCmdTel.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                idClient = int.Parse(row.ItemArray[0].ToString());
                txtbCmdNomComplet.Text = row.ItemArray[1].ToString();
                txtbCmdAdresse.Text = row.ItemArray[2].ToString();
            }
            else
            {
                txtbCmdNomComplet.Clear();
                txtbCmdAdresse.Clear();
            }
        }

        private int idProduit;
        private void txtbCmdReference_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt = service.searchProduitByReference(txtbCmdReference.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                idProduit = int.Parse(row.ItemArray[0].ToString());
                txtbCmdLibelle.Text = row.ItemArray[1].ToString();
                txtbCmdQteStock.Text = row.ItemArray[2].ToString();
                txtbCmdPrix.Text = row.ItemArray[3].ToString();
            }
            else
            {
                txtbCmdLibelle.Clear();
                txtbCmdQteStock.Clear();
                txtbCmdPrix.Clear();
            }
        }
    }
}
