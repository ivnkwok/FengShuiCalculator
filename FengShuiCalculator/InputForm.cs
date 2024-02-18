using FengShuiCalculator.Algorithms;
using FengShuiCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FengShuiCalculator
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            for (int i = 0; i <= 5; i++)
            {
                predictedDate.Items.Add(DateTime.Now.Year+i);
            }
            predictedDate.Text = DateTime.Now.Year.ToString();
            directionDropdownBox.Text = "NW1";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if ((int)moveInDate.Value.Year < 1984 || (int)moveInDate.Value.Year > 2043)
            {
                MessageBox.Show("Please enter a date from 1984-2043.", "Feng Shui Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (widthTextBox.Text == "" || lengthTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields.", "Feng Shui Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var calculator = new Calculator();
                InputData input = new InputData()
                {
                    Direction = (DirectionsEnum)Enum.Parse(typeof(DirectionsEnum), directionDropdownBox.SelectedItem.ToString()),
                    MoveInDate = moveInDate.Value.Date,
                    PredictedYear = (int)predictedDate.SelectedItem,
                    Width = int.Parse(widthTextBox.Text),
                    Length = int.Parse(lengthTextBox.Text)
                };

                var house = calculator.Calculate(input);

                var resultForm = new ResultsForm();
                resultForm.GenerateResult(house, input);
            }
        }

        private void LengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
