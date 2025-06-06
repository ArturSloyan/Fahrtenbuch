using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrtenbuchProjekt
{
    public partial class AddOrEditJourneyWindow : Form
    {
        private MainWindow _mainForm;
        private Journey? _editingJourney;
        private Employee _loggedInEmployee;
        public AddOrEditJourneyWindow(MainWindow mainForm, Journey? journey, Employee loggedInEmployee)
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
            var travelRoute = (int)numericUpDownTravelRoute.Value;
            var purpose = textBoxReason.Text.Trim();
            var kmDeparture = (int)numericUpDownKmDistanceDeparture.Value;
            var kmArrival = (int)numericUpDownKmDistanceArrival.Value;

            if (string.IsNullOrWhiteSpace(purpose) || kmArrival <= kmDeparture)
            {
                MessageBox.Show("Bitte gültige Daten eingeben.");
                return;
            }

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
                    CompanyCar = (CompanyCar)comboBoxCompanyCar.SelectedItem
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
                _editingJourney.
            }

            context.SaveChanges();
            Close();
        }
    }
}
