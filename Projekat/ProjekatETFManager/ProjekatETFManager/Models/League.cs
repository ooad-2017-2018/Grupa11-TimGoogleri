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

        public League(int leagueID, string leagueName)
        {
            this.LeagueID = leagueID;
            this.LeagueName = leagueName;
            this.Table = new List<Tuple<Tim, int, int, int, int, int>>();
            this.Scorers = new List<Tuple<Igrac, int>>();
        }

        public void sortirajTabelu()
        {
            table.Sort((x, y) =>
                {
                    int result = x.Item6 > y.Item6 || (x.Item6 == y.Item6 && x.Item5 > y.Item5) ? 1 : 0;
                    return result;
                });
                
        }

        //  zasad vraca samo string koji ce biti formatiran da izgleda kao tabela
        //  kasnije cemo mijenjati ovo je samo za potrebe testiranja
        public string tableOverview()
        {
            this.sortirajTabelu();
            string povratni = "";
            const string Format = "{000000000000000} {11} {22} {33} {44} {55}";
            foreach (var x in table)
            {
                povratni += string.Format(Format, x.Item1, x.Item2, x.Item3, x.Item4, x.Item5, x.Item6);
            }
            return povratni;
        } 

        //  vraca top n uredjenih parova (Igrac, broj golova)
        public List<Tuple<Igrac,int>> topScorers(int n) {
            List<Tuple<Igrac, int>> povratna = new List<Tuple<Igrac, int>>();
            povratna = Scorers;
            povratna.Sort((x,y) =>
            {
                int result = x.Item2 > y.Item2 ? 1 : 0;
                return result;
            });
            return povratna.Take(n).ToList();
        }

        //  potreban dogovor kako cemo implementirati simulacije i sta ce sve uzimati u obzir
        //  za pocetak mozemo samo gledati ocjene igraca i preko toga odrediti koja je bolja ekipa
        //  vraca uredjenu trojku gdje je prvo rezultat, drugo desavanja prve ekipe, trece desavanja druge ekipe
        //  ovo ko napravi njemu dvije
    
        public Tuple<string, string, string> simulateGame(Tim homeTeam, Tim awayTeam)
        {
            return new Tuple<string, string, string>("", "", "");
        }

    }
}
