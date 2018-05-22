using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    class System
    {
        private List<Osoba> users;
        private List<League> leagues;
        private List<Igrac> availablePlayers;

        public System()
        {
            users = new List<Osoba>();
            leagues = new List<League>();
            availablePlayers = new List<Igrac>();
        }
        //  nastaje problem ako se timovi ne cuvaju u system vec samo u ligama
        bool addTeam(Tim newTeam)
        {
            
        }
    }
}
