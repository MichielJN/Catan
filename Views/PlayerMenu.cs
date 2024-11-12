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
    public partial class PlayerMenu : Form
    {
        public PlayerMenu()
        {
            InitializeComponent();
            player1textbox.Visible = false;
            player2textbox.Visible = false;
            player3textbox.Visible = false;
            player4textbox.Visible = false;
        }

        private void numberofplayerscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            player1textbox.Visible = false;
            player2textbox.Visible = false;
            player3textbox.Visible = false;
            player4textbox.Visible = false;
            if (numberofplayerscombobox.Text == "3 Players")
            {
                player1textbox.Visible = true;
                player2textbox.Visible = true;
                player3textbox.Visible = true;                
            }
            else//four players
            {
                player1textbox.Visible = true;
                player2textbox.Visible = true;
                player3textbox.Visible = true;
                player4textbox.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numberofplayerscombobox.Text == "3 Players")
            {
                List<Player> players = new List<Player>() {new Player(player1textbox.Text, "Red"),
                new Player(player2textbox.Text, "Blue"),
                new Player(player3textbox.Text, "White")};

                Program.game = new Game(players);
                Program.game.LoadGame();
                GameInterface gameInterface = new GameInterface();
                gameInterface.Visible = true;
 
                foreach(Settlement settlement in Program.game.Settlements)
                {
                    settlement.UpdateSettlement(settlement);
                }
                this.Close();
            }
            else
            {
                List<Player> players = new List<Player>() {new Player(player1textbox.Text, "Red"),
                new Player(player2textbox.Text, "Blue"),
                new Player(player3textbox.Text, "White"),
                new Player(player4textbox.Text, "Black")};

                Program.game = new Game(players);
                Program.game.LoadGame();
                GameInterface gameInterface = new GameInterface();
                gameInterface.Visible = true;
                
                foreach (Settlement settlement in Program.game.Settlements)
                {
                    settlement.UpdateSettlement(settlement);
                }
                this.Close();
            }
        }
    }
}
