using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    class Osoba
    {
        private String username { get; set; }
        private String password { get; set; }

        public bool passwordCheck(String pw) {
            return true;
        }

    }
}
