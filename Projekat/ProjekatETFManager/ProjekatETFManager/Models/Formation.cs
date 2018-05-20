using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    public enum Position { GK, DL, DCL, DC, DCR, DR, ML, MCL, MC, MCR, MR, STCL, STC, STCR };
    public class Formation
    {
        
        private int brojIgraca;
        private int formationID;
        private Igrac goalkeeper;
        private Igrac[][] team;
        private string tactic;

        public global::System.Int32 FormationID { get => formationID; set => formationID = value; }
        public Igrac Goalkeeper { get => goalkeeper; set => goalkeeper = value; }
        
        public global::System.String Tactic { get => tactic; set => tactic = value; }

        public Formation()
        {
            brojIgraca = 0;     // samo je implementirano za ubaciti igraca, ne i za izbaciti
            FormationID = 0;    // treba skontati formation ID kako i sta
            Goalkeeper = null;
            team = new Igrac[3][];  // zamisljeno je da se igraci cuvaju u grbavoj matrici
            team[0] = new Igrac[5]; // gdje imamo 5 mjesta za odbrambene igrace, null znaci da je ta pozicija prazna
            team[1] = new Igrac[5]; // 5 mjesta za vezne igrace, gdje null znaci da je ta pozicija prazna
            team[2] = new Igrac[3]; // 3 mjesta za napadace
            tactic = "";
            
            // u sustini zamisljeno kako je Nedim predstavio u prototipu forme postavljanja taktike
        }

        //  ubacuje igraca na poziciju u matricu igraca
        public void putPlayerOnPosition(Igrac player, Position pos)
        {
            int i = (int)pos-1;
            int j = i % 5;
            i = i / 5;
            if (i == 0)
            {
                if (brojIgraca > 11) throw new Exception("Svaka ekipa mora imati golmana i najmanje 8, a najvise 11 igraca na terenu");
                goalkeeper = player;
                brojIgraca++;
            }
            if (team[i][j] == null && brojIgraca == 11)
                throw new Exception("Svaka ekipa mora imati golmana i najmanje 8, a najvise 11 igraca na terenu");
            else team[i][j] = player;

            int df = 0, mf = 0, st = 0;
            for(int k = 0; k < 5; i++)
            {
                if (team[0][k] != null) df++;
                if (team[1][k] != null) mf++;
                if (k < 3 && team[2][k] != null) st++;
            }
            tactic = df.ToString() + "-" + mf.ToString() + "-" + st.ToString();

        }
        
        
        
    }
}
