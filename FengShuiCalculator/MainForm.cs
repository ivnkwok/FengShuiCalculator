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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.ShowDialog(this);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = ResultsForm.ResultFolder;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    var resultForm = new ResultsForm();
                    resultForm.LoadResult(filePath);
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (string file in Directory.GetFiles(ResultsForm.TempFolder, ResultsForm.TempFilePrefix + "*"))
            {
                File.Delete(file);
            }
        }
    }
}
