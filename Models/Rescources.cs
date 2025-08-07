using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.Models
{
    public class Rescources
    {
        public int Grain { get; set; } = 0;
        public int Stone { get; set; } = 20;
        public int Wood { get; set; } = 20;
        public int Ore { get; set; } = 0;
        public int Sheep { get; set; } = 0;

        public bool BuyStreet()
        {
            if (Stone > 0 & Wood > 0)
            {

                if (AskAffirmation("straat") == true)
                {
                    Stone -= 1;
                    Wood -= 1;

                    return true;
                }
                return false;
            }
            return false;
        }

        public bool BuySettlement()
        {
            if (Stone > 0 & Wood > 0)
            {

                if (Grain > 0 & Sheep > 0)
                {
                    if (AskAffirmation("dorp") == true)
                    {

                        Stone -= 1;
                        Wood -= 1;
                        Grain -= 1;
                        Sheep -= 1;

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
            if (Ore > 2 & Grain > 1)
            {
                if (AskAffirmation("stad") == true)
                {


                    Ore -= 3;
                    Grain -= 2;
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool BuyDevelopment()
        {
            if (Ore > 0 & Sheep > 0)
            {
                if (Grain > 0)
                {
                    if (AskAffirmation("ontwikkeling") == true)
                    {
                        Ore -= 1;
                        Sheep -= 1;
                        Grain -= 1;

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

            DialogResult dialogResult = MessageBox.Show("Wil je een " + itemBaught + " kopen?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
            foreach (Tile tile in settlement.TilesConnectedToThisSettlement)
            {
                switch (Program.game.Tiles[Program.game.GetTileIndex(tile)].Rescource) //tile.Rescource)
                {
                    case "Graan":
                        Grain += 1;
                        continue;
                    case "Steen":
                        Stone += 1;
                        continue;
                    case "Hout":
                        Wood += 1;
                        continue;
                    case "Schaap":
                        Sheep += 1;
                        continue;
                    case "Erts":
                        Ore += 1;
                        continue;


                }
            }
        }
        public void Rob(Button endTurn)
        {
            Tile robbedTile = new Tile();
            foreach (Tile tile in Program.game.Tiles)
            {

                if (tile.Robber == true)
                {
                    robbedTile = tile;
                    break;
                }

            }
            List<string> robbedPlayers = new List<string>();
            foreach (Settlement settlement in robbedTile.ConnectedSettlements)
            {
                if (settlement.Owner.UserName != "-")
                {
                    robbedPlayers.Add(settlement.Owner.UserName);
                }
            }
            RobForm robForm = new RobForm(robbedPlayers, endTurn);

        }

    }
}
