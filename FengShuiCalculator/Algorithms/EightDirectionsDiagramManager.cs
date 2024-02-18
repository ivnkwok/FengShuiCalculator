using FengShuiCalculator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiCalculator.Algorithms
{
    public class EightDirectionsDiagramManager
    {
        string dataFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\OrdinalDiagramData.json");
        Diagram diagram;

        public EightDirectionsDiagramManager()
        {
            string str = File.ReadAllText(dataFile);
            diagram = JsonConvert.DeserializeObject<Diagram>(str);
        }

        public House GetHouse(DirectionsEnum direction)
        {
            var key = direction.ToString().Substring(0, direction.ToString().Length-1);
            House house;

            if (!diagram.Houses.TryGetValue(key, out house))
            {
                return null;
            }

            return house;
        }
    }
}
