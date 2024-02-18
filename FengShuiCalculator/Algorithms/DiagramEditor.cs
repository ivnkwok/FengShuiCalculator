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
    public class DiagramEditor
    { 
        string path1984 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\MoveInDiagramData1984-2003.json");
        string path2004 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\MoveInDiagramData2004-2023.json");
        Diagram diagram1984, diagram2004;
        public DiagramEditor()
        {
            string str = File.ReadAllText(path1984);
            diagram1984 = JsonConvert.DeserializeObject<Diagram>(str);
            str = File.ReadAllText(path2004);
            diagram2004 = JsonConvert.DeserializeObject<Diagram>(str);
        }

        public void AddStatus()
        {
            Dictionary<string, int> Best = new Dictionary<string, int>()
        {
            {"NW1", 0 },
            {"W2", 0 },
            {"W3", 0 },
            {"SE1", 0 },
            {"E2", 0 },
            {"E3", 0 }
        };
            Dictionary<string, int> Good = new Dictionary<string, int>()
        {
            {"N1", 0 },
            {"N2", 0 },
            {"N3", 0 },
            {"NE1", 0 },
            {"NE2", 0 },
            {"NE3", 0 },
            {"S1", 0 },
            {"S2", 0 },
            {"S3", 0 },
            {"SW1", 0 },
            {"SW2", 0 },
            {"SW3", 0 },
        };
            Dictionary<string, int> Poor = new Dictionary<string, int>()
        {
            {"NW2", 0 },
            {"NW3", 0 },
            {"W1", 0 },
            {"E1", 0 },
            {"SE2", 0 },
            {"SE3", 0 }
        };
            foreach (KeyValuePair<string, House> pair in diagram2004.Houses)
            {
                if (Poor.ContainsKey(pair.Key))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            pair.Value.Rooms[i, j].Status = StatusEnum.Poor;
                        }
                    }
                }
                if (Good.ContainsKey(pair.Key))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            pair.Value.Rooms[i, j].Status = StatusEnum.Good;
                        }
                    }
                }
                if (Best.ContainsKey(pair.Key))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            pair.Value.Rooms[i, j].Status = StatusEnum.Best;
                        }
                    }
                }
            }
            string str = JsonConvert.SerializeObject(diagram2004);
        }
    }
}
