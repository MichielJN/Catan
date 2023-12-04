using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Settlement : Building
    {//goed nadenken over hoe je de settlements in de settlement maakt.
        public int Level { get; set; } = 0;
        public List<Settlement> DisabledSettlements { get; set; } = new List<Settlement>();
        public List<Street> StreetsConnectedToThisSettlement { get; set; } = new List<Street>();

        public List<Tile> TilesConnectedToThisSettlement = new List<Tile>();

        public Settlement(string location, string disabledSettlements, string connectedStreets, string connectedTiles)
        {
            this.Location = location;  
            string[] disabledVillages = disabledSettlements.Replace(" ", "").Split(",");
            string[] connectedLines = connectedStreets.Replace(" ", "").Split(",");
            string[] tilesConnected = connectedTiles.Replace(" ", "").Split(",");
            foreach (string village in disabledVillages)
            {
                Settlement settlement = new Settlement(village);
                this.DisabledSettlements.Add(settlement);
            }
            
            foreach(string street in connectedLines)
            {
                Street _street = new Street(street);
                this.StreetsConnectedToThisSettlement.Add(_street);
            }
            
            foreach(string tile in tilesConnected)
            {
                Tile _tile = new Tile("T" + tile);
                this.TilesConnectedToThisSettlement.Add(_tile);
            }
            
            //this.DisabledSettlements = disabledVillages.ToList();
        }

        public Settlement(string location, Settlement[] disabledSettlements)
        {
            this.Location = location;
        }
        public Settlement(string location)
        {
            this.Location = location;
        }

        public Settlement(string location, string disabledSettlements)
        {
            this.Location = location;
            string[] disabledVillages = disabledSettlements.Replace(" ", "").Split(",");
            foreach (string village in disabledVillages)
            {
                Settlement settlement = new Settlement(village);
                this.DisabledSettlements.Add(settlement);
            }


            //this.DisabledSettlements = disabledVillages.ToList();
        }
        public void UpdateSettlement(Settlement settlement)
        {
            for(int i = 0; i < this.StreetsConnectedToThisSettlement.Count; i++)
            {
                settlement.StreetsConnectedToThisSettlement[i] = Program.game.Streets[Program.game.GetStreetIndex(settlement.StreetsConnectedToThisSettlement[i])];
            }
            for(int i = 0; i < this.DisabledSettlements.Count; i++)
            {
                settlement.DisabledSettlements[i] = Program.game.Settlements[Program.game.GetSettlementIndex(settlement.DisabledSettlements[i].Location)];
            }

        }
        
        public void UpdateAllSettlements()
        {
            foreach(Settlement settlement in Program.game.Settlements)
            {
                UpdateSettlement(settlement);
            }
        }
    }
}
