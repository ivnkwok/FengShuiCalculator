using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiCalculator.Models
{
    public class InputData
    {
        public DirectionsEnum Direction {get; set; }
        public DateTime MoveInDate { get; set; }
        public int PredictedYear { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
    }
}
