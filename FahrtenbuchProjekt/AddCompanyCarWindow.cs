using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrtenbuchProjekt
{
    public partial class AddCompanyCarWindow : Form
    {
        private MainWindow _mainForm;
        public AddCompanyCarWindow(MainWindow mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
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
                var context = new JourneybookContext();
                context.CompanyCars.Add(companyCar);
                context.SaveChanges();

                _mainForm.ReloadCompanyCars();
                _mainForm.Show();
                this.Close();
            }
        }
    }
}
