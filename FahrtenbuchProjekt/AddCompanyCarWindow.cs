using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;
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

            if (!string.IsNullOrWhiteSpace(textBoxBrand.Text) && !string.IsNullOrWhiteSpace(textBoxLicencePlate.Text) && comboBoxCarType.SelectedItem != null)
            {
                var context = new JourneybookContext();
                context.CompanyCars.Add(new CompanyCar()
                {
                    Brand = textBoxBrand.Text,
                    LicencePlate = textBoxLicencePlate.Text,
                    CarType = (CarType)comboBoxCarType.SelectedItem
                });
                context.SaveChanges();

                _mainForm.ReloadCompanyCars();
                _mainForm.Show();
                this.Close();
            }
            else
            {
                textBoxBrand.Clear();
                textBoxLicencePlate.Clear();
                comboBoxCarType.SelectedIndex = -1;
                textBoxBrand.Focus();
            }
        }
    }
}
