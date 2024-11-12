using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.Models
{
    public class Street : Building
    {
        public int StraightCount { get; set; }
        public List<Street> StreetsNextToThisStreet { get; set; } = new List<Street>();
        public Settlement[] SettlementsConnectedToStreet { get; set; } = new Settlement[2];

        public Street(string location)
        {
            Location = location;
        }
        public Street(string location, string streetsNextToThisStreet, string settlementsConnectedToStreet)
        {
            Location = location;

            string[] connectedStreets = streetsNextToThisStreet.Replace(" ", "").Split(",");
            //string[] villagesConnectedToStreet = settlementsConnectedToStreet.Replace(" ", "").Split(",");
            string[] villagesConnectedToStreet = settlementsConnectedToStreet.Replace(" ", "").Split(",");
            //this.SettlementsConnectedToStreet[0] = new Settlement(villagesConnectedToStreet[0]);
            SettlementsConnectedToStreet[0] = Program.game.Settlements[Program.game.GetSettlementIndex(villagesConnectedToStreet[0])];
            SettlementsConnectedToStreet[1] = Program.game.Settlements[Program.game.GetSettlementIndex(villagesConnectedToStreet[1])];

            foreach (string street in connectedStreets)
            {
                Street _street = new Street(street);
                StreetsNextToThisStreet.Add(_street);
            }

        }
        public void UpdateStreet(Street street)
        {

            for (int i = 0; i < StreetsNextToThisStreet.Count; i++)
            {
                street.StreetsNextToThisStreet[i] = Program.game.Streets[Program.game.GetStreetIndex(street.StreetsNextToThisStreet[i])];
            }
            for (int i = 0; i < 2; i++)
            {
                street.SettlementsConnectedToStreet[i] = Program.game.Settlements[Program.game.GetSettlementIndex(street.SettlementsConnectedToStreet[i].Location)];
            }


        }
        public void UpdateAllStreets()
        {
            foreach (Street street in Program.game.Streets)
            {
                UpdateStreet(street);
            }
        }

    }
}
