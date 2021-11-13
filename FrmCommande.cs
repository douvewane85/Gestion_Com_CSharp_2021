using gestion_commercial.dto;
using gestion_commercial.fabrique;
using gestion_commercial.models;
using gestion_commercial.services;
using gestion_commercial.utils;
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
            //Vider la Liste de Produit et DataGridView
            dtgvProduitsCmdes.DataSource = null;
            produtsCmdes.Clear();

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
                idClient = 0;
            }
        }

        private int idProduit;
        private void txtbCmdReference_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt = service.searchProduitByReference(txtbCmdReference.Text.Trim());
            txtbTotalCmde.Clear();
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
                idProduit = 0;
            }
        }

        private List<ProduitDto> produtsCmdes = new List<ProduitDto>();
        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            ProduitDto produit = new ProduitDto()
            {
                Id=idProduit,
                Libelle=txtbCmdLibelle.Text,
                Prix= float.Parse(txtbCmdPrix.Text),
                QteComd= int.Parse(txtCmdQteCom.Text),
                QteStock= int.Parse(txtbCmdQteStock.Text)
        };
            produit.calculMntStock();

            produtsCmdes.Add(produit);
            txtbTotalCmde.Text = string.Format("{0}", calculMntTotal());

            dtgvProduitsCmdes.DataSource = null;
            dtgvProduitsCmdes.DataSource = produtsCmdes;
            FormUtils.clearFieds(grpBoxProduit);
            btnAddDetailsCmd.Enabled = false;


        }

        private void txtCmdQteCom_KeyUp(object sender, KeyEventArgs e)
        {
            int qteComd = int.Parse(txtCmdQteCom.Text);
            int qteStock = int.Parse(txtbCmdQteStock.Text);
            if (qteComd <= qteStock)
            {

                float prix = float.Parse(txtbCmdPrix.Text);
                txtMntCmdProduit.Text = string.Format("{0}",qteComd * prix);
                btnAddDetailsCmd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Qte Commande Indisponible", 
                                    "Information", 
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtCmdQteCom.Clear();
                txtMntCmdProduit.Clear();
                btnAddDetailsCmd.Enabled = false;
            }
        }

            private float calculMntTotal()
            {
                 float total = 0;
                foreach(var produit in produtsCmdes)
                {
                    total += produit.MntStock;
                }
               return total;
            }

        private void btnSaveCommande_Click(object sender, EventArgs e)
        {
            if (idClient == 0)
            {
                MessageBox.Show("Veuillez rechercher un Client",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtbCmdTel.Focus();
            }
            else
            {
                if (produtsCmdes.Count == 0)
                {
                    MessageBox.Show("Veuillez Ajouter un Produit dans la Commande",
                                   "Information",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    txtbCmdReference.Focus();
                }
                else
                {
                    Commande cmd = new Commande()
                    {
                        Total= calculMntTotal()
                    };
                    Client client = new Client()
                    {
                        Id = idClient
                    };
                    service.addCommande(cmd, produtsCmdes, client);
                    MessageBox.Show("Commande ajoutée avec success",
                                  "Information",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                     dtgvProduitsCmdes.DataSource = null;
                     produtsCmdes.Clear();
                     txtbTotalCmde.Clear();
                }
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

        }

        private void FrmCommande_Load(object sender, EventArgs e)
        {

        }
    }
}
