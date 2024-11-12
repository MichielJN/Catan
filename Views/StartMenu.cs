namespace Catan
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerMenu playerMenu = new PlayerMenu();
            playerMenu.Show();
            this.Visible = false;
        }

        private void playersbutton_Click(object sender, EventArgs e)
        {
            All_players all_Players = new All_players();
            all_Players.Show();
        }
    }
}