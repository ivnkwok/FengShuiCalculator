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
    public class PredictedYearCalculator
    {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\2024House.json");
        House house2024;
        public PredictedYearCalculator()
        {
            string str = File.ReadAllText(path);
            house2024 = JsonConvert.DeserializeObject<House>(str);
        }
        public House GetHouse(int predictedYear)
        {
            House house = new House();
            house.Rooms = new Room[3, 3];
            int difference = predictedYear - 2024;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    house.Rooms[i, j] = new Room();
                    house.Rooms[i, j].LuckyNumbers = new int[1];
                    house.Rooms[i, j].Status = StatusEnum.Good;
                    house.Rooms[i, j].Tag = RoomTagEnum.Average;
                    house.Rooms[i, j].LuckyNumbers[0] = house2024.Rooms[i, j].LuckyNumbers[0] - difference;
                    while (house.Rooms[i, j].LuckyNumbers[0] > 9)
                    {
                        house.Rooms[i, j].LuckyNumbers[0] -= 9;
                    }
                    while (house.Rooms[i, j].LuckyNumbers[0] < 1)
                    {
                        house.Rooms[i, j].LuckyNumbers[0] += 9;
                    }
                }
            }
            return house;
        }
    }
}
