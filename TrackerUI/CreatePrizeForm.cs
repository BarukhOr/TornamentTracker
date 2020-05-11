using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // TODO: Validate user input
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameTextBox.Text,
                    placeNumberTextBox.Text,
                    prizeAmountTextBox.Text,
                    prizePercentageTextBox.Text);

                GlobalConfig.Connection.CreatePrize(model);

                placeNameTextBox.Text = "";
                placeNumberTextBox.Text = "";
                prizeAmountTextBox.Text = "0";
                prizePercentageTextBox.Text = "0";
            }
        }

        private bool ValidateForm()
        {
            bool result = true;
            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool placeNumberValidNumber = int.TryParse(placeNumberTextBox.Text, out placeNumber);
            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageTextBox.Text, out prizePercentage);

            // TODO: Should there be notifications for when there is are issues with validation?
            if (!placeNumberValidNumber)
            {
                result = false;
                MessageBox.Show("The Place Number is not a invalid number.");
            }
                

            if (placeNumber < 1)
            {
                result = false;
                MessageBox.Show("The Place Number should be greater than 0.");
            }
                

            if (placeNameTextBox.Text.Length == 0)
            {
                result = false;
                MessageBox.Show("Enter a valid Place Name.");
            }
                

            if (!prizeAmountValid || !prizePercentageValid)
            {
                result = false;
                MessageBox.Show("Enter a valid prize Amount/Percentage.");
            }


            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                result = false;
                MessageBox.Show("Enter either a Prize Amount OR a Prize Percentage. Not both.");
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                result = false;
                MessageBox.Show("Invalid Prize Percentage was entered.");
            }

            return result;
        }
    }
}
