using FengShuiCalculator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiCalculator.Algorithms
{
    public class Calculator
    {
        EightDirectionsDiagramManager eightDirectionsDiagramManager;
        MoveInDiagramManager moveInDiagramManager;
        PredictedYearCalculator predictedYearCalculator;
        DecorationManager decorationManager;
        RotationCalculator rotationCalculator;
        //DiagramEditor diagramEditor;

        public Calculator()
        {
            eightDirectionsDiagramManager = new EightDirectionsDiagramManager();
            moveInDiagramManager = new MoveInDiagramManager();
            predictedYearCalculator = new PredictedYearCalculator();
            decorationManager = new DecorationManager();
            rotationCalculator = new RotationCalculator();
            //diagramEditor = new DiagramEditor();
        }

        public House Calculate(InputData inputData)
        {
            var eightDirectionHouse = eightDirectionsDiagramManager.GetHouse(inputData.Direction);
            var moveInHouse = moveInDiagramManager.GetHouse(inputData.Direction, inputData.MoveInDate);
            var predictedYearHouse = predictedYearCalculator.GetHouse(inputData.PredictedYear);
            //diagramEditor.AddStatus();
            RotationQuotientEnum rotationQuotient;
            rotationQuotient = (RotationQuotientEnum)Enum.Parse(typeof(RotationQuotientEnum), rotationCalculator.GetDirection(inputData.Direction));
            House userHouse = new House();
            userHouse.Rooms = new Room[3, 3];
            int roomStatus = 0;
            double houseStatus = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    userHouse.Rooms[i, j] = new Room();
                    userHouse.Rooms[i, j].Status = eightDirectionHouse.Rooms[i, j].Status;
                    userHouse.Rooms[i, j].Tag = eightDirectionHouse.Rooms[i, j].Tag;
                    userHouse.Rooms[i, j].LuckyNumbers = new int[3]
                    {   predictedYearHouse.Rooms[i, j].LuckyNumbers[0],
                        moveInHouse.Rooms[i, j].LuckyNumbers[0],
                        moveInHouse.Rooms[i, j].LuckyNumbers[1]
                    };
                    userHouse.Rooms[i, j].Decoration = decorationManager.GetDecorations(userHouse.Rooms[i, j].LuckyNumbers[0]);
                    houseStatus += (double)userHouse.Rooms[i, j].Status;
                    for (int k = 0; k < 3; k++)
                    {
                        roomStatus += decorationManager.GetDecorations(userHouse.Rooms[i, j].LuckyNumbers[k]).LuckQuotient;
                        if (roomStatus < -2)
                        {
                            roomStatus = -2;
                        }
                        if (roomStatus > 2)
                        {
                            roomStatus = 2;
                        }
                    }
                    userHouse.Rooms[i, j].Status = (StatusEnum)roomStatus;
                }
            }
            
            for (int i = 0; i < (int)rotationQuotient; i++)
            {
                rotationCalculator.RotateHouse(userHouse);
            }
            userHouse.Status = (StatusEnum)(Math.Ceiling(houseStatus/9.0));
            return userHouse;
        }
    }
}
