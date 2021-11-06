using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.models
{
    public class User
    {
        private int id;
        private string nomComplet;
        private string login;
        private string password;
        private byte[] avatar;

        //Attribut Navigationnel =>ManyToOne
        private Role role;

        public int Id { get => id; set => id = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public Role Role { get => role; set => role = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }

        //Defaut 
        public User()
        {
        }

        //insertion
        public User(string nomComplet, string login, string password)
        {
            this.NomComplet = nomComplet;
            this.Login = login;
            this.Password = password;
        }

        //Update
        public User(int id, string nomComplet, string login, string password)
        {
            this.Id = id;
            this.NomComplet = nomComplet;
            this.Login = login;
            this.Password = password;
        }



   

    }
}
