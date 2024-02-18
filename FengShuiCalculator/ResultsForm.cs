using FengShuiCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FengShuiCalculator
{
    public partial class ResultsForm : Form
    {
        public static string TempFilePrefix = "tempResult_";

        public static string ResultFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Results");
        public static string TempFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Temp");

        string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template\\ResultTemplate.html");
        string tempFilePath = "";
        public ResultsForm()
        {
            InitializeComponent();
        }

        public void GenerateResult(House house, InputData inputData)
        {
            string html = File.ReadAllText(templatePath);

            html = html.Replace("[direction]", inputData.Direction.ToString());
            html = html.Replace("[moveInDate]", inputData.MoveInDate.ToString("yyyy-MM-dd"));
            html = html.Replace("[predictedYear]", inputData.PredictedYear.ToString());
            html = html.Replace("[houseWidth]", inputData.Width.ToString());
            html = html.Replace("[houseLength]", inputData.Length.ToString());
            html = html.Replace("[houseSummary]", HouseSummary(house));

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    html = html.Replace(string.Format("[roomMessage{0}{1}]", i, j), house.Rooms[i, j].Decoration.Description);
                    html = html.Replace(string.Format("[recommendation{0}{1}]", i, j), house.Rooms[i, j].Decoration.Recommendation);
                    html = html.Replace(string.Format("[roomStyle{0}{1}]", i, j), RoomStatusToColor(house.Rooms[i,j]) + DimensionChecker(inputData.Length, inputData.Width));
                }
            }

            Directory.CreateDirectory(TempFolder);

            tempFilePath = Path.Combine(TempFolder, TempFilePrefix + Guid.NewGuid());

            File.WriteAllText(tempFilePath, html);

            var uri = new Uri(tempFilePath);
            webBrowser.Url = uri;
            this.ShowDialog();
        }

        public string RoomStatusToColor(Room room)
        {
            if ((int)room.Status == -2)
            {
                return "background-color: red;";
            }

            if ((int)room.Status == -1)
            {
                return "background-color: lightcoral;";
            }

            if ((int)room.Status == 1)
            {
                return "background-color: lightgreen;";
            }

            if ((int)room.Status == 2)
            {
                return "background-color: lawngreen;";
            }

            return "";
        }

        public string DimensionChecker(int length, int width)
        {
            if (length < width)
            {
                return "width: 75pt; height: 50pt; ";
            }

            if (length > width)
            {
                return "width: 50pt; height: 75pt; ";
            }

            return "width: 50pt; height: 50pt; ";
        }

        public string HouseSummary(House house)
        {
            if (house.Status == StatusEnum.Best)
            {
                return "Your house has the best luck! It is endowed with great wealth and health.";
            }
            if (house.Status == StatusEnum.Good)
            {
                return "Your house has good luck! It is endowed with good wealth and health.";
            }
            return "Your house has average luck. It is endowed with average wealth and health.";
        }

        public void LoadResult(string path)
        {
            var uri = new Uri(path);
            webBrowser.Url = uri;
            this.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(ResultFolder);
            saveFileDialog.InitialDirectory = ResultFolder;
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    File.Copy(tempFilePath, saveFileDialog.FileName);
                }
            }
        }
    }
}
