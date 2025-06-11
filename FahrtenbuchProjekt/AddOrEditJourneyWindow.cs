using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;

namespace FahrtenbuchProjekt
{
    public partial class AddOrEditJourneyWindow : Form
    {
        private MainWindow _mainForm;
        private Journey? _editingJourney;
        private Employee _loggedInEmployee;
        public AddOrEditJourneyWindow(MainWindow mainForm, Journey? journey, Employee loggedInEmployee, JourneybookContext context)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _editingJourney = journey;
            _loggedInEmployee = loggedInEmployee;

            if (journey == null)
            {
                labelTitle.Text = "Fahrt anlegen";
            }
            else
            {
                labelTitle.Text = "Fahrt ändern";
                dateTimePickerDateOfJourney.Value = journey.JourneyDate;
                dateTimePickerStartJourney.Value = journey.TimeStampStart;
                dateTimePickerEndJourney.Value = journey.TimeStampEnd;
                textBoxTravelRoute.Text = journey.TravelRoute.ToString();
                textBoxReason.Text = journey.PurposeOfTheJourney;
                textBoxKmDistanceDeparture.Text = journey.KmDistanceDeparture.ToString();
                textBoxKmDistanceArrival.Text = journey.KmDistanceArrival.ToString();
                comboBoxCompanyCar.DataSource = context.CompanyCars.ToList();
                comboBoxCompanyCar.DisplayMember = "LicencePlate";
                comboBoxCompanyCar.ValueMember = "Id";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var context = new JourneybookContext();
            var journeyDate = dateTimePickerDateOfJourney.Value.Date;
            var start = dateTimePickerStartJourney.Value;
            var end = dateTimePickerEndJourney.Value;
            var travelRoute = Convert.ToInt32(textBoxTravelRoute.Text);
            var purpose = textBoxReason.Text.Trim();
            var kmDeparture = Convert.ToInt32(textBoxKmDistanceDeparture.Text);
            var kmArrival = Convert.ToInt32(textBoxKmDistanceArrival.Text);
            var companyCar = (CompanyCar)comboBoxCompanyCar.SelectedItem;

            if (_editingJourney == null)
            {
                var newJourney = new Journey
                {
                    JourneyDate = journeyDate,
                    TimeStampStart = start,
                    TimeStampEnd = end,
                    TravelRoute = travelRoute,
                    PurposeOfTheJourney = purpose,
                    KmDistanceDeparture = kmDeparture,
                    KmDistanceArrival = kmArrival,
                    Employee = _loggedInEmployee,
                    CompanyCar = companyCar
                };

                context.Journeys.Add(newJourney);
            }
            else
            {
                _editingJourney.JourneyDate = journeyDate;
                _editingJourney.TimeStampStart = start;
                _editingJourney.TimeStampEnd = end;
                _editingJourney.TravelRoute = travelRoute;
                _editingJourney.PurposeOfTheJourney = purpose;
                _editingJourney.KmDistanceDeparture = kmDeparture;
                _editingJourney.KmDistanceArrival = kmArrival;
                //_editingJourney.
            }

            context.SaveChanges();
            Close();
        }

        private void textBoxTravelRoute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxKmDistanceDeparture_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxKmDistanceArrival_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
