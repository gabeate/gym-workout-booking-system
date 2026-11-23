using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymWorkoutFormProject
{
    public partial class SessionsForm : Form
    {
        public SessionsForm(string sessionText)
        {
            InitializeComponent();
            PurchSessionRTB.Text = sessionText;
        }

        private void SessionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
