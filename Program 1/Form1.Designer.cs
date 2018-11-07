namespace Program_1
{
    partial class paintJobForm
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
            this.squareFeetInput = new System.Windows.Forms.TextBox();
            this.coatInput = new System.Windows.Forms.TextBox();
            this.coatNumberLabel = new System.Windows.Forms.Label();
            this.paintPerGallonLabel = new System.Windows.Forms.Label();
            this.paintPerGallonInput = new System.Windows.Forms.TextBox();
            this.totalSquareFeetLabel = new System.Windows.Forms.Label();
            this.totalSquareFeetOutput = new System.Windows.Forms.Label();
            this.gallonsRequiredLabel = new System.Windows.Forms.Label();
            this.gallonsRequiredOutput = new System.Windows.Forms.Label();
            this.laborRequiredLabel = new System.Windows.Forms.Label();
            this.laborRequiredOutput = new System.Windows.Forms.Label();
            this.totalPaintCostLabel = new System.Windows.Forms.Label();
            this.totalPaintCostOutput = new System.Windows.Forms.Label();
            this.totalLaborCostLabel = new System.Windows.Forms.Label();
            this.totalLaborCostOutput = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.squareFeetLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalsGroupBox = new System.Windows.Forms.GroupBox();
            this.redRadio = new System.Windows.Forms.RadioButton();
            this.blueRadio = new System.Windows.Forms.RadioButton();
            this.greenRadio = new System.Windows.Forms.RadioButton();
            this.yellowRadio = new System.Windows.Forms.RadioButton();
            this.noneRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.totalsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // squareFeetInput
            // 
            this.squareFeetInput.Location = new System.Drawing.Point(432, 29);
            this.squareFeetInput.Margin = new System.Windows.Forms.Padding(6);
            this.squareFeetInput.Name = "squareFeetInput";
            this.squareFeetInput.Size = new System.Drawing.Size(196, 31);
            this.squareFeetInput.TabIndex = 1;
            // 
            // coatInput
            // 
            this.coatInput.Location = new System.Drawing.Point(432, 100);
            this.coatInput.Margin = new System.Windows.Forms.Padding(6);
            this.coatInput.Name = "coatInput";
            this.coatInput.Size = new System.Drawing.Size(196, 31);
            this.coatInput.TabIndex = 3;
            // 
            // coatNumberLabel
            // 
            this.coatNumberLabel.AutoSize = true;
            this.coatNumberLabel.Location = new System.Drawing.Point(59, 106);
            this.coatNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.coatNumberLabel.Name = "coatNumberLabel";
            this.coatNumberLabel.Size = new System.Drawing.Size(342, 25);
            this.coatNumberLabel.TabIndex = 2;
            this.coatNumberLabel.Text = "Enter the desired number of coats:";
            // 
            // paintPerGallonLabel
            // 
            this.paintPerGallonLabel.AutoSize = true;
            this.paintPerGallonLabel.Location = new System.Drawing.Point(65, 177);
            this.paintPerGallonLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.paintPerGallonLabel.Name = "paintPerGallonLabel";
            this.paintPerGallonLabel.Size = new System.Drawing.Size(336, 25);
            this.paintPerGallonLabel.TabIndex = 4;
            this.paintPerGallonLabel.Text = "Enter the price of paint per gallon:";
            // 
            // paintPerGallonInput
            // 
            this.paintPerGallonInput.Location = new System.Drawing.Point(432, 171);
            this.paintPerGallonInput.Margin = new System.Windows.Forms.Padding(6);
            this.paintPerGallonInput.Name = "paintPerGallonInput";
            this.paintPerGallonInput.Size = new System.Drawing.Size(196, 31);
            this.paintPerGallonInput.TabIndex = 5;
            // 
            // totalSquareFeetLabel
            // 
            this.totalSquareFeetLabel.AutoSize = true;
            this.totalSquareFeetLabel.Location = new System.Drawing.Point(714, 35);
            this.totalSquareFeetLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalSquareFeetLabel.Name = "totalSquareFeetLabel";
            this.totalSquareFeetLabel.Size = new System.Drawing.Size(190, 25);
            this.totalSquareFeetLabel.TabIndex = 7;
            this.totalSquareFeetLabel.Text = "Total Square Feet:";
            // 
            // totalSquareFeetOutput
            // 
            this.totalSquareFeetOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSquareFeetOutput.Location = new System.Drawing.Point(938, 25);
            this.totalSquareFeetOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalSquareFeetOutput.Name = "totalSquareFeetOutput";
            this.totalSquareFeetOutput.Size = new System.Drawing.Size(198, 42);
            this.totalSquareFeetOutput.TabIndex = 8;
            this.totalSquareFeetOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonsRequiredLabel
            // 
            this.gallonsRequiredLabel.AutoSize = true;
            this.gallonsRequiredLabel.Location = new System.Drawing.Point(656, 106);
            this.gallonsRequiredLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gallonsRequiredLabel.Name = "gallonsRequiredLabel";
            this.gallonsRequiredLabel.Size = new System.Drawing.Size(253, 25);
            this.gallonsRequiredLabel.TabIndex = 9;
            this.gallonsRequiredLabel.Text = "Gallons of paint required:";
            // 
            // gallonsRequiredOutput
            // 
            this.gallonsRequiredOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsRequiredOutput.Location = new System.Drawing.Point(938, 94);
            this.gallonsRequiredOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gallonsRequiredOutput.Name = "gallonsRequiredOutput";
            this.gallonsRequiredOutput.Size = new System.Drawing.Size(198, 42);
            this.gallonsRequiredOutput.TabIndex = 10;
            this.gallonsRequiredOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborRequiredLabel
            // 
            this.laborRequiredLabel.AutoSize = true;
            this.laborRequiredLabel.Location = new System.Drawing.Point(670, 177);
            this.laborRequiredLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.laborRequiredLabel.Name = "laborRequiredLabel";
            this.laborRequiredLabel.Size = new System.Drawing.Size(238, 25);
            this.laborRequiredLabel.TabIndex = 11;
            this.laborRequiredLabel.Text = "Hours of labor required:";
            // 
            // laborRequiredOutput
            // 
            this.laborRequiredOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborRequiredOutput.Location = new System.Drawing.Point(938, 167);
            this.laborRequiredOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.laborRequiredOutput.Name = "laborRequiredOutput";
            this.laborRequiredOutput.Size = new System.Drawing.Size(198, 42);
            this.laborRequiredOutput.TabIndex = 12;
            this.laborRequiredOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPaintCostLabel
            // 
            this.totalPaintCostLabel.AutoSize = true;
            this.totalPaintCostLabel.Location = new System.Drawing.Point(12, 40);
            this.totalPaintCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalPaintCostLabel.Name = "totalPaintCostLabel";
            this.totalPaintCostLabel.Size = new System.Drawing.Size(154, 26);
            this.totalPaintCostLabel.TabIndex = 0;
            this.totalPaintCostLabel.Text = "Cost of paint:";
            this.totalPaintCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPaintCostOutput
            // 
            this.totalPaintCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPaintCostOutput.Location = new System.Drawing.Point(216, 38);
            this.totalPaintCostOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalPaintCostOutput.Name = "totalPaintCostOutput";
            this.totalPaintCostOutput.Size = new System.Drawing.Size(198, 35);
            this.totalPaintCostOutput.TabIndex = 1;
            this.totalPaintCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLaborCostLabel
            // 
            this.totalLaborCostLabel.AutoSize = true;
            this.totalLaborCostLabel.Location = new System.Drawing.Point(12, 85);
            this.totalLaborCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalLaborCostLabel.Name = "totalLaborCostLabel";
            this.totalLaborCostLabel.Size = new System.Drawing.Size(155, 26);
            this.totalLaborCostLabel.TabIndex = 2;
            this.totalLaborCostLabel.Text = "Cost of labor:";
            // 
            // totalLaborCostOutput
            // 
            this.totalLaborCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLaborCostOutput.Location = new System.Drawing.Point(216, 83);
            this.totalLaborCostOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalLaborCostOutput.Name = "totalLaborCostOutput";
            this.totalLaborCostOutput.Size = new System.Drawing.Size(198, 35);
            this.totalLaborCostOutput.TabIndex = 3;
            this.totalLaborCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(42, 127);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(122, 26);
            this.totalCostLabel.TabIndex = 4;
            this.totalCostLabel.Text = "Total cost:";
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutput.Location = new System.Drawing.Point(216, 127);
            this.totalCostOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(198, 35);
            this.totalCostOutput.TabIndex = 5;
            this.totalCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // squareFeetLabel
            // 
            this.squareFeetLabel.AutoSize = true;
            this.squareFeetLabel.Location = new System.Drawing.Point(15, 35);
            this.squareFeetLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.squareFeetLabel.Name = "squareFeetLabel";
            this.squareFeetLabel.Size = new System.Drawing.Size(386, 25);
            this.squareFeetLabel.TabIndex = 0;
            this.squareFeetLabel.Text = "Enter the square feet you wish to paint:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(71, 479);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 44);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(358, 479);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 44);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalsGroupBox
            // 
            this.totalsGroupBox.Controls.Add(this.totalPaintCostLabel);
            this.totalsGroupBox.Controls.Add(this.totalPaintCostOutput);
            this.totalsGroupBox.Controls.Add(this.totalLaborCostOutput);
            this.totalsGroupBox.Controls.Add(this.totalCostOutput);
            this.totalsGroupBox.Controls.Add(this.totalLaborCostLabel);
            this.totalsGroupBox.Controls.Add(this.totalCostLabel);
            this.totalsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsGroupBox.Location = new System.Drawing.Point(658, 304);
            this.totalsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.totalsGroupBox.Name = "totalsGroupBox";
            this.totalsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.totalsGroupBox.Size = new System.Drawing.Size(490, 219);
            this.totalsGroupBox.TabIndex = 13;
            this.totalsGroupBox.TabStop = false;
            this.totalsGroupBox.Text = "Totals";
            this.totalsGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // redRadio
            // 
            this.redRadio.AutoSize = true;
            this.redRadio.Location = new System.Drawing.Point(70, 269);
            this.redRadio.Name = "redRadio";
            this.redRadio.Size = new System.Drawing.Size(82, 29);
            this.redRadio.TabIndex = 15;
            this.redRadio.TabStop = true;
            this.redRadio.Text = "Red";
            this.redRadio.UseVisualStyleBackColor = true;
            this.redRadio.CheckedChanged += new System.EventHandler(this.redRadio_CheckedChanged);
            // 
            // blueRadio
            // 
            this.blueRadio.AutoSize = true;
            this.blueRadio.Location = new System.Drawing.Point(70, 304);
            this.blueRadio.Name = "blueRadio";
            this.blueRadio.Size = new System.Drawing.Size(86, 29);
            this.blueRadio.TabIndex = 16;
            this.blueRadio.TabStop = true;
            this.blueRadio.Text = "Blue";
            this.blueRadio.UseVisualStyleBackColor = true;
            this.blueRadio.CheckedChanged += new System.EventHandler(this.blueRadio_CheckedChanged);
            // 
            // greenRadio
            // 
            this.greenRadio.AutoSize = true;
            this.greenRadio.Location = new System.Drawing.Point(70, 339);
            this.greenRadio.Name = "greenRadio";
            this.greenRadio.Size = new System.Drawing.Size(102, 29);
            this.greenRadio.TabIndex = 17;
            this.greenRadio.TabStop = true;
            this.greenRadio.Text = "Green";
            this.greenRadio.UseVisualStyleBackColor = true;
            this.greenRadio.CheckedChanged += new System.EventHandler(this.greenRadio_CheckedChanged);
            // 
            // yellowRadio
            // 
            this.yellowRadio.AutoSize = true;
            this.yellowRadio.Location = new System.Drawing.Point(70, 374);
            this.yellowRadio.Name = "yellowRadio";
            this.yellowRadio.Size = new System.Drawing.Size(107, 29);
            this.yellowRadio.TabIndex = 18;
            this.yellowRadio.TabStop = true;
            this.yellowRadio.Text = "Yellow";
            this.yellowRadio.UseVisualStyleBackColor = true;
            this.yellowRadio.CheckedChanged += new System.EventHandler(this.yellowRadio_CheckedChanged);
            // 
            // noneRadio
            // 
            this.noneRadio.AutoSize = true;
            this.noneRadio.Location = new System.Drawing.Point(70, 409);
            this.noneRadio.Name = "noneRadio";
            this.noneRadio.Size = new System.Drawing.Size(219, 29);
            this.noneRadio.TabIndex = 19;
            this.noneRadio.TabStop = true;
            this.noneRadio.Text = "None of the above";
            this.noneRadio.UseVisualStyleBackColor = true;
            this.noneRadio.CheckedChanged += new System.EventHandler(this.noneRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Which color would you like to use to paint?";
            // 
            // paintJobForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1172, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noneRadio);
            this.Controls.Add(this.yellowRadio);
            this.Controls.Add(this.greenRadio);
            this.Controls.Add(this.blueRadio);
            this.Controls.Add(this.redRadio);
            this.Controls.Add(this.paintPerGallonInput);
            this.Controls.Add(this.coatInput);
            this.Controls.Add(this.squareFeetInput);
            this.Controls.Add(this.totalsGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.squareFeetLabel);
            this.Controls.Add(this.laborRequiredOutput);
            this.Controls.Add(this.laborRequiredLabel);
            this.Controls.Add(this.gallonsRequiredOutput);
            this.Controls.Add(this.gallonsRequiredLabel);
            this.Controls.Add(this.totalSquareFeetOutput);
            this.Controls.Add(this.totalSquareFeetLabel);
            this.Controls.Add(this.paintPerGallonLabel);
            this.Controls.Add(this.coatNumberLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "paintJobForm";
            this.Text = "Program 1";
            this.totalsGroupBox.ResumeLayout(false);
            this.totalsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox squareFeetInput;
        private System.Windows.Forms.TextBox coatInput;
        private System.Windows.Forms.Label coatNumberLabel;
        private System.Windows.Forms.Label paintPerGallonLabel;
        private System.Windows.Forms.TextBox paintPerGallonInput;
        private System.Windows.Forms.Label totalSquareFeetLabel;
        private System.Windows.Forms.Label totalSquareFeetOutput;
        private System.Windows.Forms.Label gallonsRequiredLabel;
        private System.Windows.Forms.Label gallonsRequiredOutput;
        private System.Windows.Forms.Label laborRequiredLabel;
        private System.Windows.Forms.Label laborRequiredOutput;
        private System.Windows.Forms.Label totalPaintCostLabel;
        private System.Windows.Forms.Label totalPaintCostOutput;
        private System.Windows.Forms.Label totalLaborCostLabel;
        private System.Windows.Forms.Label totalLaborCostOutput;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label squareFeetLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox totalsGroupBox;
        private System.Windows.Forms.RadioButton redRadio;
        private System.Windows.Forms.RadioButton blueRadio;
        private System.Windows.Forms.RadioButton greenRadio;
        private System.Windows.Forms.RadioButton yellowRadio;
        private System.Windows.Forms.RadioButton noneRadio;
        private System.Windows.Forms.Label label1;
    }
}

