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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            cboxSelectTeam.DataSource = null;
            cboxSelectTeam.DataSource= availableTeams;
            cboxSelectTeam.DisplayMember = "TeamName";

            lbTournamentTeams.DataSource = null;
            lbTournamentTeams.DataSource = selectedTeams;
            lbTournamentTeams.DisplayMember = "TeamName";

            lbPrizes.DataSource = null;
            lbPrizes.DataSource = selectedPrizes;
            lbPrizes.DisplayMember = "PlaceName";
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)cboxSelectTeam.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm
            CreatePrize frm = new CreatePrize(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the form a PrizeModel
            //Take the PrizeModel and put it into our list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void linkCreateNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)lbTournamentTeams.SelectedItem;
            if(t != null)
            { 
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                WireUpLists();
            }
        }

        private void btnRemovePrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)lbPrizes.SelectedItem;
            if(p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(txtEntryFee.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid entry fee!",
                    "Invalid Fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // Create our tournament model
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = txtTournamentName.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // TODO - Wire up our matchups
            TournamentLogic.CreateRounds(tm);

            // Create tournaments entry
            // Create all of the prizes entries
            // Create all of the team entries
            GlobalConfig.Connection.CreateTournament(tm);
            

            
        }
    }
}
