using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    class Korisnik : Osoba
    {
        private String email { get; set; }
        private Boolean adminPrivileges { get; set; }
    }
}
