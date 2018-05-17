using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    public class Korisnik : Osoba
    {
        private String email { get; set; }
        private Boolean adminPrivileges { get; set; }

        public Korisnik(string username, string password, string email, bool admin)
        {
            this.Username = username;
            this.Password = password;
            this.email = email;
            this.adminPrivileges = admin;
        }
    }
}
