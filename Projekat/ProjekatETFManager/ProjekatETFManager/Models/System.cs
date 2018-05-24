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
        private List<Tim> teams;

        public System()
        {
            users = new List<Osoba>();
            leagues = new List<League>();
            availablePlayers = new List<Igrac>();
            teams = new List<Tim>();
        }
        //  opet problem jer jedan igrac moze imati samo jednu ekipu
        //  trebalo bi razmotriti potrebnost ove metode
        //  eventualno ako je potrebna treba bolje povezati korisnika i tim
        public bool addTeam(Tim newTeam)
        {
            if(!teams.Any(x => x.TeamID == newTeam.TeamID && x.TeamName == newTeam.TeamName))
            {
                teams.Add(newTeam);
                return true;
            }
            return false;
        }

        //  ostalo jos par metoda ovdje
        //  opet treba razmotriti potrebnost ovih metoda
        //  moramo se dogovoriti majka mu stara, nema vas nidje
    }
}
