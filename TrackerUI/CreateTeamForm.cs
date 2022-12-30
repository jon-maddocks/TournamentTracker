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
        public CreateTeamForm()
        {
            InitializeComponent();
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

                GlobalConfig.Connection.CreatePerson(p);

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
    }
}
