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
    public partial class All_players : Form
    {
        public All_players()
        {
            InitializeComponent();
            //foreach(Player player in Program.Dal.GetAllPlayers())
            //{
            //    playerlist.Items.Add(player.Id + "," +player.UserName);
            //}
        }

        private void changeplayerbutton_Click(object sender, EventArgs e)
        {
            //if (playerlist.SelectedIndex != -1)
            //{
            //    string[] idSeperator = playerlist.Text.Split(",");
            //    Player player = Program.Dal.GetPlayerById(int.Parse(idSeperator[0]));
            //    player.UserName = changeplayerinputtextbox.Text;
            //    Program.Dal.UpdatePlayer(player);
            //    playerlist.Items.Clear();
            //    foreach (Player _player in Program.Dal.GetAllPlayers())
            //    {
            //        playerlist.Items.Add(_player.Id + "," + _player.UserName);
            //    }
            //}
        }

        private void deleteplayerbutton_Click(object sender, EventArgs e)
        {
            //if (playerlist.SelectedIndex != -1)
            //{
            //    string[] idSeperator = playerlist.Text.Split(",");
            //    Program.Dal.DeletePlayer(Program.Dal.GetPlayerById(int.Parse(idSeperator[0])));
            //    playerlist.Items.Clear();
            //    foreach (Player player in Program.Dal.GetAllPlayers())
            //    {
            //        playerlist.Items.Add(player.Id + "," + player.UserName);
            //    }
            //}
        }
    }
}
