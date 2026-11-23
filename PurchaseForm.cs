using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace GymWorkoutFormProject
{
    public partial class PurchaseForm : Form
    {
        Member member;
        Trainer trainer;
        bool calculated = false;
        double subtotal;
        double provTax;
        double fedTax;
        double total;

        public PurchaseForm()
        {
            InitializeComponent();

            MonthCB.SelectedIndex = DateTime.Now.Month - 1;
            YearTB.Text = DateTime.Now.Year.ToString();
        }

        // Member ID Search
        private bool LoadMember()
        {
            member = null;
            MemNameTB.Clear();
            MemEmailTB.Clear();

            int id;

            if (!int.TryParse(MemIDTB.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Enter a valid Member ID (positive whole number).");
                return false;
            }

            string connectionString = "Data Source=ASUSzenbook2;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT MemberName, PhoneNumber, EmailAddress, Password " +
                "FROM dbo.Member WHERE MemberId = @ParamMemberId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamMemberId", id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                member = new Member();
                member.MemberID = id;
                member.MemberName = reader["MemberName"].ToString();
                member.PhoneNumber = reader["PhoneNumber"].ToString();
                member.EmailAddress = reader["EmailAddress"].ToString();
                member.Password = reader["Password"].ToString();
            }

            reader.Close();

            // Close database.
            connection.Close();

            if (member == null)
            {
                MessageBox.Show("Member ID not found.");
                return false;
            }

            MemNameTB.Text = member.MemberName;
            MemEmailTB.Text = member.EmailAddress;
            return true;
        }

        // Trainer Search
        private bool LoadTrainer()
        {
            trainer = null;
            TrNameTB.Clear();
            TrYearsTB.Clear();
            TrRateTB.Clear();

            int id;
            double rate = 0;

            if (!int.TryParse(TrIDTB.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Enter a valid Trainer ID (positive whole number).");
                return false;
            }

            string connectionString = "Data Source=ASUSzenbook2;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT TrainerName, Expertise, HourlyRate " +
                "FROM dbo.Trainer WHERE TrainerId = @ParamTrainerId";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamTrainerId", id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                trainer = new Trainer();
                trainer.TrainerID = id;
                trainer.TrainerName = reader["TrainerName"].ToString();
                trainer.Expertise = reader["Expertise"].ToString();
                trainer.HourlyRate = double.Parse(reader["HourlyRate"].ToString());
            }

            reader.Close();

            // Close database.
            connection.Close();

            if (trainer == null)
            {
                MessageBox.Show("Trainer ID not found.");
                return false;
            }

            TrNameTB.Text = trainer.TrainerName;
            TrYearsTB.Text = trainer.Expertise;
            TrRateTB.Text = "$" + trainer.HourlyRate.ToString("N2") + "/hour";
            return true;
        }

        private bool TryReadYear(out int year)
        {
            if (!int.TryParse(YearTB.Text.Trim(), out year) || year < 2000 || year > 2100)
            {
                MessageBox.Show("Year must be a 4-digit year between 2000 and 2100.");
                return false;
            }
            return true;
        }

        private void SearchMemberB_Click(object sender, EventArgs e)
        {
            LoadMember();
        }

        private void SearchTrainerB_Click(object sender, EventArgs e)
        {
            LoadTrainer();
        }

        private void Input_Changed(object sender, EventArgs e)
        {
            calculated = false;
            SubtotalTB.Clear();
            ProvTaxTB.Clear();
            FedTaxTB.Clear();
            TotalTB.Clear();
        }

        private void CalculateB_Click(object sender, EventArgs e)
        {
            if (!LoadMember() || !LoadTrainer())
            {
                return;
            }

            int sessions;
            int year;

            if (!int.TryParse(SessionsTB.Text.Trim(), out sessions) || sessions < 1)
            {
                MessageBox.Show("The number of sessions must be a whole number of at least 1.");
                return;
            }

            if (!TryReadYear(out year))
            {
                return;
            }

            trainer.NumSession = sessions;
            subtotal = trainer.CalculateSubtotal();
            provTax = Math.Round(trainer.CalculateProvTax(), 2, MidpointRounding.AwayFromZero);
            fedTax = Math.Round(trainer.CalculateFedTax(), 2, MidpointRounding.AwayFromZero);
            total = subtotal + provTax + fedTax;

            SubtotalTB.Text = "$" + subtotal.ToString("N2");
            ProvTaxTB.Text = "$" + provTax.ToString("N2");
            FedTaxTB.Text = "$" + fedTax.ToString("N2");
            TotalTB.Text = "$" + total.ToString("N2");
            calculated = true;
        }

        // Save purchase into Purchase table.
        private void ConfirmB_Click(object sender, EventArgs e)
        {
            if (!calculated || member == null || trainer == null)
            {
                MessageBox.Show("Please click Calculate first.");
                return;
            }

            int year;

            if (!TryReadYear(out year))
            {
                return;
            }

            string connectionString = "Data Source=ASUSzenbook2;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Next Purchase ID = highest Purchase ID plus 1
            string sql = "SELECT ISNULL(MAX(PurchaseId), 0) + 1 AS NextId FROM dbo.Purchase";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int nextId = int.Parse(reader["NextId"].ToString());
            reader.Close();

            Purchase purchase = new Purchase();
            purchase.PurchaseID = nextId;
            purchase.MemberID = member.MemberID;
            purchase.TrainerID = trainer.TrainerID;
            purchase.NumSession = trainer.NumSession;
            purchase.Subtotal = subtotal;
            purchase.ProvTax = provTax;
            purchase.FedTax = fedTax;
            purchase.Total = total;
            purchase.Month = MonthCB.SelectedIndex + 1;
            purchase.Year = year;

            // INSERT the purchase
            sql = "INSERT INTO dbo.Purchase (PurchaseId, MemberId, TrainerId, NumSession, Subtotal, " +
                "ProvTax, FedTax, Total, PurchaseMonth, PurchaseYear) " +
                "VALUES (@ParamPurchaseId, @ParamMemberId, @ParamTrainerId, @ParamNumSession, @ParamSubtotal, " +
                "@ParamProvTax, @ParamFedTax, @ParamTotal, @ParamMonth, @ParamYear)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamPurchaseId", purchase.PurchaseID);
            command.Parameters.AddWithValue("@ParamMemberId", purchase.MemberID);
            command.Parameters.AddWithValue("@ParamTrainerId", purchase.TrainerID);
            command.Parameters.AddWithValue("@ParamNumSession", purchase.NumSession);
            command.Parameters.AddWithValue("@ParamSubtotal", purchase.Subtotal);
            command.Parameters.AddWithValue("@ParamProvTax", purchase.ProvTax);
            command.Parameters.AddWithValue("@ParamFedTax", purchase.FedTax);
            command.Parameters.AddWithValue("@ParamTotal", purchase.Total);
            command.Parameters.AddWithValue("@ParamMonth", purchase.Month);
            command.Parameters.AddWithValue("@ParamYear", purchase.Year);
            command.ExecuteNonQuery();

            // Close database.
            connection.Close();

            MessageBox.Show("Purchase #" + purchase.PurchaseID + " confirmed!\n\n"
                            + "Member: " + member.MemberName + "\n"
                            + "Trainer: " + trainer.TrainerName + " (" + trainer.Expertise + ")\n"
                            + "Sessions: " + purchase.NumSession + "\n"
                            + "Total: $" + purchase.Total.ToString("N2"),
                            "Purchase Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            calculated = false;   // the same calculation cannot be confirmed twice
        }

        private void ResetB_Click(object sender, EventArgs e)
        {
            MemIDTB.Clear();
            MemNameTB.Clear();
            MemEmailTB.Clear();
            TrIDTB.Clear();
            TrNameTB.Clear();
            TrYearsTB.Clear();
            TrRateTB.Clear();
            SessionsTB.Clear();
            MonthCB.SelectedIndex = DateTime.Now.Month - 1;
            YearTB.Text = DateTime.Now.Year.ToString();
            Input_Changed(sender, e);
            member = null;
            trainer = null;
            MemIDTB.Focus();
        }
    }
}