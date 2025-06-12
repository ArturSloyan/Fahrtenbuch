using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;
using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchProjekt
{
    public partial class AddCompanyCarWindow : Form
    {
        private MainWindow _mainForm;
        private JourneybookContext _context;
        public AddCompanyCarWindow(MainWindow mainForm, JourneybookContext context)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _context = context;
            comboBoxCarType.DataSource = Enum.GetValues(typeof(CarType));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var companyCar = new CompanyCar()
            {
                Brand = textBoxBrand.Text,
                CarType = (CarType)comboBoxCarType.SelectedItem,
                LicencePlate = textBoxLicencePlate.Text
            };
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(companyCar, new ValidationContext(companyCar), validationResults, true);
            string invalidationText =string.Empty;

            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    invalidationText += $"{validationResult.ErrorMessage}\r";
                }

                MessageBox.Show(invalidationText);
            }
            else
            {
                _context.CompanyCars.Add(companyCar);
                _context.SaveChanges();

                _mainForm.ReloadCompanyCars();
                _mainForm.Show();
                this.Close();
            }
        }
    }
}
