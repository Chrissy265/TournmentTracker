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
        IPrizeRequester callingForm; 

        public CreatePrizeForm(IPrizeRequester caller) 
        {
            InitializeComponent();
            callingForm = caller; 
          
        }

      private  void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            
            
                if (ValidateForm())
                {

                    PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text,
                    placeNumberValueTextBox.Text,
                    PrizeAmountValue.Text,
                    PrizePercentage.Text);


                GlobalConfig.Connection.CreatePrize(model);
                callingForm.PrizeComplete(model);

                this.Close(); //Close the prize form

                    //PlaceNameValue.Text = "";
                    //placeNumberValueTextBox.Text = "";
                    //PrizeAmountValue.Text = "0";
                    //PrizePercentage.Text = "0";


                }


                else
                {
                    MessageBox.Show("This form has invalid information. Please check it and try again");
                }
            

           

            /* if(ValidateForm())
             {
                 PrizeModel model = new PrizeModel(
                 PlaceNameTextbox.Text,
                 placeNumberValueTextBox.Text,
                 PrizeAmountValue.Text, 
                 PrizePercentage.Text);




                 PlaceNameTextbox.Text = "";
                 placeNumberValueTextBox.Text = "";
                 PrizeAmountValue.Text = "0";
                 PrizePercentage.Text = "0"; 
                   GlobalConfig.Connection.CreatePrize(model);
             }
             else
             {
                 MessageBox.Show("This form has invalid information. Please check it and try again"); 
             }*/

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValueTextBox.Text, out placeNumber); //the out parameter stores the value in the placeNumber variable

            if(placeNumberValidNumber==false)
            {

                output = false; 
            }
          
            if(placeNumber < 1)
            {
                output = false; 
            }

            if (PlaceNameValue.Text.Length ==0)
            {
                output = false; 
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentage.Text, out prizePercentage); 

            if(prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false; 
            }
            if(prizeAmount <=0 && prizePercentage <=0)
            {
                output = false; 
            }
            if(prizePercentage < 0 || prizePercentage >100) 
            {
                output = false; 
            }

            return output; 
        }

    }
}

