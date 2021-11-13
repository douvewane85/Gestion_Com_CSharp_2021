using gestion_commercial.models;
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
    public partial class FrmMenu : Form
    {
        private User userConnect;
        public FrmMenu()
        {
            InitializeComponent();
        }
        public FrmMenu(User user)
        {
            InitializeComponent();
            userConnect = user;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            loadFrmCommande();

        }

        private void lblUtilisateur_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmUser frm = new FrmUser();
            frm.MdiParent = this;
            frm.Show();
        }
        private void clearChildren()
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void lblProduit_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmProduits frm = new FrmProduits();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lblNouvelleCommande_Click(object sender, EventArgs e)
        {
            loadFrmCommande();
        }

        private void loadFrmCommande()
        {
            clearChildren();
            FrmCommande frm = new FrmCommande();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lblListeCmde_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmListeCommande frm = new FrmListeCommande();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
