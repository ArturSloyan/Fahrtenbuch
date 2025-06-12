using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.DataAccessLayer;
using FahrtenbuchProjektCore.Models;

namespace FahrtenbuchProjekt
{
    public partial class AddEmployeeWindow : Form
    {
        private MainWindow _mainWindow;
        private JourneybookContext _context;
        public AddEmployeeWindow(MainWindow mainWindow, JourneybookContext context)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            _context = context;


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _mainWindow.Show();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                Firstname = textBoxFirstname.Text,
                Lastname = textBoxLastname.Text,
                Email = textBoxEmail.Text,
                Password = BCrypt.Net.BCrypt.HashPassword(textBoxEmail.Text)
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
            _mainWindow.Show();
            this.Close();
        }
    }
}
