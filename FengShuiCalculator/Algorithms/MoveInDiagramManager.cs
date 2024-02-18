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
    public class MoveInDiagramManager
    {
        string path1984 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\MoveInDiagramData1984-2003.json");
        string path2004 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\MoveInDiagramData2004-2023.json");
        string path2024 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\MoveInDiagramData2024-2043.json");
        Diagram diagram1984, diagram2004, diagram2024;

        public MoveInDiagramManager()
        {
            string str = File.ReadAllText(path1984);
            diagram1984 = JsonConvert.DeserializeObject<Diagram>(str);
            str = File.ReadAllText(path2004);
            diagram2004 = JsonConvert.DeserializeObject<Diagram>(str);
            str = File.ReadAllText(path2024);
            diagram2024 = JsonConvert.DeserializeObject<Diagram>(str);
        }

        public House GetHouse(DirectionsEnum direction, DateTime moveInDate)
        {
            var key = direction.ToString();
            House house;
            if (1984 <= moveInDate.Year && moveInDate.Year <= 2003)
            {
                if (!diagram1984.Houses.TryGetValue(key, out house))
                {
                    return null;
                }
                return house;
            }
            else if (2004 <= moveInDate.Year && moveInDate.Year <= 2023)
            {
                if (!diagram2004.Houses.TryGetValue(key, out house))
                {
                    return null;
                }
                return house;
            }
            else if (2024 <= moveInDate.Year && moveInDate.Year <= 2043)
            {
                if (!diagram2024.Houses.TryGetValue(key, out house))
                {
                    return null;
                }
                return house;
            }
            return null;
        }
    }
}
