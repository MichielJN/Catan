using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Rescources
    {
        public int Grain { get; set; } = 0;
        public int Stone { get; set; } = 0;
        public int Wood { get; set; } = 0;
        public int Ore { get; set; } = 0;
        public int Sheep { get; set; } = 0;

        public bool BuyStreet()
        {
            if(this.Stone > 0 & this.Wood > 0)
            {

                if (AskAffirmation("straat") == true)
                {
                    this.Stone -= 1;
                    this.Wood -= 1;

                    return true;
                }
                return false;
            }
            return false;
        }

        public bool BuySettlement()
        {
            if (this.Stone > 0 & this.Wood > 0)
            {

                if(this.Grain > 0 & this.Sheep > 0)
                {
                    if (AskAffirmation("dorp") == true)
                    {

                        this.Stone -= 1;
                        this.Wood -= 1;
                        this.Grain -= 1;
                        this.Sheep -= 1;

                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        public bool BuyCity()
        {
            if(this.Ore > 2 & this.Grain > 1)
            {
                if (AskAffirmation("stad") == true)
                {


                    this.Ore -= 3;
                    this.Grain -= 2;
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool BuyDevelopment()
        {
            if(this.Ore > 0 & this.Sheep > 0)
            {
                if(this.Grain > 0)
                {
                    if (AskAffirmation("ontwikkeling") == true)
                    {
                        this.Ore -= 1;
                        this.Sheep -= 1;
                        this.Grain -= 1;

                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        public bool AskAffirmation(string itemBaught)
        {

            DialogResult dialogResult = MessageBox.Show("Wil je een " + itemBaught + " kopen?","", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetStartGameRescources(Settlement settlement)
        {
            foreach(Tile tile in settlement.TilesConnectedToThisSettlement)
            {
                switch (Program.game.Tiles[Program.game.GetTileIndex(tile)].Rescource) //tile.Rescource)
                {
                    case "Graan":
                        this.Grain += 1;
                        continue;
                    case "Steen":
                        this.Stone += 1;
                        continue;
                    case "Hout":
                        this.Wood += 1;
                        continue;
                    case "Schaap":
                        this.Sheep += 1;
                        continue;
                    case "Erts":
                        this.Ore += 1;
                        continue;
                        

                }
            }
        }
        public void Rob(Button endTurn)
        {
            Tile robbedTile = new Tile();
            foreach (Tile tile in Program.game.Tiles)
            {
                
                if(tile.Robber == true)
                {
                    robbedTile = tile;
                    break;
                }

            }
            List<string> robbedPlayers = new List<string>();
            foreach(Settlement settlement in robbedTile.ConnectedSettlements)
            {
                if(settlement.Owner.UserName != "-")
                {
                    robbedPlayers.Add(settlement.Owner.UserName);
                }
            }
            RobForm robForm = new RobForm(robbedPlayers, endTurn);

        }

    }
}
