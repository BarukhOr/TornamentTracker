using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Alaine", LastName = "Jones" });
        }

        private void WireUpLists()
        {
            // TODO: Look into if there is a better way to refresh data binding
            teamMemberDropdown.DataSource = null;
            teamMemberDropdown.DataSource = availableTeamMembers;
            teamMemberDropdown.DisplayMember = "FullName";

            teamMemberListBox.DataSource = null;
            teamMemberListBox.DataSource = selectedTeamMembers;
            teamMemberListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel();

                person.FirstName = firstNameTextBox.Text;
                person.LastName = lastNameTextBox.Text;
                person.CellPhoneNumber = cellphoneTextBox.Text;
                person.EmailAddress = emailTextBox.Text;

                GlobalConfig.Connection.CreatePerson(person);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                cellphoneTextBox.Text = "";
                emailTextBox.Text = "";
            }

        }

        private bool ValidateForm()
        {
            bool result = true;
            // TODO: Complete this function
            return result;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            // TODO: Need to ensure that a valid person is selected
            PersonModel p = (PersonModel) teamMemberDropdown.SelectedItem;

            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            WireUpLists();
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            // TODO: Ensure that a valid person is selected
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;
            
            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            WireUpLists();
        }
    }
}
