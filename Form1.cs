using gestion_commercial.dao;
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
    public partial class Form1 : Form
    {

        private IService service = Fabrique.getInstanceService();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtbLogin.Text.Trim();
            string password = txtbPassword.Text;
            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login ou Mot de Passe Obligatoire",
                    "Erreur", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
              User user=  service.searchUserLoginAndPassword(login,password);
                if (user == null) {
                    lblError.Visible = true;
                }
                else
                {
                    //Redirection vers la page Accueil
                    FrmMenu frm = new FrmMenu(user);
                    frm.Show();
                    this.Hide();
                }
            }
            

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txtbLogin.Clear();
            txtbPassword.Clear();
        }
    }
}
