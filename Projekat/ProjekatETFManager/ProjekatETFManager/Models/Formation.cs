using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    public class Formation
    {
        private static enum position { GK, DC, DR, DL, MCR, MCL , MC, MR, ML, STC, STCR, STCL};
        private int brojIgraca;
        private int formationID;
        private Igrac goalkeeper;
        private Igrac[] centralDefenders;
        private Igrac leftBack;
        private Igrac rightBack;
        private Igrac[] midfielders;
        private Igrac leftWinger;
        private Igrac rightWinger;
        private Igrac[] strikers;
        private string tactic;

        public global::System.Int32 FormationID { get => formationID; set => formationID = value; }
        public Igrac Goalkeeper { get => goalkeeper; set => goalkeeper = value; }
        public Igrac[] CentralDefenders { get => centralDefenders; set => centralDefenders = value; }
        public Igrac LeftBack { get => leftBack; set => leftBack = value; }
        public Igrac RightBack { get => rightBack; set => rightBack = value; }
        public Igrac[] Midfielders { get => midfielders; set => midfielders = value; }
        public Igrac LeftWinger { get => leftWinger; set => leftWinger = value; }
        public Igrac RightWinger { get => rightWinger; set => rightWinger = value; }
        public Igrac[] Strikers { get => strikers; set => strikers = value; }
        public global::System.String Tactic { get => tactic; set => tactic = value; }

        public Formation()
        {
            brojIgraca = 0;
            FormationID = 0;
            Goalkeeper = null;
            CentralDefenders = null;
            LeftBack = null;
            RightBack = null;
            Midfielders = null;
            LeftWinger = null;
            RightWinger = null;
            strikers = null;
            tactic = "";
            
        }
        
        
    }
}
