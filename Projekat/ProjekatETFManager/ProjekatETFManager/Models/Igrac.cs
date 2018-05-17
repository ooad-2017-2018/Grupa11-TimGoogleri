using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    public class Igrac
    {
        private int playerID { get; set; }
        private string name { get; set; }
        private string lastName { get; set; }
        private bool prefferedFoot { get; set; } //true se tumaci kao desna, false kao lijeva
        private int goalkeeping;
        private int defending;
        private int playmaking;
        private int winger;
        private int passing;
        private int scoring;
        private int setPieces;
        public int Goalkeeping
        {
            get
            {
                return this.goalkeeping;
            }
            set
            {
                if (value < 0 || value > 99) throw new Exception("Ocjena nije validna!");
                this.goalkeeping = value;
            }
        }
        public int Defending
        {
            get
            {
                return this.defending;
            }
            set
            {
                if (value < 0 || value > 99) throw new Exception("Ocjena nije validna!");
                this.defending = value;
            }
        }
        public int Playmaking
        {
            get
            {
                return this.playmaking;
            }
            set
            {
                if (value < 0 || value > 99) throw new Exception("Ocjena nije validna!");
                this.playmaking = value;
            }
        }
        public int Winger
        {
            get
            {
                return this.winger;
            }
            set
            {
                if (value < 0 || value > 99) throw new Exception("Ocjena nije validna!");
                this.winger = value;
            }
        }
        public int Passing
        {
            get
            {
                return this.passing;
            }
            set
            {
                if (value < 0 || value > 99) throw new Exception("Ocjena nije validna!");
                this.passing = value;
            }
        }
        public int Scoring
        {
            get
            {
                return this.scoring;
            }
            set
            {
                if (value < 0 || value > 99) throw new Exception("Ocjena nije validna!");
                this.scoring = value;
            }
        }
        public int SetPieces
        {
            get
            {
                return this.setPieces;
            }
            set
            {
                if (value < 0 || value > 99) throw new Exception("Ocjena nije validna!");
                this.setPieces = value;
            }
        }
    }
}
