using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace FahrtenbuchProjekt
{
    public partial class AddOrEditJourneyWindow : Form
    {
        private MainWindow _mainForm;
        private Employee _loggedInEmployee;
        private JourneybookContext _context;
        private Journey _journey;
        public AddOrEditJourneyWindow(MainWindow mainForm, Journey? journey, Employee loggedInEmployee, JourneybookContext context)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _loggedInEmployee = loggedInEmployee;
            _context = context;
            _journey = journey;
            comboBoxCompanyCar.DataSource = context.CompanyCars.ToList();
            dateTimePickerTimeStampStart.Format = DateTimePickerFormat.Time;
            dateTimePickerTimeStampEnd.Format = DateTimePickerFormat.Time;

            if (_journey == null)
            {
                labelTitle.Text = "Fahrt anlegen";
            }
            else
            {
                labelTitle.Text = "Fahrt ändern";
                dateTimePickerDateOfJourney.Value = _journey.JourneyDate;
                dateTimePickerTimeStampStart.Value = _journey.TimeStampStart;
                dateTimePickerTimeStampEnd.Value = _journey.TimeStampEnd;
                textBoxTravelRoute.Text = _journey.TravelRoute.ToString();
                textBoxReason.Text = _journey.PurposeOfTheJourney;
                textBoxKmDistanceDeparture.Text = _journey.KmDistanceDeparture.ToString();
                textBoxKmDistanceArrival.Text = _journey.KmDistanceArrival.ToString();
                comboBoxCompanyCar.SelectedItem = _journey.CompanyCar;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var journeyDate = dateTimePickerDateOfJourney.Value.Date;
            var start = dateTimePickerTimeStampStart.Value;
            var end = dateTimePickerTimeStampEnd.Value;
            // TODO shouldnt create error here, it should be outputed in the message box
            var travelRoute = Convert.ToInt32(textBoxTravelRoute.Text);
            var purpose = textBoxReason.Text.Trim();
            var kmDeparture = Convert.ToInt32(textBoxKmDistanceDeparture.Text);
            var kmArrival = Convert.ToInt32(textBoxKmDistanceArrival.Text);
            var companyCar = (CompanyCar)comboBoxCompanyCar.SelectedItem;

            if (_journey == null)
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
                    EmployeeId = _loggedInEmployee.Id,
                    CompanyCar = companyCar
                };

                _context.Journeys.Add(newJourney);
            }
            else
            {
                _journey.JourneyDate = journeyDate;
                _journey.TimeStampStart = start;
                _journey.TimeStampEnd = end;
                _journey.TravelRoute = travelRoute;
                _journey.PurposeOfTheJourney = purpose;
                _journey.KmDistanceDeparture = kmDeparture;
                _journey.KmDistanceArrival = kmArrival;
                _journey.EmployeeId = _loggedInEmployee.Id;
                _journey.CompanyCar = companyCar;

                _context.Journeys.Update(_journey);
            }

            _context.SaveChanges();
            _mainForm.Show();
            _mainForm.ReloadJourneys();
            this.Close();
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
