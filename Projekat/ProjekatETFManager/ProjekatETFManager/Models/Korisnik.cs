using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    public class Korisnik : Osoba
    {
        private String email;
        private Boolean adminPrivileges;

        public Korisnik(string username, string password, string email, bool admin)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.AdminPrivileges = admin;
        }

        public string Email { get => email; set => email = value; }
        public bool AdminPrivileges { get => adminPrivileges; set => adminPrivileges = value; }
    }
}
