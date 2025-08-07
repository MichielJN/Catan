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

        public int CountStreets(List<Street> allStreets, Street street, List<string> visitedStreets, int streetCount, List<(string, int, List<string>)> streetsToRevisit, bool isRevisitedStreet)
        {
            if (street.Owner.UserName == "-" & streetCount == 0)
            {
                return 0;
            }
            List<string> _visitedStreets = new List<string>(visitedStreets);
            _visitedStreets.Add(street.Location);
            List<(string, int, List<string>)> _streetsToRevisit = new List<(string, int, List<string>)>(streetsToRevisit);
            int _streetCount = streetCount + 1;

            if (isRevisitedStreet)
            {
                _streetsToRevisit.RemoveAt(0);
            }

            int amountOfStreetsNextToThisStreet = 0;
            List<Street> ownedNearbyStreets = new List<Street>();

            foreach (Street _street in street.StreetsNextToThisStreet)
            {
                if (_street.Owner.UserName == street.Owner.UserName)
                {
                    amountOfStreetsNextToThisStreet++;
                    ownedNearbyStreets.Add(_street);
                }
            }

            if (ownedNearbyStreets.Count == 0)
            {
                return _streetCount;
            }
            else if (ownedNearbyStreets.Count == 1)
            {
                if (visitedStreets.Contains(ownedNearbyStreets[0].Location))
                {
                    if (_streetsToRevisit.Count == 0)
                    {
                        return _streetCount;
                    }
                    else
                    {
                        Street nextStreet = allStreets.FirstOrDefault(x => x.Location == _streetsToRevisit[0].Item1);
                        return CountStreets(allStreets, nextStreet, _streetsToRevisit[0].Item3, _streetsToRevisit[0].Item2, _streetsToRevisit, true);
                    }
                }
                else
                {
                    return CountStreets(allStreets, ownedNearbyStreets[0], _visitedStreets, _streetCount, _streetsToRevisit, false);
                }
            }
            else if (ownedNearbyStreets.Count > 1)
            {

                Street nextStreet = ownedNearbyStreets[0];
                ownedNearbyStreets.RemoveAt(0);

                List<(string, int, List<string>)> addToStreetsToRevisit = new List<(string, int, List<string>)>();

                foreach (Street _street in ownedNearbyStreets)
                {
                    addToStreetsToRevisit.Add((_street.Location, _streetCount, _visitedStreets));
                    _visitedStreets.Add(_street.Location);
                }
                _streetsToRevisit.AddRange(addToStreetsToRevisit);
                return CountStreets(allStreets, nextStreet, _visitedStreets, _streetCount, _streetsToRevisit, false);
            }

            return _streetCount;

        }
    }
}
