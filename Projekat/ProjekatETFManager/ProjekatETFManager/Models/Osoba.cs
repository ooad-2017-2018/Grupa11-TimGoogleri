using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    public abstract class Osoba
    {
        private string username;
        private string password;

        public global::System.String Username { get => username; set => username = value; }
        public global::System.String Password { get => password; set => password = CalculateMD5Hash(value); }
        

        private string CalculateMD5Hash(string input)
        {

            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));
            

            return sb.ToString();

        }
        
        public bool PasswordCheck(string pw) {
            return CalculateMD5Hash(pw) == this.password;
        }

    }
}
