using Catan.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catan
{
    public partial class RobForm : Form
    {
        public RobForm(List<string> playersToRob, Button endTurn)
        {
            InitializeComponent();


            switch (playersToRob.Count)
            {
                case 1:
                    Program.game.InterfaceButtons.EnableStreets(Program.game.StreetButons);
                    Program.game.InterfaceButtons.EnableVillages(Program.game.SettlementButtons);
                    endTurn.Enabled = true;
                    break;
                case 2:
                    player1button.Text = playersToRob[0];
                    player1button.Visible = true;
                    
                    player2button.Text = playersToRob[1];
                    player2button.Visible = true;
                    
                    break;
                case 3:
                    player1button.Text = playersToRob[0];
                    player1button.Visible = true;

                    player2button.Text = playersToRob[1];
                    player2button.Visible = true;

                    player3button.Text = playersToRob[2];
                    player3button.Visible = true;
                    break;

                default:
                    Program.game.InterfaceButtons.EnableStreets(Program.game.StreetButons);
                    Program.game.InterfaceButtons.EnableVillages(Program.game.SettlementButtons);
                    endTurn.Enabled = true;
                    break;
            }
        }
        //Moet nog stelen aan toegevoegd worden
        private void player1button_Click(object sender, EventArgs e)
        {
            foreach(Player player in Program.game.Players)
            {
                if(player.UserName == this.player1button.Text)
                {
                    
                }
            }
        }

        private void player2button_Click(object sender, EventArgs e)
        {

        }

        private void player3button_Click(object sender, EventArgs e)
        {

        }
    }
}
