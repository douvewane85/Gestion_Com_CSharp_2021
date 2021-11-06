
namespace gestion_commercial
{
    partial class FrmProduits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.picBoxProduit = new System.Windows.Forms.PictureBox();
            this.cboSousCat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbQteStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbLibelle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvProduits = new System.Windows.Forms.DataGridView();
            this.IDProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SousCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.IDCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSousCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.picBoxProduit);
            this.groupBox1.Controls.Add(this.cboSousCat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.cboCategorie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbPrix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbQteStock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbLibelle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 511);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau Produit";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnUpload.Location = new System.Drawing.Point(139, 132);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 32);
            this.btnUpload.TabIndex = 15;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // picBoxProduit
            // 
            this.picBoxProduit.Image = global::gestion_commercial.Properties.Resources.avatar_produit1;
            this.picBoxProduit.Location = new System.Drawing.Point(111, 25);
            this.picBoxProduit.Name = "picBoxProduit";
            this.picBoxProduit.Size = new System.Drawing.Size(136, 101);
            this.picBoxProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProduit.TabIndex = 14;
            this.picBoxProduit.TabStop = false;
            // 
            // cboSousCat
            // 
            this.cboSousCat.FormattingEnabled = true;
            this.cboSousCat.Location = new System.Drawing.Point(28, 416);
            this.cboSousCat.Name = "cboSousCat";
            this.cboSousCat.Size = new System.Drawing.Size(295, 28);
            this.cboSousCat.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sous Categorie";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(273, 462);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 32);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(192, 462);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 32);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(122)))), ((int)(((byte)(139)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(111, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAnnuler.Location = new System.Drawing.Point(28, 462);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 32);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboCategorie
            // 
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(31, 359);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(291, 28);
            this.cboCategorie.TabIndex = 7;
            this.cboCategorie.SelectedIndexChanged += new System.EventHandler(this.cboCategorie_SelectedIndexChanged);
            this.cboCategorie.SelectionChangeCommitted += new System.EventHandler(this.cboCategorie_SelectionChangeCommitted);
            this.cboCategorie.ValueMemberChanged += new System.EventHandler(this.cboCategorie_ValueMemberChanged);
            this.cboCategorie.SelectedValueChanged += new System.EventHandler(this.cboCategorie_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix";
            // 
            // txtbPrix
            // 
            this.txtbPrix.Location = new System.Drawing.Point(34, 300);
            this.txtbPrix.Name = "txtbPrix";
            this.txtbPrix.Size = new System.Drawing.Size(289, 26);
            this.txtbPrix.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock";
            // 
            // txtbQteStock
            // 
            this.txtbQteStock.Location = new System.Drawing.Point(34, 242);
            this.txtbQteStock.Name = "txtbQteStock";
            this.txtbQteStock.Size = new System.Drawing.Size(289, 26);
            this.txtbQteStock.TabIndex = 2;
            this.txtbQteStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbQteStock_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libelle";
            // 
            // txtbLibelle
            // 
            this.txtbLibelle.Location = new System.Drawing.Point(33, 183);
            this.txtbLibelle.Name = "txtbLibelle";
            this.txtbLibelle.Size = new System.Drawing.Size(289, 26);
            this.txtbLibelle.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dtgvProduits);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(410, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 510);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des Produits";
            // 
            // dtgvProduits
            // 
            this.dtgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduit,
            this.Reference,
            this.Nom_Prenom,
            this.Login,
            this.Role,
            this.SousCat,
            this.Avatar,
            this.IDCategorie,
            this.IDSousCat});
            this.dtgvProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProduits.Location = new System.Drawing.Point(3, 22);
            this.dtgvProduits.Name = "dtgvProduits";
            this.dtgvProduits.Size = new System.Drawing.Size(743, 485);
            this.dtgvProduits.TabIndex = 0;
            this.dtgvProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUtilisateurs_CellContentClick);
            // 
            // IDProduit
            // 
            this.IDProduit.DataPropertyName = "id";
            this.IDProduit.HeaderText = "IDProduit";
            this.IDProduit.Name = "IDProduit";
            this.IDProduit.Visible = false;
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "reference";
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            // 
            // Nom_Prenom
            // 
            this.Nom_Prenom.DataPropertyName = "libelle_produit";
            this.Nom_Prenom.HeaderText = "Libelle";
            this.Nom_Prenom.Name = "Nom_Prenom";
            this.Nom_Prenom.Width = 150;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "stock";
            this.Login.HeaderText = "Stock";
            this.Login.Name = "Login";
            this.Login.Width = 75;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "prix";
            this.Role.HeaderText = "Prix";
            this.Role.Name = "Role";
            this.Role.Width = 75;
            // 
            // SousCat
            // 
            this.SousCat.DataPropertyName = "libelle_sous_cat";
            this.SousCat.HeaderText = "Sous Categorie";
            this.SousCat.Name = "SousCat";
            this.SousCat.Width = 150;
            // 
            // Avatar
            // 
            this.Avatar.DataPropertyName = "image";
            this.Avatar.HeaderText = "Image";
            this.Avatar.Image = global::gestion_commercial.Properties.Resources.avatar_produit;
            this.Avatar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Avatar.Name = "Avatar";
            this.Avatar.Width = 150;
            // 
            // IDCategorie
            // 
            this.IDCategorie.DataPropertyName = "id_categorie";
            this.IDCategorie.HeaderText = "IDCategorie";
            this.IDCategorie.Name = "IDCategorie";
            this.IDCategorie.Visible = false;
            // 
            // IDSousCat
            // 
            this.IDSousCat.DataPropertyName = "id_sous_categorie";
            this.IDSousCat.HeaderText = "IDSousCat";
            this.IDSousCat.Name = "IDSousCat";
            this.IDSousCat.Visible = false;
            // 
            // FrmProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProduits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduits";
            this.Load += new System.EventHandler(this.FrmProduits_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbQteStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbLibelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvProduits;
        private System.Windows.Forms.ComboBox cboSousCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox picBoxProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn SousCat;
        private System.Windows.Forms.DataGridViewImageColumn Avatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSousCat;
    }
}