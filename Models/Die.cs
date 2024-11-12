using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.Models
{
    public class Die
    {
        public List<int> DiceHistory { get; set; } = new List<int>();

        public int ThrowDie()
        {
            List<int> diceNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int index = random.Next(0, 6);
                int diceNumber = diceNumbers[index];
                diceNumbers.RemoveAt(index);
                diceNumbers.Insert(random.Next(0, 6), diceNumber);
            }
            DiceHistory.Add(diceNumbers[0]);
            return diceNumbers[0];
        }

        public int ThrowDiceRegularGame()
        {
            foreach (Tile tile in Program.game.Tiles)
            {
                tile.UpdateConnectingVillages(tile);
            }
            return Program.game.Dice.ThrowDie() + Program.game.Dice.ThrowDie();
        }

        public string CheckRescourcesDiceValue(int diceValue)
        {
            foreach (Tile tile in Program.game.Tiles)
            {
                if (tile.Number == diceValue)
                {
                    if (tile.Robber == false)
                    {


                        foreach (Settlement settlement in tile.ConnectedSettlements)
                        {
                            if (settlement.Owner.UserName != "-")
                            {
                                switch (tile.Rescource)
                                {
                                    case "Hout":
                                        if (settlement.Level == 0)
                                        {
                                            CheckOwnedSettlements(settlement, 1, tile.Rescource);
                                        }
                                        else if (settlement.Level == 1)
                                        {
                                            CheckOwnedSettlements(settlement, 2, tile.Rescource);
                                        }
                                        continue;


                                    case "Steen":
                                        if (settlement.Level == 0)
                                        {
                                            CheckOwnedSettlements(settlement, 1, tile.Rescource);
                                        }
                                        else if (settlement.Level == 1)
                                        {
                                            CheckOwnedSettlements(settlement, 2, tile.Rescource);
                                        }
                                        continue;


                                    case "Graan":
                                        if (settlement.Level == 0)
                                        {
                                            CheckOwnedSettlements(settlement, 1, tile.Rescource);
                                        }
                                        else if (settlement.Level == 1)
                                        {
                                            CheckOwnedSettlements(settlement, 2, tile.Rescource);
                                        }
                                        continue;


                                    case "Schaap":
                                        if (settlement.Level == 0)
                                        {
                                            CheckOwnedSettlements(settlement, 1, tile.Rescource);
                                        }
                                        else if (settlement.Level == 1)
                                        {
                                            CheckOwnedSettlements(settlement, 2, tile.Rescource);
                                        }
                                        continue;


                                    case "Erts":
                                        if (settlement.Level == 0)
                                        {
                                            CheckOwnedSettlements(settlement, 1, tile.Rescource);
                                        }
                                        else if (settlement.Level == 1)
                                        {
                                            CheckOwnedSettlements(settlement, 2, tile.Rescource);
                                        }
                                        continue;
                                }
                            }
                        }
                    }
                }
            }
            return diceValue.ToString();
        }

        public void CheckOwnedSettlements(Settlement settlement, int amountOfPoints, string rescource)
        {
            foreach (Player player in Program.game.Players)
            {
                if (settlement.Owner.UserName == player.UserName)
                {
                    if (rescource == "Hout")
                    {
                        player.Rescources.Wood += amountOfPoints;
                    }

                    else if (rescource == "Steen")
                    {
                        player.Rescources.Stone += amountOfPoints;
                    }

                    else if (rescource == "Graan")
                    {
                        player.Rescources.Grain += amountOfPoints;
                    }

                    else if (rescource == "Schaap")
                    {
                        player.Rescources.Sheep += amountOfPoints;
                    }

                    else if (rescource == "Erts")
                    {
                        player.Rescources.Ore += amountOfPoints;
                    }

                }
            }
        }
    }
}
