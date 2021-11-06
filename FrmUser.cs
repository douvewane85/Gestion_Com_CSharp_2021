using gestion_commercial.fabrique;
using gestion_commercial.models;
using gestion_commercial.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_commercial.utils;

namespace gestion_commercial
{
    public enum Action { ADD, UPDATE, DELETE, UPDEL };
    public partial class FrmUser : Form
    {
     
        IService service = Fabrique.getInstanceService();
        public FrmUser()
        {
            InitializeComponent();
        }

        private void loadComboBox(){
            cboRole.DataSource = service.showAllRole();
            cboRole.DisplayMember = "libelle";
            cboRole.ValueMember = "id";
        }

        private void loadDataGridView()
        {
            dtgvUtilisateurs.AutoGenerateColumns = false;
            dtgvUtilisateurs.DataSource = service.showAllUsers();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadDataGridView();
            FormUtils.desactiveFied(btnAdd,btnUp,btnDel,Action.ADD);

        }

       

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearFields();
            FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
        }
        
        private void clearFields()
        {
            txtbLogin.Clear();
            txtbNomPrenom.Clear();
            txtbPassword.Clear();
            cboRole.SelectedIndex = 0;
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //byte[] images = convertImageToByte(this.fileName);

            String nomComplet = txtbNomPrenom.Text.Trim();
            String login = txtbLogin.Text.Trim();
            String password = txtbPassword.Text;
            int idRole = int.Parse(cboRole.SelectedValue.ToString());
            if(string.IsNullOrEmpty(nomComplet)|| string.IsNullOrEmpty(login)
                || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Champs Obligatoires", "Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                User user = new User()
                {
                  NomComplet=nomComplet,
                  Login=login,
                  Password=password,
                  //Avatar = images,
                };
                Role role = new Role()
                {
                    Id = idRole
                };
                user.Role = role;
                if (service.addUser(user) != 0)
                {
                    MessageBox.Show("Utilisateur insérée avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                    clearFields();
                }
            }

        }
        private int id;
        private void dtgvUtilisateurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.RowIndex < dtgvUtilisateurs.Rows.Count-1) {

                FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.UPDEL);
                 DataGridViewRow row = dtgvUtilisateurs.Rows[e.RowIndex];
                 row.Selected = true;
                 id = int.Parse(row.Cells[0].Value.ToString());
                 txtbLogin.Text = row.Cells[2].Value.ToString();
                 txtbNomPrenom.Text = row.Cells[1].Value.ToString();
              
                
            }
           
            
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
           // byte[] images = convertImageToByte(this.fileName);
            String nomComplet = txtbNomPrenom.Text.Trim();
            String login = txtbLogin.Text.Trim();
            String password = txtbPassword.Text;
            int idRole = int.Parse(cboRole.SelectedValue.ToString());
            if (string.IsNullOrEmpty(nomComplet) || string.IsNullOrEmpty(login)
                || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User()
                {
                    NomComplet = nomComplet,
                    Login = login,
                    Password = password,
                    Id=id,
                 //   Avatar=images
                    
                };
                Role role = new Role()
                {
                    Id = idRole
                };
                user.Role = role;
                if (service.updateUser(user) != 0)
                {
                    MessageBox.Show("Utilisateur Modifiée avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                    clearFields();
                    FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result=  MessageBox.Show("Veuillez confirmer la suppression!", "Message",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) ;
            if (result == DialogResult.Yes)
            {
               if(service.deleteUser(id) != 0)
                {
                    MessageBox.Show("Utilisateur supprimée avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                    clearFields();
                    FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
                }
            }
        }
        public static byte[] convertImageToByte(string fileName)
        {
            using (Image image = Image.FromFile(fileName))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }

        }

        public static Image convertByteToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }

        private string fileName;

        private void picBoxAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "*.jpg files (*.jpg)|*jpg|.jpeg files (*.jpeg)|*jpeg|.png files (*.png)|*png";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picBoxAvatar.Image = Image.FromFile(dialog.FileName);
                    this.fileName = dialog.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
