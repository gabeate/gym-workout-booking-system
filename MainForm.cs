using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymWorkoutFormProject
{
    public partial class MainForm : Form
    {
        // Role of employee that logged in
        string userRole;

        public MainForm(string employeeName, string role)
        {
            InitializeComponent();
            userRole = role;
            WelcomeL.Text = "Welcome, " + employeeName + "! (" + userRole + ")";
        }

        // Input Data

        private void MemberMI_Click(object sender, EventArgs e)
        {
            MemberForm form = new MemberForm();
            form.Show();
        }

        private void TrainerMI_Click(object sender, EventArgs e)
        {
            TrainerForm form = new TrainerForm(userRole);
            form.Show();
        }

        // Output Purchase

        private void PurchaseMI_Click(object sender, EventArgs e)
        {
            PurchaseForm form = new PurchaseForm();
            form.Show();
        }

        // Reports
        private void MemberReportMI_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Only an Admin can access reports.");
                return;
            }

            MemberReportForm form = new MemberReportForm();
            form.Show();
        }

        private void TrainerReportMI_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Only an Admin can access reports.");
                return;
            }

            TrainerReportForm form = new TrainerReportForm();
            form.Show();
        }

        // Log Out

        private void ExitMI_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}