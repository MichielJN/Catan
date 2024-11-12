using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.Models
{
    public class Building
    {
        public Player Owner { get; set; } = new Player();
        public string Location { get; set; }
    }
}
