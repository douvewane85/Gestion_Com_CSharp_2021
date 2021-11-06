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
    public partial class FrmProduits : Form
    {
        private readonly string IMG_DEFAULT = @"C:\Users\USER\source\repos\gestion_commercial_demon\Resources\avatar-produit.jpg";
        IService service = Fabrique.getInstanceService();
        public FrmProduits()
        {
            InitializeComponent();
        }

        private int idProduit;
        private void dtgvUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvProduits.Rows.Count - 1)
            {
                FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.UPDEL);
                DataGridViewRow row = dtgvProduits.Rows[e.RowIndex];
                row.Selected = true;
                idProduit = int.Parse(row.Cells[0].Value.ToString());
                txtbLibelle.Text = row.Cells[2].Value.ToString();
                txtbQteStock.Text = row.Cells[3].Value.ToString();
                txtbPrix.Text = row.Cells[4].Value.ToString();

                int idCat = int.Parse(row.Cells[7].Value.ToString());
                cboCategorie.SelectedValue = idCat;
                loadComboxSousCategorie(idCat);
                int idSousCat = int.Parse(row.Cells[8].Value.ToString());
                cboSousCat.SelectedValue = idSousCat;

                if (row.Cells[6].Value != DBNull.Value)
                {
                    picBoxProduit.Image = MyImage.convertByteToImage((byte[])row.Cells[6].Value);
                }
                 
                
                

            }
        }

        private void FrmProduits_Load(object sender, EventArgs e)
        {
            loadComboxCategorie();
            int idCat=int.Parse(cboCategorie.SelectedValue.ToString());
            loadComboxSousCategorie(idCat);
            loadDataGridView();
            FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
        }

        private void loadComboxCategorie()
        {
            cboCategorie.DataSource = service.showAllCategories();
            cboCategorie.DisplayMember = "libelle";
            cboCategorie.ValueMember = "id";
        }

        private void loadComboxSousCategorie(int idCat)
        {
            cboSousCat.DataSource = null;
            cboSousCat.DataSource = service.showAllSousCategories(idCat);
            cboSousCat.DisplayMember = "libelle";
            cboSousCat.ValueMember = "id";
        }

        private void cboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCategorie_SelectedValueChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cboCategorie.SelectedValue.ToString());
           
        }

        private void cboCategorie_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void cboCategorie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idCat = int.Parse(cboCategorie.SelectedValue.ToString());
             loadComboxSousCategorie(idCat);
        }

        private string fileName;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.jpeg Files (*.jpeg)|*.jpeg|.jpg Files (*.jpg)|*.jpg|.png Files (*.png)|*.png";

            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK){
                picBoxProduit.Image = Image.FromFile(dialog.FileName);

                fileName = dialog.FileName;
               
            }
        }

        private void clearFields()
        {
            //Effacer les Champs de Text
            txtbLibelle.Clear();
            txtbPrix.Clear();
            txtbQteStock.Clear();
            //Reinitialiser les ComboBox
            cboCategorie.SelectedIndex = 0;
            int idCat=int.Parse(cboCategorie.SelectedValue.ToString());
            loadComboxSousCategorie(idCat);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearFields();
            FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtbLibelle.Text)
                || string.IsNullOrEmpty(txtbPrix.Text)
                || string.IsNullOrEmpty(txtbQteStock.Text)
                //|| string.IsNullOrEmpty(fileName)
                
             )
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Convertir l'image en byte[]
                if (string.IsNullOrEmpty(fileName)) fileName = IMG_DEFAULT;
                byte[] image = MyImage.convertImageToByte(fileName);
                Produit produit = new Produit()
                {
                    Libelle = txtbLibelle.Text,
                    Prix = float.Parse(txtbPrix.Text),
                    QteStock = int.Parse(txtbQteStock.Text),
                    Image = image,
                   Reference=Produit.getReference()
                };

                SousCategorie sousCat = new SousCategorie()
                {
                    Id = int.Parse(cboSousCat.SelectedValue.ToString())
                };

                produit.SousCategorie = sousCat;
                service.addProduit(produit); 
                
                    MessageBox.Show("Produit  Ajoutée avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                    clearFields();
                    FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
               
            }
        }

       private void loadDataGridView()
        {
            dtgvProduits.AutoGenerateColumns = false;
            dtgvProduits.DataSource = service.showAllProduits();
        }

        private void txtbQteStock_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbLibelle.Text)
                || string.IsNullOrEmpty(txtbPrix.Text)
                || string.IsNullOrEmpty(txtbQteStock.Text)
             //|| string.IsNullOrEmpty(fileName)

             )
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Convertir l'image en byte[]
                if (string.IsNullOrEmpty(fileName)) fileName = IMG_DEFAULT;
                byte[] image = MyImage.convertImageToByte(fileName);
                Produit produit = new Produit()
                {
                    Libelle = txtbLibelle.Text,
                    Prix = float.Parse(txtbPrix.Text),
                    QteStock = int.Parse(txtbQteStock.Text),
                    Image = image,
                    Id=idProduit
                };

                SousCategorie sousCat = new SousCategorie()
                {
                    Id = int.Parse(cboSousCat.SelectedValue.ToString())
                };

                produit.SousCategorie = sousCat;
                service.updateProduit(produit);

                MessageBox.Show("Produit  Ajoutée avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGridView();
                clearFields();
                FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);

            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Veuillez confirmer la suppression!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                if (service.deleteProduit(idProduit) != 0)
                {
                    MessageBox.Show("Produit supprimée avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                    clearFields();
                    FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
                }
            }
        }
    }
}
