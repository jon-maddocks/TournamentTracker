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

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    txtPlaceName.Text,
                    txtPlaceNumber.Text,
                    txtPrizeAmount.Text,
                    txtPrizePercentage.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                    txtPlaceName.Text = "";
                    txtPlaceNumber.Text = "";
                    txtPrizeAmount.Text = "0";
                    txtPrizePercentage.Text = "0";
            } else
            {
                MessageBox.Show("This form has invalid information");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(txtPlaceNumber.Text, out placeNumber);

            if (!placeNumberValidNumber) 
            {
                output = false;
            }
            if(placeNumber < 1)
            {
                output = false;
            }
            if (txtPlaceName.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(txtPrizeAmount.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(txtPrizePercentage.Text, out prizePercentage);

            if(!prizeAmountValid || !prizePercentageValid)
            {
                output= false;
            }
            if(prizeAmount <=0 && prizePercentage <=0)
            {
                output = false;
            }
            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
