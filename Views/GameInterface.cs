using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catan.Models;

namespace Catan
{
    public partial class GameInterface : Form
    {
        private InterfaceButtons interfaceButtons = new InterfaceButtons();
        private int turnPhase = 0;
        private int endTurn = 0;
        private bool robber = false;
        bool startGame = true;

        public GameInterface()
        {
            InitializeComponent();
            Program.game.StreetButons = new Button[72]{ S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17, S18, S19, S20, S21, S22, S23, S24, S25, S26, S27, S28, S29, S30, S31, S32, S33, S34, S35, S36, S37, S38, S39, S40, S41, S42, S43, S44, S45, S46, S47, S48, S49, S50, S51, S52, S53, S54, S55, S56, S57, S58, S59, S60, S61, S62, S63, S64, S65, S66, S67, S68, S69, S70, S71, S72 };
            Program.game.SettlementButtons = new Button[54] { D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31, D32, D33, D34, D35, D36, D37, D38, D39, D40, D41, D42, D43, D44, D45, D46, D47, D48, D49, D50, D51, D52, D53, D54 };

            playername.Text = Program.game.Players[0].UserName;
            
            T1.Text = "(" + Program.game.Tiles[0].Number.ToString() + ")\n" + Program.game.Tiles[0].Rescource;
            T2.Text = "(" + Program.game.Tiles[1].Number.ToString() + ")\n" + Program.game.Tiles[1].Rescource;
            T3.Text = "(" + Program.game.Tiles[2].Number.ToString() + ")\n" + Program.game.Tiles[2].Rescource;
            T4.Text = "(" + Program.game.Tiles[3].Number.ToString() + ")\n" + Program.game.Tiles[3].Rescource;
            T5.Text = "(" + Program.game.Tiles[4].Number.ToString() + ")\n" + Program.game.Tiles[4].Rescource;
            T6.Text = "(" + Program.game.Tiles[5].Number.ToString() + ")\n" + Program.game.Tiles[5].Rescource;
            T7.Text = "(" + Program.game.Tiles[6].Number.ToString() + ")\n" + Program.game.Tiles[6].Rescource;
            T8.Text = "(" + Program.game.Tiles[7].Number.ToString() + ")\n" + Program.game.Tiles[7].Rescource;
            T9.Text = "(" + Program.game.Tiles[8].Number.ToString() + ")\n" + Program.game.Tiles[8].Rescource;
            T10.Text = "(" + Program.game.Tiles[9].Number.ToString() + ")\n" + Program.game.Tiles[9].Rescource;
            T11.Text = "(" + Program.game.Tiles[10].Number.ToString() + ")\n" + Program.game.Tiles[10].Rescource;
            T12.Text = "(" + Program.game.Tiles[11].Number.ToString() + ")\n" + Program.game.Tiles[11].Rescource;
            T13.Text = "(" + Program.game.Tiles[12].Number.ToString() + ")\n" + Program.game.Tiles[12].Rescource;
            T14.Text = "(" + Program.game.Tiles[13].Number.ToString() + ")\n" + Program.game.Tiles[13].Rescource;
            T15.Text = "(" + Program.game.Tiles[14].Number.ToString() + ")\n" + Program.game.Tiles[14].Rescource;
            T16.Text = "(" + Program.game.Tiles[15].Number.ToString() + ")\n" + Program.game.Tiles[15].Rescource;
            T17.Text = "(" + Program.game.Tiles[16].Number.ToString() + ")\n" + Program.game.Tiles[16].Rescource;
            T18.Text = "(" + Program.game.Tiles[17].Number.ToString() + ")\n" + Program.game.Tiles[17].Rescource;
            T19.Text = "(" + Program.game.Tiles[18].Number.ToString() + ")\n" + Program.game.Tiles[18].Rescource;

            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e) //D20
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void GameInterface_Load(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)//D33
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void S1_Click(object sender, EventArgs e)
        {

                ClickStreet(GetSenderNumber(sender) , sender);


        }

        private void D23_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender) , sender);
        }

        private void S72_Click(object sender, EventArgs e)
        {
            ClickStreet(72, sender);
        }

        private void S71_Click(object sender, EventArgs e)
        {
            ClickStreet(71, sender);
        }

        private void S70_Click(object sender, EventArgs e)
        {
            ClickStreet(70, sender);
        }

        private void S69_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S68_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S67_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S66_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S65_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S64_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S63_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S62_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S61_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S60_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S59_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S58_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S57_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S56_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S55_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S54_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S53_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S52_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S51_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S50_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S49_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S48_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S47_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S46_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S45_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S44_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S43_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S42_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void s41_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void s40_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S39_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S38_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S37_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S36_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S35_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S34_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S33_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S32_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S31_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S30_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S29_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S28_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S27_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S26_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S25_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S24_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S23_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S22_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S21_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S20_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S19_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S18_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S17_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S16_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S15_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S14_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S13_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S12_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S11_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S10_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S9_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S8_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S7_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S6_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S5_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S4_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S3_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void S2_Click(object sender, EventArgs e)
        {
            ClickStreet(GetSenderNumber(sender), sender);
        }

        private void D5_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D25_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D31_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D41_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D43_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D42_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D44_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D45_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D19_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D30_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D32_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D34_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D35_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D36_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D21_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D22_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D37_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D24_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D10_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D14_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D13_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D12_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D11_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D9_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D1_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void D18_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D17_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D28_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D29_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D39_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D40_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D48_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D49_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D50_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D51_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D52_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D53_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D54_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D46_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D47_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D38_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D27_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D26_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D16_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D15_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D7_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D6_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D4_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D3_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }

        private void D2_Click(object sender, EventArgs e)
        {
            ClickSettlement(GetSettlementNumber(sender), sender);
        }



        //functions for clicking villages or streets

        public void ClickSettlement(int settlementNumber, object Sender)
        {
            Button button = Sender as Button;
            Settlement settlement = Program.game.Settlements[settlementNumber - 1];
            try
            {
                
                if(Program.game.Players[0].FirstSettlement == 0 & CheckNearbySettlements(settlement) == true)
                {
                    PlaceFirstSettlements(button, settlement, settlementNumber);
                    Program.game.Players[0].Points += 1;
                    Program.game.Players[0].NumberOfVillages -= 1;
                    

                }

                else if(Program.game.Players[0].FirstSettlement == 1 & CheckNearbySettlements(settlement) == true)
                {
                    PlaceFirstSettlements(button, settlement, settlementNumber, woodamount, stoneamount, grainamount, sheepamount, oreamount);
                    Program.game.Players[0].Points += 1;
                    Program.game.Players[0].NumberOfVillages -= 1;
                }

                else if(Program.game.Players[0].FirstSettlement > 1 & CheckNearbySettlements(settlement) == true)
                {
                    if (CheckIsOwnedSettlement(settlement) != true)
                    {
                        bool streetIsConnected = false;
                        foreach (Street street in settlement.StreetsConnectedToThisSettlement)
                        {
                            if (Program.game.Players[0].UserName == street.Owner.UserName)
                            {
                                streetIsConnected = true;
                                break;
                            }
                        }
                        if (Program.game.Players[0].NumberOfVillages > 0)
                        {


                            if (streetIsConnected == true & Program.game.Players[0].Rescources.BuySettlement() == true)
                            {
                                settlement.Owner = Program.game.Players[0];
                                Program.game.Settlements[settlementNumber - 1] = settlement;
                                button.BackColor = System.Drawing.ColorTranslator.FromHtml(settlement.Owner.PlayerColour);
                                Program.game.Players[0].Points += 1;
                                Program.game.Players[0].NumberOfVillages -= 1;
                            }
                        }
                    }
                    else if(CheckIsOwnedSettlement(settlement) == true)
                    {
                        Program.game.Players[0].Points += 1;
                        Program.game.Players[0].NumberOfVillages += 1;
                        Program.game.Players[0].NumberOfCities -= 1;
                        button.Text = "*";
                    }
                }
            }
            catch
            {

            }
        }

        private static void PlaceFirstSettlements(Button button, Settlement settlement, int settlementNumber)
        {
            if (settlement.Owner.UserName == "-")
            {

                
                
                    settlement.Owner = Program.game.Players[0];
                    Program.game.Settlements[settlementNumber - 1] = settlement;
                    button.BackColor = System.Drawing.ColorTranslator.FromHtml(settlement.Owner.PlayerColour);
                    Program.game.Players[0].FirstSettlement += 1;
                    if(Program.game.Players[0].FirstSettlement == 2)
                {
                    Program.game.Players[0].Rescources.GetStartGameRescources(settlement);


                }
                
            }
        }

        private static void PlaceFirstSettlements(Button button, Settlement settlement, int settlementNumber, Button woodAmount, Button stoneAmount, Button grainAmount, Button sheepAmount, Button oreAmount)
        {
            if (settlement.Owner.UserName == "-")
            {



                settlement.Owner = Program.game.Players[0];
                Program.game.Settlements[settlementNumber - 1] = settlement;
                button.BackColor = System.Drawing.ColorTranslator.FromHtml(settlement.Owner.PlayerColour);
                Program.game.Players[0].FirstSettlement += 1;
                if (Program.game.Players[0].FirstSettlement == 2)
                {
                    Program.game.Players[0].Rescources.GetStartGameRescources(settlement);
                    UpdateRescourcesInterface(woodAmount, stoneAmount, grainAmount, sheepAmount, oreAmount);


                }

            }
        }

        private static bool CheckNearbySettlements(Settlement settlement)
        {
            bool noNearbySettlement = true;
            foreach (Settlement village in settlement.DisabledSettlements)
            {
                if (Program.game.Settlements[GetSettlementIndex(village)].Owner.UserName != "-")
                {
                    noNearbySettlement = false;
                }
            }

            return noNearbySettlement;
        }
        public bool CheckIsOwnedSettlement(Settlement settlement)
        {
            bool isSettlement = false;

                if (Program.game.Settlements[GetSettlementIndex(settlement)].Owner.UserName == Program.game.Players[0].UserName)
                {
                    isSettlement = true;
                }


            return isSettlement;
        }

        public void ClickStreet(int streetNumber, object Sender)
        {
            Button button = Sender as Button;
            Street street = Program.game.Streets[streetNumber - 1];

            try
            {



                    if (street.Owner.UserName == "-")
                    {
                        foreach (Settlement settlement in street.SettlementsConnectedToStreet)
                        {
                            GetSettlementIndex(settlement);

                        }


                        if (Program.game.Players[0].FirstStreets == 0 & Program.game.Players[0].FirstSettlement == 1)
                        {
                            PlaceFirstStreets(streetNumber, button, street);
                        Program.game.Players[0].NumberOfStreets -= 1;
                        }
                        else if(Program.game.Players[0].FirstStreets == 1 & Program.game.Players[0].FirstSettlement == 2)
                        {
                            PlaceFirstStreets(streetNumber, button, street);
                        Program.game.Players[0].NumberOfStreets -= 1;
                        this.startGame = false;
                        }
                        else
                        {
                            CalculateWheterStreetCanBeBuiltNotBegin(streetNumber, button, street);

                        }
                    }
                


            }
            catch
            {
                
            }

          


        }

        private void PlaceFirstStreets(int streetNumber, Button button, Street street)
        {

            bool villageOfPlayerConnectedToStreet = false;
            foreach(Settlement settlement in street.SettlementsConnectedToStreet)
            {
                if (Program.game.Settlements[GetSettlementIndex(settlement)].Owner.UserName == Program.game.Players[0].UserName)
                {
                    villageOfPlayerConnectedToStreet = true;
                }
            }

            if (villageOfPlayerConnectedToStreet == true)
            {
                

                street.Owner = Program.game.Players[0];
                Program.game.Streets[streetNumber - 1] = street;
                button.BackColor = System.Drawing.ColorTranslator.FromHtml(street.Owner.PlayerColour);
                Player player = Program.game.Players[0];
                player.FirstStreets += 1;
                bool lastPlayer = true;
                foreach (Player _player in Program.game.Players)
                {
                    if (_player.FirstStreets != 1 | _player.FirstSettlement != 1)
                    {
                        lastPlayer = false;
                    }
                }

                bool firstPlayer = true;
                foreach (Player _player in Program.game.Players)
                {
                    if (_player.FirstStreets != 2 & _player.FirstSettlement != 2)
                    {
                        firstPlayer = false;
                    }
                }

                
                if(firstPlayer == true)
                {
                    ReversePlayersStartGame();
                }
                else if(lastPlayer == true)
                {
                    ReversePlayersStartGame();
                    this.endTurn = 1;
                }
                else if (lastPlayer == false)
                {
                    Program.game.Players.RemoveAt(0);
                    Program.game.Players.Add(player);
                    playername.Text = Program.game.Players[0].UserName;
                }
            }
        }

        private static void ReversePlayersStartGame()
        {
            List<Player> reverse = Program.game.Players;
            Player finalPlayer = reverse[0];
            reverse.RemoveAt(0);
            reverse.Reverse();
            reverse.Insert(0, finalPlayer);
        }

        public void CalculateWheterStreetCanBeBuiltNotBegin(int streetNumber, Button button, Street street)
        {
            street.UpdateStreet(street);
            foreach (Street _street in street.StreetsNextToThisStreet)
            {

                if (Program.game.Streets[GetStreetIndex(_street)].Owner.UserName == Program.game.Players[0].UserName)
                {
                    //return _street.Owner.PlayerColour;
                    if (Program.game.Players[0].Rescources.BuyStreet() == true)
                    {
                        street.Owner = Program.game.Players[0];
                        Program.game.Streets[streetNumber - 1] = street;
                        button.BackColor = System.Drawing.ColorTranslator.FromHtml(_street.Owner.PlayerColour);
                        Program.game.Players[0].NumberOfStreets -= 1;
                    }
                }
            }
        }

        private static int GetStreetIndex(Street street)
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

        private static int GetSettlementIndex(Settlement settlement)
        {
            string settlementNumber = "";

            foreach (char c in settlement.Location)
            {
                if (new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }.Contains(c.ToString()))
                {
                    settlementNumber += c.ToString();
                }
            }
            return int.Parse(settlementNumber) - 1;
        }

        private static int GetSettlementNumber(Object sender)
        {
            Button button = sender as Button;

            string settlementNumber = "";

            foreach (char c in button.Name)
            {
                if (new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }.Contains(c.ToString()))
                {
                    settlementNumber += c.ToString();
                }
            }
            return int.Parse(settlementNumber);
        }

        private static int GetSenderNumber(Object sender)
        {
            Button button = sender as Button;

            string streetNumber = "";

            foreach (char c in button.Name)
            {
                if (new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }.Contains(c.ToString()))
                {
                    streetNumber += c.ToString();
                }
            }
            return int.Parse(streetNumber);
        }

        private static void UpdateRescourcesInterface(Button woodAmount, Button stoneAmount, Button grainAmount, Button sheepAmount, Button oreAmount)
        {
            woodAmount.Text = Program.game.Players[0].Rescources.Wood.ToString();
            stoneAmount.Text = Program.game.Players[0].Rescources.Stone.ToString();
            grainAmount.Text = Program.game.Players[0].Rescources.Grain.ToString();
            sheepAmount.Text = Program.game.Players[0].Rescources.Sheep.ToString();
            oreAmount.Text = Program.game.Players[0].Rescources.Ore.ToString();
        }

        private void Dice_Click(object sender, EventArgs e)
        {
            if (this.turnPhase == 0 & this.startGame == false)
            {
                this.turnPhase = 1;
                Dice.Text = Program.game.Dice.CheckRescourcesDiceValue(Program.game.Dice.ThrowDiceRegularGame());
                if(Dice.Text == "7")
                {
                    this.robber = true;
                    endturnbutton.Enabled = false;
                    interfaceButtons.DisableStreets(Program.game.StreetButons);
                    interfaceButtons.DisableVillages(Program.game.SettlementButtons);
                    Program.game.ShowMessage("", Program.game.Players[0].UserName + "Verplaats de struikrover!\nKlik op een grondstoftegel!", woodamount, stoneamount, grainamount, sheepamount, oreamount, knightamountbutton, yearofplentyamountbutton, monopoloyamountbutton, victorypointamountbutton, playername, endturnbutton, Dice);
                }
                UpdateRescourcesInterface(woodamount, stoneamount, grainamount, sheepamount, oreamount);
                //Dice.Text = Program.game.Dice.ThrowDiceRegularGame().ToString();
            }
        }

        private void endturnbutton_Click(object sender, EventArgs e)
        {
            if (this.endTurn == 1 & this.turnPhase == 1)
            {
                if (this.startGame == false)
                {
                    
                    Player player = Program.game.Players[0];
                    Program.game.Players.RemoveAt(0);
                    Program.game.Players.Add(player);
                    Program.game.ShowMessage("", Program.game.Players[0].UserName + "\nis er klaar voor!", woodamount, stoneamount, grainamount, sheepamount, oreamount, knightamountbutton, yearofplentyamountbutton, monopoloyamountbutton, victorypointamountbutton, playername, endturnbutton, Dice);
                    this.endTurn = 2;
                }
            }
            else if(this.endTurn == 2)
            {
                Dice.Text = "Gooi dobbelsteen";
                this.endTurn = 1;
                this.turnPhase = 0;
                Program.game.UpdatePlayerButtons(Program.game.Players[0], woodamount, stoneamount, grainamount, sheepamount, oreamount, knightamountbutton, yearofplentyamountbutton, monopoloyamountbutton, victorypointamountbutton, playername, endturnbutton, Dice);
            }
        }
        private void T1_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }
        
        private void T2_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T3_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T4_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T5_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T6_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T7_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T8_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T9_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T10_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T11_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T12_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T13_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T14_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T15_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T16_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T17_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T18_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        private void T19_Click(object sender, EventArgs e)
        {
            TileClick(sender);
        }

        public void TileClick(Object sender)
        {
            Button button = sender as Button;
            if(this.robber == true & Program.game.Tiles[GetSenderNumber(sender) - 1].Robber == false)
            {
                foreach(Tile tile in Program.game.Tiles)
                {
                    if( tile.Robber == true)
                    {
                        tile.Robber = false;
                        
                        break;
                    }
                }
                Program.game.Tiles[GetSenderNumber(sender) - 1].Robber = true;
                this.robber = false;
                Program.game.UpdatePlayerButtons(Program.game.Players[0], woodamount, stoneamount, grainamount, sheepamount, oreamount, knightamountbutton, yearofplentyamountbutton, monopoloyamountbutton, victorypointamountbutton, playername, endturnbutton, Dice);
                UpdateTiles(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19);
                interfaceButtons.EnableVillages(Program.game.SettlementButtons);
                interfaceButtons.EnableStreets(Program.game.StreetButons);
                endturnbutton.Enabled = true;
            }
        }
        public void UpdateTiles(Button t1, Button t2, Button t3, Button t4, Button t5, Button t6, Button t7, Button t8, Button t9, Button t10, Button t11, Button t12, Button t13, Button t14, Button t15, Button t16, Button t17, Button t18, Button t19)
        {
            if(Program.game.Tiles[GetSenderNumber(t1) - 1].Robber == true)
            {
                t1.Text = "X" + Program.game.Tiles[GetSenderNumber(t1) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t1) - 1].Number + "X";
            }
            else
            {
                t1.Text = Program.game.Tiles[GetSenderNumber(t1) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t1) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t2) - 1].Robber == true)
            {
                t2.Text = "X" + Program.game.Tiles[GetSenderNumber(t2) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t2) - 1].Number + "X";
            }
            else
            {
                t2.Text = Program.game.Tiles[GetSenderNumber(t2) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t2) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t3) - 1].Robber == true)
            {
                t3.Text = "X" + Program.game.Tiles[GetSenderNumber(t3) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t3) - 1].Number + "X";
            }
            else
            {
                t3.Text = Program.game.Tiles[GetSenderNumber(t3) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t3) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t4) - 1].Robber == true)
            {
                t4.Text = "X" + Program.game.Tiles[GetSenderNumber(t4) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t4) - 1].Number + "X";
            }
            else
            {
                t4.Text = Program.game.Tiles[GetSenderNumber(t4) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t4) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t5) - 1].Robber == true)
            {
                t5.Text = "X" + Program.game.Tiles[GetSenderNumber(t5) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t5) - 1].Number + "X";
            }
            else
            {
                t5.Text = Program.game.Tiles[GetSenderNumber(t5) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t5) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t6) - 1].Robber == true)
            {
                t6.Text = "X" + Program.game.Tiles[GetSenderNumber(t6) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t6) - 1].Number + "X";
            }
            else
            {
                t6.Text = Program.game.Tiles[GetSenderNumber(t6) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t6) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t7) - 1].Robber == true)
            {
                t7.Text = "X" + Program.game.Tiles[GetSenderNumber(t7) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t7) - 1].Number + "X";
            }
            else
            {
                t7.Text = Program.game.Tiles[GetSenderNumber(t7) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t7) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t8) - 1].Robber == true)
            {
                t8.Text = "X" + Program.game.Tiles[GetSenderNumber(t8) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t8) - 1].Number + "X";
            }
            else
            {
                t8.Text = Program.game.Tiles[GetSenderNumber(t8) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t8) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t9) - 1].Robber == true)
            {
                t9.Text = "X" + Program.game.Tiles[GetSenderNumber(t9) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t9) - 1].Number + "X";
            }
            else
            {
                t9.Text = Program.game.Tiles[GetSenderNumber(t9) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t9) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t10) - 1].Robber == true)
            {
                t10.Text = "X" + Program.game.Tiles[GetSenderNumber(t10) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t10) - 1].Number + "X";
            }
            else
            {
                t10.Text = Program.game.Tiles[GetSenderNumber(t10) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t10) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t11) - 1].Robber == true)
            {
                t11.Text = "X" + Program.game.Tiles[GetSenderNumber(t11) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t11) - 1].Number + "X";
            }
            else
            {
                t11.Text = Program.game.Tiles[GetSenderNumber(t11) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t11) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t12) - 1].Robber == true)
            {
                t12.Text = "X" + Program.game.Tiles[GetSenderNumber(t12) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t12) - 1].Number + "X";
            }
            else
            {
                t12.Text = Program.game.Tiles[GetSenderNumber(t12) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t12) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t13) - 1].Robber == true)
            {
                t13.Text = "X" + Program.game.Tiles[GetSenderNumber(t13) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t13) - 1].Number + "X";
            }
            else
            {
                t13.Text = Program.game.Tiles[GetSenderNumber(t13) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t13) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t14) - 1].Robber == true)
            {
                t14.Text = "X" + Program.game.Tiles[GetSenderNumber(t14) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t14) - 1].Number + "X";
            }
            else
            {
                t14.Text = Program.game.Tiles[GetSenderNumber(t14) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t14) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t15) - 1].Robber == true)
            {
                t15.Text = "X" + Program.game.Tiles[GetSenderNumber(t15) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t15) - 1].Number + "X";
            }
            else
            {
                t15.Text = Program.game.Tiles[GetSenderNumber(t15) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t15) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t16) - 1].Robber == true)
            {
                t16.Text = "X" + Program.game.Tiles[GetSenderNumber(t16) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t16) - 1].Number + "X";
            }
            else
            {
                t16.Text = Program.game.Tiles[GetSenderNumber(t16) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t16) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t17) - 1].Robber == true)
            {
                t17.Text = "X" + Program.game.Tiles[GetSenderNumber(t17) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t17) - 1].Number + "X";
            }
            else
            {
                t17.Text = Program.game.Tiles[GetSenderNumber(t17) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t17) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t18) - 1].Robber == true)
            {
                t18.Text = "X" + Program.game.Tiles[GetSenderNumber(t18) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t18) - 1].Number + "X";
            }
            else
            {
                t18.Text = Program.game.Tiles[GetSenderNumber(t18) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t18) - 1].Number + ")";
            }
            if (Program.game.Tiles[GetSenderNumber(t19) - 1].Robber == true)
            {
                t19.Text = "X" + Program.game.Tiles[GetSenderNumber(t19) - 1].Rescource + "X\nX" + Program.game.Tiles[GetSenderNumber(t19) - 1].Number + "X";
            }
            else
            {
                t19.Text = Program.game.Tiles[GetSenderNumber(t19) - 1].Rescource + "\n(" + Program.game.Tiles[GetSenderNumber(t19) - 1].Number + ")";
            }
        }
        

    }
}
