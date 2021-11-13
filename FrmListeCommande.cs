using gestion_commercial.entity;
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
    public partial class FrmListeCommande : Form
    {
        ServiceEF service = new ServiceEF();
       
        public void loadDataGridView(List<commande> cmdes)
        {
            dtgvCommande.AutoGenerateColumns = false;
            dtgvCommande.DataSource = cmdes;
        }
        public FrmListeCommande()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListeCommande_Load(object sender, EventArgs e)
        {
            loadDataGridView(service.showAllCommandes());
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Chaine en Enumeration
            Statut statut = (Statut)Enum.Parse(typeof(Statut), comboBox1.SelectedItem.ToString(), true);
            loadDataGridView(service.showAllCommandes(statut));
          
        }

        private void txtbTelClient_KeyUp(object sender, KeyEventArgs e)
        {
            string tel = txtbTelClient.Text.Trim();
            List<commande> cmdesClient = service.showAllCommandes(tel);
            if(cmdesClient.Count > 0)
            {
                loadDataGridView(cmdesClient);

            }
            else
            {
                dtgvCommande.DataSource=null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Statut statut = (Statut)Enum.Parse(typeof(Statut), comboBox1.SelectedItem.ToString(), true);
            string tel = txtbTelClient.Text.Trim();
            loadDataGridView(service.showAllCommandes(statut, tel));
        }

        private void dtgvCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private int idCmde;
        private void dtgvCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvCommande.Rows.Count )
            {

                DataGridViewRow row = dtgvCommande.Rows[e.RowIndex];
                row.Selected = true;
                idCmde = int.Parse(row.Cells[0].Value.ToString());
                commande cmde = service.showCommandeById(idCmde);
                MessageBox.Show("" + idCmde);
                //Données  Client
                txtbNomPrenom.Text = cmde.utilisateur.nom_complet;
                txtbTel.Text = cmde.utilisateur.telephone;
                txtbAdresse.Text = cmde.utilisateur.adresse;
                //Données  Commande
                txtbDateCom.Text = cmde.date_cmde.ToString();
                txtbMnt.Text = cmde.total.ToString();
                dtgDetailsProduits.DataSource = cmde.details.ToList();
                //
               // cboStatut.SelectedItem = cmde.statut;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            commande cmd = new commande()
            {
                Id=idCmde,
                statut=cboStatut.SelectedItem.ToString()
            };
            service.updateCommande(cmd);

        }
    }
}
