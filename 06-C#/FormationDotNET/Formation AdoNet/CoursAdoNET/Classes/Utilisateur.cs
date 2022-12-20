using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursAdoNET.Classes
{
    internal class Utilisateur
    {
        private int id;
        private string login;
        private string password;

        public Utilisateur()
        {

        }

        public Utilisateur(int id, string login, string password)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public bool Add()
        {

            return true;
        }
    }
}
