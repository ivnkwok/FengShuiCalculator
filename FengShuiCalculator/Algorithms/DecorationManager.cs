using FengShuiCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiCalculator.Algorithms
{
    public class DecorationManager
    {
        Dictionary<int, Decorations> decorationDictionary = new Dictionary<int, Decorations>();
        public DecorationManager()
        {
            decorationDictionary = new Dictionary<int, Decorations>()
            {
                {1, new Decorations(){Description = "This room has an affinity for social interactions.", Recommendation = "", LuckQuotient = 0 } },
                {2, new Decorations(){Description = "This room has an affinity for sickness that affects females greatly.", Recommendation = "Recommendation: Place bells in the room.", LuckQuotient = -2} },
                {3, new Decorations(){Description = "This room has an affinity for others talking behind one's back.", Recommendation = "Recommendation: Place a red carpet in the room.", LuckQuotient = -1} },
                {4, new Decorations(){Description = "This room has an affinity for education.", Recommendation = "Recommendation: Place bamboo in the room.", LuckQuotient = 1} },
                {5, new Decorations(){Description = "This room has an affinity for sickness that affects males greatly.", Recommendation = "Recommendation: Place old coins in the room.", LuckQuotient = -2 } },
                {6, new Decorations(){Description = "This room has an affinity for unexpected income.", Recommendation = "", LuckQuotient = 1 } },
                {7, new Decorations(){Description = "This room has an affinity for accidents.", Recommendation = "", LuckQuotient = -1 } },
                {8, new Decorations(){Description = "This room has an affinity for expected income.", Recommendation = "Recommendation: Place a plant in a red pot in the room.", LuckQuotient = 2 } },
                {9, new Decorations(){Description = "This room has an affinity for expected income.", Recommendation = "Recommendation: Place a fruit tree or a red pillow in the room.", LuckQuotient = 2 } },
            };
        }

        public Decorations GetDecorations(int key)
        {
            return decorationDictionary[key];
        }
    }
}
