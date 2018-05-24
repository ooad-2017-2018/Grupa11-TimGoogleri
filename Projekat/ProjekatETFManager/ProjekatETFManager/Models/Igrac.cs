using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    public class Igrac
    {
        private int playerID;
        private string name;
        private string lastName;
        private bool prefferedFoot;//true se tumaci kao desna, false kao lijeva
        private int goalkeeping;
        private int defending;
        private int playmaking;
        private int winger;
        private int passing;
        private int scoring;
        private int setPieces;
        private int cost;

        //  konstruktor sa svim parametrima
        //  baca izuzetak u slucaju da setter baci izuzetak
        public Igrac(int ID, string name, string lastName, bool prefferedFoot, int goalkeeping, int defending, int playmaking, int winger, int passing, int scoring, int setPieces, int cost)
        {
            this.PlayerID = ID;
            this.name = name;
            this.LastName = lastName;
            this.PrefferedFoot = prefferedFoot;
            this.Goalkeeping = Goalkeeping;
            this.Defending = defending;
            this.Playmaking = playmaking;
            this.Winger = winger;
            this.Passing = passing;
            this.Scoring = scoring;
            this.SetPieces = setPieces;
            this.Cost = cost;
        }
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

        public int Cost { get => cost; set => cost = value; }
        public int PlayerID { get => playerID; set => playerID = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public bool PrefferedFoot { get => prefferedFoot; set => prefferedFoot = value; }
    }
}
