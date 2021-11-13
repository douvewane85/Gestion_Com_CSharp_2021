
namespace gestion_commercial
{
    partial class FrmCommande
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
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbAdresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTelephone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNomPrenom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveCommande = new System.Windows.Forms.Button();
            this.txtbTotalCmde = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvProduitsCmdes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte_Com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.grpBoxProduit = new System.Windows.Forms.GroupBox();
            this.btnAddDetailsCmd = new System.Windows.Forms.Button();
            this.txtMntCmdProduit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbCmdPrix = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCmdQteCom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbCmdQteStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbCmdLibelle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbCmdReference = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbCmdAdresse = new System.Windows.Forms.TextBox();
            this.txtbCmdNomComplet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCmdTel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduitsCmdes)).BeginInit();
            this.grpBoxProduit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnUploadImage);
            this.groupBox1.Controls.Add(this.picAvatar);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbAdresse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbTelephone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbNomPrenom);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 543);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau Client";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnUploadImage.Location = new System.Drawing.Point(128, 143);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(100, 32);
            this.btnUploadImage.TabIndex = 13;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::gestion_commercial.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(106, 25);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(153, 112);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 12;
            this.picAvatar.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(122)))), ((int)(((byte)(139)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(250, 500);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAnnuler.Location = new System.Drawing.Point(34, 499);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 32);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adresse";
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(36, 330);
            this.txtbAdresse.Multiline = true;
            this.txtbAdresse.Name = "txtbAdresse";
            this.txtbAdresse.Size = new System.Drawing.Size(289, 158);
            this.txtbAdresse.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telephone";
            // 
            // txtbTelephone
            // 
            this.txtbTelephone.Location = new System.Drawing.Point(34, 262);
            this.txtbTelephone.Name = "txtbTelephone";
            this.txtbTelephone.Size = new System.Drawing.Size(289, 26);
            this.txtbTelephone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom et Prenom";
            // 
            // txtbNomPrenom
            // 
            this.txtbNomPrenom.Location = new System.Drawing.Point(33, 202);
            this.txtbNomPrenom.Name = "txtbNomPrenom";
            this.txtbNomPrenom.Size = new System.Drawing.Size(289, 26);
            this.txtbNomPrenom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnSaveCommande);
            this.groupBox2.Controls.Add(this.txtbTotalCmde);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.grpBoxProduit);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(396, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 543);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faire une  Commande";
            // 
            // btnSaveCommande
            // 
            this.btnSaveCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCommande.ForeColor = System.Drawing.Color.White;
            this.btnSaveCommande.Location = new System.Drawing.Point(546, 487);
            this.btnSaveCommande.Name = "btnSaveCommande";
            this.btnSaveCommande.Size = new System.Drawing.Size(117, 32);
            this.btnSaveCommande.TabIndex = 14;
            this.btnSaveCommande.Text = "Enregistrer";
            this.btnSaveCommande.UseVisualStyleBackColor = false;
            this.btnSaveCommande.Click += new System.EventHandler(this.btnSaveCommande_Click);
            // 
            // txtbTotalCmde
            // 
            this.txtbTotalCmde.Enabled = false;
            this.txtbTotalCmde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTotalCmde.ForeColor = System.Drawing.Color.Red;
            this.txtbTotalCmde.Location = new System.Drawing.Point(97, 492);
            this.txtbTotalCmde.Name = "txtbTotalCmde";
            this.txtbTotalCmde.Size = new System.Drawing.Size(149, 29);
            this.txtbTotalCmde.TabIndex = 26;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvProduitsCmdes);
            this.groupBox5.Location = new System.Drawing.Point(19, 291);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(644, 183);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Produits Commandés";
            // 
            // dtgvProduitsCmdes
            // 
            this.dtgvProduitsCmdes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduitsCmdes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Libelle,
            this.Prix,
            this.Qte_Com,
            this.Montant});
            this.dtgvProduitsCmdes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProduitsCmdes.Location = new System.Drawing.Point(3, 22);
            this.dtgvProduitsCmdes.Name = "dtgvProduitsCmdes";
            this.dtgvProduitsCmdes.Size = new System.Drawing.Size(638, 158);
            this.dtgvProduitsCmdes.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Libelle
            // 
            this.Libelle.DataPropertyName = "Libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "Prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // Qte_Com
            // 
            this.Qte_Com.DataPropertyName = "QteComd";
            this.Qte_Com.HeaderText = "Quantité Commandée";
            this.Qte_Com.Name = "Qte_Com";
            this.Qte_Com.Width = 150;
            // 
            // Montant
            // 
            this.Montant.DataPropertyName = "MntStock";
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            this.Montant.Width = 140;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total";
            // 
            // grpBoxProduit
            // 
            this.grpBoxProduit.Controls.Add(this.btnAddDetailsCmd);
            this.grpBoxProduit.Controls.Add(this.txtMntCmdProduit);
            this.grpBoxProduit.Controls.Add(this.label12);
            this.grpBoxProduit.Controls.Add(this.txtbCmdPrix);
            this.grpBoxProduit.Controls.Add(this.label11);
            this.grpBoxProduit.Controls.Add(this.txtCmdQteCom);
            this.grpBoxProduit.Controls.Add(this.label10);
            this.grpBoxProduit.Controls.Add(this.txtbCmdQteStock);
            this.grpBoxProduit.Controls.Add(this.label7);
            this.grpBoxProduit.Controls.Add(this.label8);
            this.grpBoxProduit.Controls.Add(this.txtbCmdLibelle);
            this.grpBoxProduit.Controls.Add(this.label9);
            this.grpBoxProduit.Controls.Add(this.txtbCmdReference);
            this.grpBoxProduit.Location = new System.Drawing.Point(22, 140);
            this.grpBoxProduit.Name = "grpBoxProduit";
            this.grpBoxProduit.Size = new System.Drawing.Size(644, 147);
            this.grpBoxProduit.TabIndex = 20;
            this.grpBoxProduit.TabStop = false;
            this.grpBoxProduit.Text = "Données Produit";
            // 
            // btnAddDetailsCmd
            // 
            this.btnAddDetailsCmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(122)))), ((int)(((byte)(139)))));
            this.btnAddDetailsCmd.Enabled = false;
            this.btnAddDetailsCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetailsCmd.ForeColor = System.Drawing.Color.White;
            this.btnAddDetailsCmd.Location = new System.Drawing.Point(560, 110);
            this.btnAddDetailsCmd.Name = "btnAddDetailsCmd";
            this.btnAddDetailsCmd.Size = new System.Drawing.Size(75, 30);
            this.btnAddDetailsCmd.TabIndex = 14;
            this.btnAddDetailsCmd.Text = "ADD";
            this.btnAddDetailsCmd.UseVisualStyleBackColor = false;
            this.btnAddDetailsCmd.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // txtMntCmdProduit
            // 
            this.txtMntCmdProduit.Enabled = false;
            this.txtMntCmdProduit.Location = new System.Drawing.Point(477, 61);
            this.txtMntCmdProduit.Name = "txtMntCmdProduit";
            this.txtMntCmdProduit.Size = new System.Drawing.Size(158, 26);
            this.txtMntCmdProduit.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(473, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Montant";
            // 
            // txtbCmdPrix
            // 
            this.txtbCmdPrix.Enabled = false;
            this.txtbCmdPrix.Location = new System.Drawing.Point(355, 64);
            this.txtbCmdPrix.Name = "txtbCmdPrix";
            this.txtbCmdPrix.Size = new System.Drawing.Size(80, 26);
            this.txtbCmdPrix.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Qte Commandée";
            // 
            // txtCmdQteCom
            // 
            this.txtCmdQteCom.Location = new System.Drawing.Point(355, 98);
            this.txtCmdQteCom.Name = "txtCmdQteCom";
            this.txtCmdQteCom.Size = new System.Drawing.Size(80, 26);
            this.txtCmdQteCom.TabIndex = 20;
            this.txtCmdQteCom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCmdQteCom_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Prix";
            // 
            // txtbCmdQteStock
            // 
            this.txtbCmdQteStock.Enabled = false;
            this.txtbCmdQteStock.Location = new System.Drawing.Point(105, 98);
            this.txtbCmdQteStock.Name = "txtbCmdQteStock";
            this.txtbCmdQteStock.Size = new System.Drawing.Size(107, 26);
            this.txtbCmdQteStock.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Qte Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Libelle";
            // 
            // txtbCmdLibelle
            // 
            this.txtbCmdLibelle.Enabled = false;
            this.txtbCmdLibelle.Location = new System.Drawing.Point(105, 67);
            this.txtbCmdLibelle.Name = "txtbCmdLibelle";
            this.txtbCmdLibelle.Size = new System.Drawing.Size(107, 26);
            this.txtbCmdLibelle.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Reference";
            // 
            // txtbCmdReference
            // 
            this.txtbCmdReference.Location = new System.Drawing.Point(162, 27);
            this.txtbCmdReference.Name = "txtbCmdReference";
            this.txtbCmdReference.Size = new System.Drawing.Size(264, 26);
            this.txtbCmdReference.TabIndex = 14;
            this.txtbCmdReference.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbCmdReference_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtbCmdAdresse);
            this.groupBox3.Controls.Add(this.txtbCmdNomComplet);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtbCmdTel);
            this.groupBox3.Location = new System.Drawing.Point(19, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 110);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Données Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nom et Prenom";
            // 
            // txtbCmdAdresse
            // 
            this.txtbCmdAdresse.Enabled = false;
            this.txtbCmdAdresse.Location = new System.Drawing.Point(400, 45);
            this.txtbCmdAdresse.Multiline = true;
            this.txtbCmdAdresse.Name = "txtbCmdAdresse";
            this.txtbCmdAdresse.Size = new System.Drawing.Size(228, 55);
            this.txtbCmdAdresse.TabIndex = 14;
            // 
            // txtbCmdNomComplet
            // 
            this.txtbCmdNomComplet.Enabled = false;
            this.txtbCmdNomComplet.Location = new System.Drawing.Point(162, 62);
            this.txtbCmdNomComplet.Name = "txtbCmdNomComplet";
            this.txtbCmdNomComplet.Size = new System.Drawing.Size(148, 26);
            this.txtbCmdNomComplet.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telephone";
            // 
            // txtbCmdTel
            // 
            this.txtbCmdTel.Location = new System.Drawing.Point(162, 27);
            this.txtbCmdTel.Name = "txtbCmdTel";
            this.txtbCmdTel.Size = new System.Drawing.Size(148, 26);
            this.txtbCmdTel.TabIndex = 14;
            this.txtbCmdTel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCmdTel_KeyUp);
            // 
            // FrmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCommande";
            this.Load += new System.EventHandler(this.FrmCommande_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduitsCmdes)).EndInit();
            this.grpBoxProduit.ResumeLayout(false);
            this.grpBoxProduit.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbAdresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNomPrenom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCmdTel;
        private System.Windows.Forms.TextBox txtbTotalCmde;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvProduitsCmdes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpBoxProduit;
        private System.Windows.Forms.Button btnAddDetailsCmd;
        private System.Windows.Forms.TextBox txtMntCmdProduit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbCmdPrix;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCmdQteCom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbCmdQteStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbCmdLibelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbCmdReference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbCmdAdresse;
        private System.Windows.Forms.TextBox txtbCmdNomComplet;
        private System.Windows.Forms.Button btnSaveCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte_Com;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
    }
}