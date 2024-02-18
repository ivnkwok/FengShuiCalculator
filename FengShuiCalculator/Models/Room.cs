using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiCalculator.Models
{
    public class Room
    {
        public int[] LuckyNumbers { get; set; }
        public RoomTagEnum Tag { get; set; }
        public StatusEnum Status { get; set; }
        public Decorations Decoration { get; set; }
    }
}
