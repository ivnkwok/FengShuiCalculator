using FengShuiCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiCalculator.Algorithms
{
    public class RotationCalculator
    {
        public void RotateHouse(House userHouse)
        {
            int m = 3, n = 3;
            int row = 0, col = 0;
            Room prev, curr;

            /* 
            row - Staring row index 
            m - ending row index 
            col - starting column index 
            n - ending column index 
            i - iterator 
            */
            while (row < m && col < n)
            {

                if (row + 1 == m || col + 1 == n)
                    break;

                // Store the first element of next 
                // row, this element will replace  
                // first element of current row 
                prev = userHouse.Rooms[row + 1, col];

                // Move elements of first row  
                // from the remaining rows  
                for (int i = col; i < n; i++)
                {
                    curr = userHouse.Rooms[row, i];
                    userHouse.Rooms[row, i] = prev;
                    prev = curr;
                }
                row++;

                // Move elements of last column 
                // from the remaining columns  
                for (int i = row; i < m; i++)
                {
                    curr = userHouse.Rooms[i, n - 1];
                    userHouse.Rooms[i, n - 1] = prev;
                    prev = curr;
                }
                n--;

                // Move elements of last row  
                // from the remaining rows  
                if (row < m)
                {
                    for (int i = n - 1; i >= col; i--)
                    {
                        curr = userHouse.Rooms[m - 1, i];
                        userHouse.Rooms[m - 1, i] = prev;
                        prev = curr;
                    }
                }
                m--;

                // Move elements of first column 
                // from the remaining rows  
                if (col < n)
                {
                    for (int i = m - 1; i >= row; i--)
                    {
                        curr = userHouse.Rooms[i, col];
                        userHouse.Rooms[i, col] = prev;
                        prev = curr;
                    }
                }
                col++;
            }
        }
        public string GetDirection(DirectionsEnum direction)
        {
            return direction.ToString().Substring(0, direction.ToString().Length - 1);
        }
    }
}
