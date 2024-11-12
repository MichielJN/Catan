using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.Models
{
    public class Player
    {
        public int Id { get; set; } = -1;
        public int Points { get; set; } = 0;
        public string UserName { get; set; } = "-";
        public Development Developments { get; set; } = new Development();
        public Rescources Rescources { get; set; } = new Rescources();

        public int NumberOfStreets { get; set; } = 15;
        public int NumberOfVillages { get; set; } = 5;
        public int NumberOfCities { get; set; } = 4;
        public string PlayerColour { get; set; } = "-";
        public int FirstSettlement { get; set; } = 0;
        public int FirstStreets { set; get; } = 0;


        public Player(string userName, string playerColour)
        {
            UserName = userName;
            PlayerColour = playerColour;
        }
        public Player(string userName)
        {
            UserName = userName;
        }

        public Player()
        {

        }
        public Player(int id, int points, string userName, int numberOfStreets, int numberOfVillages, int numberOfCities, string playerColour, int firstSettlement, int firstStreets)
        {
            Id = id;
            Points = points;
            UserName = userName;
            NumberOfStreets = numberOfStreets;
            NumberOfVillages = numberOfVillages;
            NumberOfCities = numberOfCities;
            PlayerColour = playerColour;
            FirstSettlement = firstSettlement;
            FirstStreets = firstStreets;
        }

    }
}
