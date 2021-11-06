
namespace gestion_commercial
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnAnnuler;
            System.Windows.Forms.Button btnConnexion;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            btnAnnuler = new System.Windows.Forms.Button();
            btnConnexion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(btnConnexion);
            this.panel1.Controls.Add(btnAnnuler);
            this.panel1.Controls.Add(this.txtbPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 209);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txtbLogin
            // 
            this.txtbLogin.Location = new System.Drawing.Point(200, 60);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(228, 20);
            this.txtbLogin.TabIndex = 1;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(202, 116);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(228, 20);
            this.txtbPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de Passe";
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = System.Drawing.Color.WhiteSmoke;
            btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAnnuler.ForeColor = System.Drawing.Color.Black;
            btnAnnuler.Location = new System.Drawing.Point(145, 160);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new System.Drawing.Size(85, 29);
            btnAnnuler.TabIndex = 4;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnConnexion.ForeColor = System.Drawing.Color.White;
            btnConnexion.Location = new System.Drawing.Point(305, 160);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new System.Drawing.Size(123, 29);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(183, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Formulaire de Connexion";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(123, 17);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(269, 20);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Login ou Mot de Passe Incorrect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(587, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Commercial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

