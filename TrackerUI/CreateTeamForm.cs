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
            //CreateSampleData();
            WireUpLists();
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Jon", LastName = "Madd" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Janes", LastName = "Jones" });
        }

        // TODO - Make more efficient method to refresh lists. 
        private void WireUpLists()
        {
            cboxSelectMember.DataSource = null;
            cboxSelectMember.DataSource = availableTeamMembers;
            cboxSelectMember.DisplayMember = "FullName";

            listTeamMembers.DataSource = null;
            listTeamMembers.DataSource = selectedTeamMembers;
            listTeamMembers.DisplayMember = "FullName";

        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = txtFirstName.Text;
                p.LastName = txtLastName.Text;
                p.EmailAddress = txtEmail.Text;
                p.CellPhoneNumber = txtCellPhone.Text;

                p = GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                WireUpLists();

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtCellPhone.Text = "";
                txtEmail.Text = "";
            } else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if(txtFirstName.Text.Length == 0)
            {
                return false;
            }
            if (txtLastName.Text.Length == 0)
            {
                return false;
            }
            if (txtEmail.Text.Length == 0)
            {
                return false;
            }
            if (txtCellPhone.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)cboxSelectMember.SelectedItem;

            if(p != null)
            {
            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            WireUpLists();
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)listTeamMembers.SelectedItem;

            if(p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = txtTeamName.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);
            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}
