
namespace gestion_commercial
{
    partial class FrmUser
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
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNomPrenom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvUtilisateurs = new System.Windows.Forms.DataGridView();
            this.IDUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUtilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.picBoxAvatar);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.cboRole);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbNomPrenom);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvel Utilisateur";
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.Image = global::gestion_commercial.Properties.Resources.avatar;
            this.picBoxAvatar.Location = new System.Drawing.Point(117, 39);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(108, 106);
            this.picBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAvatar.TabIndex = 12;
            this.picBoxAvatar.TabStop = false;
            this.picBoxAvatar.Click += new System.EventHandler(this.picBoxAvatar_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(279, 424);
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
            this.btnUp.Location = new System.Drawing.Point(198, 424);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 32);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(122)))), ((int)(((byte)(139)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(117, 424);
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
            this.btnAnnuler.Location = new System.Drawing.Point(36, 424);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 32);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(34, 381);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(409, 28);
            this.cboRole.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(36, 323);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(407, 26);
            this.txtbPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // txtbLogin
            // 
            this.txtbLogin.Location = new System.Drawing.Point(34, 266);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(409, 26);
            this.txtbLogin.TabIndex = 2;
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
            this.txtbNomPrenom.Size = new System.Drawing.Size(410, 26);
            this.txtbNomPrenom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dtgvUtilisateurs);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(576, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 474);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des Utilisateurs";
            // 
            // dtgvUtilisateurs
            // 
            this.dtgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUtilisateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUser,
            this.Nom_Prenom,
            this.Login,
            this.Role});
            this.dtgvUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvUtilisateurs.Location = new System.Drawing.Point(3, 22);
            this.dtgvUtilisateurs.Name = "dtgvUtilisateurs";
            this.dtgvUtilisateurs.Size = new System.Drawing.Size(480, 449);
            this.dtgvUtilisateurs.TabIndex = 0;
            this.dtgvUtilisateurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUtilisateurs_CellClick);
            // 
            // IDUser
            // 
            this.IDUser.DataPropertyName = "id";
            this.IDUser.HeaderText = "ID";
            this.IDUser.Name = "IDUser";
            this.IDUser.Visible = false;
            // 
            // Nom_Prenom
            // 
            this.Nom_Prenom.DataPropertyName = "nom_complet";
            this.Nom_Prenom.HeaderText = "Nom et Prenom";
            this.Nom_Prenom.Name = "Nom_Prenom";
            this.Nom_Prenom.Width = 150;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // Role
            // 
            this.Role.DataPropertyName = "libelle";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.Width = 150;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1142, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUtilisateurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNomPrenom;
        private System.Windows.Forms.DataGridView dtgvUtilisateurs;
        private System.Windows.Forms.PictureBox picBoxAvatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}