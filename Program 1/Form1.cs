// C3527
// Due Date 2-14-17
// Program 1 
// CIS 199-75
// This program takes user inputs for the amount of square feet the user wants to paint, the number of coats the user wants to paint, and the price 
// of the paint itself. The program takes these inputs to calculate the total square feet to be painted, the gallons of paint required, the hours of labor
// required, as well as the cost of labor, the cost of paint, and the total overall cost. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Program_1
{
    public partial class paintJobForm : Form
    {
        private const decimal SQUARE_FEET_PER_GALLON = 330; // The square feet that one gallon of paint can cover
        private const decimal LABOR_PER_GALLON = 6; // The hours of labor for each gallon of paint
        private const decimal HOURLY_WAGE = 10.50m; // The hourly wage being paid to workers


        public paintJobForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal squareFeet;      // The square feet needed to be painted
            int numberOfCoats;       // The number of coats of paint
            decimal pricePerGallon;  // The price for each gallon of paint
            decimal totalSquareFeet; // The total amount of square feet needed to be painted
            decimal totalGallons;    // The total amount of gallons of paint required
            decimal totalLabor;      // The hours of labor required
            decimal totalPaintCost;  // The total cost of paint
            decimal totalLaborCost;  // The total cost of labor
            decimal totalCost;       // The total overall cost


            // Get the amount of square feet needed to be painted
            squareFeet = decimal.Parse(squareFeetInput.Text);

            // Get the number of coats needed
            numberOfCoats = int.Parse(coatInput.Text);

            // Get the price per gallon of paint
            if (paintPerGallonInput.Text.Contains("$"))
            {
                pricePerGallon = decimal.Parse(paintPerGallonInput.Text, NumberStyles.Currency);
            }
            else
            {
                pricePerGallon = decimal.Parse(paintPerGallonInput.Text);
            }

            // Calculate the total square feet to be painted
            totalSquareFeet = squareFeet * numberOfCoats;

            // Calculate the total gallons of paint required
            totalGallons = Math.Ceiling(totalSquareFeet / SQUARE_FEET_PER_GALLON);

            // Calculate the number of hours of labor
            totalLabor = totalSquareFeet / SQUARE_FEET_PER_GALLON * LABOR_PER_GALLON;

            // Calculate the total cost of paint
            totalPaintCost = totalGallons * pricePerGallon;

            // Calculate the total cost of labor
            totalLaborCost = totalLabor * HOURLY_WAGE;

            // Calculate the total overall cost 
            totalCost = totalPaintCost + totalLaborCost;

            totalSquareFeetOutput.Text = totalSquareFeet.ToString("n1");

            gallonsRequiredOutput.Text = totalGallons.ToString();

            laborRequiredOutput.Text = totalLabor.ToString("n1");

            totalPaintCostOutput.Text = totalPaintCost.ToString("c");

            totalLaborCostOutput.Text = totalLaborCost.ToString("c");

            totalCostOutput.Text = totalCost.ToString("c");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void redRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; // Changes the form color to red
        }

        private void blueRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue; // Changes the form color to blue
        }

        private void greenRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green; // Changes the form color to green
        }

        private void yellowRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow; // Changes the form color to green
        }

        private void noneRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;    // Changes the form color to default
            MessageBox.Show("I'm sorry none of these colors are to your liking.");

        }
    }
}
