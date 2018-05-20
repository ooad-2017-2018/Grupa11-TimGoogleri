using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatETFManager.Models
{
    class Tim
    {
        private bool setToDelete;
        private int teamID;
        private int ownerID;
        private string teamName;
        private int leagueID;
        private Formation formation;
        private List<Igrac> squad;
        private int transferBudget;
        public int TeamID { get => teamID; set => teamID = value; }
        public int OwnerID { get => ownerID; set => ownerID = value; }
        public string TeamName { get => teamName; set => teamName = value; }
        public int LeagueID { get => leagueID; set => leagueID = value; }
        public Formation Formation { get => formation; set => formation = value; }
        public int TransferBudget { get => transferBudget; set => transferBudget = value; }
        public List<Igrac> Squad { get => squad; set => squad = value; }
        public bool SetToDelete { get => setToDelete; set => setToDelete = value; }

        public bool transferBuy(Igrac player)
        {
            if (squad.Contains(player) || player.Cost > transferBudget || squad.Count > 25) return false;

            Squad.Add(player);
            TransferBudget -= player.Cost;
            return true;
        }
        public bool transferSell(Igrac player)
        {
            if (!squad.Contains(player)) return false;
            squad.Remove(player);
            TransferBudget += player.Cost;
            return true;
        }

        public void DeleteTeam()
        {
            SetToDelete = true;
        }
    }
}
