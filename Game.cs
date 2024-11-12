using Catan.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Game
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public List<Development> Developments { get; set; } = new List<Development>();
        public Settlement[] Settlements { get; set; }  = new Settlement[54];
        public Street[] Streets { get; set; } = new Street[72];
        public Tile[] Tiles { get; set; } = new Tile[19];
        public Development developments { get; set; }
        public bool GameBegin { get; set; } = true;
        public Die Dice { get; set; } = new Die();
        public Button[] SettlementButtons { get; set; }
        public Button[] StreetButons { get; set; }
        public InterfaceButtons InterfaceButtons { get; set; } = new InterfaceButtons();

        public Game()
        {
        }
        public Game(List<Player> players)
        {
            //LoadGame();
            this.Players = players;
            //foreach(Player player in Players)
            //{
            //    Program.Dal.SavePlayer(player);
            //}
            
           
        }

        public void LoadGame()//werkt niet als het in de constructor wordt gebruikt
        {
            LoadSettlements();
            LoadStreets();
            CreateTiles();
            GetConnectingSettlementsToTiles();
            
            LoadStreets();
        }

        public void LoadSettlements()
        {
            List<Settlement> villages = new List<Settlement>();
            for (int settlementNumber = 1; settlementNumber < 55; settlementNumber++)
            {

                switch (settlementNumber)
                {
                    case 1:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D2, D7", "S1, S7", "1");
                        continue;
                    case 2:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D1, D3", "S1, S2", "1");
                        continue;
                    case 3:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D2, D4, D11", "S2, S3, S8", "1,2");
                        continue;
                    case 4:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D3, D5", "S3, S4", "2");
                        continue;
                    case 5:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D4, D6, D13", "S4, S5, S9", "2,3");
                        continue;
                    case 6:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D5, D7", "S5, S6", "3");
                        continue;
                    case 7:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D6, D15", "S6, S10", "3");
                        continue;
                    case 8:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D9, D18", "S11, S14", "4");
                        continue;
                    case 9:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D1, D8, D10", "S7, S11, S12", "1,4");
                        continue;
                    case 10:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D9, D11, D20", "S12, S13, S20", "1,4,5");
                        continue;
                    case 11:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D3, D10, D12", "S8, S13, S14", "1,2,5");
                        continue;
                    case 12:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D11, D13, D22", "S14, S15, S21", "2,5,6");
                        continue;
                    case 13:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D5, D12, D14", "S9, S15, S16", "2,3,6");
                        continue;
                    case 14:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D13, D15, D24", "S16, S17, S22", "3,6,7");
                        continue;
                    case 15:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D7, D14, D16", "S10, S17, S18", "3,7");
                        continue;
                    case 16:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D15, D26", "S18, S23", "7");
                        continue;
                    case 17:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D18, D28", "S24, S34", "8");
                        continue;
                    case 18:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D8, D17, D19", "S14, S24, S25", "4,8");
                        continue;
                    case 19:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D18, D20, D30", "S25, S26, S35", "4,8,9");
                        continue;
                    case 20:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D10, D19, D21", "S20, S26, S27", "4,5,9");
                        continue;
                    case 21:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D20, D22, D32", "S27, S28, S36", "5,9,10");
                        continue;
                    case 22:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D12, D21, D23", "S21, S28, S29", "5,6,10");
                        continue;
                    case 23:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D22, 24, D34", "S29, S30, S35", "6,10,11");
                        continue;
                    case 24:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D14, D23, D25", "S22, S30, S31", "6,7,11");
                        continue;
                    case 25:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D24, D26, D36", "S31, S32, S38", "7,11,12");
                        continue;
                    case 26:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D16, D25, D27", "S23, S32, S33", "7,12");
                        continue;
                    case 27:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D26, D38", "S33, S39", "12");
                        continue;
                    case 28:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D17, D29", "S34, S40", "8");
                        continue;
                    case 29:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D28, D30, D39", "S40, S41, S50", "8,13");
                        continue;
                    case 30:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D19, D29, D31", "S35, S41, S42", "8,9,13");
                        continue;
                    case 31:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D30, D32, D41", "S42, S43, S51", "9,13,14");
                        continue;
                    case 32:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D21, D31, D33", "S36, S43, S44", "9,10,14");
                        continue;
                    case 33:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D32, D34, D43", "S44, S45, S52", "10,14,15");
                        continue;
                    case 34:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D23, D33, D35", "S37, S45, S46", "10,11,15");
                        continue;
                    case 35:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D34, D36, D45", "S46, S47, S53", "11,15,16");
                        continue;
                    case 36:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D25, D35, D37", "S38, S47, S48", "11,12,16");
                        continue;
                    case 37:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D36, D38, D47", "S48, S49, S54", "12,16");
                        continue;
                    case 38:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D24, D37", "S39, S49", "12");
                        continue;
                    case 39:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D29, D40", "S50, S55", "13");
                        continue;
                    case 40:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D39, D41, D48", "S55, S56, S63", "13,17");
                        continue;
                    case 41:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D31, D40, D42", "S51, S56, S57", "13,14,17");
                        continue;
                    case 42:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D41, D43, D50", "S57, S58, S64", "14,17,18");
                        continue;
                    case 43:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D33, D42, D44", "S52, S58, S59", "14,15,18");
                        continue;
                    case 44:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D43, D45, D52", "S59, S60, S65", "15,18,19");
                        continue;
                    case 45:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D35, D44, D46", "S53, S60, S61", "15,16,19");
                        continue;
                    case 46:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D45, D47, D54", "S61, S62, S66", "16,19");
                        continue;
                    case 47:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D37, D46", "S54, S62", "16");
                        continue;
                    case 48:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D40, D49", "S63, S67", "17");
                        continue;
                    case 49:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D48, D50", "S67, S68", "17");
                        continue;
                    case 50:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D42, D49, D51", "S64, S68, S69", "17,18");
                        continue;
                    case 51:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D50, D52", "S69, S70", "18");
                        continue;
                    case 52:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D44, D51, D53", "S65, S70, S71", "18,19");
                        continue;
                    case 53:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D52, D54", "S71, S72", "19");
                        continue;
                    case 54:
                        AssignConnectingPartsOfSettlement(settlementNumber, "D46, D53", "S66, S72", "19");
                        continue;
                }
            }
        }
        
        public void LoadStreets()
        {
            for (int settlementNumber = 1; settlementNumber < 73; settlementNumber++)
            {
                switch (settlementNumber)// hier moeten de naastliggende straten komen.
                {
                    case 1:
                        AssignConnectingPartsToStreet(settlementNumber, "S2, S7", "D1, D2");
                        continue;
                    case 2:
                        AssignConnectingPartsToStreet(settlementNumber, "S1, S3, S8", "D2, D3");
                        continue;
                    case 3:
                        AssignConnectingPartsToStreet(settlementNumber, "S2, S4, S8", "D3, D4");
                        continue;
                    case 4:
                        AssignConnectingPartsToStreet(settlementNumber, "S3, S5, S9", "D4, D5");
                        continue;
                    case 5:
                        AssignConnectingPartsToStreet(settlementNumber, "S4, S6, S9", "D5, D6");
                        continue;
                    case 6:
                        AssignConnectingPartsToStreet(settlementNumber, "S5, S10", "D6, D7");
                        continue;
                    case 7:
                        AssignConnectingPartsToStreet(settlementNumber, "S1, S11, S12", "D1, D9");
                        continue;
                    case 8:
                        AssignConnectingPartsToStreet(settlementNumber, "S2, S3, S13, S14", "D3, D11");
                        continue;
                    case 9:
                        AssignConnectingPartsToStreet(settlementNumber, "S4, S5,S15, S16", "D5, D13");
                        continue;
                    case 10:
                        AssignConnectingPartsToStreet(settlementNumber, "S6, S17, S18", "D7, D15");
                        continue;
                    case 11:
                        AssignConnectingPartsToStreet(settlementNumber, "S7, S12, S14", "D8, D9");
                        continue;
                    case 12:
                        AssignConnectingPartsToStreet(settlementNumber, "S7, S11, S13, S20", "D9, D10");
                        continue;
                    case 13:
                        AssignConnectingPartsToStreet(settlementNumber, "S8, S12, S14, S20 ", "D10, D11");
                        continue;
                    case 14:
                        AssignConnectingPartsToStreet(settlementNumber, "S8, S13, S15, S21", "D11, D12");
                        continue;
                    case 15:
                        AssignConnectingPartsToStreet(settlementNumber, "S9, S14, S16, S21", "D12, D13");
                        continue;
                    case 16:
                        AssignConnectingPartsToStreet(settlementNumber, "S9, S15, S17, S22", "D13, D14");
                        continue;
                    case 17:
                        AssignConnectingPartsToStreet(settlementNumber, "S10, S16, S18, S22", "D14, D15");
                        continue;
                    case 18:
                        AssignConnectingPartsToStreet(settlementNumber, "S10, S17, S23", "D15, D16");
                        continue;
                    case 19:
                        AssignConnectingPartsToStreet(settlementNumber, "S11, S24, S25", "D8, D18");
                        continue;
                    case 20:
                        AssignConnectingPartsToStreet(settlementNumber, "S12, S13, S28, S29", "D10, D20");
                        continue;
                    case 21:
                        AssignConnectingPartsToStreet(settlementNumber, "S14, S15, S28, S29", "D12, D22");
                        continue;
                    case 22:
                        AssignConnectingPartsToStreet(settlementNumber, "S16, S17, S30, S31", "D14, D24");
                        continue;
                    case 23:
                        AssignConnectingPartsToStreet(settlementNumber, "S18, S32, S33", "D16, D26");
                        continue;
                    case 24:
                        AssignConnectingPartsToStreet(settlementNumber, "S19, S25, S34", "D17, D18");
                        continue;
                    case 25:
                        AssignConnectingPartsToStreet(settlementNumber, "S14, S24, S26, S35", "D18, D19");
                        continue;
                    case 26:
                        AssignConnectingPartsToStreet(settlementNumber, "S20, S25, S27, S35", "D19, D20");
                        continue;
                    case 27:
                        AssignConnectingPartsToStreet(settlementNumber, "S20, S26, S28, S36", "D20, D21");
                        continue;
                    case 28:
                        AssignConnectingPartsToStreet(settlementNumber, "S21, S27, S29, S36", "D21, D22");
                        continue;
                    case 29:
                        AssignConnectingPartsToStreet(settlementNumber, "S21, S28, S30, S37", "D22, D23");
                        continue;
                    case 30:
                        AssignConnectingPartsToStreet(settlementNumber, "S22, S29, S31, S37", "D23, D24");
                        continue;
                    case 31:
                        AssignConnectingPartsToStreet(settlementNumber, "S22, S30, S32, S38", "D24, D25");
                        continue;
                    case 32:
                        AssignConnectingPartsToStreet(settlementNumber, "S23, S31, S33, S38", "D25, D26");
                        continue;
                    case 33:
                        AssignConnectingPartsToStreet(settlementNumber, "S23, S32, S39", "D26, D27");
                        continue;
                    case 34:
                        AssignConnectingPartsToStreet(settlementNumber, "S24, S40", "D17, D28");
                        continue;
                    case 35:
                        AssignConnectingPartsToStreet(settlementNumber, "S25, S26, S41, S42", "D19, D30");
                        continue;
                    case 36:
                        AssignConnectingPartsToStreet(settlementNumber, "S27, S28, S43, S44", "D21, D32");
                        continue;
                    case 37:
                        AssignConnectingPartsToStreet(settlementNumber, "S29, S30, S45, S46", "D23, D34");
                        continue;
                    case 38:
                        AssignConnectingPartsToStreet(settlementNumber, "S31, S32, S47, S48", "D25, D36");
                        continue;
                    case 39:
                        AssignConnectingPartsToStreet(settlementNumber, "S33, S49", "D27, D38");
                        continue;
                    case 40:
                        AssignConnectingPartsToStreet(settlementNumber, "S34, S41, S50", "D28, D29");
                        continue;
                    case 41:
                        AssignConnectingPartsToStreet(settlementNumber, "S35, S40, S42, S50", "D29, D30");
                        continue;
                    case 42:
                        AssignConnectingPartsToStreet(settlementNumber, "S35, S41, S43, S51", "D30, D31");
                        continue;
                    case 43:
                        AssignConnectingPartsToStreet(settlementNumber, "S36, S42, S44, S51", "D31, D32");
                        continue;
                    case 44:
                        AssignConnectingPartsToStreet(settlementNumber, "S36, S43, S45, S52", "D32, D33");
                        continue;
                    case 45:
                        AssignConnectingPartsToStreet(settlementNumber, "S35, S44, S46, S52", "D33, D34");
                        continue;
                    case 46:
                        AssignConnectingPartsToStreet(settlementNumber, "S35, S45, S47, S53", "D34, D35");
                        continue;
                    case 47:
                        AssignConnectingPartsToStreet(settlementNumber, "S38, S46, S48, S53", "D35, D36");
                        continue;
                    case 48:
                        AssignConnectingPartsToStreet(settlementNumber, "S38, S47, S49, S54", "D36, D37");
                        continue;
                    case 49:
                        AssignConnectingPartsToStreet(settlementNumber, "S39, S48, S54", "D37, D38");
                        continue;
                    case 50:
                        AssignConnectingPartsToStreet(settlementNumber, "S40, S41, S55", "D29, D39");
                        continue;
                    case 51:
                        AssignConnectingPartsToStreet(settlementNumber, "S42, S43, S56, S57", "D31, D41");
                        continue;
                    case 52:
                        AssignConnectingPartsToStreet(settlementNumber, "S44, S45, S58, S59", "D33, D43");
                        continue;
                    case 53:
                        AssignConnectingPartsToStreet(settlementNumber, "S46, S47, S60, S61", "D35, D45");
                        continue;
                    case 54:
                        AssignConnectingPartsToStreet(settlementNumber, "S48, S49, S62", "D37, D47");
                        continue;
                    case 55:
                        AssignConnectingPartsToStreet(settlementNumber, "S50, S56, S63", "D39, D40");
                        continue;
                    case 56:
                        AssignConnectingPartsToStreet(settlementNumber, "S51, S55, S57, S63", "D40, D41");
                        continue;
                    case 57:
                        AssignConnectingPartsToStreet(settlementNumber, "S51, S56, S58, S64", "D41, D42");
                        continue;
                    case 58:
                        AssignConnectingPartsToStreet(settlementNumber, "S52, S57, S59, S64", "D42, D43");
                        continue;
                    case 59:
                        AssignConnectingPartsToStreet(settlementNumber, "S52, S58, S60, S65", "D43, D44");
                        continue;
                    case 60:
                        AssignConnectingPartsToStreet(settlementNumber, "S53, S59, S61, S65", "D44, D45");
                        continue;
                    case 61:
                        AssignConnectingPartsToStreet(settlementNumber, "S53, S60, S62, S66", "D45, D46");
                        continue;
                    case 62:
                        AssignConnectingPartsToStreet(settlementNumber, "S54, S61, S66", "D46, D47");
                        continue;
                    case 63:
                        AssignConnectingPartsToStreet(settlementNumber, "S55, S56, S67", "D40, D48");
                        continue;
                    case 64:
                        AssignConnectingPartsToStreet(settlementNumber, "S57, S58, S68, S69", "D42, D50");
                        continue;
                    case 65:
                        AssignConnectingPartsToStreet(settlementNumber, "S59, S60, S70, S71", "D44, D52");
                        continue;
                    case 66:
                        AssignConnectingPartsToStreet(settlementNumber, "S61, S62, S72", "D46, D54");
                        continue;
                    case 67:
                        AssignConnectingPartsToStreet(settlementNumber, "S63, S68", "D48, D49");
                        continue;
                    case 68:
                        AssignConnectingPartsToStreet(settlementNumber, "S64, S67, S69", "D49, D50");
                        continue;
                    case 69:
                        AssignConnectingPartsToStreet(settlementNumber, "S64, S67, S69", "D50, D51");
                        continue;
                    case 70:
                        AssignConnectingPartsToStreet(settlementNumber, "S65, S69, S71", "D51, D52");
                        continue;
                    case 71:
                        AssignConnectingPartsToStreet(settlementNumber, "S65, S70, S72", "D52, D53");
                        continue;
                    case 72:
                        AssignConnectingPartsToStreet(settlementNumber, "S66, S71", "D53, D54");
                        continue;

                }
            
            }
            
        }

        public void CreateTiles()
        {
            Random random = new Random();
            List<int> numbers = ShuffleNumbers(random);
            ShuffleTiles(random, numbers);

        }

        public List<int> ShuffleNumbers(Random random)
        {
            List<int> numbers = new List<int>() { 2, 3, 3, 4, 4, 5, 5, 6, 6, 8, 8, 9, 9, 10, 10, 11, 11, 12 };
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                numbers.RemoveAt(i);
                numbers.Insert(random.Next(0, numbers.Count), number);
            }

            return numbers;                   
        }

        public void ShuffleTiles(Random random, List<int> numbers)
        {
            List<Tile> tiles = new List<Tile>();




            for (int tileLocation = 1; tileLocation < 5; tileLocation++)
            {
                tiles.Add(new Tile(tileLocation, "Graan", numbers[tileLocation - 1]));
            }

            for (int i = 5; i < 9; i++)
            {
                tiles.Add(new Tile(i, "Hout", numbers[i - 1]));
            }

            for (int i = 9; i < 13; i++)
            {
                tiles.Add(new Tile(i, "Schaap", numbers[i - 1]));
            }

            for (int i = 13; i < 16; i++)
            {
                tiles.Add(new Tile(i, "Steen", numbers[i - 1]));
            }

            for (int tileLocation = 16; tileLocation < 19; tileLocation++)
            {
                tiles.Add(new Tile(tileLocation, "Erts", numbers[tileLocation - 1]));
            }

            for (int i = 0; i < 18; i++)
            {
                Tile tile = tiles[i];
                tiles.RemoveAt(i);
                tiles.Insert(random.Next(0, tiles.Count), tile);
            }


            tiles.Insert(9, new Tile(10, "-", 0, true)); 
            Tile _tile = new Tile(10, "-", 0);
            tiles = _tile.AssignTileNames(tiles);
            this.Tiles = tiles.ToArray();
            UpdateTilesOfSettlements();
            GetConnectingSettlementsToTiles();
        }

        public void UpdateTilesOfSettlements()
        {
            foreach(Settlement settlement in this.Settlements)
            {
                for(int i = 0; i < settlement.TilesConnectedToThisSettlement.Count; i++)
                {
                    settlement.TilesConnectedToThisSettlement[i] = this.Tiles[GetTileIndex(settlement.TilesConnectedToThisSettlement[i])];
                }
            }
        }
        public void AssignConnectingPartsOfSettlement(int settlementNumber, string villagesNextToThisVillage, string streetsNextToThisVillage, string connectedTiles)
        {
            this.Settlements[settlementNumber - 1] = new Settlement("D" + settlementNumber.ToString(), villagesNextToThisVillage, streetsNextToThisVillage, connectedTiles); 
        }
        public void AssignConnectingPartsToStreet(int streetNumber, string streetsNextToThisStreet, string villagesTouchingStreet)
        {
            Street street = new Street("S" + streetNumber.ToString(), streetsNextToThisStreet, villagesTouchingStreet);
            this.Streets[streetNumber -1] = street;
        }

        public int GetSettlementIndex(string settlementLocation)
        {
            string settlementNumber = "";

            foreach (char c in settlementLocation)
            {
                if (new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }.Contains(c.ToString()))
                {
                    settlementNumber += c.ToString();
                }
            }
            return int.Parse(settlementNumber) - 1;
        }
        public int GetTileNumber(Tile tile)
        {
            string tileNumber = "";

            foreach (char c in tile.TileName)
            {
                if (new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }.Contains(c.ToString()))
                {
                    tileNumber += c.ToString();
                }
            }
            return int.Parse(tileNumber);
            
        }
        public int GetTileIndex(Tile tile)
        {
            return GetTileNumber(tile) - 1;
        }
        public void GetConnectingSettlementsToTiles()
        {
            for(int i = 0; i < 19; i++)
            {
                switch (i)
                {
                    case 0:
                        AssignConnectingSettlementsToTile(i, "D1, D2, D3, D9, D10, D11");
                        continue;
                    case 1:
                        AssignConnectingSettlementsToTile(i, "D3, D4, D5, D11, D12, D13");
                        continue;
                    case 2:
                        AssignConnectingSettlementsToTile(i, "D5, D6, D7, D13, D14, D15");
                        continue;
                    case 3:
                        AssignConnectingSettlementsToTile(i, "D8, D9, D10, D18, D19, D20");
                        continue;
                    case 4:
                        AssignConnectingSettlementsToTile(i, "D10, D11, D12, D20, D21, D22");
                        continue;
                    case 5:
                        AssignConnectingSettlementsToTile(i, "D12, D13, D14, D22, D23, D24");
                        continue;
                    case 6:
                        AssignConnectingSettlementsToTile(i, "D14, D15, D16, D24, D25, D26");
                        continue;
                    case 7:
                        AssignConnectingSettlementsToTile(i, "D17, D18, D19, D28, D29, D30");
                        continue;
                    case 8:
                        AssignConnectingSettlementsToTile(i, "D19, D20, D21, D30, D31, D32");
                        continue;
                    case 9:
                        AssignConnectingSettlementsToTile(i, "D21, D22, D23, D32, D33, D34");
                        continue;
                    case 10:
                       AssignConnectingSettlementsToTile(i, "D23, D24, D25, D34, D35, D36");
                        continue;
                    case 11:
                        AssignConnectingSettlementsToTile(i, "D25, D26, D27, D36, D37, D38");
                        continue;
                    case 12:
                        AssignConnectingSettlementsToTile(i, "D29, D30, D31, D39, D40, D41");
                        continue;
                    case 13:
                        AssignConnectingSettlementsToTile(i, "D31, D32, D33, D41, D42, D43");
                        continue;
                    case 14:
                        AssignConnectingSettlementsToTile(i, "D33, D34, D35, D43, D44, D45");
                        continue;
                    case 15:
                        AssignConnectingSettlementsToTile(i, "D35, D36, D37, D45, D46, D47");
                        continue;
                    case 16:
                        AssignConnectingSettlementsToTile(i, "D40, D41, D42, D48, D49, D50");
                        continue;
                    case 17:
                        AssignConnectingSettlementsToTile(i, "D42, D43, D44, D50, D51, D52");
                        continue;
                    case 18:
                        AssignConnectingSettlementsToTile(i, "D44, D45, D46, D52, D53, D54");
                        continue;
                }
            }
        }

        public void AssignConnectingSettlementsToTile(int TileIndex, string connectingSettlements)
        {
            string[] connectedSettlements = connectingSettlements.Replace(" ", "").Split(",");
            Settlement[] settlements = new Settlement[6];

            for(int i = 0; i < 6; i++)
            {
                string connectedSettlement = connectedSettlements[i];
                //Settlement thisSettlement = Program.game.Settlements[GetSettlementIndex(connectedSettlement)];
                this.Tiles[TileIndex].ConnectedSettlements[i] = this.Settlements[GetSettlementIndex(connectedSettlement)];
            }   

        }
        public int GetStreetIndex(Street street)
        {
            string streetNumber = "";

            foreach (char c in street.Location)
            {
                if (new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }.Contains(c.ToString()))
                {
                    streetNumber += c.ToString();
                }
            }
            return int.Parse(streetNumber) - 1;
        }

        public Settlement[] GetSettlements()
        {
            Settlement[] settlements = this.Settlements;
            return settlements;
        }
        public void ShowMessage(string message, string messageEndTurn, Button woodAmount, Button stoneAmount, Button grainAmount, Button sheepAmount, Button oreAmount, Button knightAmount, Button yearOfPlentyAmount, Button monopolyAmount, Button victoryPointAmount, Button playerName, Button endTurn, Button dice)
        {
            dice.Enabled = false;
            woodAmount.Text = message;
            stoneAmount.Text = message;
            grainAmount.Text = message;
            sheepAmount.Text = message;
            oreAmount.Text = message;
            knightAmount.Text = message;
            yearOfPlentyAmount.Text = message;
            monopolyAmount.Text = message;
            victoryPointAmount.Text = message;
            playerName.Text = message;
            endTurn.Text = messageEndTurn;

        }

        public void UpdatePlayerButtons(Player player, Button woodAmount, Button stoneAmount, Button grainAmount, Button sheepAmount, Button oreAmount, Button knightAmount, Button yearOfPlentyAmount, Button monopolyAmount, Button victoryPointAmount, Button playerName, Button endTurn, Button dice)
        {
            dice.Enabled = true;
            woodAmount.Text = player.Rescources.Wood.ToString();
            stoneAmount.Text = player.Rescources.Stone.ToString();
            grainAmount.Text = player.Rescources.Grain.ToString();
            sheepAmount.Text = player.Rescources.Sheep.ToString();
            oreAmount.Text = player.Rescources.Ore.ToString();
            knightAmount.Text = player.Developments.Knight.ToString();
            victoryPointAmount.Text = player.Developments.VictoryPoint.ToString();
            monopolyAmount.Text = player.Developments.Monopoly.ToString();
            yearOfPlentyAmount.Text = player.Developments.YearOfPlenty.ToString();
            endTurn.Text = "Einde beurt";
            playerName.Text = player.UserName + "\n" + player.Points;

        }
       
        public bool EndGame()
        {
            if(Program.game.Players[0].Points > 9)
            {
                return true;
            }
            return false;
        }

    }
    
}
