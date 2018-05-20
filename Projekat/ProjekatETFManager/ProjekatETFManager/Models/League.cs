using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    class League
    {
        private int leagueID;
        private string leagueName;
        private List<Tuple<Tim, int, int, int, int, int>> table;
        private List<Tuple<Igrac, int>> scorers;

        public int LeagueID { get => leagueID; set => leagueID = value; }
        public string LeagueName { get => leagueName; set => leagueName = value; }
        public List<Tuple<Igrac, int>> Scorers { get => scorers; set => scorers = value; }
        internal List<Tuple<Tim, int, int, int, int, int>> Table { get => table; set => table = value; }

        //  zasad vraca samo string koji ce biti formatiran da izgleda kao tabela
        //  kasnije cemo mijenjati ovo je samo za potrebe testiranja
        public string tableOverview() { } 

        //  vraca top n uredjenih parova (Igrac, broj golova)
        public List<Tuple<Igrac,int>> topScorers(int n) { }

        //  potreban dogovor kako cemo implementirati simulacije i sta ce sve uzimati u obzir
        // za pocetak mozemo samo gledati ocjene igraca i preko toga odrediti koja je bolja ekipa
        public void simulateGame(Tim homeTeam, Tim awayTeam) { } // ovo ko napravi njemu dvije

    }
}
