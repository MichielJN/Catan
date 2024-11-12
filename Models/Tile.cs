using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.Models
{
    public class Tile
    {
        public string TileName { get; set; } = "";
        public string Rescource { get; set; } = "";
        public int Number { get; set; } = 0;
        public bool Robber { get; set; } = false;
        public Settlement[] ConnectedSettlements { get; set; } = new Settlement[6];

        public Tile(int tileNumber, string rescource, int number, string connectedSettlements)
        {
            TileName = "T" + tileNumber;
            Rescource = rescource;
            Number = number;
            string[] connectedVillages = connectedSettlements.Split(",");
            Settlement[] villagesConnected = new Settlement[6];
            AssignConnectingSettlements(connectedVillages);
        }

        public Tile(string tileName)
        {
            TileName = tileName;
        }

        public Tile(int tileNumber, string rescource, int number)
        {
            TileName = "T" + tileNumber;
            Rescource = rescource;
            Number = number;
        }

        public Tile(int tileNumber, string rescource, int number, bool robber)
        {
            TileName = "T" + tileNumber;
            Rescource = rescource;
            Number = number;
            Robber = robber;
        }

        public Tile()
        {

        }

        public List<Tile> AssignTileNames(List<Tile> tiles)
        {
            for (int i = 0; i < 19; i++)
            {
                //tiles[i].ConnectedSettlements = Program.game.Tiles[i].ConnectedSettlements;
                tiles[i].TileName = "T" + (i + 1).ToString();
            }
            return tiles;
        }

        public void UpdateConnectingVillages(Tile tile)
        {
            for (int i = 0; i < 6; i++)
            {
                Program.game.Tiles[Program.game.GetTileIndex(tile)].ConnectedSettlements[i] = Program.game.Settlements[Program.game.GetSettlementIndex(ConnectedSettlements[i].Location)];
            }
        }

        public void AssignConnectingSettlements(string[] connectedVillages)
        {
            for (int i = 0; i < 6; i++)
            {
                ConnectedSettlements[i] = Program.game.Settlements[Program.game.GetSettlementIndex(connectedVillages[i])];
            }
        }
    }
}



