using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiCalculator.Models
{
    public class House
    {
        public Room[,] Rooms { get; set; }

        public StatusEnum Status = 0;
    }
}
