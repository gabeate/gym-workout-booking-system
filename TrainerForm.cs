using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GymWorkoutFormProject
{
    public partial class TrainerForm : Form
    {
        // Role of the employee that logged in ("Admin" or "User")
        string userRole;

        public TrainerForm(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void ClearFields()
        {
            TrIDTB.Clear();
            TrNameTB.Clear();
            TrExpertiseTB.Clear();
            TrRateTB.Clear();
            TrIDTB.Focus();
        }

        // Checks the fields (used by Add and Update). Returns true if everything is valid.
        private bool FieldsAreValid(out int id, out double rate)
        {
            rate = 0;

            if (!int.TryParse(TrIDTB.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Trainer ID must be a positive whole number.");
                TrIDTB.Focus();
                return false;
            }

            if (TrNameTB.Text.Trim() == "" || TrExpertiseTB.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in the name and the expertise.");
                return false;
            }

            if (TrExpertiseTB.Text.Trim().Length > 30)
            {
                MessageBox.Show("Expertise can have up to 30 characters (for example Bodybuilding or CrossFit).");
                TrExpertiseTB.Focus();
                return false;
            }

            if (!double.TryParse(TrRateTB.Text.Trim(), out rate) || rate <= 0 || rate > 1000)
            {
                MessageBox.Show("Hourly rate must be a number greater than 0 (for example 40 or 40.50).");
                TrRateTB.Focus();
                return false;
            }

            return true;
        }

        // Adds a trainer to the Trainer table (Admin only)
        private void AddB_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Only an Admin can add trainers.");
                return;
            }

            int id;
            double rate;

            if (!FieldsAreValid(out id, out rate))
            {
                return;
            }

            // Connect to MS SQL
            // Open the connection.
            string connectionString = "Data Source=[YOUR SERVER NAME];Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // First check that this Trainer ID does not already exist
            string sql = "SELECT TrainerId FROM dbo.Trainer WHERE TrainerId = @ParamTrainerId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamTrainerId", id);

            SqlDataReader reader = command.ExecuteReader();
            bool exists = reader.Read();
            reader.Close();

            if (exists)
            {
                connection.Close();
                MessageBox.Show("A trainer with ID " + id + " already exists.");
                TrIDTB.Focus();
                return;
            }

            // INSERT the new trainer
            sql = "INSERT INTO dbo.Trainer (TrainerId, TrainerName, Expertise, HourlyRate) " +
                "VALUES (@ParamTrainerId, @ParamTrainerName, @ParamExpertise, @ParamRate)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamTrainerId", id);
            command.Parameters.AddWithValue("@ParamTrainerName", TrNameTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamExpertise", TrExpertiseTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamRate", rate);
            command.ExecuteNonQuery();

            // Close database.
            connection.Close();

            MessageBox.Show("Trainer added.");
            ClearFields();
        }

        // Search for Trainer ID in the Trainer table and show the record in the form
        private void SearchB_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(TrIDTB.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Enter a valid Trainer ID (positive whole number).");
                TrIDTB.Focus();
                return;
            }

            // Connect to MS SQL
            // Open the connection.
            string connectionString = "Data Source=[YOUR SERVER NAME];Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT TrainerName, Expertise, HourlyRate " +
                "FROM dbo.Trainer WHERE TrainerId = @ParamTrainerId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamTrainerId", id);

            SqlDataReader reader = command.ExecuteReader();

            bool found = false;

            if (reader.Read())
            {
                TrNameTB.Text = reader["TrainerName"].ToString();
                TrExpertiseTB.Text = reader["Expertise"].ToString();
                TrRateTB.Text = reader["HourlyRate"].ToString();
                found = true;
            }

            reader.Close();

            // Close database.
            connection.Close();

            if (!found)
            {
                MessageBox.Show("Trainer ID not found.");
            }
        }

        // Updates the trainer with the Trainer ID in the form
        private void UpdateB_Click(object sender, EventArgs e)
        {
            int id;
            double rate;

            if (!FieldsAreValid(out id, out rate))
            {
                return;
            }

            // Connect to MS SQL
            // Open the connection.
            string connectionString = "Data Source=[YOUR SERVER NAME];Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "UPDATE dbo.Trainer SET TrainerName = @ParamTrainerName, " +
                "Expertise = @ParamExpertise, HourlyRate = @ParamRate " +
                "WHERE TrainerId = @ParamTrainerId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamTrainerName", TrNameTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamExpertise", TrExpertiseTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamRate", rate);
            command.Parameters.AddWithValue("@ParamTrainerId", id);

            int rows = command.ExecuteNonQuery();

            // Close database.
            connection.Close();

            if (rows == 0)
            {
                MessageBox.Show("Trainer ID not found.");
            }
            else
            {
                MessageBox.Show("Trainer updated.");
                ClearFields();
            }
        }

        // Deletes the trainer with the Trainer ID in the form (Admin only)
        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Only an Admin can delete trainers.");
                return;
            }

            int id;

            if (!int.TryParse(TrIDTB.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Enter a valid Trainer ID (positive whole number).");
                TrIDTB.Focus();
                return;
            }

            // Connect to MS SQL
            // Open the connection.
            string connectionString = "Data Source=[YOUR SERVER NAME];Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // A trainer who already has purchases cannot be deleted (Purchase table references Trainer)
            string sql = "SELECT PurchaseId FROM dbo.Purchase WHERE TrainerId = @ParamTrainerId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamTrainerId", id);

            SqlDataReader reader = command.ExecuteReader();
            bool hasPurchases = reader.Read();
            reader.Close();

            if (hasPurchases)
            {
                connection.Close();
                MessageBox.Show("This trainer has purchases and cannot be deleted.");
                return;
            }

            sql = "DELETE FROM dbo.Trainer WHERE TrainerId = @ParamTrainerId";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamTrainerId", id);

            int rows = command.ExecuteNonQuery();

            // Close database.
            connection.Close();

            if (rows == 0)
            {
                MessageBox.Show("Trainer ID not found.");
            }
            else
            {
                MessageBox.Show("Trainer deleted.");
                ClearFields();
            }
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}