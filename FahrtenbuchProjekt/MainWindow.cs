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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
            new AddOrEditJourneyWindow(e).Show();
            this.Close();
        }
    }
}
