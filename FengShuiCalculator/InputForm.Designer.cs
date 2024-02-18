namespace FengShuiCalculator
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox directionalDiagram;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.inputFrontDoorDirectionLabel = new System.Windows.Forms.Label();
            this.inputPredictedDateLabel = new System.Windows.Forms.Label();
            this.inputHouseLengthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.inputHouseWidthLabel = new System.Windows.Forms.Label();
            this.moveInDate = new System.Windows.Forms.DateTimePicker();
            this.calculateButton = new System.Windows.Forms.Button();
            this.inputMoveInDateLabel = new System.Windows.Forms.Label();
            this.directionDropdownBox = new System.Windows.Forms.ComboBox();
            this.predictedDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            directionalDiagram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(directionalDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // directionalDiagram
            // 
            directionalDiagram.BackColor = System.Drawing.Color.Transparent;
            directionalDiagram.BackgroundImage = global::FengShuiCalculator.Properties.Resources._24Directions;
            directionalDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            directionalDiagram.Location = new System.Drawing.Point(497, 90);
            directionalDiagram.Name = "directionalDiagram";
            directionalDiagram.Size = new System.Drawing.Size(248, 244);
            directionalDiagram.TabIndex = 4;
            directionalDiagram.TabStop = false;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(222, 213);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(208, 20);
            this.lengthTextBox.TabIndex = 8;
            this.lengthTextBox.Text = "100";
            this.lengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LengthTextBox_KeyPress);
            // 
            // inputFrontDoorDirectionLabel
            // 
            this.inputFrontDoorDirectionLabel.AutoSize = true;
            this.inputFrontDoorDirectionLabel.Location = new System.Drawing.Point(33, 93);
            this.inputFrontDoorDirectionLabel.Name = "inputFrontDoorDirectionLabel";
            this.inputFrontDoorDirectionLabel.Size = new System.Drawing.Size(162, 39);
            this.inputFrontDoorDirectionLabel.TabIndex = 1;
            this.inputFrontDoorDirectionLabel.Text = "Your house\'s &front door direction:\r\n(Use the diagram to \r\nthe right for referenc" +
    "e)";
            // 
            // inputPredictedDateLabel
            // 
            this.inputPredictedDateLabel.AutoSize = true;
            this.inputPredictedDateLabel.Location = new System.Drawing.Point(33, 181);
            this.inputPredictedDateLabel.Name = "inputPredictedDateLabel";
            this.inputPredictedDateLabel.Size = new System.Drawing.Size(145, 13);
            this.inputPredictedDateLabel.TabIndex = 5;
            this.inputPredictedDateLabel.Text = "The year you want to &predict:";
            // 
            // inputHouseLengthLabel
            // 
            this.inputHouseLengthLabel.AutoSize = true;
            this.inputHouseLengthLabel.Location = new System.Drawing.Point(33, 220);
            this.inputHouseLengthLabel.Name = "inputHouseLengthLabel";
            this.inputHouseLengthLabel.Size = new System.Drawing.Size(143, 13);
            this.inputHouseLengthLabel.TabIndex = 7;
            this.inputHouseLengthLabel.Text = "The &length of your house (ft):";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(222, 243);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(208, 20);
            this.widthTextBox.TabIndex = 10;
            this.widthTextBox.Text = "100";
            this.widthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthTextBox_KeyPress);
            // 
            // inputHouseWidthLabel
            // 
            this.inputHouseWidthLabel.AutoSize = true;
            this.inputHouseWidthLabel.Location = new System.Drawing.Point(33, 246);
            this.inputHouseWidthLabel.Name = "inputHouseWidthLabel";
            this.inputHouseWidthLabel.Size = new System.Drawing.Size(139, 13);
            this.inputHouseWidthLabel.TabIndex = 9;
            this.inputHouseWidthLabel.Text = "The &width of your house (ft):";
            // 
            // moveInDate
            // 
            this.moveInDate.Location = new System.Drawing.Point(222, 142);
            this.moveInDate.Name = "moveInDate";
            this.moveInDate.Size = new System.Drawing.Size(208, 20);
            this.moveInDate.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(330, 304);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 30);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // inputMoveInDateLabel
            // 
            this.inputMoveInDateLabel.AutoSize = true;
            this.inputMoveInDateLabel.Location = new System.Drawing.Point(33, 148);
            this.inputMoveInDateLabel.Name = "inputMoveInDateLabel";
            this.inputMoveInDateLabel.Size = new System.Drawing.Size(180, 13);
            this.inputMoveInDateLabel.TabIndex = 3;
            this.inputMoveInDateLabel.Text = "When did you &move into your house:";
            // 
            // directionDropdownBox
            // 
            this.directionDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directionDropdownBox.FormattingEnabled = true;
            this.directionDropdownBox.Items.AddRange(new object[] {
            "N1",
            "N2",
            "N3",
            "NE1",
            "NE2",
            "NE3",
            "E1",
            "E2",
            "E3",
            "SE1",
            "SE2",
            "SE3",
            "S1",
            "S2",
            "S3",
            "SW1",
            "SW2",
            "SW3",
            "W1",
            "W2",
            "W3",
            "NW1",
            "NW2",
            "NW3"});
            this.directionDropdownBox.Location = new System.Drawing.Point(222, 90);
            this.directionDropdownBox.MaxDropDownItems = 24;
            this.directionDropdownBox.Name = "directionDropdownBox";
            this.directionDropdownBox.Size = new System.Drawing.Size(208, 21);
            this.directionDropdownBox.TabIndex = 2;
            // 
            // predictedDate
            // 
            this.predictedDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.predictedDate.FormattingEnabled = true;
            this.predictedDate.Location = new System.Drawing.Point(222, 178);
            this.predictedDate.Name = "predictedDate";
            this.predictedDate.Size = new System.Drawing.Size(208, 21);
            this.predictedDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter House Information";
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Location = new System.Drawing.Point(222, 304);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 30);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(776, 383);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predictedDate);
            this.Controls.Add(this.directionDropdownBox);
            this.Controls.Add(directionalDiagram);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.moveInDate);
            this.Controls.Add(this.inputHouseWidthLabel);
            this.Controls.Add(this.inputHouseLengthLabel);
            this.Controls.Add(this.inputMoveInDateLabel);
            this.Controls.Add(this.inputPredictedDateLabel);
            this.Controls.Add(this.inputFrontDoorDirectionLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feng Shui Calculator";
            ((System.ComponentModel.ISupportInitialize)(directionalDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label inputFrontDoorDirectionLabel;
        private System.Windows.Forms.Label inputPredictedDateLabel;
        private System.Windows.Forms.Label inputHouseLengthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label inputHouseWidthLabel;
        private System.Windows.Forms.DateTimePicker moveInDate;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label inputMoveInDateLabel;
        private System.Windows.Forms.ComboBox directionDropdownBox;
        private System.Windows.Forms.ComboBox predictedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
    }
}