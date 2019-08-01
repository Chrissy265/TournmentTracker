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
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm; 



        
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller; 
            //Test purposes
            //CreateSampleData();  

            WireUpLists(); 
        }

     

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Christina", LastName = "Beckford" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Mike", LastName = "Smith" });


            selectedTeamMembers.Add(new PersonModel { FirstName = "Janie", LastName = "Jones" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Chanel", LastName = "Campbell" }); 

        }

        private void WireUpLists()
        {

            SelectTeamDropdown.DataSource = null; 
            SelectTeamDropdown.DataSource = availableTeamMembers;
            SelectTeamDropdown.DisplayMember = "FullName";

            TeamMembersListbox.DataSource = null; 

            TeamMembersListbox.DataSource = selectedTeamMembers;
            TeamMembersListbox.DisplayMember = "FullName";

        }

        private void TeamOneScoreValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateMemberbutton_Click(object sender, EventArgs e)
        {
            
            if(ValidateForm())
            {
            
                PersonModel p = new PersonModel();
                p.FirstName = FirstNameValueTextBox.Text;
                p.LastName = LastNameValueTextBox.Text;
                p.EmailAddress = EmailValue.Text;
                p.CellphoneNumber = CellPhoneValueTextbox.Text;

             p =  GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                WireUpLists();


                //Clear out the form
                FirstNameValueTextBox.Text = "";
                LastNameValueTextBox.Text = "";
                EmailValue.Text = "";
                CellPhoneValueTextbox.Text = ""; 

            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields."); 
            }

            PersonModel p = (PersonModel)SelectTeamDropdown.SelectedItem;  
        }

        private bool ValidateForm()
        {
            if(FirstNameValueTextBox.Text.Length ==0)
            {
                return false; 
            }
            if (LastNameValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (EmailValue.Text.Length == 0)
            {
                return false;
            }
            if (CellPhoneValueTextbox.Text.Length == 0)
            {
                return false;
            }

            return true; 
        }

   

         void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamDropdown.SelectedItem;
            availableTeamMembers.Remove(p); //remove the person from the available Team members list

            selectedTeamMembers.Add(p);

            if (p != null)
            {
               
                SelectTeamDropdown.Refresh();
                TeamMembersListbox.Refresh();
                WireUpLists();
            }

            
        }

        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListbox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = TeamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;


             GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);
            this.Close(); 

            //TODO- IF we aren't closing the form afer creation, reset the form
        }
    }
}
