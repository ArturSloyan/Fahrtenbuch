using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;

namespace FahrtenbuchProjekt
{
    public partial class MainWindow : Form
    {
        private readonly JourneybookContext _context = new();

        public MainWindow(Employee loggedInEmployee)
        {
            InitializeComponent();

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
            new AddCompanyCarWindow().Show();
            this.Close();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            new AddEmployeeWindow().Show();
            this.Close();
        }

        private void buttonAddJourney_Click(object sender, EventArgs e)
        {
            new AddOrEditJourneyWindow().Show();
            this.Close();
        }
    }
}
