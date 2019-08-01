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
    public partial class CreateTournamentForum : Form, IPrizeRequester,ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>(); 
        public CreateTournamentForum()
        {
            InitializeComponent();
            WireUpList();   //list the team in the drop down box
        }

        private void WireUpList()
        {
            TeamDropdown.DataSource = null;
            TeamDropdown.DataSource = availableTeams;
            TeamDropdown.DisplayMember = "TeamName";

            tournamentTeamListBox.DataSource = null;
            tournamentTeamListBox.DataSource = selectedTeams;
            tournamentTeamListBox.DisplayMember = "TeamName";

            PrizesListbox.DataSource = null;
            PrizesListbox.DataSource = selectedPrizes;
            PrizesListbox.DisplayMember = "PlaceName"; 
        }


        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)TeamDropdown.SelectedItem; 

            if(t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpList(); 
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePRizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();  //display the prize form


            



        }
        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateTournamentForum_Load(object sender, EventArgs e)
        {

        }

        private void TeamDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the form a PrizeModel
            //Take the PrizeModel and putit into our list of selected prizes

            selectedPrizes.Add(model); 
            WireUpList(); 
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpList(); 
        }

        public void CreateTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show(); 
        }

        private void RemoveSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            //PersonModel p = (PersonModel)tournamentTeamListBox.SelectedItem;

            //if(p !=null)
            //{
            //    selectedTeams.Remove(p);
            //    availableTeams.Add(p);

            //    WireUpList(); 
            //}

            TeamModel t = (TeamModel)tournamentTeamListBox.SelectedItem; 

            if(t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpList(); 
            }
        }

        private void RemovePrizebutton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListbox.SelectedItem; 
            
            if(p !=null)
            {
                selectedPrizes.Remove(p);
                WireUpList(); 
            }
        }

        private void CreateTournamentbutton_Click(object sender, EventArgs e)
        {
            //Validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(EntrryFeeValue.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee.",
                    "Invalid fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return; //stops the process won't proceed to the tournament model
            }
            //Create our tournament model

            TournamentModel tm = new TournamentModel();
            tm.TournamentName = TournamentNameValue.Text;
            tm.EntryFee = 0;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            //Wire our matchups

            //Create Tournament Entry
            //Create all of the prizes entries

            //Create all of team entries
            GlobalConfig.Connection.CreateTournament(tm);


           
        }
    }
}
