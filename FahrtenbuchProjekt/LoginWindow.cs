﻿using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.DataAccessLayer;
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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var context = new JourneybookContext();
            var loginAccessLayer = new LoginAccessLayer(context);

            if (loginAccessLayer.Login(textBoxEmail.Text, textBoxPassword.Text))
            {
                new MainWindow(loginAccessLayer.GetLoggedInEmployee(textBoxEmail.Text)).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Username or password is invalid!");
                textBoxEmail.Clear();
                textBoxPassword.Clear();
                textBoxEmail.Focus();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
