using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Player
    {
        public int Id { get; set; } = -1;
        public int Points { get; set; } = 0;
        public string UserName { get; set; } = "-";
        public Development Developments { get; set; } = new Development();
        public List<Settlement> Settlements { get; set;} = new List<Settlement>();
        public Rescources Rescources { get; set; } = new Rescources();

        public int NumberOfStreets { get; set; } = 15;
        public int NumberOfVillages { get; set; } = 5;
        public int NumberOfCities { get; set; } = 4;
        public string PlayerColour { get; set; } = "-";
        public int FirstSettlement { get; set; } = 0;
        public int FirstStreets { set; get; } = 0;


        public Player(string userName, string playerColour)
        {
            this.UserName = userName;
            this.PlayerColour = playerColour;
        }
        public Player(string userName)
        {
            this.UserName = userName;
        }
       
        public Player()
        {

        }
        public Player(int id, int points, string userName, int numberOfStreets, int numberOfVillages, int numberOfCities, string playerColour, int firstSettlement, int firstStreets)
        {
            this.Id = id;
            this.Points = points;
            this.UserName=userName;
            this.NumberOfStreets = numberOfStreets;
            this.NumberOfVillages = numberOfVillages;
            this.NumberOfCities = numberOfCities;
            this.PlayerColour = playerColour;
            this.FirstSettlement = firstSettlement;
            this.FirstStreets = firstStreets;
        }
        
    }
}
