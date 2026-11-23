using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymWorkoutFormProject
{
    // Member Form
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            MemIDTB.Clear();
            MemNameTB.Clear();
            PhoneTB.Clear();
            EmailTB.Clear();
            PasswordTB.Clear();
            MemIDTB.Focus();
        }

        // Check fields.
        private bool FieldsAreValid(out int id)
        {
            if (!int.TryParse(MemIDTB.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Member ID must be a positive whole number.");
                MemIDTB.Focus();
                return false;
            }

            if (MemNameTB.Text.Trim() == "" || PhoneTB.Text.Trim() == "" || EmailTB.Text.Trim() == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }

            if (!EmailTB.Text.Contains("@"))
            {
                MessageBox.Show("Enter a valid e-mail address (for example name@example.com");
                EmailTB.Focus();
                return false;
            }

            return true;
        }

        // Add member to Member table
        private void AddB_Click(object sender, EventArgs e)
        {
            int id;

            if (!FieldsAreValid(out id))
            {
                return;
            }

            string connectionString = "Data Source=[YOUR SERVER NAME];Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT MemberId FROM dbo.Member WHERE MemberId = @ParamMemberId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamMemberId", id);

            SqlDataReader reader = command.ExecuteReader();
            bool exists = reader.Read();
            reader.Close();

            if (exists)
            {
                connection.Close();
                MessageBox.Show("A member with ID " + id + " already exists.");
                MemIDTB.Focus();
                return;
            }

            // INSERT member
            sql = "INSERT INTO dbo.Member (MemberId, MemberName, PhoneNumber, EmailAddress, Password) " +
                "VALUES (@ParamMemberId, @ParamMemberName, @ParamPhone, @ParamEmail, @ParamPassword)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamMemberId", id);
            command.Parameters.AddWithValue("@ParamMemberName", MemNameTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamPhone", PhoneTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamEmail", EmailTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamPassword", PasswordTB.Text);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Member added.");
            ClearFields();
        }

        // Search for Member ID in the Member table and show the record in the form
        private void SearchB_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(MemIDTB.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Enter a valid Member ID (positive whole number).");
                MemIDTB.Focus();
                return;
            }

            // Connect to MS SQL
            // Open the connection.
            string connectionString = "Data Source=[YOUR SERVER NAME];Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT MemberName, PhoneNumber, EmailAddress, Password " +
                "FROM dbo.Member WHERE MemberId = @ParamMemberId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamMemberId", id);

            SqlDataReader reader = command.ExecuteReader();

            bool found = false;

            if (reader.Read())
            {
                MemNameTB.Text = reader["MemberName"].ToString();
                PhoneTB.Text = reader["PhoneNumber"].ToString();
                EmailTB.Text = reader["EmailAddress"].ToString();
                PasswordTB.Text = reader["Password"].ToString();
                found = true;
            }

            reader.Close();

            // Close database.
            connection.Close();

            if (!found)
            {
                MessageBox.Show("Member ID not found.");
            }
        }

        // Updates the member with the Member ID in the form
        private void UpdateB_Click(object sender, EventArgs e)
        {
            int id;

            if (!FieldsAreValid(out id))
            {
                return;
            }

            // Connect to MS SQL
            // Open the connection.
            string connectionString = "Data Source=[YOUR SERVER NAME];Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "UPDATE dbo.Member SET MemberName = @ParamMemberName, " +
                "PhoneNumber = @ParamPhone, EmailAddress = @ParamEmail, Password = @ParamPassword " +
                "WHERE MemberId = @ParamMemberId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamMemberName", MemNameTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamPhone", PhoneTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamEmail", EmailTB.Text.Trim());
            command.Parameters.AddWithValue("@ParamPassword", PasswordTB.Text);
            command.Parameters.AddWithValue("@ParamMemberId", id);

            int rows = command.ExecuteNonQuery();

            // Close database.
            connection.Close();

            if (rows == 0)
            {
                MessageBox.Show("Member ID not found.");
            }
            else
            {
                MessageBox.Show("Member updated.");
                ClearFields();
            }
        }

        // Deletes the member with the Member ID in the form
        private void DeleteB_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(MemIDTB.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Enter a valid Member ID (positive whole number).");
                MemIDTB.Focus();
                return;
            }

            // Connect to MS SQL
            // Open the connection.
            string connectionString = "Data Source=[YOUR SERVER NAME];Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // A member who already has purchases cannot be deleted (Purchase table references Member)
            string sql = "SELECT PurchaseId FROM dbo.Purchase WHERE MemberId = @ParamMemberId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamMemberId", id);

            SqlDataReader reader = command.ExecuteReader();
            bool hasPurchases = reader.Read();
            reader.Close();

            if (hasPurchases)
            {
                connection.Close();
                MessageBox.Show("This member has purchases and cannot be deleted.");
                return;
            }

            sql = "DELETE FROM dbo.Member WHERE MemberId = @ParamMemberId";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamMemberId", id);

            int rows = command.ExecuteNonQuery();

            // Close database.
            connection.Close();

            if (rows == 0)
            {
                MessageBox.Show("Member ID not found.");
            }
            else
            {
                MessageBox.Show("Member deleted.");
                ClearFields();
            }
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}