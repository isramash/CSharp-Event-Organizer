using System;
using System.Net;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Isra : Form
    {
        private EventManager eventManager;

        public Isra()
        {
            InitializeComponent();
            cmbCountry.DataSource = Enum.GetValues(typeof(Countries)); // Fill country combo box from enum
            grpAddParticipant.Enabled = false;  // Disable until event is created
            grpBoxParticipants.Enabled = false; // Disable until event is created
        }

        // Update event financial summary fields
        private void UpdateFinancials()
        {
            txtNumberOfParticipants.Text = eventManager.ParticipantCount.ToString();
            txtTotalCost.Text = eventManager.TotalCost.ToString("F2");
            txtTotalFees.Text = eventManager.TotalFees.ToString("F2");
            txtSurplus.Text = eventManager.Profit.ToString("F2");
        }

        // Create or update event
        private void btnCreateEvent_Click_1(object sender, EventArgs e)
        {
            string title = txtEventTitle.Text.Trim();
            string feeText = txtFeePerParticipant.Text.Trim();
            string costText = txtCostPerParticipant.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a title for the event.");
                return;
            }

            double fee = 0.0;
            double cost = 0.0;

            if (!double.TryParse(feeText, out fee))
            {
                fee = 0.0;
            }

            if (!double.TryParse(costText, out cost))
            {
                cost = 0.0;
            }

            if (eventManager == null)
            {
                eventManager = new EventManager(title, fee, cost);
            }
            else
            {
                eventManager.EventName = title;
                eventManager.FeePerParticipant = fee;
                eventManager.CostPerParticipant = cost;
            }

            grpAddParticipant.Enabled = true;  // Enable participant group
            grpBoxParticipants.Enabled = true; // Enable list group

            UpdateFinancials();

            MessageBox.Show("Event created successfully!");
        }

        // Add new participant
        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            if (eventManager == null)
            {
                MessageBox.Show("Please create an event first.");
                return;
            }

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string street = txtStreet.Text.Trim();
            string zip = txtZipCode.Text.Trim();
            string city = txtCity.Text.Trim();


            Countries country = (Countries)cmbCountry.SelectedItem;

            Address address = new Address(street, city, zip, country);

            if (!address.Validate())
            {
                MessageBox.Show("Please fill in all address fields.");
                return;
            }

            Participant participant = new Participant(firstName, lastName, address);

            if (!participant.Validate())
            {
                MessageBox.Show("Please enter valid first and last names.");
                return;
            }

            eventManager.AddParticipant(participant);

            ClearParticipantFields();
            UpdateParticipantList();
            UpdateFinancials();
        }

        // Change existing participant
        private void btnChange_Click(object sender, EventArgs e)
        {

            int index = listBox.SelectedIndex;
            if (eventManager == null || index < 0)
            {
                MessageBox.Show("Please select a participant to change.");
                return;
            }

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string street = txtStreet.Text.Trim();
            string zip = txtZipCode.Text.Trim();
            string city = txtCity.Text.Trim();

            

            Countries country = (Countries)cmbCountry.SelectedItem;

            Address updatedAddress = new Address(street, city, zip, country);

            if (!updatedAddress.Validate())
            {
                MessageBox.Show("Please fill in all address fields.");
                return;
            }

            Participant updatedParticipant = new Participant(firstName, lastName, updatedAddress);

            if (!updatedParticipant.Validate())
            {
                MessageBox.Show("Please enter valid first and last names.");
                return;
            }
            eventManager.Participants.UpdateParticipantAt(index, updatedParticipant);

            UpdateParticipantList();
            listBox.SelectedIndex = index;// Keep selection after update
            UpdateFinancials();
            MessageBox.Show("Participant updated successfully.");
        }

        // When a participant is selected, show their info in the fields
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index >= 0)
            {
                Participant p = eventManager.Participants.GetParticipant(index);
                if (p != null)
                {
                    txtFirstName.Text = p.FirstName;
                    txtLastName.Text = p.LastName;
                    txtStreet.Text = p.Address.Street;
                    txtZipCode.Text = p.Address.ZipCode;
                    txtCity.Text = p.Address.City;
                    cmbCountry.SelectedItem = p.Address.Country;
                }
            }
        }
        // Delete selected participant
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (eventManager == null || index < 0)
            {
                MessageBox.Show("Please select a participant to Delete.");
                return;
            }
            eventManager.Participants.RemoveAt(index);
            UpdateParticipantList();
            ClearParticipantFields();
            UpdateFinancials();
        }
        // Clear participant input fields
        private void ClearParticipantFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtStreet.Clear();
            txtZipCode.Clear();
            txtCity.Clear();
            cmbCountry.SelectedIndex = 0;
        }
        // Update the participant list in the ListBox
        private void UpdateParticipantList()
        {
            listBox.Items.Clear();
            var list = eventManager.Participants.GetAllParticipants();
            foreach (var p in list)
            {
                listBox.Items.Add(p.ToString());
            }
        }

    }
}