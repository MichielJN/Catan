﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.Models
{
    public class Development
    {
        public int VictoryPoint { get; set; } = 0;
        public int RoadBuilding { get; set; } = 0;
        public int Monopoly { get; set; } = 0;
        public int YearOfPlenty { get; set; } = 0;
        public int Knight { get; set; } = 0;

        public Development()
        {

        }
    }
}