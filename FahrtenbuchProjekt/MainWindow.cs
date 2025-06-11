using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace FahrtenbuchProjekt
{
    public partial class MainWindow : Form
    {
        private readonly JourneybookContext _context = new();
        private readonly Employee _loggedInEmployee;
        public MainWindow(Employee loggedInEmployee)
        {
            InitializeComponent();

            _loggedInEmployee = loggedInEmployee;

            dataGridViewCompanyCars.DataSource = _context.CompanyCars.ToList();
            dataGridViewCompanyCars.Columns["Journeys"].Visible = false;

            dataGridViewJourneys.DataSource = _context.Journeys.Where(x => x.Employee == loggedInEmployee).ToList();
            dataGridViewJourneys.Columns["Employee"].Visible = false;
            dataGridViewJourneys.Columns["CompanyCar"].Visible = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            new LoginWindow().Show();
            this.Close();
        }

        private void buttonAddCompanyCar_Click(object sender, EventArgs e)
        {
            new AddCompanyCarWindow(this).Show();
            this.Hide();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            new AddEmployeeWindow().Show();
            this.Close();
        }

        public void ReloadCompanyCars()
        {
            dataGridViewCompanyCars.ClearSelection();
            dataGridViewJourneys.ClearSelection();
            dataGridViewCompanyCars.DataSource = null;
            dataGridViewCompanyCars.DataSource = _context.CompanyCars.ToList();
        }

        private void ReloadJourneys()
        {
            dataGridViewJourneys.DataSource = _context.Journeys
                .Include(j => j.CompanyCar)
                .Include(j => j.Employee)
                .Where(j => j.Employee == _loggedInEmployee)
                .ToList();
            dataGridViewJourneys.CellFormatting += dataGridViewJourneys_CellFormatting;
        }

        private void dataGridViewCompanyCars_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCompanyCars.SelectedRows.Count > 0)
            {
                var selectedCar = (CompanyCar)dataGridViewCompanyCars.SelectedRows[0].DataBoundItem;

                dataGridViewJourneys.DataSource = _context.Journeys
                    .Include(j => j.CompanyCar)
                    .Include(j => j.Employee)
                    .Where(j => j.Employee == _loggedInEmployee && j.CompanyCar.Id == selectedCar.Id)
                    .ToList();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dataGridViewCompanyCars.ClearSelection();
            dataGridViewJourneys.ClearSelection();
            dataGridViewJourneys.DataSource = _context.Journeys
                .Include(j => j.CompanyCar)
                .Include(j => j.Employee)
                .Where(j => j.Employee == _loggedInEmployee)
                .ToList();
        }

        private void buttonShowAllJourneys_Click(object sender, EventArgs e)
        {
            dataGridViewCompanyCars.ClearSelection();
            dataGridViewJourneys.DataSource = _context.Journeys
                .Include(j => j.CompanyCar)
                .Include(j => j.Employee)
                .Where(j => j.Employee == _loggedInEmployee)
                .ToList();
        }

        private void buttonDeleteJourney_Click(object sender, EventArgs e)
        {
            if (dataGridViewJourneys.SelectedRows.Count > 0)
            {
                var selectedJourney = (Journey)dataGridViewJourneys.SelectedRows[0].DataBoundItem;

                _context.Journeys.Remove(selectedJourney);
                _context.SaveChanges();

                ReloadJourneys();
            }
        }

        private void buttonAddJourney_Click(object sender, EventArgs e)
        {
            new AddOrEditJourneyWindow(this, null, _loggedInEmployee, _context).Show();
            this.Hide();
        }

        private void buttonEditJourney_Click(object sender, EventArgs e)
        {
            new AddOrEditJourneyWindow(this, (Journey)dataGridViewJourneys.SelectedRows[0].DataBoundItem, _loggedInEmployee, _context).Show();
            this.Hide();
        }

        private void dataGridViewJourneys_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewJourneys.Columns[e.ColumnIndex].Name == "TimeStampStart")
            {
                if (e.Value != null)
                {
                    DateTime timestamp = (DateTime)e.Value;
                    e.Value = timestamp.ToString("HH:mm");
                    e.FormattingApplied = true;
                }
            }
            if (dataGridViewJourneys.Columns[e.ColumnIndex].Name == "TimeStampEnd")
            {
                if (e.Value != null)
                {
                    DateTime timestamp = (DateTime)e.Value;
                    e.Value = timestamp.ToString("HH:mm");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}